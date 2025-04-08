using CM.SendBrick.Tools;
using CM.SendBrickCore.Messages;
using CM.SendBrickCore.Tools;

namespace CM.SendBrickCore.Core.Tests
{
    [TestClass()]
    public class SetControlToolsTests
    {
        [TestMethod()]
        public void SetControlToolsTest()
        {
            // Create comparison objects.
            ConfigurationFile configFile = new ConfigurationFile();
            ConnectionParameters connectParams = new ConnectionParameters(configFile);
            Errors errors = new Errors();
            Logging logging = new Logging();
            MessageData messages = new MessageData();

            // Create our test object.
            SetControlTools controler = new SetControlTools();

            Assert.AreEqual(configFile.GetType(), controler.GetConfigFile().GetType());
            Assert.AreEqual(connectParams.GetType(), controler.GetConnectionParamsController().GetType());
            Assert.AreEqual(errors.GetType(), controler.GetErrorHandler().GetType());
            Assert.AreEqual(logging.GetType(), controler.GetLogHandler().GetType());
            Assert.AreEqual(messages.GetType(), controler.GetMessageHandler().GetType());
        }

        [TestMethod()]
        public void SetControlToolsConfigTest()
        {
            // Create comparison objects.
            ConfigurationFile configFile = new ConfigurationFile();
            ConnectionParameters connectParams = new ConnectionParameters(configFile);
            Errors errors = new Errors();
            Logging logging = new Logging();
            MessageData messages = new MessageData();

            // Create our test object.
            SetControlTools controler = new SetControlTools(configFile);

            Assert.AreSame(configFile, controler.GetConfigFile());
            Assert.AreEqual(connectParams.GetType(), controler.GetConnectionParamsController().GetType());
            Assert.AreEqual(errors.GetType(), controler.GetErrorHandler().GetType());
            Assert.AreEqual(logging.GetType(), controler.GetLogHandler().GetType());
            Assert.AreEqual(messages.GetType(), controler.GetMessageHandler().GetType());
        }

        [TestMethod()]
        public void SetControlToolsConfigConnectTest()
        {
            // Create comparison objects.
            ConfigurationFile configFile = new ConfigurationFile();
            ConnectionParameters connectParams = new ConnectionParameters(configFile);
            Errors errors = new Errors();
            Logging logging = new Logging();
            MessageData messages = new MessageData();

            // Create our test object.
            SetControlTools controler = new SetControlTools(configFile, connectParams);

            Assert.AreSame(configFile, controler.GetConfigFile());
            Assert.AreSame(connectParams, controler.GetConnectionParamsController());
            Assert.AreEqual(errors.GetType(), controler.GetErrorHandler().GetType());
            Assert.AreEqual(logging.GetType(), controler.GetLogHandler().GetType());
            Assert.AreEqual(messages.GetType(), controler.GetMessageHandler().GetType());
        }

        [TestMethod()]
        public void SetControlToolsConfigConnectErrorsTest()
        {
            // Create comparison objects.
            ConfigurationFile configFile = new ConfigurationFile();
            ConnectionParameters connectParams = new ConnectionParameters(configFile);
            Errors errors = new Errors();
            Logging logging = new Logging();
            MessageData messages = new MessageData();

            // Create our test object.
            SetControlTools controler = new SetControlTools(configFile, connectParams, errors);

            Assert.AreSame(configFile, controler.GetConfigFile());
            Assert.AreSame(connectParams, controler.GetConnectionParamsController());
            Assert.AreSame(errors, controler.GetErrorHandler());
            Assert.AreEqual(logging.GetType(), controler.GetLogHandler().GetType());
            Assert.AreEqual(messages.GetType(), controler.GetMessageHandler().GetType());
        }

        [TestMethod()]
        public void SetControlToolsConfigConnectErrorsLoggingTest()
        {
            // Create comparison objects.
            ConfigurationFile configFile = new ConfigurationFile();
            ConnectionParameters connectParams = new ConnectionParameters(configFile);
            Errors errors = new Errors();
            Logging logging = new Logging();
            MessageData messages = new MessageData();

            // Create our test object.
            SetControlTools controler = new SetControlTools(configFile, connectParams, errors, logging);

            Assert.AreSame(configFile, controler.GetConfigFile());
            Assert.AreSame(connectParams, controler.GetConnectionParamsController());
            Assert.AreSame(errors, controler.GetErrorHandler());
            Assert.AreSame(logging, controler.GetLogHandler());
            Assert.AreEqual(messages.GetType(), controler.GetMessageHandler().GetType());
        }

        [TestMethod()]
        public void SetControlToolsConfigConnectErrorsLoggingMessagesTest()
        {
            // Create comparison objects.
            ConfigurationFile configFile = new ConfigurationFile();
            ConnectionParameters connectParams = new ConnectionParameters(configFile);
            Errors errors = new Errors();
            Logging logging = new Logging();
            MessageData messages = new MessageData();

            // Create our test object.
            SetControlTools controler = new SetControlTools(configFile, connectParams, errors, logging, messages);

            Assert.AreSame(configFile, controler.GetConfigFile());
            Assert.AreSame(connectParams, controler.GetConnectionParamsController());
            Assert.AreSame(errors, controler.GetErrorHandler());
            Assert.AreSame(logging, controler.GetLogHandler());
            Assert.AreSame(messages, controler.GetMessageHandler());
        }

        [TestMethod()]
        public void SetControlToolsErrorsLoggingMessagesTest()
        {
            // Create comparison objects.
            ConfigurationFile configFile = new ConfigurationFile();
            ConnectionParameters connectParams = new ConnectionParameters(configFile);
            Errors errors = new Errors();
            Logging logging = new Logging();
            MessageData messages = new MessageData();

            // Create our test object.
            SetControlTools controler = new SetControlTools(errors, logging, messages);

            Assert.AreEqual(configFile.GetType(), controler.GetConfigFile().GetType());
            Assert.AreEqual(connectParams.GetType(), controler.GetConnectionParamsController().GetType());
            Assert.AreSame(errors, controler.GetErrorHandler());
            Assert.AreSame(logging, controler.GetLogHandler());
            Assert.AreSame(messages, controler.GetMessageHandler());
        }

        [TestMethod()]
        public void SetControlToolsErrorsLoggingTest()
        {
            // Create comparison objects.
            ConfigurationFile configFile = new ConfigurationFile();
            ConnectionParameters connectParams = new ConnectionParameters(configFile);
            Errors errors = new Errors();
            Logging logging = new Logging();
            MessageData messages = new MessageData();

            // Create our test object.
            SetControlTools controler = new SetControlTools(errors, logging);

            Assert.AreEqual(configFile.GetType(), controler.GetConfigFile().GetType());
            Assert.AreEqual(connectParams.GetType(), controler.GetConnectionParamsController().GetType());
            Assert.AreSame(errors, controler.GetErrorHandler());
            Assert.AreSame(logging, controler.GetLogHandler());
            Assert.AreEqual(messages.GetType(), controler.GetMessageHandler().GetType());
        }

        [TestMethod()]
        public void SetControlToolsErrorsMessagesTest()
        {
            // Create comparison objects.
            ConfigurationFile configFile = new ConfigurationFile();
            ConnectionParameters connectParams = new ConnectionParameters(configFile);
            Errors errors = new Errors();
            Logging logging = new Logging();
            MessageData messages = new MessageData();

            // Create our test object.
            SetControlTools controler = new SetControlTools(errors, messages);

            Assert.AreEqual(configFile.GetType(), controler.GetConfigFile().GetType());
            Assert.AreEqual(connectParams.GetType(), controler.GetConnectionParamsController().GetType());
            Assert.AreSame(errors, controler.GetErrorHandler());
            Assert.AreEqual(logging.GetType(), controler.GetLogHandler().GetType());
            Assert.AreSame(messages, controler.GetMessageHandler());
        }

        [TestMethod()]
        public void SetControlToolsLoggingMessagesTest()
        {
            // Create comparison objects.
            ConfigurationFile configFile = new ConfigurationFile();
            ConnectionParameters connectParams = new ConnectionParameters(configFile);
            Errors errors = new Errors();
            Logging logging = new Logging();
            MessageData messages = new MessageData();

            // Create our test object.
            SetControlTools controler = new SetControlTools(logging, messages);

            Assert.AreEqual(configFile.GetType(), controler.GetConfigFile().GetType());
            Assert.AreEqual(connectParams.GetType(), controler.GetConnectionParamsController().GetType());
            Assert.AreEqual(errors.GetType(), controler.GetErrorHandler().GetType());
            Assert.AreSame(logging, controler.GetLogHandler());
            Assert.AreSame(messages, controler.GetMessageHandler());
        }

        [TestMethod()]
        public void SetControlToolsErrorsTest()
        {
            // Create comparison objects.
            ConfigurationFile configFile = new ConfigurationFile();
            ConnectionParameters connectParams = new ConnectionParameters(configFile);
            Errors errors = new Errors();
            Logging logging = new Logging();
            MessageData messages = new MessageData();

            // Create our test object.
            SetControlTools controler = new SetControlTools(errors);

            Assert.AreEqual(configFile.GetType(), controler.GetConfigFile().GetType());
            Assert.AreEqual(connectParams.GetType(), controler.GetConnectionParamsController().GetType());
            Assert.AreSame(errors, controler.GetErrorHandler());
            Assert.AreEqual(logging.GetType(), controler.GetLogHandler().GetType());
            Assert.AreEqual(messages.GetType(), controler.GetMessageHandler().GetType());
        }

        [TestMethod()]
        public void SetControlToolsLoggingTest()
        {
            // Create comparison objects.
            ConfigurationFile configFile = new ConfigurationFile();
            ConnectionParameters connectParams = new ConnectionParameters(configFile);
            Errors errors = new Errors();
            Logging logging = new Logging();
            MessageData messages = new MessageData();

            // Create our test object.
            SetControlTools controler = new SetControlTools(logging);

            Assert.AreEqual(configFile.GetType(), controler.GetConfigFile().GetType());
            Assert.AreEqual(connectParams.GetType(), controler.GetConnectionParamsController().GetType());
            Assert.AreEqual(errors.GetType(), controler.GetErrorHandler().GetType());
            Assert.AreSame(logging, controler.GetLogHandler());
            Assert.AreEqual(messages.GetType(), controler.GetMessageHandler().GetType());
        }

        [TestMethod()]
        public void SetControlToolsMassagesTest()
        {
            // Create comparison objects.
            ConfigurationFile configFile = new ConfigurationFile();
            ConnectionParameters connectParams = new ConnectionParameters(configFile);
            Errors errors = new Errors();
            Logging logging = new Logging();
            MessageData messages = new MessageData();

            // Create our test object.
            SetControlTools controler = new SetControlTools(messages);

            Assert.AreEqual(configFile.GetType(), controler.GetConfigFile().GetType());
            Assert.AreEqual(connectParams.GetType(), controler.GetConnectionParamsController().GetType());
            Assert.AreEqual(errors.GetType(), controler.GetErrorHandler().GetType());
            Assert.AreEqual(logging.GetType(), controler.GetLogHandler().GetType());
            Assert.AreSame(messages, controler.GetMessageHandler());
        }
    }
}