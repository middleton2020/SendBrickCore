using CM.SendBrick.Interfaces.Tools;
using CM.SendBrick.Tools;
using CM.SendBrickCore.Interfaces.Messages;
using CM.SendBrickCore.Interfaces.Tools;
using CM.SendBrickCore.Messages;
using CM.SendBrickCore.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CM.SendBrickCore.Core
{
    /// <summary>
    /// Get configuration details.
    /// </summary>
    public class SetControlTools
    {
        // This is the top level of our system, which sets up the DependencyInversions to be used by the other classes.
        #region VariableDefinitions
        private IErrors errorMessages;
        private ILogging logMessages;
        private IConfigurationFile configFile;
        private IConnectionParameters connectionParams;
        #endregion

        #region Constructors
        /// <summary>
        /// Set up the DependencyInversions.
        /// </summary>
        public SetControlTools()
        {
            configFile = new ConfigurationFile();
            connectionParams = new ConnectionParameters(configFile);

            errorMessages = new Errors();
            logMessages = new Logging();
        }
        public SetControlTools(IConfigurationFile inpConfigFile)
        {
            configFile = inpConfigFile;
            connectionParams = new ConnectionParameters(configFile);

            errorMessages = new Errors();
            logMessages = new Logging();
        }
        public SetControlTools(IConfigurationFile inpConfigFile,
                               IConnectionParameters inpConnections)
        {
            configFile = inpConfigFile;
            connectionParams = inpConnections;

            errorMessages = new Errors();
            logMessages = new Logging();
        }
        public SetControlTools(IConfigurationFile inpConfigFile,
                               IConnectionParameters inpConnections,
                               IErrors inpErrorMessages)
        {
            configFile = inpConfigFile;
            connectionParams = inpConnections;

            errorMessages = inpErrorMessages;
            logMessages = new Logging();
        }
        public SetControlTools(IConfigurationFile inpConfigFile,
                               IConnectionParameters inpConnections,
                               IErrors inpErrorMessages,
                               ILogging inpLogMessages)
        {
            configFile = inpConfigFile;
            connectionParams = inpConnections;

            errorMessages = inpErrorMessages;
            logMessages = inpLogMessages;
        }
        public SetControlTools(IErrors inpErrorMessages,
                               ILogging inpLogMessages)
        {
            configFile = new ConfigurationFile();
            connectionParams = new ConnectionParameters(configFile);

            errorMessages = inpErrorMessages;
            logMessages = inpLogMessages;
        }
        public SetControlTools(IErrors inpErrorMessages)
        {
            configFile = new ConfigurationFile();
            connectionParams = new ConnectionParameters(configFile);

            errorMessages = inpErrorMessages;
            logMessages = new Logging();
        }
        public SetControlTools(ILogging inpLogMessages)
        {
            configFile = new ConfigurationFile();
            connectionParams = new ConnectionParameters(configFile);

            errorMessages = new Errors();
            logMessages = inpLogMessages;
        }
        #endregion  // Constructors

        #region GetControllerObjects
        /// <summary>
        /// Get the right configuration file handler object.
        /// </summary>
        /// <returns>Configuration file handler matching IConfigurationFile.</returns>
        public IConfigurationFile GetConfigFile()
        {
            return configFile;
        }

        #endregion  // GetControllerObjects
    }
}
