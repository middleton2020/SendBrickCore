using CM.SendBrick.Interfaces.Tools;
using CM.SendBrick.Tools;
using CM.SendBrickCore.Interfaces.Messages;
using CM.SendBrickCore.Interfaces.Tools;
using CM.SendBrickCore.Messages;
using CM.SendBrickCore.Tools;

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
        private IMessageData messageData;
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
            messageData = new MessageData();
        }
        public SetControlTools(IConfigurationFile inpConfigFile)
        {
            configFile = inpConfigFile;
            connectionParams = new ConnectionParameters(configFile);

            errorMessages = new Errors();
            logMessages = new Logging();
            messageData = new MessageData();
        }
        public SetControlTools(IConfigurationFile inpConfigFile,
                               IConnectionParameters inpConnections)
        {
            configFile = inpConfigFile;
            connectionParams = inpConnections;

            errorMessages = new Errors();
            logMessages = new Logging();
            messageData = new MessageData();
        }
        public SetControlTools(IConfigurationFile inpConfigFile,
                               IConnectionParameters inpConnections,
                               IErrors inpErrorMessages)
        {
            configFile = inpConfigFile;
            connectionParams = inpConnections;

            errorMessages = inpErrorMessages;
            logMessages = new Logging();
            messageData = new MessageData();
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
            messageData = new MessageData();
        }
        public SetControlTools(IConfigurationFile inpConfigFile,
                               IConnectionParameters inpConnections,
                               IErrors inpErrorMessages,
                               ILogging inpLogMessages,
                               IMessageData inpMessageData)
        {
            configFile = inpConfigFile;
            connectionParams = inpConnections;

            errorMessages = inpErrorMessages;
            logMessages = inpLogMessages;
            messageData = inpMessageData;
        }
        public SetControlTools(IErrors inpErrorMessages,
                               ILogging inpLogMessages,
                               IMessageData inpMessageData)
        {
            configFile = new ConfigurationFile();
            connectionParams = new ConnectionParameters(configFile);

            errorMessages = inpErrorMessages;
            logMessages = inpLogMessages;
            messageData = inpMessageData;
        }
        public SetControlTools(IErrors inpErrorMessages,
                               ILogging inpLogMessages)
        {
            configFile = new ConfigurationFile();
            connectionParams = new ConnectionParameters(configFile);

            errorMessages = inpErrorMessages;
            logMessages = inpLogMessages;
            messageData = new MessageData();
        }
        public SetControlTools(IErrors inpErrorMessages,
                               IMessageData inpMessageData)
        {
            configFile = new ConfigurationFile();
            connectionParams = new ConnectionParameters(configFile);

            errorMessages = inpErrorMessages;
            logMessages = new Logging();
            messageData = inpMessageData;
        }
        public SetControlTools(ILogging inpLogMessages,
                               IMessageData inpMessageData)
        {
            configFile = new ConfigurationFile();
            connectionParams = new ConnectionParameters(configFile);

            errorMessages = new Errors();
            logMessages = inpLogMessages;
            messageData = inpMessageData;
        }
        public SetControlTools(IErrors inpErrorMessages)
        {
            configFile = new ConfigurationFile();
            connectionParams = new ConnectionParameters(configFile);

            errorMessages = inpErrorMessages;
            logMessages = new Logging();
            messageData = new MessageData();
        }
        public SetControlTools(ILogging inpLogMessages)
        {
            configFile = new ConfigurationFile();
            connectionParams = new ConnectionParameters(configFile);

            errorMessages = new Errors();
            logMessages = inpLogMessages;
            messageData = new MessageData();
        }
        public SetControlTools(IMessageData inpMessageData)
        {
            configFile = new ConfigurationFile();
            connectionParams = new ConnectionParameters(configFile);

            errorMessages = new Errors();
            logMessages = new Logging();
            messageData = inpMessageData;
        }
        #endregion  // Constructors

        #region GetControllerObjects
        /// <summary>
        /// Get the right error handler object.
        /// </summary>
        /// <returns>Error handler matching IErrors.</returns>
        public IErrors GetErrorHandler()
        {
            return errorMessages;
        }

        /// <summary>
        /// Get the right log handler object.
        /// </summary>
        /// <returns>Log handler matching ILogging.</returns>
        public ILogging GetLogHandler()
        {
            return logMessages;
        }

        /// <summary>
        /// Get the right message handler object.
        /// </summary>
        /// <returns>Message handler matching IMessageData.</returns>
        public IMessageData GetMessageHandler()
        {
            return messageData;
        }

        /// <summary>
        /// Get the right configuration file handler object.
        /// </summary>
        /// <returns>Configuration file handler matching IConfigurationFile.</returns>
        public IConfigurationFile GetConfigFile()
        {
            return configFile;
        }

        /// <summary>
        /// Get the right connection parameter handler object.
        /// </summary>
        /// <returns>Connection parameter handler matching IConnecctionParameters.</returns>
        public IConnectionParameters GetConnectionParamsController()
        {
            return connectionParams;
        }
        #endregion  // GetControllerObjects
    }
}
