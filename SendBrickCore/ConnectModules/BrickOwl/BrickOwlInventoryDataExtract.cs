using CM.JsonTools;
using CM.SendBrickCore.FunctionModules.Inventory;
using CM.SendbrickShared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.SendBrickCore.ConnectModules.BrickOwl
{
    /// <summary>
    /// Code to unpack BrickOwl Inventory data to the InventoryItemData Class.
    /// </summary>
    public class BrickOwlInventoryDataExtract
    {
        private InventoryManager inventoryList = null;
        private InventoryItemData inventoryItem = null;
        private int currentEntry = 0;

        private bool extraIdMode = false;
        private string idValue = "";

        #region JsonToolsVariables
        private JsonReader jsonReader;
        private JsonReader.DeligateMakeObject makeObject;
        private JsonReader.DeligateCloseObject closeObject;
        private JsonReader.DeligateMakeArray makeArray;
        private JsonReader.DeligateCloseArray closeArray;
        private JsonReader.DeligateSetBoolean setBoolean;
        private JsonReader.DeligateSetDecimal setDecimal;
        private JsonReader.DeligateSetInteger setInteger;
        private JsonReader.DeligateSetString setString;
        #endregion

        #region Constructors
        public BrickOwlInventoryDataExtract()
        {
            // Setup the JSON handling tools.
            makeObject = MakeObject;
            closeObject = CloseObject;
            makeArray = MakeArray;
            closeArray = CloseArray;
            setBoolean = SetField;
            setDecimal = SetField;
            setInteger = SetField;
            setString = SetField;

            jsonReader = new JsonReader(makeObject,
                                        closeObject,
                                        makeArray,
                                        closeArray,
                                        setBoolean,
                                        setDecimal,
                                        setInteger,
                                        setString);

            // If we've not been passed an OrderManager, then we need to create one.
            if (inventoryList == null)
            {
                inventoryList = new InventoryManager();
            }
        }
        public BrickOwlInventoryDataExtract(InventoryManager inpManager) : this()
        {
            inventoryList = inpManager;
        }
        #endregion  // Constructors

        #region InventoryUnpackingDeligates
        public object MakeObject(string inpName, object inpItem, string inpPath)
        {
            if (inpName == "" || inpName == "Root")
            {
                if (inpPath == "data")
                {
                    inventoryItem = new InventoryItemData();
                    currentEntry = inventoryList.AddItem(inventoryItem);
                    inventoryItem.SourceSystem = SystemTypes.SourceSystemType.BrickLink;
                    inpItem = inventoryItem;
                }
                else
                {
                    // No action to take, this is just a container.
                }
            }
            else if (inpName == "meta")
            {

            }
            else if (inpName == "item")
            {
            }

            return inpItem;
        }
        public object CloseObject(string inpName, object inpItem, string inpPath)
        {
            return inpItem;
        }
        public object MakeArray(string inpName, object inpItem, string inpPath)
        {
            if (inpName == "" || inpName == "Root")
            {

            }
            else if (inpName == "data")
            {

            }

            return inpItem;
        }
        public object CloseArray(string inpName, object inpItem, string inpPath)
        {
            return inpItem;
        }
        public object SetField(string inpName, bool inpValue, object inpItem, string inpPath)
        {
            return inpItem;
        }
        public object SetField(string inpName, decimal inpValue, object inpItem, string inpPath)
        {
            switch (inpName)
            {
                case "price":
                    inventoryItem.SalePrice = inpValue;
                    break;
                case "base_price":
                    inventoryItem.BasePrice = inpValue;
                    break;
                case "final_price":
                    inventoryItem.FinalPrice = inpValue;
                    break;
                case "my_cost":
                    if (inpValue > 0)
                    {
                        inventoryItem.PurchasePrice = inpValue;
                    }
                    break;
                case "lot_weight":
                    inventoryItem.Weight = inpValue;
                    break;
            }

            return inpItem;
        }
        public object SetField(string inpName, int inpValue, object inpItem, string inpPath)
        {
            switch (inpName)
            {
                case "qty":
                    inventoryItem.Quantity = inpValue;
                    break;
                case "lot_id":
                    inventoryItem.AddAlternateId(SystemTypes.SourceSystemType.BrickOwl, "lot_id", inpValue.ToString());
                    break;
                case "sale_percent":
                    inventoryItem.SalePercent = inpValue;
                    break;
                case "bulk_qty":
                    inventoryItem.Bulk = inpValue;
                    break;
                case "reserve_uid":
                    inventoryItem.AddAlternateId(SystemTypes.SourceSystemType.BrickOwl, "reserve_uid", inpValue.ToString());
                    break;
                case "color_id":
                    inventoryItem.ColourCode = inpValue;
                    break;
            }

            return inpItem;
        }
        public object SetField(string inpName, string inpValue, object inpItem, string inpPath)
        {
            switch (inpName)
            {
                case "con":
                    if (inpValue == "new")
                    {
                        inventoryItem.ItemCondition = ProductProperties.Condition.New;
                    }
                    else
                    {
                        inventoryItem.ItemCondition = ProductProperties.Condition.UsedAcceptable;
                    }
                    break;
                case "full_con":
                    if (inventoryItem.ItemCondition == ProductProperties.Condition.NoUpdate)
                    {
                        inpItem = SetField("con", inpValue, inpItem, "");
                    }
                    break;
                case "url":
                    if (string.IsNullOrWhiteSpace(inventoryItem.Url))
                    { inventoryItem.Url = inpValue; }
                    break;
                case "owl_id":
                    inventoryItem.AddAlternateId(SystemTypes.SourceSystemType.BrickOwl, "owl_id", inpValue);
                    break;
                case "public_note":
                    inventoryItem.Description = inpValue;
                    break;
                case "personal_note":
                    inventoryItem.Comments = inpValue;
                    inventoryItem.Location = inpValue;
                    break;
                case "boid":
                    inventoryItem.InventoryId = inpValue;
                    break;
                case "other":
                    inventoryItem.AddAlternateId(SystemTypes.SourceSystemType.BrickOwl, "external_lot_ids", inpValue);
                    break;
                case "type":
                    if (inpPath == ".Type")
                    {
                        inventoryItem.LegoType = inpValue;
                    }
                    else if (extraIdMode)
                    {
                        extraIdMode = false;
                        inventoryItem.AddAlternateId(SystemTypes.SourceSystemType.BrickOwl, inpValue, idValue);
                    }
                    break;
                case "id":
                    extraIdMode = true;
                    idValue = inpValue;
                    break;
                case "name":
                    inventoryItem.LegoDescription = inpValue;
                    break;
                case "permalink":
                    if (string.IsNullOrWhiteSpace(inventoryItem.PermaLink))
                    { inventoryItem.PermaLink = inpValue; }
                    break;
                case "color_name":
                    inventoryItem.ColourName = inpValue;
                    break;

                // In case decimal values are read as strings, handle them here too.
                case "price":
                case "base_price":
                case "final_price":
                case "my_cost":
                case "lot_weight":
                    SetField(inpName, Convert.ToDecimal(inpValue), inpItem, inpPath);
                    break;

                // In case integer values are read as strings, handle them here too.
                case "qty":
                case "lot_id":
                case "sale_percent":
                case "bulk_qty":
                case "reserve_uid":
                case "color_id":
                    SetField(inpName, Convert.ToInt32(inpValue), inpItem, inpPath);
                    break;
            }

            return inpItem;
        }
        #endregion  // InventoryUnpackingDeligates
    }
}

//BrickOwl Inventory
//{
//    auto creation.
//						SourceSystem SystemTypes.SourceSystemType	
//						object	Create inventory item.
//	"con":"new",				string	ItemCondition Condition
//	"full_con":"new",			string	ItemCondition Condition
//	"qty":"2",				string	Quantity	int
//	"lot_id":"97624985",			string	
//	"price":"2.633",			string	SalePrice	decimal
//	"base_price":"2.633",			string	BasePrice	decimal
//	"final_price":"2.633",			string	FinalPrice	decimal
//	"url":"https:\/\/bricksinbloom.brickowl.com\/store\/lego-sersi-minifigure",	string	Url	string
//	"owl_id":"478011",			string	
//	"public_note":"null",			string	Description	string
//	"personal_note":"b 595",		string	Comments	string
//							Location	string
//	"sale_percent":"0",			string	SalePercent	double
//	"bulk_qty":"1",				string	Bulk		int
//	"for_sale":"1",				string	
//	"my_cost":"null",			string	PurchasePrice	decimal
//	"lot_weight":"null",			string	Weight		decimal
//	"reserve_uid":"null",			string	ReservedUid	int
//	"boid":"1299842",			string	InventoryId	string
//	"external_lot_ids":{
//        object No action

//        "other":"321501076"     string BindId  int

//    },					object	No action
//	"type":"Minifigure",			string	LegoType	string
//	"ids":[array   No action
//		{				object	No action
//			"id":"1299842",     string	InventoryId	string
//			"type":"boid"		string	

//        }
//object No action
//	], array	No action
//	"tier_price":[array   Add Tier Record
//		"":""				string	TierQuantity	int

//                            TierPrice	decimal
//	]                   array No action
//},
//BrickOwl Catalog List (Minifigures)
//{
//    "boid":"1299842",			string InventoryId string

//    "type":"Minifigure",			string LegoType    string

//    "name":"LEGO Sersi Minifigure",		string LegoDescription string

//    "permalink":"https:\/\/www.brickowl.com\/boid\/1299842"     string PermaLink   string	// Catalog List
//},

//BrickOwl Inventory
//{
//    auto creation.
//						SourceSystem SystemTypes.SourceSystemType	
//						object	Create inventory item.
//	"con":"new",				string	ItemCondition Condition
//	"full_con":"new",			string	ItemCondition Condition
//	"qty":"70",				string	Quantity	int
//	"lot_id":"111849263",			string	
//	"price":"0.321",			string	SalePrice	decimal
//	"base_price":"0.321",			string	BasePrice	decimal
//	"final_price":"0.321",			string	FinalPrice	decimal
//	"url":"https:\/\/bricksinbloom.brickowl.com\/store\/lego-brick-1-x-2-with-studs-on-one-side-11211",	string	Url	string
//	"owl_id":"288971",			string	
//	"public_note":"null",			string	Description	string
//	"personal_note":"b 377",		string	Comments	string
//							Location	string
//	"sale_percent":"0",			string	SalePercent	double
//	"bulk_qty":"1",				string	Bulk		int
//	"for_sale":"1",				string	
//	"my_cost":"null",			string	PurchasePrice	decimal
//	"lot_weight":"null",			string	Weight		decimal
//	"reserve_uid":"null",			string	ReservedUid	int
//	"boid":"929279-55",			string	InventoryId	string
//	"external_lot_ids":{
//        object No action

//        "other":"350986181"     string BindId  int

//    },					object	No action
//	"type":"Part",				string	LegoType	string
//	"ids":[array   No action
//		{				object	No action
//			"id":"11211",       string	
//			"type":"design_id"	string	

//        },				object No action
//		{				object	No action
//			"id":"929279-55",	string InventoryId	string
//			"type":"boid"       string	
//		},				object No action
//		{				object	No action
//			"id":"6380026",		string
//            "type":"item_no"    string	
//		}				object No action
//	], array	No action
//	"tier_price":[array   Add Tier Record
//		"":""				string	TierQuantity	int

//                            TierPrice	decimal
//	]                   array No action
//},
//BrickOwl Catalog Lookup
//{
//	"boid":"929279-55",			string InventoryId	string
//	"type":"Part",				string LegoType	string
//	"ids":[array   No action
//		{				object	No action
//			"id":"11211",       string	
//			"type":"design_id"	string	
//		},				object No action
//		{				object	No action
//			"id":"929279-55",	string InventoryId	string
//			"type":"boid"       string	
//		},				object No action
//		{				object	No action
//			"id":"6380026",		string
//            "type":"item_no"    string	
//		}				object No action
//	], array	No action
//	"name":"LEGO Dark Purple Brick 1 x 2 with Studs on One Side (11211)",		string LegoDescription	string
//	"url":"https:\/\/www.brickowl.com\/catalog\/lego-dark-purple-brick-1-x-2-with-studs-on-one-side-11211",	string Url	string
//	"permalink":"https:\/\/www.brickowl.com\/boid\/929279-55",	string PermaLink	string	// Catalog List
//	"cheapest_gbp":"0.04",
//	"cat_name_path":"Parts \/ Brick \/ Non-Standard",
//	"missing_data":"",
//	"delete_scheduled":0,
//	"images":[array   No action
//		{				object	No action
//			"small":"https:\/\/img.brickowl.com\/files\/image_cache\/small\/lego-dark-purple-brick-1-x-2-with-studs-on-one-side-11211-27-929279-55.jpg",
//			"medium":"https:\/\/img.brickowl.com\/files\/image_cache\/medium\/lego-dark-purple-brick-1-x-2-with-studs-on-one-side-11211-27-929279-55.jpg",
//			"large":"https:\/\/img.brickowl.com\/files\/image_cache\/large\/lego-dark-purple-brick-1-x-2-with-studs-on-one-side-11211-27-929279-55.jpg"
//		}				object No action
//	], array	No action
//	"color_name":"Dark Purple",		string ColourName	string
//	"color_id":"55",			int ColourCode	int
//	"color_hex":"5f2683"
//}

//BrickOwl Inventory
//{
//    auto creation.
//						SourceSystem SystemTypes.SourceSystemType	
//						object	Create inventory item.
//	"con":"new",				string	ItemCondition Condition
//	"full_con":"new",			string	ItemCondition Condition
//	"qty":"202",				string	Quantity	int
//	"lot_id":"115546639",			string	
//	"price":"0.050",			string	SalePrice	decimal
//	"base_price":"0.050",			string	BasePrice	decimal
//	"final_price":"0.050",			string	FinalPrice	decimal
//	"url":"https:\/\/bricksinbloom.brickowl.com\/store\/lego-brick-1-x-2-with-studs-on-one-side-11211",	string	Url	string
//	"owl_id":"81741",			string	
//	"public_note":"null",			string	Description	string
//	"personal_note":"tray 127",		string	Comments	string
//							Location	string
//	"sale_percent":"0",			string	SalePercent	double
//	"bulk_qty":"1",				string	Bulk		int
//	"for_sale":"1",				string	
//	"my_cost":"null",			string	PurchasePrice	decimal
//	"lot_weight":"null",			string	Weight		decimal
//	"reserve_uid":"null",			string	ReservedUid	int
//	"boid":"929279-89",			string	InventoryId	string
//	"external_lot_ids":{
//        object No action

//        "other":"358885969"     string BindId  int

//    },					object	No action
//	"type":"Part",				string	LegoType	string
//	"ids":[array   No action
//		{				object	No action
//			"id":"11211",       string	
//			"type":"design_id"	string	

//        },				object No action
//		{				object	No action
//			"id":"11211",		string
//            "type":"ldraw"      string	
//		},				object No action
//		{				object	No action
//			"id":"929279-89",	string InventoryId	string
//			"type":"boid"       string	
//		},				object No action
//		{				object	No action
//			"id":"6024495",		string
//            "type":"item_no"    string	
//		}				object No action
//	], array	No action
//	"tier_price":[array   Add Tier Record
//		"":""				string	TierQuantity	int

//                            TierPrice	decimal
//	]                   array No action
//},
//BrickOwl Catalog Lookup
//{
//	"boid":"929279-89",			string InventoryId	string
//	"type":"Part",				string LegoType	string
//	"ids":[array   No action
//		{				object	No action
//			"id":"11211",       string	
//			"type":"design_id"	string	
//		},				object No action
//		{				object	No action
//			"id":"11211",		string
//            "type":"design_id"  string	
//		},				object No action
//		{				object	No action
//			"id":"11211",		string
//            "type":"ldraw"      string	
//		},				object No action
//		{				object	No action
//			"id":"929279-89",	string InventoryId	string
//			"type":"boid"       string	
//		},				object No action
//		{				object	No action
//			"id":"6024495",		string
//            "type":"item_no"    string	
//		}				object No action
//	], array	No action
//	"name":"LEGO Tan Brick 1 x 2 with Studs on One Side (11211)",		string LegoDescription	string
//	"url":"https:\/\/www.brickowl.com\/catalog\/lego-tan-brick-1-x-2-with-studs-on-one-side-11211",	string Url	string
//	"permalink":"https:\/\/www.brickowl.com\/boid\/929279-89",	string PermaLink	string	// Catalog List
//	"cheapest_gbp":"0.01",
//	"cat_name_path":"Parts \/ Brick \/ Non-Standard",
//	"missing_data":"",
//	"delete_scheduled":0,
//	"images":[array   No action
//		{				object	No action
//			"small":"https:\/\/img.brickowl.com\/files\/image_cache\/small\/lego-tan-brick-1-x-2-with-studs-on-one-side-11211-27-929279-89.jpg",
//			"medium":"https:\/\/img.brickowl.com\/files\/image_cache\/medium\/lego-tan-brick-1-x-2-with-studs-on-one-side-11211-27-929279-89.jpg",
//			"large":"https:\/\/img.brickowl.com\/files\/image_cache\/large\/lego-tan-brick-1-x-2-with-studs-on-one-side-11211-27-929279-89.jpg"
//		}				object No action
//	], array	No action
//	"color_name":"Tan",			string ColourName	string
//	"color_id":"89",			int ColourCode	int
//	"color_hex":"dec69c"
//}