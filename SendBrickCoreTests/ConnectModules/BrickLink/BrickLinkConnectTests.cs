using CM.ReformatJson.Processing;
using CM.SendBrickCore.ConnectModules.BrickLink;
using CM.SendBrickCore.Core;
using CM.SendBrickCore.Interfaces.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.SendBrickCoreTests.ConnectModules.BrickLink
{
    [TestClass()]
    public class BrickLinkConnectTests
    {
        IConnectionParameters connectionParams = null;

        /// <summary>
        /// Run this to setup the connections to your instance of BrickOwl.
        /// </summary>
        private IConnectionParameters SetConfig()
        {
            if (connectionParams == null)
            {
                SetControlTools configControl = new SetControlTools();
                connectionParams = configControl.GetConnectionParamsController();
            }
            return connectionParams;
        }

        #region OrderTests
        [TestMethod()]
        public void GetOrderListTest()
        {
            IConnectionParameters connectionParams = SetConfig();
            BrickLinkOrderApiTools connectBrickLink = new BrickLinkOrderApiTools(connectionParams);
            string result = connectBrickLink.GetOrderList("", "", 200, "");

            // Commented this out because it takes over 4 hours to run.
            //ResformatJson reformatJson = new ResformatJson();
            //string readableJson = (string)reformatJson.MakeReadable(result);

            //// File is output to the repos\SendBrick2Tests\bin\Debug\netcoreapp3.1 directory
            //using (StreamWriter outputFile = new StreamWriter("BrickLink.Orders.txt", false))
            //{
            //    outputFile.WriteLine(readableJson);
            //}

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Length > 10);
        }

        [TestMethod()]
        public void GetOrderViewTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetOrderItemsTest()
        {
            Assert.Fail();
        }
        #endregion

        #region InventoryTests
        [TestMethod()]
        public void GetInventoryListTest()
        {
            SetConfig();
            string result = "";
            // string result = BrickLinkInventoryCommands.GetInventoryList(apiKey, "", "", "", "");

            // Commented this out because it takes over 2 hours to run.
            //ResformatJson reformatJson = new ResformatJson();
            //string readableJson = (string)reformatJson.MakeReadable(result);

            //// File is output to the repos\SendBrick2Tests\bin\Debug\netcoreapp3.1 directory
            //using (StreamWriter outputFile = new StreamWriter("BrickLink.Inventory.txt", false))
            //{
            //    outputFile.WriteLine(readableJson);
            //}

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Length > 10);
        }

        [TestMethod()]
        public void GetInventoryDetailsTest()
        {
            SetConfig();
            string result = "";
            // string result = BrickLinkInventoryCommands.GetInventoryDetails(apiKey, "", "");

            ResformatJson reformatJson = new ResformatJson();
            string readableJson = (string)reformatJson.MakeReadable(result);

            // File is output to the repos\SendBrick2Tests\bin\Debug\netcoreapp3.1 directory
            using (StreamWriter outputFile = new StreamWriter("BrickLink.Inventory.ById.txt", false))
            {
                outputFile.WriteLine(readableJson);
            }

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Length > 10);
        }
        #endregion
    }
}