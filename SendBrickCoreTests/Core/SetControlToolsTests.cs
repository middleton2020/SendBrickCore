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
            SetControlTools controler = new SetControlTools();

            ConfigurationFile configFile= new ConfigurationFile();
            ConnectionParameters connectParams = new ConnectionParameters(configFile);
            Errors errors = new Errors();
            Logging logging = new Logging();
            MessageData messages = new MessageData();

            Assert.AreEqual(configFile.GetType(), controler.GetConfigFile().GetType());
            Assert.AreEqual(connectParams.GetType(), controler.GetConnectionParamsController().GetType());
            Assert.AreEqual(errors.GetType(),controler.GetErrorHandler().GetType());
            Assert.AreEqual(logging.GetType(),controler.GetLogHandler().GetType());
            Assert.AreEqual(messages.GetType(),controler.GetMessageHandler().GetType());
        }

        [TestMethod()]
        public void SetControlToolsTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SetControlToolsTest2()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SetControlToolsTest3()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SetControlToolsTest4()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SetControlToolsTest5()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SetControlToolsTest6()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void SetControlToolsTest7()
        {
            Assert.Fail();
        }
    }
}