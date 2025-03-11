namespace CM.SendBrickCore.FunctionModules.Orders.Tests
{
    [TestClass()]
    public class OrderParcelDataTests
    {
        [TestMethod()]
        public void ParcelAddBlankTest()
        {
            OrderData testItem;

            testItem = new OrderData();
            testItem.AddParcel();

            Assert.AreNotEqual(testItem.PostingTotalPackages, 0);
        }
        [TestMethod()]
        public void ParcelAddTwiceTest()
        {
            OrderData testItem;

            testItem = new OrderData();
            int numberOfParcels = testItem.PostingTotalPackages;

            testItem.AddParcel();
            testItem.AddParcel();

            Assert.AreEqual(testItem.PostingTotalPackages, numberOfParcels + 2);
        }
        [TestMethod()]
        public void ParcelAddTestFromData()
        {
            OrderData testItem;
            testItem = new OrderData();
            testItem.AddParcel(1, "TestParcel", 3.2, 15, 8, 1);

            Assert.AreNotEqual(testItem.PostingTotalPackages, 0);
            Assert.AreEqual(testItem.ParcelInstance, 1);
            Assert.AreEqual(testItem.ParcelId, "TestParcel");
            Assert.AreEqual(testItem.ParcelWeight, 3.2);
            Assert.AreEqual(testItem.ParcelLength, 15);
            Assert.AreEqual(testItem.ParcelWidth, 8);
            Assert.AreEqual(testItem.ParcelHeight, 1);
            Assert.AreEqual(testItem.PostingTotalWeight, 3.2);
        }
        [TestMethod()]
        public void ParcelGetFirstTest()
        {
            OrderData testItem;
            testItem = new OrderData();
            testItem.AddParcel(1, "TestParcel", 3.2, 15, 8, 1); // First parcel
            testItem.AddParcel(3, "TestParcel2", 1.3, 8, 3, 1); // Second parcel
            testItem.AddParcel(6, "TestParcel3", 0.2, 5, 5, 2); // Third parcel
            testItem.AddParcel(2, "TestParcel4", 5.1, 16, 8, 3); // Fourth parcel

            bool hasFound = testItem.FindFirstParcel();

            Assert.AreEqual(testItem.PostingTotalPackages, 4);
            Assert.AreEqual(testItem.PostingTotalWeight, 9.8);
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.ParcelInstance, 1);
            Assert.AreEqual(testItem.ParcelId, "TestParcel");
            Assert.AreEqual(testItem.ParcelWeight, 3.2);
            Assert.AreEqual(testItem.ParcelLength, 15);
            Assert.AreEqual(testItem.ParcelWidth, 8);
            Assert.AreEqual(testItem.ParcelHeight, 1);
        }
        [TestMethod()]
        public void ParcelGetLastTest()
        {
            OrderData testItem;
            testItem = new OrderData();
            testItem.AddParcel(1, "TestParcel", 3.2, 15, 8, 1); // First parcel
            testItem.AddParcel(3, "TestParcel2", 1.3, 8, 3, 1); // Second parcel
            testItem.AddParcel(6, "TestParcel3", 0.2, 5, 5, 2); // Third parcel
            testItem.AddParcel(2, "TestParcel4", 5.1, 16, 8, 3); // Fourth parcel

            bool hasFound = testItem.FindLastParcel();

            Assert.AreEqual(testItem.PostingTotalPackages, 4);
            Assert.AreEqual(testItem.PostingTotalWeight, 9.8);
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.ParcelInstance, 2);
            Assert.AreEqual(testItem.ParcelId, "TestParcel4");
            Assert.AreEqual(testItem.ParcelWeight, 5.1);
            Assert.AreEqual(testItem.ParcelLength, 16);
            Assert.AreEqual(testItem.ParcelWidth, 8);
            Assert.AreEqual(testItem.ParcelHeight, 3);
        }
        [TestMethod()]
        public void ParcelStepThroughTest()
        {
            OrderData testItem;
            testItem = new OrderData();
            testItem.AddParcel(1, "TestParcel", 3.2, 15, 8, 1); // First parcel
            testItem.AddParcel(3, "TestParcel2", 1.3, 8, 3, 1); // Second parcel
            testItem.AddParcel(6, "TestParcel3", 0.2, 5, 5, 2); // Third parcel
            testItem.AddParcel(2, "TestParcel4", 5.1, 16, 8, 3); // Fourth parcel

            bool hasFound = testItem.FindFirstParcel();

            // Check that we've got the first parcel correctly.
            Assert.AreEqual(testItem.PostingTotalPackages, 4);
            Assert.AreEqual(testItem.PostingTotalWeight, 9.8);
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.ParcelInstance, 1);
            Assert.AreEqual(testItem.ParcelId, "TestParcel");
            Assert.AreEqual(testItem.ParcelWeight, 3.2);
            Assert.AreEqual(testItem.ParcelLength, 15);
            Assert.AreEqual(testItem.ParcelWidth, 8);
            Assert.AreEqual(testItem.ParcelHeight, 1);

            hasFound = testItem.FindNextParcel();

            // Check that we've got the second parcel correctly.
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.ParcelInstance, 3);
            Assert.AreEqual(testItem.ParcelId, "TestParcel2");
            Assert.AreEqual(testItem.ParcelWeight, 1.3);
            Assert.AreEqual(testItem.ParcelLength, 8);
            Assert.AreEqual(testItem.ParcelWidth, 3);
            Assert.AreEqual(testItem.ParcelHeight, 1);

            hasFound = testItem.FindNextParcel();

            // Check that we've got the third parcel correctly.
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.ParcelInstance, 6);
            Assert.AreEqual(testItem.ParcelId, "TestParcel3");
            Assert.AreEqual(testItem.ParcelWeight, 0.2);
            Assert.AreEqual(testItem.ParcelLength, 5);
            Assert.AreEqual(testItem.ParcelWidth, 5);
            Assert.AreEqual(testItem.ParcelHeight, 2);

            hasFound = testItem.FindNextParcel();

            // Check that we've got the fourth parcel correctly.
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.ParcelInstance, 2);
            Assert.AreEqual(testItem.ParcelId, "TestParcel4");
            Assert.AreEqual(testItem.ParcelWeight, 5.1);
            Assert.AreEqual(testItem.ParcelLength, 16);
            Assert.AreEqual(testItem.ParcelWidth, 8);
            Assert.AreEqual(testItem.ParcelHeight, 3);

            hasFound = testItem.FindNextParcel();
            // Check that we've not found any more parcels.
            Assert.AreEqual(hasFound, false);
        }
        [TestMethod()]
        public void ParcelStepBackTest()
        {
            OrderData testItem;
            testItem = new OrderData();
            testItem.AddParcel(1, "TestParcel", 3.2, 15, 8, 1); // First parcel
            testItem.AddParcel(3, "TestParcel2", 1.3, 8, 3, 1); // Second parcel
            testItem.AddParcel(6, "TestParcel3", 0.2, 5, 5, 2); // Third parcel
            testItem.AddParcel(2, "TestParcel4", 5.1, 16, 8, 3); // Fourth parcel

            bool hasFound = testItem.FindLastParcel();

            // Check that we've got the last (fourth) parcel correctly.
            Assert.AreEqual(testItem.PostingTotalPackages, 4);
            Assert.AreEqual(testItem.PostingTotalWeight, 9.8);
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.ParcelInstance, 2);
            Assert.AreEqual(testItem.ParcelId, "TestParcel4");
            Assert.AreEqual(testItem.ParcelWeight, 5.1);
            Assert.AreEqual(testItem.ParcelLength, 16);
            Assert.AreEqual(testItem.ParcelWidth, 8);
            Assert.AreEqual(testItem.ParcelHeight, 3);

            hasFound = testItem.FindPrevParcel();

            // Check that we've got the third parcel correctly.
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.ParcelInstance, 6);
            Assert.AreEqual(testItem.ParcelId, "TestParcel3");
            Assert.AreEqual(testItem.ParcelWeight, 0.2);
            Assert.AreEqual(testItem.ParcelLength, 5);
            Assert.AreEqual(testItem.ParcelWidth, 5);
            Assert.AreEqual(testItem.ParcelHeight, 2);

            hasFound = testItem.FindPrevParcel();

            // Check that we've got the second parcel correctly.
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.ParcelInstance, 3);
            Assert.AreEqual(testItem.ParcelId, "TestParcel2");
            Assert.AreEqual(testItem.ParcelWeight, 1.3);
            Assert.AreEqual(testItem.ParcelLength, 8);
            Assert.AreEqual(testItem.ParcelWidth, 3);
            Assert.AreEqual(testItem.ParcelHeight, 1);

            hasFound = testItem.FindPrevParcel();

            // Check that we've got the first parcel correctly.
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.ParcelInstance, 1);
            Assert.AreEqual(testItem.ParcelId, "TestParcel");
            Assert.AreEqual(testItem.ParcelWeight, 3.2);
            Assert.AreEqual(testItem.ParcelLength, 15);
            Assert.AreEqual(testItem.ParcelWidth, 8);
            Assert.AreEqual(testItem.ParcelHeight, 1);

            hasFound = testItem.FindPrevParcel();
            // Check that we've not found any more parcels.
            Assert.AreEqual(hasFound, false);
        }
        [TestMethod()]
        public void ParcelGetSpecificTest()
        {

            OrderData testItem;
            testItem = new OrderData();
            testItem.AddParcel(1, "TestParcel", 3.2, 15, 8, 1); // First parcel
            testItem.AddParcel(3, "TestParcel2", 1.3, 8, 3, 1); // Second parcel
            testItem.AddParcel(6, "TestParcel3", 0.2, 5, 5, 2); // Third parcel
            testItem.AddParcel(2, "TestParcel4", 5.1, 16, 8, 3); // Fourth parcel

            bool hasFound = testItem.FindSpecificParcel(2);

            // Check that we've got the third parcel correctly.
            Assert.AreEqual(testItem.PostingTotalPackages, 4);
            Assert.AreEqual(testItem.PostingTotalWeight, 9.8);
            Assert.AreEqual(hasFound, true);
            Assert.AreEqual(testItem.ParcelInstance, 6);
            Assert.AreEqual(testItem.ParcelId, "TestParcel3");
            Assert.AreEqual(testItem.ParcelWeight, 0.2);
            Assert.AreEqual(testItem.ParcelLength, 5);
            Assert.AreEqual(testItem.ParcelWidth, 5);
            Assert.AreEqual(testItem.ParcelHeight, 2);
        }
    }
}