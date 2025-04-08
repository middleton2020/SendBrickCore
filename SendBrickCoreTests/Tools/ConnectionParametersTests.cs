using Microsoft.VisualStudio.TestTools.UnitTesting;
using CM.SendBrickCore.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CM.SendBrickCore.Interfaces.Tools;
using CM.SendbrickShared.Enums;

namespace CM.SendBrickCore.Tools.Tests
{
    [TestClass()]
    public class ConnectionParametersTests
    {
            TestConfigLocation configFile = new TestConfigLocation();

            /// <summary>
            /// Check that we can get a parameter out of the configuration file for BrickOwl.
            /// </summary>
            [TestMethod()]
            public void GetConnectionParameterTest()
            {
                ConnectionParameters paramsGetter = new ConnectionParameters(configFile);
                string apiKeyParameter = paramsGetter.GetConnectionParameter(SystemTypes.SourceSystemType.BrickOwl, "apikey");

                Assert.AreEqual("gjgi7gqeijbsj0bn9890808090fagU999GQEEJ", apiKeyParameter);
            }

            /// <summary>
            /// Check that we can get a parameter out of the configuration file using for Royal Mail.
            /// </summary>
            [TestMethod()]
            public void GetPostageConnectionParameterTest()
            {
                ConnectionParameters paramsGetter = new ConnectionParameters(configFile);
                string apiKeyParameter = paramsGetter.GetConnectionParameter(SystemTypes.PostageSystemType.RoyalMail, "apikey");

                Assert.AreEqual("", apiKeyParameter);
            }

            /// <summary>
            /// Check that we can get a parameter out of the configuration file for BrickLink.
            /// </summary>
            [TestMethod()]
            public void GetSourceConnectionParameterTest()
            {
                ConnectionParameters paramsGetter = new ConnectionParameters(configFile);
                string apiKeyParameter = paramsGetter.GetConnectionParameter(SystemTypes.SourceSystemType.BrickLink, "apikey");

                Assert.AreEqual("", apiKeyParameter);
            }

            /// <summary>
            /// Get a list of configured systems.
            /// </summary>
            [TestMethod()]
            public void GetSystemListTest()
            {
                ConnectionParameters paramsGetter = new ConnectionParameters(configFile);
                string[] systemList = paramsGetter.GetSystemList();
                string[] systemList2 = paramsGetter.GetSystemList();

                Assert.AreEqual(3, systemList.Length);
                Assert.AreEqual(systemList.Length, systemList2.Length);
            }

            /// <summary>
            /// Get a list of configured systems, blanking the list first.
            /// </summary>
            [TestMethod()]
            public void ReGetSystemListTest()
            {
                ConnectionParameters paramsGetter = new ConnectionParameters(configFile);
                string[] systemList = paramsGetter.ReGetSystemList();
                string[] systemList2 = paramsGetter.ReGetSystemList();

                Assert.AreEqual(3, systemList.Length);
                Assert.AreEqual(systemList.Length, systemList2.Length);
            }

            /// <summary>
            /// Checking that we can validate systems, passing in a string value.
            /// </summary>
            [TestMethod()]
            public void IsValidSystemTest()
            {
                ConnectionParameters paramsGetter = new ConnectionParameters(configFile);

                bool hasBrickLink = paramsGetter.IsValidSystem("BrickLink");
                bool hasBrickOwl = paramsGetter.IsValidSystem("BrickOwl");
                bool hasPaperOrder = paramsGetter.IsValidSystem("PaperOrder");

                bool hasDPD = paramsGetter.IsValidSystem("DPD");
                bool hasEvri = paramsGetter.IsValidSystem("Evri");
                bool hasRoyalMail = paramsGetter.IsValidSystem("RoyalMail");
                bool hasUPS = paramsGetter.IsValidSystem("UPS");

                Assert.IsTrue(!hasDPD);
                Assert.IsTrue(!hasEvri);
                Assert.IsTrue(hasRoyalMail);
                Assert.IsTrue(!hasUPS);

                Assert.IsTrue(!hasPaperOrder);
                Assert.IsTrue(hasBrickLink);
                Assert.IsTrue(hasBrickOwl);
            }

            /// <summary>
            /// Checking that we can validate systems, passing in a postage enum.
            /// </summary>
            [TestMethod()]
            public void IsValidPostageSystemTest()
            {
                ConnectionParameters paramsGetter = new ConnectionParameters(configFile);

                bool hasDPD = paramsGetter.IsValidSystem(SystemTypes.PostageSystemType.DPD);
                bool hasEvri = paramsGetter.IsValidSystem(SystemTypes.PostageSystemType.Evri);
                bool hasRoyalMail = paramsGetter.IsValidSystem(SystemTypes.PostageSystemType.RoyalMail);
                bool hasUPS = paramsGetter.IsValidSystem(SystemTypes.PostageSystemType.UPS);

                Assert.IsTrue(!hasDPD);
                Assert.IsTrue(!hasEvri);
                Assert.IsTrue(hasRoyalMail);
                Assert.IsTrue(!hasUPS);
            }

            /// <summary>
            /// Checking that we can validate systems, passing in a source enum.
            /// </summary>
            [TestMethod()]
            public void IsValidSourceSystemTest()
            {
                ConnectionParameters paramsGetter = new ConnectionParameters(configFile);

                bool hasBrickLink = paramsGetter.IsValidSystem(SystemTypes.SourceSystemType.BrickLink);
                bool hasBrickOwl = paramsGetter.IsValidSystem(SystemTypes.SourceSystemType.BrickOwl);
                bool hasPaperOrder = paramsGetter.IsValidSystem("PaperOrder");

                Assert.IsTrue(!hasPaperOrder);
                Assert.IsTrue(hasBrickLink);
                Assert.IsTrue(hasBrickOwl);
            }



        [TestMethod()]
        public void ConnectionParametersTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void ConnectionParametersTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetConnectionParameterTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetConnectionParameterTest2()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void IsValidSystemTest1()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void IsValidSystemTest2()
        {
            Assert.Fail();
        }
    }

        /// <summary>
        /// A fake IConfigurationFile for testing puroses.
        /// </summary>
        public class TestConfigLocation : IConfigurationFile
        {
            /// <summary>
            /// Get the fake connection file.
            /// </summary>
            /// <returns>\SendBrick2Tests\Connections.txt</returns>
            public string GetConfFileLocation()
            {
                return "..\\..\\..\\Connections.txt";
            }
        }
}