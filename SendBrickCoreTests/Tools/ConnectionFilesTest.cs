using Microsoft.VisualStudio.TestTools.UnitTesting;
using CM.SendBrick.Tools;

namespace CM.SendBrick.Tools.Tests
{
    [TestClass()]
    public class ConnectionFilesTest
    {
        [TestMethod()]
        public void GetConfFileLocationTest()
        {
            ConfigurationFile config = new();

            Assert.AreEqual("..\\..\\..\\..\\SendBrick2\\Connections.txt",config.GetConfFileLocation());
        }
    }
}