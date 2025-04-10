using CM.JsonTools;
using CM.SendBrickCore.FunctionModules.Inventory;
using CM.SendbrickShared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.SendBrickCore.ConnectModules.BrickLink
{
    /// <summary>
    /// Code to unpack BrickLink Inventory data to the InventoryItemData Class.
    /// </summary>
    public class BrickLinkInventoryDataExtract
    {
        private InventoryManager inventoryList = null;
        private InventoryItemData inventoryItem = null;
        private int currentEntry = 0;

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
        public BrickLinkInventoryDataExtract()
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
        public BrickLinkInventoryDataExtract(InventoryManager inpManager) : this()
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
                //    inventoryList.GetItem(currentEntry);
            }
            else if (inpName == "item")
            {
                //    inventoryList.GetItem(currentEntry);
                //}
                ////else if (inpName == "shipping")
                ////{

                ////}
                //else if (inpName == "address")
                //{
                //    inventoryList.GetItem(currentEntry);
                //}
                //else if (inpName == "name")
                //{
                //    inventoryList.GetItem(currentEntry);
                //}
                //else if (inpName == "cost")
                //{
                //    inventoryList.GetItem(currentEntry);
                //}
                //else if (inpName == "disp_cost")
                //{
                //    inventoryList.GetItem(currentEntry);
                //}
                //else if (inpName == "external_lot_ids")
                //{

                //}
                //else if (inpName == "ids")
                //{

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
            //switch (inpName)
            //{
            //}

            return inpItem;
        }
        public object SetField(string inpName, bool inpValue, object inpItem, string inpPath)
        {
            switch (inpName)
            {
                case "is_retain":
                    inventoryItem.IsRetained = inpValue;
                    break;
                case "is_stock_room":
                    inventoryItem.IsStockRoom = inpValue;
                    break;
            }

            return inpItem;
        }
        public object SetField(string inpName, decimal inpValue, object inpItem, string inpPath)
        {
            switch (inpName)
            {
                case "unit_price":
                    inventoryItem.BasePrice = inpValue;
                    break;
                case "my_cost":
                    inventoryItem.PurchasePrice = inpValue;
                    break;
                case "tier_price1":
                    if (inventoryItem.FindFirstPriceTier() == false)
                    {
                        inventoryItem.AddPriceTier();
                    }
                    inventoryItem.PriceTierPrice = inpValue;
                    break;
                case "tier_price2":
                    if (inventoryItem.FindSpecificPriceTier(1) == false)
                    {
                        inventoryItem.AddPriceTier();
                    }
                    inventoryItem.PriceTierPrice = inpValue;
                    break;
                case "tier_price3":
                    if (inventoryItem.FindSpecificPriceTier(2) == false)
                    {
                        inventoryItem.AddPriceTier();
                    }
                    inventoryItem.PriceTierPrice = inpValue;
                    break;
                case "my_weight":
                    inventoryItem.Weight = inpValue;
                    break;
            }

            return inpItem;
        }
        public object SetField(string inpName, int inpValue, object inpItem, string inpPath)
        {
            switch (inpName)
            {
                case "inventory_id":
                    inventoryItem.InventoryId = inpValue.ToString();
                    break;
                case "category_id":
                    inventoryItem.LegoCategory = inpValue.ToString();
                    break;
                case "color_id":
                    inventoryItem.ColourCode = inpValue;
                    break;
                case "quantity":
                    inventoryItem.Quantity = inpValue;
                    break;
                case "bind_id":
                    inventoryItem.BindId = inpValue;
                    break;
                case "bulk":
                    inventoryItem.Bulk = inpValue;
                    break;
                case "sale_rate":
                    inventoryItem.SaleRate = inpValue;
                    break;
                case "tier_quantity1":
                    if (inventoryItem.FindFirstPriceTier() == false)
                    {
                        inventoryItem.AddPriceTier();
                    }
                    inventoryItem.PriceTierQuantity = inpValue;
                    break;
                case "tier_quantity2":
                    if (inventoryItem.FindSpecificPriceTier(1) == false)
                    {
                        inventoryItem.AddPriceTier();
                    }
                    inventoryItem.PriceTierQuantity = inpValue;
                    break;
                case "tier_quantity3":
                    if (inventoryItem.FindSpecificPriceTier(2) == false)
                    {
                        inventoryItem.AddPriceTier();
                    }
                    inventoryItem.PriceTierQuantity = inpValue;
                    break;
            }

            return inpItem;
        }
        public object SetField(string inpName, string inpValue, object inpItem, string inpPath)
        {
            switch (inpName)
            {
                case "no":
                    inventoryItem.LegoNumber = inpValue;
                    break;
                case "name":
                    inventoryItem.LegoDescription = inpValue;
                    break;
                case "type":
                    inventoryItem.LegoType = inpValue;
                    break;
                case "category_id":
                    inventoryItem.LegoCategory = inpValue;
                    break;
                case "color_name":
                    inventoryItem.ColourName = inpValue;
                    break;
                case "new_or_used":
                    if (inpValue == "U")
                    {
                        inventoryItem.ItemCondition = ProductProperties.Condition.UsedAcceptable;
                    }
                    else
                    {
                        inventoryItem.ItemCondition = ProductProperties.Condition.New;
                    }
                    inventoryItem.ColourName = inpValue;
                    break;
                case "description":
                    inventoryItem.Description = inpValue;
                    break;
                case "remarks":
                    inventoryItem.Location = inpValue;
                    break;
                case "date_created":
                    inventoryItem.DateCreated = Convert.ToDateTime(inpValue);
                    break;

                // In case boolean values are read as strings, handle them here too.
                case "is_retain":
                case "is_stock_room":
                    SetField(inpName, Convert.ToBoolean(inpValue), inpItem, inpPath);
                    break;

                // In case decimal values are read as strings, handle them here too.
                case "unit_price":
                case "my_cost":
                case "tier_price1":
                case "tier_price2":
                case "tier_price3":
                case "my_weight":
                    SetField(inpName, Convert.ToDecimal(inpValue), inpItem, inpPath);
                    break;

                // In case integer values are read as strings, handle them here too.
                case "inventory_id":
                case "color_id":
                case "quantity":
                case "bind_id":
                case "bulk":
                case "sale_rate":
                case "tier_quantity1":
                case "tier_quantity2":
                case "tier_quantity3":
                    SetField(inpName, Convert.ToInt32(inpValue), inpItem, inpPath);
                    break;
            }

            return inpItem;
        }
        #endregion  // InventoryUnpackingDeligates
    }
}