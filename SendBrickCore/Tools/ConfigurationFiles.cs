using CM.SendBrickCore.Interfaces.Tools;

namespace CM.SendBrick.Tools
{
    /// <summary>
    /// Provide access to the configuration data, so that we can over-ride this.
    /// </summary>
    public class ConfigurationFile : IConfigurationFile
    {
        /// <summary>
        /// Provide the location of the connections file, so that we can over-ride this.
        /// </summary>
        /// <returns>Path to configuration file.</returns>
        public string GetConfFileLocation()
        {
            return "..\\..\\..\\..\\SendBrick2\\Connections.txt";
        }
    }
}
