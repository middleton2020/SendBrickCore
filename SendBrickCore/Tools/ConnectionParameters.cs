using CM.SendBrick.Interfaces.Tools;
using CM.SendBrickCore.Connectors;
using CM.SendBrickCore.Interfaces;
using CM.SendBrickCore.Interfaces.Connectors;
using CM.SendBrickCore.Interfaces.Tools;
using CM.SendbrickShared.Enums;
using System.IO;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.SendBrickCore.Tools
{
    public class ConnectionParameters: IConnectionParameters
    {
        #region Variables
        private Dictionary<string, string> connectionList = new Dictionary<string, string>();
        private List<string> systemsList = new List<string>();

        IConfigurationFile fileConfigurationFile = null;
        private string configurationFileName = "";
        #endregion  // Variables

        #region Constructors
        /// <summary>
        /// Constructor, sets up the control classes we're using.
        /// </summary>
        /// <param name="inpSetControlTools">The Control Tools Object holding our config.</param>
        public ConnectionParameters(ISetControlTools inpSetControlTools)
        {
            fileConfigurationFile = inpSetControlTools.GetConfigFile();
            configurationFileName = fileConfigurationFile.GetConfFileLocation();
        }
        /// <summary>
        /// Constructor, sets up the control classes we're using.
        /// </summary>
        /// <param name="inpConfigFile">The config file object to use.</param>
        public ConnectionParameters(IConfigurationFile inpConfigFile)
        {
            fileConfigurationFile = inpConfigFile;
            configurationFileName = fileConfigurationFile.GetConfFileLocation();
        }
        #endregion  // Constructors

        #region GetParameters
        /// <summary>
        /// Get the specified connection parameter (for the specified system) from the configuration file.
        /// </summary>
        /// <param name="inpSystem">System name (as Postage enum).</param>
        /// <param name="inpParameterName">Name of parameter to return.</param>
        /// <returns>Value of the parameter as a string.</returns>
        public string GetConnectionParameter(SystemTypes.PostageSystemType inpSystem, string inpParameterName)
        {
            return GetConnectionParameter(inpSystem.ToString(), inpParameterName);
        }
        /// <summary>
        /// Get the specified connection parameter (for the specified system) from the configuration file.
        /// </summary>
        /// <param name="inpSystem">System name (as Source enum).</param>
        /// <param name="inpParameterName">Name of parameter to return.</param>
        /// <returns>Value of the parameter as a string.</returns>
        public string GetConnectionParameter(SystemTypes.SourceSystemType inpSystem, string inpParameterName)
        {
            return GetConnectionParameter(inpSystem.ToString(), inpParameterName);
        }
        /// <summary>
        /// Get the specified connection parameter (for the specified system) from the configuration file.
        /// </summary>
        /// <param name="inpSystem">System name (as a string).</param>
        /// <param name="inpParameterName">Name of parameter to return.</param>
        /// <returns>Value of the parameter as a string.</returns>
        public string GetConnectionParameter(string inpSystem, string inpParameterName)
        {
            // We call this from the above, public, versions, which then convert the name to a string.
            // We always want to use system in uppercase, so that we can do comparisons reliably.
            inpSystem = inpSystem.ToUpper();

            string outParameterValue = "";

            // The Parameter Key is a combination of the system and the parameter name.
            string parameterKeyString = inpSystem + "-" + inpParameterName;

            // Do we already have the parameter stored?
            if (connectionList.ContainsKey(parameterKeyString))
            {
                outParameterValue = connectionList[parameterKeyString];
            }
            // We don't have the parameter stored, so go and look for it.
            else
            {
                outParameterValue = GetParameterFromFile(inpSystem, inpParameterName);
                connectionList.Add(parameterKeyString, outParameterValue);
            }

            return outParameterValue;
        }
        #endregion  // GetParameters

        #region SystemValidation
        /// <summary>
        /// Gets an array of systems this instance is configured for. Note, only goes to the config file if nothing has been loaded into the cache yet.
        /// </summary>
        /// <returns>Array of system names.</returns>
        public string[] GetSystemList()
        {
            // If we've not got any cached, get them from the config file.
            if (systemsList.Count == 0)
            {
                return ReGetSystemList();
            }
            // If we have cached systems, just return them.
            else
            {
                return systemsList.ToArray();
            }
        }
        /// <summary>
        /// Gets an array of systems this instance is configured for. Always goes back to the config file for this.
        /// </summary>
        /// <returns>Array of system names.</returns>
        public string[] ReGetSystemList()
        {
            systemsList.Clear();

            if (File.Exists(configurationFileName))
            {
                // Step through the file, line by line.
                using (StreamReader configurationSR = new StreamReader(configurationFileName))
                {
                    string currentLine = configurationSR.ReadLine();

                    while (currentLine != null)
                    {
                        AddSystem(currentLine, currentLine);
                        currentLine = configurationSR.ReadLine();
                    }
                    configurationSR.Close();
                }
            }
            else
            {
                // This should never happen, but if it does, some-one needs to know about it.
                File.Create(configurationFileName);
                throw new FileNotFoundException("Cannot find configuration file. Created blank file.", nameof(GetParameterFromFile));
            }

            return systemsList.ToArray();
        }

        /// <summary>
        /// Verify that our system has valid configuration.
        /// </summary>
        /// <param name="inpSystem">Name of system to check for.</param>
        /// <returns>True if the system has a configuration set up.</returns>
        public bool IsValidSystem(string inpSystem)
        {
            inpSystem = inpSystem.ToUpper();

            // If we don't have any data in the cache, populate it.
            if (systemsList.Count == 0)
            {
                ReGetSystemList();
            }

            return systemsList.Contains(inpSystem);
        }
        /// <summary>
        /// Verify that our system has valid configuration.
        /// </summary>
        /// <param name="inpSystem">Name of system to check for.</param>
        /// <returns>True if the system has a configuration set up.</returns>
        public bool IsValidSystem(SystemTypes.PostageSystemType inpSystem)
        {
            return IsValidSystem(inpSystem.ToString());
        }
        /// <summary>
        /// Verify that our system has valid configuration.
        /// </summary>
        /// <param name="inpSystem">Name of system to check for.</param>
        /// <returns>True if the system has a configuration set up.</returns>
        public bool IsValidSystem(SystemTypes.SourceSystemType inpSystem)
        {
            return IsValidSystem(inpSystem.ToString());
        }
        #endregion  // SystemValidation

        #region InternalTools
        /// <summary>
        /// Read the configuration file and search for the spacified parameter for that system.
        /// </summary>
        /// <param name="inpSystem">Name of the system that we're looking for (as a string)</param>
        /// <param name="inpParameterName">Name of the parameter that we're looking for (as a string).</param>
        /// <returns>Value of the parameter as a string.</returns>
        private string GetParameterFromFile(string inpSystem, string inpParameterName)
        {
            string outParameterValue = "";
            string currentSystem = "";

            if (File.Exists(configurationFileName))
            {
                // Step through the file, line by line.
                using (StreamReader configurationSR = new StreamReader(configurationFileName))
                {
                    string currentLine = configurationSR.ReadLine();

                    while (currentLine != null)
                    {
                        // If we're already in the right system in the configuration file, then get the parameter for the system.
                        if (currentSystem == inpSystem)
                        {
                            string outParameterName = "";
                            (outParameterName, outParameterValue) = GetParameterFromLine(currentLine);
                            if (outParameterName == inpParameterName)
                            {
                                return outParameterValue;
                            }
                        }

                        // If we've just found the right system in the file, flag it, as we need to look for the argument next.
                        if (currentLine.ToUpper().StartsWith(inpSystem))
                        {
                            if (AddSystem(currentLine, inpSystem))
                            {
                                currentSystem = inpSystem;
                            }
                        }
                        currentLine = configurationSR.ReadLine();
                    }
                    configurationSR.Close();
                }
            }
            else
            {
                // This should never happen, but if it does, some-one needs to know about it.
                File.Create(configurationFileName);
                throw new FileNotFoundException("Cannot find configuration file. Created blank file.", nameof(GetParameterFromFile));
            }

            return outParameterValue;
        }

        /// <summary>
        /// Divide the line into a parameter name and value.
        /// </summary>
        /// <param name="inpCurrentLine">Current line, read from the file.</param>
        /// <param name="inpParameterName">Name of parameter that we're looking for.</param>
        /// <returns>The value of the argument as a string.</returns>
        private (string outParameterName, string outParameterValue) GetParameterFromLine(string inpCurrentLine)
        {
            string outParameterName = "";
            string outParameterValue = "";

            // The first value before the = is the argument name.
            string[] parameterValues = inpCurrentLine.Split("=");
            outParameterName = parameterValues[0];
            if (parameterValues.Length > 1)
            {
                // If there are = in the argument, put them back in!
                for (int i = 1; i < parameterValues.Length; i++)
                {
                    outParameterValue += i > 2 ? "=" : "";
                    outParameterValue += parameterValues[i];
                }
            }

            return (outParameterName, outParameterValue);
        }

        /// <summary>
        /// Add this system to the list of valid systems.
        /// </summary>
        /// <param name="inpSystem">Name of system to add.</param>
        /// <returns>Was the line a valid system name?</returns>
        private void AddSystem(string inpSystem)
        {
            // Don't add the system twice.
            if (!systemsList.Contains(inpSystem))
            {
                systemsList.Add(inpSystem);
            }
        }
        /// <summary>
        /// Add this system to the list of valid systems.
        /// </summary>
        /// <param name="inpCurrentLine">Current line, read from the file.</param>
        /// <param name="inpSystem">Name of system to add.</param>
        /// <returns>Was the line a valid system name?</returns>
        private bool AddSystem(string inpCurrentLine, string inpSystem)
        {
            // Ignore blank lines and comments (which begin "//").
            if (inpCurrentLine == "" ||
               inpCurrentLine.StartsWith($"//"))
            {
                return false;
            }
            // System lines don't have an equals value in them.
            if (!inpCurrentLine.Contains("="))
            {
                AddSystem(inpSystem);
                return true;
            }
            return false;
        }

        #endregion  // InternalTools
    }
}
