using CM.SendBrickCore.ConnectModules.BrickOwl;
using CM.SendBrickCore.Core;
using CM.SendBrickCore.Interfaces.Tools;
using CM.ReformatJson.Processing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.SendBrickCoreTests.ConnectModules.BrickOwl
{
    [TestClass()]
    public class BrickOwlConnectTests
    {
        IConnectionParameters connectionParams;

        /// <summary>
        /// Run this to setup the connections to your instance of BrickOwl.
        /// </summary>
        private void SetConfig()
        {
            if (connectionParams == null)
            {
                SetControlTools configControl = new SetControlTools();
                connectionParams = configControl.GetConnectionParamsController();
            }
        }

        #region CatalogTests
        #region CatalogListingTests
        /// <summary>
        /// Attempts a lookup for all items in the catalog. This fails due to the size of data returned, to check that a suitable error is returned.
        /// </summary>
        [TestMethod()]
        public void GetCatalogTest()
        {
            SetConfig();
            BrickOwlInventoryApiTools connectBrickOwl = new BrickOwlInventoryApiTools(connectionParams);

            string result = "";
            try
            {
                result = connectBrickOwl.GetCatalog("", "");
            }
            catch (ArgumentException ex)
            {
                Assert.AreEqual("You must provide an Item Type, or the results are too large to manage.", ex.Message);
            }

            // Note that this code should never be reached.
            //ResformatJson reformatJson = new ResformatJson();
            //string readableJson = (string)reformatJson.MakeReadable(result);

            //// File is output to the repos\SendBrick2Tests\bin\Debug\netcoreapp3.1 directory
            //using (StreamWriter outputFile = new StreamWriter("BrickOwl.Catalog.List.txt", false))
            //{
            //    outputFile.WriteLine(readableJson);
            //}

            Assert.Fail();
        }
        /// <summary>
        /// Lookup the Catalog details for all Parts.
        /// </summary>
        [TestMethod()]
        public void GetCatalogPartTest()
        {
            SetConfig();
            BrickOwlInventoryApiTools connectBrickOwl = new BrickOwlInventoryApiTools(connectionParams);
            string result = connectBrickOwl.GetCatalog("Part", "");

            ResformatJson reformatJson = new ResformatJson();
            string readableJson = (string)reformatJson.MakeReadable(result);

            // File is output to the repos\SendBrick2Tests\bin\Debug\netcoreapp3.1 directory
            using (StreamWriter outputFile = new StreamWriter("BrickOwl.Catalog.PartList.txt", false))
            {
                outputFile.WriteLine(readableJson);
            }

            Assert.IsNotNull(result);
        }
        /// <summary>
        /// Lookup the Catalog details for all Sets.
        /// </summary>
        [TestMethod()]
        public void GetCatalogSetTest()
        {
            SetConfig();
            BrickOwlInventoryApiTools connectBrickOwl = new BrickOwlInventoryApiTools(connectionParams);
            string result = connectBrickOwl.GetCatalog("Set", "");

            ResformatJson reformatJson = new ResformatJson();
            string readableJson = (string)reformatJson.MakeReadable(result);

            // File is output to the repos\SendBrick2Tests\bin\Debug\netcoreapp3.1 directory
            using (StreamWriter outputFile = new StreamWriter("BrickOwl.Catalog.SetList.txt", false))
            {
                outputFile.WriteLine(readableJson);
            }

            Assert.IsNotNull(result);
        }
        /// <summary>
        /// Lookup the Catalog details for all Mini Figures.
        /// </summary>
        [TestMethod()]
        public void GetCatalogMinifigureTest()
        {
            SetConfig();
            BrickOwlInventoryApiTools connectBrickOwl = new BrickOwlInventoryApiTools(connectionParams);
            string result = connectBrickOwl.GetCatalog("Minifigure", "");

            ResformatJson reformatJson = new ResformatJson();
            string readableJson = (string)reformatJson.MakeReadable(result);

            // File is output to the repos\SendBrick2Tests\bin\Debug\netcoreapp3.1 directory
            using (StreamWriter outputFile = new StreamWriter("BrickOwl.Catalog.MinifigureList.txt", false))
            {
                outputFile.WriteLine(readableJson);
            }

            Assert.IsNotNull(result);
        }
        /// <summary>
        /// Lookup the Catalog details for all Gears.
        /// </summary>
        [TestMethod()]
        public void GetCatalogGearTest()
        {
            SetConfig();
            BrickOwlInventoryApiTools connectBrickOwl = new BrickOwlInventoryApiTools(connectionParams);
            string result = connectBrickOwl.GetCatalog("Gear", "");

            ResformatJson reformatJson = new ResformatJson();
            string readableJson = (string)reformatJson.MakeReadable(result);

            // File is output to the repos\SendBrick2Tests\bin\Debug\netcoreapp3.1 directory
            using (StreamWriter outputFile = new StreamWriter("BrickOwl.Catalog.GearList.txt", false))
            {
                outputFile.WriteLine(readableJson);
            }

            Assert.IsNotNull(result);
        }
        /// <summary>
        /// Lookup the Catalog details for all Stickers.
        /// </summary>
        [TestMethod()]
        public void GetCatalogStickerTest()
        {
            SetConfig();
            BrickOwlInventoryApiTools connectBrickOwl = new BrickOwlInventoryApiTools(connectionParams);
            string result = connectBrickOwl.GetCatalog("Sticker", "");

            ResformatJson reformatJson = new ResformatJson();
            string readableJson = (string)reformatJson.MakeReadable(result);

            // File is output to the repos\SendBrick2Tests\bin\Debug\netcoreapp3.1 directory
            using (StreamWriter outputFile = new StreamWriter("BrickOwl.Catalog.StickerList.txt", false))
            {
                outputFile.WriteLine(readableJson);
            }

            Assert.IsNotNull(result);
        }
        /// <summary>
        /// Lookup the Catalog details for all Mini-Builds.
        /// </summary>
        [TestMethod()]
        public void GetCatalogMinibuildsTest()
        {
            SetConfig();
            BrickOwlInventoryApiTools connectBrickOwl = new BrickOwlInventoryApiTools(connectionParams);
            string result = connectBrickOwl.GetCatalog("Minibuild", "");

            ResformatJson reformatJson = new ResformatJson();
            string readableJson = (string)reformatJson.MakeReadable(result);

            // File is output to the repos\SendBrick2Tests\bin\Debug\netcoreapp3.1 directory
            using (StreamWriter outputFile = new StreamWriter("BrickOwl.Catalog.MinibuildList.txt", false))
            {
                outputFile.WriteLine(readableJson);
            }

            Assert.IsNotNull(result);
        }
        /// <summary>
        /// Lookup the Catalog details for all Instructions.
        /// </summary>
        [TestMethod()]
        public void GetCatalogInstructionsTest()
        {
            SetConfig();
            BrickOwlInventoryApiTools connectBrickOwl = new BrickOwlInventoryApiTools(connectionParams);
            string result = connectBrickOwl.GetCatalog("Instructions", "");

            ResformatJson reformatJson = new ResformatJson();
            string readableJson = (string)reformatJson.MakeReadable(result);

            // File is output to the repos\SendBrick2Tests\bin\Debug\netcoreapp3.1 directory
            using (StreamWriter outputFile = new StreamWriter("BrickOwl.Catalog.InstructionsList.txt", false))
            {
                outputFile.WriteLine(readableJson);
            }

            Assert.IsNotNull(result);
        }
        /// <summary>
        /// Lookup the Catalog details for all Packages.
        /// </summary>
        [TestMethod()]
        public void GetCatalogPackagingTest()
        {
            SetConfig();
            BrickOwlInventoryApiTools connectBrickOwl = new BrickOwlInventoryApiTools(connectionParams);
            string result = connectBrickOwl.GetCatalog("Packaging", "");

            ResformatJson reformatJson = new ResformatJson();
            string readableJson = (string)reformatJson.MakeReadable(result);

            // File is output to the repos\SendBrick2Tests\bin\Debug\net5.0 directory
            using (StreamWriter outputFile = new StreamWriter("BrickOwl.Catalog.PackagingList.txt", false))
            {
                outputFile.WriteLine(readableJson);
            }

            Assert.IsNotNull(result);
        }
        /// <summary>
        /// Lookup the Catalog details for a single item.
        /// </summary>
        [TestMethod()]
        public void GetCatalogLookupTest()
        {
            SetConfig();
            BrickOwlInventoryApiTools connectBrickOwl = new BrickOwlInventoryApiTools(connectionParams);
            string result = connectBrickOwl.GetCatalogLookup("869830");

            ResformatJson reformatJson = new ResformatJson();
            string readableJson = (string)reformatJson.MakeReadable(result);

            // File is output to the repos\SendBrick2Tests\bin\Debug\net5.0 directory
            using (StreamWriter outputFile = new StreamWriter("BrickOwl.Catalog.Lookup.txt", false))
            {
                outputFile.WriteLine(readableJson);
            }

            Assert.IsNotNull(result);
        }
        #endregion CatalogListingTests

        #region CatalogPropertyTests
        /// <summary>
        /// Get the lost of Availability status' in the Catalog. Convert to a reabable format.
        /// </summary>
        [TestMethod()]
        public void GetCatalogAvailabilityTest()
        {
            SetConfig();
            BrickOwlInventoryApiTools connectBrickOwl = new BrickOwlInventoryApiTools(connectionParams);
            string result = connectBrickOwl.GetCatalogAvailability("869830", "GB", 0);

            ResformatJson reformatJson = new ResformatJson();
            string readableJson = (string)reformatJson.MakeReadable(result);

            // File is output to the repos\SendBrick2Tests\bin\Debug\net5.0 directorAvailabilityy
            using (StreamWriter outputFile = new StreamWriter("BrickOwl.Catalog.Availability.txt", false))
            {
                outputFile.WriteLine(readableJson);
            }

            Assert.IsNotNull(result);
        }
        /// <summary>
        /// Get the list of part Conditions in the Catalog. Convert to a readable format.
        /// </summary>
        [TestMethod()]
        public void GetCatalogConditionListTest()
        {
            SetConfig();
            BrickOwlInventoryApiTools connectBrickOwl = new BrickOwlInventoryApiTools(connectionParams);
            string result = connectBrickOwl.GetCatalogConditionList();

            ResformatJson reformatJson = new ResformatJson();
            string readableJson = (string)reformatJson.MakeReadable(result);

            // File is output to the repos\SendBrick2Tests\bin\Debug\net5.0 directorAvailabilityy
            using (StreamWriter outputFile = new StreamWriter("BrickOwl.Catalog.Condition.txt", false))
            {
                outputFile.WriteLine(readableJson);
            }

            Assert.IsNotNull(result);
        }
        /// <summary>
        /// Get the list of Colour Names in the Catalog. Convert to a readable format.
        /// </summary>
        [TestMethod()]
        public void GetCatalogColorListTest()
        {
            SetConfig();
            BrickOwlInventoryApiTools connectBrickOwl = new BrickOwlInventoryApiTools(connectionParams);
            string result = connectBrickOwl.GetCatalogColorList();

            ResformatJson reformatJson = new ResformatJson();
            string readableJson = (string)reformatJson.MakeReadable(result);

            // File is output to the repos\SendBrick2Tests\bin\Debug\net5.0 directorAvailabilityy
            using (StreamWriter outputFile = new StreamWriter("BrickOwl.Catalog.ColorList.txt", false))
            {
                outputFile.WriteLine(readableJson);
            }

            Assert.IsNotNull(result);
        }
        #endregion CatalogPropertyTests

        #region CatalogFieldOptionTests
        /// <summary>
        /// Get the Field Options values for the Catagory. Convert to a readable format.
        /// </summary>
        [TestMethod()]
        public void GetCatalogFieldOptionsCategoryListTest()
        {
            SetConfig();
            BrickOwlInventoryApiTools connectBrickOwl = new BrickOwlInventoryApiTools(connectionParams);
            string result = connectBrickOwl.GetCatalogFieldOptionsList("category", "EN");

            ResformatJson reformatJson = new ResformatJson();
            string readableJson = (string)reformatJson.MakeReadable(result);

            // File is output to the repos\SendBrick2Tests\bin\Debug\net5.0 directorAvailabilityy
            using (StreamWriter outputFile = new StreamWriter("BrickOwl.Catalog.FieldOptions.Category.txt", false))
            {
                outputFile.WriteLine(readableJson);
            }

            Assert.IsNotNull(result);
        }
        /// <summary>
        /// Get the Field Options values for the Eye Colour. Convert to a readable format.
        /// </summary>
        [TestMethod()]
        public void GetCatalogFieldOptionsEyesListTest()
        {
            SetConfig();
            BrickOwlInventoryApiTools connectBrickOwl = new BrickOwlInventoryApiTools(connectionParams);
            string result = connectBrickOwl.GetCatalogFieldOptionsList("eyes", "EN");

            ResformatJson reformatJson = new ResformatJson();
            string readableJson = (string)reformatJson.MakeReadable(result);

            // File is output to the repos\SendBrick2Tests\bin\Debug\net5.0 directorAvailabilityy
            using (StreamWriter outputFile = new StreamWriter("BrickOwl.Catalog.FieldOptions.Eyes.txt", false))
            {
                outputFile.WriteLine(readableJson);
            }

            Assert.IsNotNull(result);
        }
        /// <summary>
        /// Get the Field Options values for the Eyebrow Colour. Convert to a readable format.
        /// </summary>
        [TestMethod()]
        public void GetCatalogFieldOptionsEyebrowsListTest()
        {
            SetConfig();
            BrickOwlInventoryApiTools connectBrickOwl = new BrickOwlInventoryApiTools(connectionParams);
            string result = connectBrickOwl.GetCatalogFieldOptionsList("brows", "EN");

            ResformatJson reformatJson = new ResformatJson();
            string readableJson = (string)reformatJson.MakeReadable(result);

            // File is output to the repos\SendBrick2Tests\bin\Debug\net5.0 directorAvailabilityy
            using (StreamWriter outputFile = new StreamWriter("BrickOwl.Catalog.FieldOptions.Eyebrows.txt", false))
            {
                outputFile.WriteLine(readableJson);
            }

            Assert.IsNotNull(result);
        }
        /// <summary>
        /// Get the Field Options values for the Facial Expressions. Convert to a readable format.
        /// </summary>
        [TestMethod()]
        public void GetCatalogFieldOptionsExperssionListTest()
        {
            SetConfig();
            BrickOwlInventoryApiTools connectBrickOwl = new BrickOwlInventoryApiTools(connectionParams);
            string result = connectBrickOwl.GetCatalogFieldOptionsList("facial eXpression", "EN");

            ResformatJson reformatJson = new ResformatJson();
            string readableJson = (string)reformatJson.MakeReadable(result);

            // File is output to the repos\SendBrick2Tests\bin\Debug\net5.0 directorAvailabilityy
            using (StreamWriter outputFile = new StreamWriter("BrickOwl.Catalog.FieldOptions.Expression.txt", false))
            {
                outputFile.WriteLine(readableJson);
            }

            Assert.IsNotNull(result);
        }
        /// <summary>
        /// Get the Field Options values for the Facil Hair Colours. Convert to a readable format.
        /// </summary>
        [TestMethod()]
        public void GetCatalogFieldOptionsFacialHairColourListTest()
        {
            SetConfig();
            BrickOwlInventoryApiTools connectBrickOwl = new BrickOwlInventoryApiTools(connectionParams);
            string result = connectBrickOwl.GetCatalogFieldOptionsList("facial_hair_colour", "EN");

            ResformatJson reformatJson = new ResformatJson();
            string readableJson = (string)reformatJson.MakeReadable(result);

            // File is output to the repos\SendBrick2Tests\bin\Debug\net5.0 directorAvailabilityy
            using (StreamWriter outputFile = new StreamWriter("BrickOwl.Catalog.FieldOptions.FacialHairColour.txt", false))
            {
                outputFile.WriteLine(readableJson);
            }

            Assert.IsNotNull(result);
        }
        /// <summary>
        /// Get the Field Options values for the Facial Hair Types. Convert to a readable format.
        /// </summary>
        [TestMethod()]
        public void GetCatalogFieldOptionsFacilaHairListTest()
        {
            SetConfig();
            BrickOwlInventoryApiTools connectBrickOwl = new BrickOwlInventoryApiTools(connectionParams);
            string result = connectBrickOwl.GetCatalogFieldOptionsList("beard", "EN");

            ResformatJson reformatJson = new ResformatJson();
            string readableJson = (string)reformatJson.MakeReadable(result);

            // File is output to the repos\SendBrick2Tests\bin\Debug\net5.0 directorAvailabilityy
            using (StreamWriter outputFile = new StreamWriter("BrickOwl.Catalog.FieldOptions.FacialHair.txt", false))
            {
                outputFile.WriteLine(readableJson);
            }

            Assert.IsNotNull(result);
        }
        /// <summary>
        /// Get the Field Options values for the Genders. Convert to a readable format.
        /// </summary>
        [TestMethod()]
        public void GetCatalogFieldOptionsGenderListTest()
        {
            SetConfig();
            BrickOwlInventoryApiTools connectBrickOwl = new BrickOwlInventoryApiTools(connectionParams);
            string result = connectBrickOwl.GetCatalogFieldOptionsList("gender", "EN");

            ResformatJson reformatJson = new ResformatJson();
            string readableJson = (string)reformatJson.MakeReadable(result);

            // File is output to the repos\SendBrick2Tests\bin\Debug\net5.0 directorAvailabilityy
            using (StreamWriter outputFile = new StreamWriter("BrickOwl.Catalog.FieldOptions.Gender.txt", false))
            {
                outputFile.WriteLine(readableJson);
            }

            Assert.IsNotNull(result);
        }
        /// <summary>
        /// Get the Field Options values for the Materials. Convert to a readable format.
        /// </summary>
        [TestMethod()]
        public void GetCatalogFieldOptionsMaterialListTest()
        {
            SetConfig();
            BrickOwlInventoryApiTools connectBrickOwl = new BrickOwlInventoryApiTools(connectionParams);
            string result = connectBrickOwl.GetCatalogFieldOptionsList("material", "EN");

            ResformatJson reformatJson = new ResformatJson();
            string readableJson = (string)reformatJson.MakeReadable(result);

            // File is output to the repos\SendBrick2Tests\bin\Debug\net5.0 directorAvailabilityy
            using (StreamWriter outputFile = new StreamWriter("BrickOwl.Catalog.FieldOptions.Material.txt", false))
            {
                outputFile.WriteLine(readableJson);
            }

            Assert.IsNotNull(result);
        }
        /// <summary>
        /// Get the Field Options values for the Packaging. Convert to a readable format.
        /// </summary>
        [TestMethod()]
        public void GetCatalogFieldOptionsPackagingListTest()
        {
            SetConfig();
            BrickOwlInventoryApiTools connectBrickOwl = new BrickOwlInventoryApiTools(connectionParams);
            string result = connectBrickOwl.GetCatalogFieldOptionsList("packaging_type", "EN");

            ResformatJson reformatJson = new ResformatJson();
            string readableJson = (string)reformatJson.MakeReadable(result);

            // File is output to the repos\SendBrick2Tests\bin\Debug\net5.0 directorAvailabilityy
            using (StreamWriter outputFile = new StreamWriter("BrickOwl.Catalog.FieldOptions.Packaging.txt", false))
            {
                outputFile.WriteLine(readableJson);
            }

            Assert.IsNotNull(result);
        }
        /// <summary>
        /// This currently returns no data (there is none in BrickOwl).
        /// </summary>
        [TestMethod()]
        public void GetCatalogFieldOptionsImageListTest()
        {
            SetConfig();
            BrickOwlInventoryApiTools connectBrickOwl = new BrickOwlInventoryApiTools(connectionParams);

            string result = result = connectBrickOwl.GetCatalogFieldOptionsList("image", "EN");

            ResformatJson reformatJson = new ResformatJson();
            string readableJson = (string)reformatJson.MakeReadable(result);

            // File is output to the repos\SendBrick2Tests\bin\Debug\net5.0 directorAvailabilityy
            using (StreamWriter outputFile = new StreamWriter("BrickOwl.Catalog.FieldOptions.Image.txt", false))
            {
                outputFile.WriteLine(readableJson);
            }

            Assert.IsNotNull(result);
        }
        [TestMethod()]
        public void GetCatalogFieldOptionsSidesListTest()
        {
            SetConfig();
            BrickOwlInventoryApiTools connectBrickOwl = new BrickOwlInventoryApiTools(connectionParams);
            string result = connectBrickOwl.GetCatalogFieldOptionsList("sides printed", "EN");

            ResformatJson reformatJson = new ResformatJson();
            string readableJson = (string)reformatJson.MakeReadable(result);

            // File is output to the repos\SendBrick2Tests\bin\Debug\net5.0 directorAvailabilityy
            using (StreamWriter outputFile = new StreamWriter("BrickOwl.Catalog.FieldOptions.Sides.txt", false))
            {
                outputFile.WriteLine(readableJson);
            }

            Assert.IsNotNull(result);
        }
        /// <summary>
        /// Get the Field Options values for the Sticker Colours. Convert to a readable format.
        /// </summary>
        [TestMethod()]
        public void GetCatalogFieldOptionsStickersListTest()
        {
            SetConfig();
            BrickOwlInventoryApiTools connectBrickOwl = new BrickOwlInventoryApiTools(connectionParams);
            string result = connectBrickOwl.GetCatalogFieldOptionsList("Stickers", "EN");

            ResformatJson reformatJson = new ResformatJson();
            string readableJson = (string)reformatJson.MakeReadable(result);

            // File is output to the repos\SendBrick2Tests\bin\Debug\net5.0 directorAvailabilityy
            using (StreamWriter outputFile = new StreamWriter("BrickOwl.Catalog.FieldOptions.Stickers.txt", false))
            {
                outputFile.WriteLine(readableJson);
            }

            Assert.IsNotNull(result);
        }
        /// <summary>
        /// Get the Field Options values for the Theme. Convert to a readable format.
        /// </summary>
        [TestMethod()]
        public void GetCatalogFieldOptionsThemeListTest()
        {
            SetConfig();
            BrickOwlInventoryApiTools connectBrickOwl = new BrickOwlInventoryApiTools(connectionParams);
            string result = connectBrickOwl.GetCatalogFieldOptionsList("theme", "EN");

            ResformatJson reformatJson = new ResformatJson();
            string readableJson = (string)reformatJson.MakeReadable(result);

            // File is output to the repos\SendBrick2Tests\bin\Debug\net5.0 directorAvailabilityy
            using (StreamWriter outputFile = new StreamWriter("BrickOwl.Catalog.FieldOptions.Theme.txt", false))
            {
                outputFile.WriteLine(readableJson);
            }

            Assert.IsNotNull(result);
        }
        /// <summary>
        /// Get the Field Options values for the Type. Convert to a readable format.
        /// </summary>
        [TestMethod()]
        public void GetCatalogFieldOptionsTypeListTest()
        {
            SetConfig();
            BrickOwlInventoryApiTools connectBrickOwl = new BrickOwlInventoryApiTools(connectionParams);
            string result = connectBrickOwl.GetCatalogFieldOptionsList("type", "EN");

            ResformatJson reformatJson = new ResformatJson();
            string readableJson = (string)reformatJson.MakeReadable(result);

            // File is output to the repos\SendBrick2Tests\bin\Debug\net5.0 directorAvailabilityy
            using (StreamWriter outputFile = new StreamWriter("BrickOwl.Catalog.FieldOptions.Type.txt", false))
            {
                outputFile.WriteLine(readableJson);
            }

            Assert.IsNotNull(result);
        }
        #endregion CatalogFieldOptionTests
        #endregion  CatalogTests

        #region InventoryTests
        /// <summary>
        /// Get the full inventry list. Check that there is date. Convert to a readable format.
        /// </summary>
        [TestMethod()]
        public void GetInventoryListTest()
        {
            SetConfig();
            BrickOwlInventoryApiTools connectBrickOwl = new BrickOwlInventoryApiTools(connectionParams);
            string result = connectBrickOwl.GetInventoryList("", "A", "", "");

            // Commented this out because it takes over 2 hours to run.

            //ResformatJson reformatJson = new ResformatJson();
            //string readableJson = (string)reformatJson.MakeReadable(result);

            //// File is output to the repos\SendBrick2Tests\bin\Debug\net5.0 directory
            //using (StreamWriter outputFile = new StreamWriter("BrickOwl.Inventory.txt", false))
            //{
            //    outputFile.WriteLine(readableJson);
            //}

            Assert.IsNotNull(result);
        }
        /// <summary>
        /// Get the inventry list for instructions only. Check that there is date. Convert to a readable format.
        /// </summary>
        [TestMethod()]
        public void GetInventoryListTypeTest()
        {
            SetConfig();
            BrickOwlInventoryApiTools connectBrickOwl = new BrickOwlInventoryApiTools(connectionParams);
            string result = connectBrickOwl.GetInventoryList("Instructions", "A", "", "");

            ResformatJson reformatJson = new ResformatJson();
            string readableJson = (string)reformatJson.MakeReadable(result);

            // File is output to the repos\SendBrick2Tests\bin\Debug\netcoreapp3.1 directory
            using (StreamWriter outputFile = new StreamWriter("BrickOwl.Inventory.Type.txt", false))
            {
                outputFile.WriteLine(readableJson);
            }

            Assert.IsNotNull(result);
        }
        /// <summary>
        /// Get the inventry list for instructions, including inactive ones.
        /// Check that there is date. Convert to a readable format.
        /// </summary>
        [TestMethod()]
        public void GetInventoryListTypeInactiveTest()
        {
            SetConfig();
            BrickOwlInventoryApiTools connectBrickOwl = new BrickOwlInventoryApiTools(connectionParams);
            string result = connectBrickOwl.GetInventoryList("Instructions", "*", "", "");

            ResformatJson reformatJson = new ResformatJson();
            string readableJson = (string)reformatJson.MakeReadable(result);

            // File is output to the repos\SendBrick2Tests\bin\Debug\netcoreapp3.1 directory
            using (StreamWriter outputFile = new StreamWriter("BrickOwl.Inventory.Type.Inactive.txt", false))
            {
                outputFile.WriteLine(readableJson);
            }

            Assert.IsNotNull(result);
        }
        /// <summary>
        /// Get the inventry list for a given external ID. Check that there is date. Convert to a readable format.
        /// </summary>
        [TestMethod()]
        public void GetInventoryListExternalId()
        {
            SetConfig();
            BrickOwlInventoryApiTools connectBrickOwl = new BrickOwlInventoryApiTools(connectionParams);
            string result = connectBrickOwl.GetInventoryDetails("", "381251603");

            ResformatJson reformatJson = new ResformatJson();
            string readableJson = (string)reformatJson.MakeReadable(result);

            // File is output to the repos\SendBrick2Tests\bin\Debug\netcoreapp3.1 directory
            using (StreamWriter outputFile = new StreamWriter("BrickOwl.Inventory.ExternalId.txt", false))
            {
                outputFile.WriteLine(readableJson);
            }

            Assert.IsNotNull(result);
        }
        /// <summary>
        /// Get the inventry list for a given Lot ID. Check that there is date. Convert to a readable format.
        /// </summary>
        [TestMethod()]
        public void GetInventoryListLotIdTest()
        {
            SetConfig();
            BrickOwlInventoryApiTools connectBrickOwl = new BrickOwlInventoryApiTools(connectionParams);
            string result = connectBrickOwl.GetInventoryDetails("82229793", "");

            ResformatJson reformatJson = new ResformatJson();
            string readableJson = (string)reformatJson.MakeReadable(result);

            // File is output to the repos\SendBrick2Tests\bin\Debug\netcoreapp3.1 directory
            using (StreamWriter outputFile = new StreamWriter("BrickOwl.Inventory.LotId.txt", false))
            {
                outputFile.WriteLine(readableJson);
            }

            Assert.IsNotNull(result);
        }
        #endregion  InventoryTests
    }
}