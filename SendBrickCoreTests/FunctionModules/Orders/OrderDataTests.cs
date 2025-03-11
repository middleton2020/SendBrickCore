namespace CM.SendBrickCore.FunctionModules.Orders.Tests
{
    [TestClass()]
    public class OrderDataTests
    {
        #region TransferOrderTests
        [TestMethod()]
        public void OrderDataAddBlankTest()
        {
            OrderData testItem;
            testItem = new OrderData();

            Assert.IsNotNull(testItem);
        }

        [TestMethod()]
        public void OrderDataAddTestFromData()
        {
            OrderData testItem;

            DateTime justDate = new DateTime(2022, 01, 16);


            testItem = new OrderData("bricksinbloom7308",
                                "Leigha Middleton",
                                "Bricks In  Bloom",
                                "7308",
                                "BrcikLink",
                                7308,
                                "Unit 4",
                                "Candy Works",
                                "15 Parkhouse Road",
                                "",
                                "Carlisle",
                                "Cumbria",
                                "GB",
                                "CA3 0JU",
                                "1228511030",
                                "bricksinbloom@bricklink.com",
                                "GB123 4567 89",
                                "BL15748250",
                                "Colin Middleton",
                                "",
                                "257 Ecclesall Road",
                                "",
                                "",
                                "",
                                "Sheffield",
                                "South Yorkshire",
                                "GB",
                                "S5 7HJ",
                                "7505363818",
                                "colin@test.com",
                                "",
                                "Front Porch",
                                justDate,
                                "TPLN",
                                "KG",
                                "123456789",
                                "01",
                                "P",
                                false,
                                "Level5",
                                false,
                                "EmailAndSMS",
                                false,
                                "LEGO",
                                "LEGO sets",
                                "Sale of goods",
                                10.42,
                                0.00,
                                "GBP",
                                "DDU",
                                "15748250",
                                justDate,
                                "PDF",
                                "75b59db8-3cd3-4578-888e-54be016f07cc",
                                "Process",
                                "GB15748250",
                                "EORI",
                                0.00,
                                false,
                                1234567890);

            Assert.IsNotNull(testItem);

            Assert.AreEqual(testItem.SupplierId, "bricksinbloom7308", false);
            Assert.AreEqual(testItem.SupplierReference1, "7308", false);
            Assert.AreEqual(testItem.SupplierReference2, "BrcikLink", false);
            Assert.AreEqual(testItem.Department, 7308, 0);
            Assert.AreEqual(testItem.SupplierBusinessName, "Bricks In  Bloom", false);
            Assert.AreEqual(testItem.SupplierContactName, "Leigha Middleton", false);
            Assert.AreEqual(testItem.SupplierAddressLine1, "Unit 4", false);
            Assert.AreEqual(testItem.SupplierAddressLine2, "Candy Works", false);
            Assert.AreEqual(testItem.SupplierAddressLine3, "15 Parkhouse Road", false);
            Assert.AreEqual(testItem.SupplierAddressLine4, "", false);
            Assert.AreEqual(testItem.SupplierAddressTown, "Carlisle", false);
            Assert.AreEqual(testItem.SupplierAddressCounty, "Cumbria", false);
            Assert.AreEqual(testItem.SupplierCountryCode, "GB", false);
            Assert.AreEqual(testItem.SupplierAddressPostcode, "CA3 0JU", false);
            Assert.AreEqual(testItem.SupplierPhoneNumber, "1228511030", false);
            Assert.AreEqual(testItem.SupplierEmailAddress, "bricksinbloom@bricklink.com", false);
            Assert.AreEqual(testItem.SupplierVatNumber, "GB123 4567 89", false);

            Assert.AreEqual(testItem.CustomerId, "BL15748250", false);
            Assert.AreEqual(testItem.CustomerBusinessName, "", false);
            Assert.AreEqual(testItem.CustomerContactName, "Colin Middleton", false);
            Assert.AreEqual(testItem.CustomerAddressLine1, "257 Ecclesall Road", false);
            Assert.AreEqual(testItem.CustomerAddressLine2, "", false);
            Assert.AreEqual(testItem.CustomerAddressLine3, "", false);
            Assert.AreEqual(testItem.CustomerAddressLine4, "", false);
            Assert.AreEqual(testItem.CustomerAddressTown, "Sheffield", false);
            Assert.AreEqual(testItem.CustomerAddressCounty, "South Yorkshire", false);
            Assert.AreEqual(testItem.CustomerCountryCode, "GB", false);
            Assert.AreEqual(testItem.CustomerAddressPostcode, "S5 7HJ", false);
            Assert.AreEqual(testItem.CustomerPhoneNumber, "7505363818");
            Assert.AreEqual(testItem.CustomerEmailAddress, "colin@test.com", false);
            Assert.AreEqual(testItem.CustomerVatNumber, "", false);

            Assert.AreEqual(testItem.PostingDate.ToString(), justDate.ToString(), false);
            Assert.AreEqual(testItem.PostageType, "TPLN", false);
            Assert.AreEqual(testItem.PostingWeightUOM, "KG", false);
            Assert.AreEqual(testItem.CustomsProduct, "LEGO", false);
            Assert.AreEqual(testItem.CustomsDescriptionOfGoods, "LEGO sets", false);
            Assert.AreEqual(testItem.CustomsReasonForExport, "Sale of goods", false);
            Assert.AreEqual(testItem.CustomsCurrency, "GBP", false);
            Assert.AreEqual(testItem.CustomsIncoterms, "DDU", false);
            Assert.AreEqual(testItem.CustomsLabelFormat, "PDF", false);
            Assert.AreEqual(testItem.CustomsSilentPrintProfile, "75b59db8-3cd3-4578-888e-54be016f07cc", false);
            Assert.AreEqual(testItem.CustomsShipmentAction, "Process", false);

            Assert.AreEqual(testItem.PostingLocation, "123456789", false);
            Assert.AreEqual(testItem.PostingServiceLevel, "01", false);
            Assert.AreEqual(testItem.PostingServiceFormat, "P", false);
            Assert.AreEqual(testItem.CustomerSafeplace, "Front Porch", false);
            Assert.IsFalse(testItem.PostingSaturdayGuaranteed);
            Assert.AreEqual(testItem.PostingConsequentialLoss, "Level5", false);
            Assert.IsFalse(testItem.PostingLocalCollect);
            Assert.AreEqual(testItem.PostingTrackingNotifications, "EmailAndSMS", false);
            Assert.IsFalse(testItem.PostingRecordedSignedFor);

            Assert.AreEqual(testItem.CustomsPreRegistrationNumber, "GB15748250", false);
            Assert.AreEqual(testItem.CustomsPreRegistrationType, "EORI", false);
            Assert.AreEqual(testItem.CustomsShippingCharges, 10.42, 0);
            Assert.AreEqual(testItem.CustomsOtherCharges, 0.00, 0);
            Assert.AreEqual(testItem.CustomsQuotedLandedCost, 0.00, 0);
            Assert.AreEqual(testItem.CustomsInvoiceNumber, "15748250", false);
            Assert.AreEqual(testItem.CustomsInvoiceDate.ToString(), justDate.ToString(), false);
            Assert.IsFalse(testItem.CustomsExportLicence);
            Assert.AreEqual(testItem.AddresseeIdentificationReferenceNumber, 1234567890, 0);
        }
        #endregion

        #region ParcelTests
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
        #endregion

        #region ItemTests
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
        #endregion
    }
}