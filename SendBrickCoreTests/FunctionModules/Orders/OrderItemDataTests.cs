namespace CM.SendBrickCore.FunctionModules.Orders.Tests
{
    [TestClass()]
    public class OrderItemDataTests
    {
        [TestMethod()]
        public void ItemAddBlankTest()
        {
            OrderData testItem;

            testItem = new OrderData();
            testItem.AddItem();

            Assert.AreNotEqual(testItem.TotalItemCount, 0);
        }
        [TestMethod()]
        public void ItemAddTwiceTest()
        {
            OrderData testItem;

            testItem = new OrderData();
            int numberOfItems = testItem.TotalItemCount;

            testItem.AddItem();
            testItem.AddItem();

            Assert.AreEqual(testItem.TotalItemCount, numberOfItems + 2);
        }
        [TestMethod()]
        public void ItemAddTestFromData()
        {
            OrderData testItem;

            testItem = new OrderData();
            testItem.AddItem("1", 3, 0, "Plate 1x4", 0.06, 0.02, "Code1", "SKU1", "Denmark", "");

            Assert.AreEqual(testItem.TotalItemCount, 1);
            Assert.AreEqual(testItem.ItemId, "1");
            Assert.AreEqual(testItem.ItemQuantity, 3);
            Assert.AreEqual(testItem.ItemParcelInstance, 0);
            Assert.AreEqual(testItem.ItemDescription, "Plate 1x4");
            Assert.AreEqual(testItem.ItemValue, 0.06);
            Assert.AreEqual(testItem.ItemWeight, 0.02);
            Assert.AreEqual(testItem.ItemHsCode, "Code1");
            Assert.AreEqual(testItem.ItemSkuCode, "SKU1");
            Assert.AreEqual(testItem.ItemCountryOfOrigin, "Denmark");
            Assert.AreEqual(testItem.ItemImageUrl, "");
        }
        [TestMethod()]
        public void ItemGetFirstTest()
        {
            OrderData testItem;

            testItem = new OrderData();
            testItem.AddItem("1", 3, 0, "Plate 1x4", 0.06, 0.02, "Code1", "SKU1", "Denmark", ""); // First Item
            testItem.AddItem("5", 1, 0, "Turntable 2x2", 0.12, 0.03, "Code3", "SKU3", "Denmark", ""); // Second Item
            testItem.AddItem("2", 2, 0, "Tile 2x4", 0.06, 0.02, "Code2", "SKU2", "Denmark", ""); // Third Item
            testItem.AddItem("3", 1, 0, "Round Brick 2x2", 0.15, 0.05, "Code4", "SKU4", "Denmark", ""); // Fourth Item
            testItem.AddItem("4", 8, 1, "Brick 1x2", 0.24, 0.24, "Code7", "SKU7", "China", "https://www.bricklink.com/catalogList.asp?pg=2&catString=43&catType=P"); // Fifth Item

            bool hasFound = testItem.FindFirstItem();

            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.TotalItemCount, 5);
            Assert.AreEqual(testItem.ItemId, "1");
            Assert.AreEqual(testItem.ItemQuantity, 3);
            Assert.AreEqual(testItem.ItemParcelInstance, 0);
            Assert.AreEqual(testItem.ItemDescription, "Plate 1x4");
            Assert.AreEqual(testItem.ItemValue, 0.06);
            Assert.AreEqual(testItem.ItemWeight, 0.02);
            Assert.AreEqual(testItem.ItemHsCode, "Code1");
            Assert.AreEqual(testItem.ItemSkuCode, "SKU1");
            Assert.AreEqual(testItem.ItemCountryOfOrigin, "Denmark");
            Assert.AreEqual(testItem.ItemImageUrl, "");
        }
        [TestMethod()]
        public void ItemGetLastTest()
        {
            OrderData testItem;

            testItem = new OrderData();
            testItem.AddItem("1", 3, 0, "Plate 1x4", 0.06, 0.02, "Code1", "SKU1", "Denmark", ""); // First Item
            testItem.AddItem("5", 1, 0, "Turntable 2x2", 0.12, 0.03, "Code3", "SKU3", "Denmark", ""); // Second Item
            testItem.AddItem("2", 2, 0, "Tile 2x4", 0.06, 0.02, "Code2", "SKU2", "Denmark", ""); // Third Item
            testItem.AddItem("3", 1, 0, "Round Brick 2x2", 0.15, 0.05, "Code4", "SKU4", "Denmark", ""); // Fourth Item
            testItem.AddItem("4", 8, 1, "Brick 1x2", 0.24, 0.24, "Code7", "SKU7", "China", "https://www.bricklink.com/catalogList.asp?pg=2&catString=43&catType=P"); // Fifth Item

            bool hasFound = testItem.FindLastItem();

            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.TotalItemCount, 5);
            Assert.AreEqual(testItem.ItemId, "4");
            Assert.AreEqual(testItem.ItemQuantity, 8);
            Assert.AreEqual(testItem.ItemParcelInstance, 1);
            Assert.AreEqual(testItem.ItemDescription, "Brick 1x2");
            Assert.AreEqual(testItem.ItemValue, 0.24);
            Assert.AreEqual(testItem.ItemWeight, 0.24);
            Assert.AreEqual(testItem.ItemHsCode, "Code7");
            Assert.AreEqual(testItem.ItemSkuCode, "SKU7");
            Assert.AreEqual(testItem.ItemCountryOfOrigin, "China");
            Assert.AreEqual(testItem.ItemImageUrl, "https://www.bricklink.com/catalogList.asp?pg=2&catString=43&catType=P");
        }
        [TestMethod()]
        public void ItemStepThroughTest()
        {
            OrderData testItem;

            testItem = new OrderData();
            testItem.AddItem("1", 3, 0, "Plate 1x4", 0.06, 0.02, "Code1", "SKU1", "Denmark", ""); // First Item
            testItem.AddItem("5", 1, 0, "Turntable 2x2", 0.12, 0.03, "Code3", "SKU3", "Denmark", ""); // Second Item
            testItem.AddItem("2", 2, 0, "Tile 2x4", 0.06, 0.02, "Code2", "SKU2", "Denmark", ""); // Third Item
            testItem.AddItem("3", 1, 0, "Round Brick 2x2", 0.15, 0.05, "Code4", "SKU4", "Denmark", ""); // Fourth Item
            testItem.AddItem("4", 8, 1, "Brick 1x2", 0.24, 0.24, "Code7", "SKU7", "China", "https://www.bricklink.com/catalogList.asp?pg=2&catString=43&catType=P"); // Fifth Item

            bool hasFound = testItem.FindFirstItem();

            // Check that we've got the first item correctly.
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.TotalItemCount, 5);
            Assert.AreEqual(testItem.ItemId, "1");
            Assert.AreEqual(testItem.ItemQuantity, 3);
            Assert.AreEqual(testItem.ItemParcelInstance, 0);
            Assert.AreEqual(testItem.ItemDescription, "Plate 1x4");
            Assert.AreEqual(testItem.ItemValue, 0.06);
            Assert.AreEqual(testItem.ItemWeight, 0.02);
            Assert.AreEqual(testItem.ItemHsCode, "Code1");
            Assert.AreEqual(testItem.ItemSkuCode, "SKU1");
            Assert.AreEqual(testItem.ItemCountryOfOrigin, "Denmark");
            Assert.AreEqual(testItem.ItemImageUrl, "");

            hasFound = testItem.FindNextItem();

            // Check that we've got the second item correctly.
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.ItemId, "5");
            Assert.AreEqual(testItem.ItemQuantity, 1);
            Assert.AreEqual(testItem.ItemParcelInstance, 0);
            Assert.AreEqual(testItem.ItemDescription, "Turntable 2x2");
            Assert.AreEqual(testItem.ItemValue, 0.12);
            Assert.AreEqual(testItem.ItemWeight, 0.03);
            Assert.AreEqual(testItem.ItemHsCode, "Code3");
            Assert.AreEqual(testItem.ItemSkuCode, "SKU3");
            Assert.AreEqual(testItem.ItemCountryOfOrigin, "Denmark");
            Assert.AreEqual(testItem.ItemImageUrl, "");

            hasFound = testItem.FindNextItem();

            // Check that we've got the third item correctly.
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.ItemId, "2");
            Assert.AreEqual(testItem.ItemQuantity, 2);
            Assert.AreEqual(testItem.ItemParcelInstance, 0);
            Assert.AreEqual(testItem.ItemDescription, "Tile 2x4");
            Assert.AreEqual(testItem.ItemValue, 0.06);
            Assert.AreEqual(testItem.ItemWeight, 0.02);
            Assert.AreEqual(testItem.ItemHsCode, "Code2");
            Assert.AreEqual(testItem.ItemSkuCode, "SKU2");
            Assert.AreEqual(testItem.ItemCountryOfOrigin, "Denmark");
            Assert.AreEqual(testItem.ItemImageUrl, "");

            hasFound = testItem.FindNextItem();

            // Check that we've got the fourth item correctly.
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.ItemId, "3");
            Assert.AreEqual(testItem.ItemQuantity, 1);
            Assert.AreEqual(testItem.ItemParcelInstance, 0);
            Assert.AreEqual(testItem.ItemDescription, "Round Brick 2x2");
            Assert.AreEqual(testItem.ItemValue, 0.15);
            Assert.AreEqual(testItem.ItemWeight, 0.05);
            Assert.AreEqual(testItem.ItemHsCode, "Code4");
            Assert.AreEqual(testItem.ItemSkuCode, "SKU4");
            Assert.AreEqual(testItem.ItemCountryOfOrigin, "Denmark");
            Assert.AreEqual(testItem.ItemImageUrl, "");

            hasFound = testItem.FindNextItem();

            // Check that we've got the last (fifth) item correctly.
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.ItemId, "4");
            Assert.AreEqual(testItem.ItemQuantity, 8);
            Assert.AreEqual(testItem.ItemParcelInstance, 1);
            Assert.AreEqual(testItem.ItemDescription, "Brick 1x2");
            Assert.AreEqual(testItem.ItemValue, 0.24);
            Assert.AreEqual(testItem.ItemWeight, 0.24);
            Assert.AreEqual(testItem.ItemHsCode, "Code7");
            Assert.AreEqual(testItem.ItemSkuCode, "SKU7");
            Assert.AreEqual(testItem.ItemCountryOfOrigin, "China");
            Assert.AreEqual(testItem.ItemImageUrl, "https://www.bricklink.com/catalogList.asp?pg=2&catString=43&catType=P");

            hasFound = testItem.FindNextItem();
            // Check that we've not found any more item.
            Assert.AreEqual(hasFound, false);
        }
        [TestMethod()]
        public void ItemStepBackTest()
        {
            OrderData testItem;

            testItem = new OrderData();
            testItem.AddItem("1", 3, 0, "Plate 1x4", 0.06, 0.02, "Code1", "SKU1", "Denmark", ""); // First Item
            testItem.AddItem("5", 1, 0, "Turntable 2x2", 0.12, 0.03, "Code3", "SKU3", "Denmark", ""); // Second Item
            testItem.AddItem("2", 2, 0, "Tile 2x4", 0.06, 0.02, "Code2", "SKU2", "Denmark", ""); // Third Item
            testItem.AddItem("3", 1, 0, "Round Brick 2x2", 0.15, 0.05, "Code4", "SKU4", "Denmark", ""); // Fourth Item
            testItem.AddItem("4", 8, 1, "Brick 1x2", 0.24, 0.24, "Code7", "SKU7", "China", "https://www.bricklink.com/catalogList.asp?pg=2&catString=43&catType=P"); // Fifth Item

            bool hasFound = testItem.FindLastItem();

            //// Check that we've got the last (fifth) item correctly.
            Assert.AreEqual(testItem.TotalItemCount, 5);
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.ItemId, "4");
            Assert.AreEqual(testItem.ItemQuantity, 8);
            Assert.AreEqual(testItem.ItemParcelInstance, 1);
            Assert.AreEqual(testItem.ItemDescription, "Brick 1x2");
            Assert.AreEqual(testItem.ItemValue, 0.24);
            Assert.AreEqual(testItem.ItemWeight, 0.24);
            Assert.AreEqual(testItem.ItemHsCode, "Code7");
            Assert.AreEqual(testItem.ItemSkuCode, "SKU7");
            Assert.AreEqual(testItem.ItemCountryOfOrigin, "China");
            Assert.AreEqual(testItem.ItemImageUrl, "https://www.bricklink.com/catalogList.asp?pg=2&catString=43&catType=P");

            hasFound = testItem.FindPrevItem();

            // Check that we've got the fourth item correctly.
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.ItemId, "3");
            Assert.AreEqual(testItem.ItemQuantity, 1);
            Assert.AreEqual(testItem.ItemParcelInstance, 0);
            Assert.AreEqual(testItem.ItemDescription, "Round Brick 2x2");
            Assert.AreEqual(testItem.ItemValue, 0.15);
            Assert.AreEqual(testItem.ItemWeight, 0.05);
            Assert.AreEqual(testItem.ItemHsCode, "Code4");
            Assert.AreEqual(testItem.ItemSkuCode, "SKU4");
            Assert.AreEqual(testItem.ItemCountryOfOrigin, "Denmark");
            Assert.AreEqual(testItem.ItemImageUrl, "");

            hasFound = testItem.FindPrevItem();

            // Check that we've got the third item correctly.
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.ItemId, "2");
            Assert.AreEqual(testItem.ItemQuantity, 2);
            Assert.AreEqual(testItem.ItemParcelInstance, 0);
            Assert.AreEqual(testItem.ItemDescription, "Tile 2x4");
            Assert.AreEqual(testItem.ItemValue, 0.06);
            Assert.AreEqual(testItem.ItemWeight, 0.02);
            Assert.AreEqual(testItem.ItemHsCode, "Code2");
            Assert.AreEqual(testItem.ItemSkuCode, "SKU2");
            Assert.AreEqual(testItem.ItemCountryOfOrigin, "Denmark");
            Assert.AreEqual(testItem.ItemImageUrl, "");

            hasFound = testItem.FindPrevItem();

            // Check that we've got the second item correctly.
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.ItemId, "5");
            Assert.AreEqual(testItem.ItemQuantity, 1);
            Assert.AreEqual(testItem.ItemParcelInstance, 0);
            Assert.AreEqual(testItem.ItemDescription, "Turntable 2x2");
            Assert.AreEqual(testItem.ItemValue, 0.12);
            Assert.AreEqual(testItem.ItemWeight, 0.03);
            Assert.AreEqual(testItem.ItemHsCode, "Code3");
            Assert.AreEqual(testItem.ItemSkuCode, "SKU3");
            Assert.AreEqual(testItem.ItemCountryOfOrigin, "Denmark");
            Assert.AreEqual(testItem.ItemImageUrl, "");

            hasFound = testItem.FindPrevItem();

            // Check that we've got the first item correctly.
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.TotalItemCount, 5);
            Assert.AreEqual(testItem.ItemId, "1");
            Assert.AreEqual(testItem.ItemQuantity, 3);
            Assert.AreEqual(testItem.ItemParcelInstance, 0);
            Assert.AreEqual(testItem.ItemDescription, "Plate 1x4");
            Assert.AreEqual(testItem.ItemValue, 0.06);
            Assert.AreEqual(testItem.ItemWeight, 0.02);
            Assert.AreEqual(testItem.ItemHsCode, "Code1");
            Assert.AreEqual(testItem.ItemSkuCode, "SKU1");
            Assert.AreEqual(testItem.ItemCountryOfOrigin, "Denmark");
            Assert.AreEqual(testItem.ItemImageUrl, "");

            hasFound = testItem.FindPrevItem();
            // Check that we've not found any more item.
            Assert.AreEqual(hasFound, false);
        }
        [TestMethod()]
        public void ItemGetSpecificTest()
        {
            OrderData testItem;

            testItem = new OrderData();
            testItem.AddItem("1", 3, 0, "Plate 1x4", 0.06, 0.02, "Code1", "SKU1", "Denmark", ""); // First Item
            testItem.AddItem("5", 1, 0, "Turntable 2x2", 0.12, 0.03, "Code3", "SKU3", "Denmark", ""); // Second Item
            testItem.AddItem("2", 2, 0, "Tile 2x4", 0.06, 0.02, "Code2", "SKU2", "Denmark", ""); // Third Item
            testItem.AddItem("3", 1, 0, "Round Brick 2x2", 0.15, 0.05, "Code4", "SKU4", "Denmark", ""); // Fourth Item
            testItem.AddItem("4", 8, 1, "Brick 1x2", 0.24, 0.24, "Code7", "SKU7", "China", "https://www.bricklink.com/catalogList.asp?pg=2&catString=43&catType=P"); // Fifth Item

            bool hasFound = testItem.FindSpecificItem(2);

            // Check that we've got the third parcel correctly.
            Assert.AreEqual(testItem.TotalItemCount, 5);
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.ItemId, "2");
            Assert.AreEqual(testItem.ItemQuantity, 2);
            Assert.AreEqual(testItem.ItemParcelInstance, 0);
            Assert.AreEqual(testItem.ItemDescription, "Tile 2x4");
            Assert.AreEqual(testItem.ItemValue, 0.06);
            Assert.AreEqual(testItem.ItemWeight, 0.02);
            Assert.AreEqual(testItem.ItemHsCode, "Code2");
            Assert.AreEqual(testItem.ItemSkuCode, "SKU2");
            Assert.AreEqual(testItem.ItemCountryOfOrigin, "Denmark");
            Assert.AreEqual(testItem.ItemImageUrl, "");
        }
    }
}