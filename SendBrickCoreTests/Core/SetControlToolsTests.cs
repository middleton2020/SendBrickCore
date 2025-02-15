using Microsoft.VisualStudio.TestTools.UnitTesting;
using CM.SendBrickCore.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CM.SendBrick.Tools;
using CM.SendBrickCore.Tools;
using CM.SendBrickCore.Messages;

namespace CM.SendBrickCore.Core.Tests
{
    [TestClass()]
    public class SetControlToolsTests
    {
        [TestMethod()]
        public void SetControlToolsTest()
        {
            // Create comparison objects.
            ConfigurationFile configFile= new ConfigurationFile();
            ConnectionParameters connectParams = new ConnectionParameters(configFile);
            Errors errors = new Errors();
            Logging logging = new Logging();
            MessageData messages = new MessageData();

            // Create our test object.
            SetControlTools controler = new SetControlTools();

            Assert.AreEqual(configFile.GetType(), controler.GetConfigFile().GetType());
            Assert.AreEqual(connectParams.GetType(), controler.GetConnectionParamsController().GetType());
            Assert.AreEqual(errors.GetType(),controler.GetErrorHandler().GetType());
            Assert.AreEqual(logging.GetType(),controler.GetLogHandler().GetType());
            Assert.AreEqual(messages.GetType(),controler.GetMessageHandler().GetType());
        }

        [TestMethod()]
        public void SetControlToolsTest1()
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
        public void SetControlToolsTest2()
        {
            // Create comparison objects.
            ConfigurationFile configFile = new ConfigurationFile();
            ConnectionParameters connectParams = new ConnectionParameters(configFile);
            Errors errors = new Errors();
            Logging logging = new Logging();
            MessageData messages = new MessageData();

            // Create our test object.
            SetControlTools controler = new SetControlTools(configFile,connectParams);

            Assert.AreSame(configFile, controler.GetConfigFile());
            Assert.AreEqual(connectParams.GetType(), controler.GetConnectionParamsController().GetType());
            Assert.AreEqual(errors.GetType(), controler.GetErrorHandler().GetType());
            Assert.AreEqual(logging.GetType(), controler.GetLogHandler().GetType());
            Assert.AreEqual(messages.GetType(), controler.GetMessageHandler().GetType());
        }

        [TestMethod()]
        public void SetControlToolsTest3()
        {
            // Create comparison objects.
            ConfigurationFile configFile = new ConfigurationFile();
            ConnectionParameters connectParams = new ConnectionParameters(configFile);
            Errors errors = new Errors();
            Logging logging = new Logging();
            MessageData messages = new MessageData();

            // Create our test object.
            SetControlTools controler = new SetControlTools(configFile,connectParams,errors);

            Assert.AreSame(configFile, controler.GetConfigFile());
            Assert.AreEqual(connectParams.GetType(), controler.GetConnectionParamsController().GetType());
            Assert.AreEqual(errors.GetType(), controler.GetErrorHandler().GetType());
            Assert.AreEqual(logging.GetType(), controler.GetLogHandler().GetType());
            Assert.AreEqual(messages.GetType(), controler.GetMessageHandler().GetType());
        }

        [TestMethod()]
        public void SetControlToolsTest4()
        {
            // Create comparison objects.
            ConfigurationFile configFile = new ConfigurationFile();
            ConnectionParameters connectParams = new ConnectionParameters(configFile);
            Errors errors = new Errors();
            Logging logging = new Logging();
            MessageData messages = new MessageData();

            // Create our test object.
            SetControlTools controler = new SetControlTools(configFile,connectParams,errors,logging);

            Assert.AreSame(configFile, controler.GetConfigFile());
            Assert.AreEqual(connectParams.GetType(), controler.GetConnectionParamsController().GetType());
            Assert.AreEqual(errors.GetType(), controler.GetErrorHandler().GetType());
            Assert.AreEqual(logging.GetType(), controler.GetLogHandler().GetType());
            Assert.AreEqual(messages.GetType(), controler.GetMessageHandler().GetType());
        }

        [TestMethod()]
        public void SetControlToolsTest5()
        {
            // Create comparison objects.
            ConfigurationFile configFile = new ConfigurationFile();
            ConnectionParameters connectParams = new ConnectionParameters(configFile);
            Errors errors = new Errors();
            Logging logging = new Logging();
            MessageData messages = new MessageData();

            // Create our test object.
            SetControlTools controler = new SetControlTools(configFile,connectParams,errors,logging,messages);

            Assert.AreSame(configFile, controler.GetConfigFile());
            Assert.AreEqual(connectParams.GetType(), controler.GetConnectionParamsController().GetType());
            Assert.AreEqual(errors.GetType(), controler.GetErrorHandler().GetType());
            Assert.AreEqual(logging.GetType(), controler.GetLogHandler().GetType());
            Assert.AreEqual(messages.GetType(), controler.GetMessageHandler().GetType());
        }

        [TestMethod()]
        public void SetControlToolsTest6()
        {
            // Create comparison objects.
            ConfigurationFile configFile = new ConfigurationFile();
            ConnectionParameters connectParams = new ConnectionParameters(configFile);
            Errors errors = new Errors();
            Logging logging = new Logging();
            MessageData messages = new MessageData();

            // Create our test object.
            SetControlTools controler = new SetControlTools(errors,logging,messages);

            Assert.AreEqual(configFile.GetType(), controler.GetConfigFile().GetType());
            Assert.AreEqual(connectParams.GetType(), controler.GetConnectionParamsController().GetType());
            Assert.AreEqual(errors.GetType(), controler.GetErrorHandler().GetType());
            Assert.AreEqual(logging.GetType(), controler.GetLogHandler().GetType());
            Assert.AreEqual(messages.GetType(), controler.GetMessageHandler().GetType());
        }

        [TestMethod()]
        public void SetControlToolsTest7()
        {
            // Create comparison objects.
            ConfigurationFile configFile = new ConfigurationFile();
            ConnectionParameters connectParams = new ConnectionParameters(configFile);
            Errors errors = new Errors();
            Logging logging = new Logging();
            MessageData messages = new MessageData();

            // Create our test object.
            SetControlTools controler = new SetControlTools(errors,logging);

            Assert.AreEqual(configFile.GetType(), controler.GetConfigFile().GetType());
            Assert.AreEqual(connectParams.GetType(), controler.GetConnectionParamsController().GetType());
            Assert.AreEqual(errors.GetType(), controler.GetErrorHandler().GetType());
            Assert.AreEqual(logging.GetType(), controler.GetLogHandler().GetType());
            Assert.AreEqual(messages.GetType(), controler.GetMessageHandler().GetType());
        }

        [TestMethod()]
        public void SetControlToolsTest8()
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
            Assert.AreEqual(errors.GetType(), controler.GetErrorHandler().GetType());
            Assert.AreEqual(logging.GetType(), controler.GetLogHandler().GetType());
            Assert.AreEqual(messages.GetType(), controler.GetMessageHandler().GetType());
        }

        [TestMethod()]
        public void SetControlToolsTest9()
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
            Assert.AreEqual(logging.GetType(), controler.GetLogHandler().GetType());
            Assert.AreEqual(messages.GetType(), controler.GetMessageHandler().GetType());
        }

        [TestMethod()]
        public void SetControlToolsTest10()
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
            Assert.AreEqual(errors.GetType(), controler.GetErrorHandler().GetType());
            Assert.AreEqual(logging.GetType(), controler.GetLogHandler().GetType());
            Assert.AreEqual(messages.GetType(), controler.GetMessageHandler().GetType());
        }

        [TestMethod()]
        public void SetControlToolsTest11()
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
            Assert.AreEqual(logging.GetType(), controler.GetLogHandler().GetType());
            Assert.AreEqual(messages.GetType(), controler.GetMessageHandler().GetType());
        }

        [TestMethod()]
        public void SetControlToolsTest12()
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
            Assert.AreEqual(messages.GetType(), controler.GetMessageHandler().GetType());
        }
    }
}