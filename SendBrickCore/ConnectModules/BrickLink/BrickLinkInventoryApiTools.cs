using CM.SendBrickCore.Connectors;
using CM.SendBrickCore.Interfaces.Connectors;
using CM.SendBrickCore.Interfaces.Tools;
using CM.SendBrickCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CM.SendbrickShared.Enums.ProductProperties;
using SendBrickCore.Interfaces.FunctionModules;
using CM.SendBrickCore.Interfaces.FunctionModules;

namespace CM.SendBrickCore.ConnectModules.BrickLink
{
    /// <summary>
    /// Commands to send to BrickLink.
    /// </summary>
    public class BrickLinkInventoryApiTools : IInventoryCommands
    {
        #region Variables
        // The controller class for handling connections.
        IApiConnect connectionControl;
        #endregion

        #region Constructors
        /// <summary>
        /// Setup the connection tool.
        /// </summary>
        /// <param name="inpControlTools">System controller, where all control settings are initiated.</param>
        public BrickLinkInventoryApiTools(ISetControlTools inpControlTools)
        {
            connectionControl = new OAuth1Connect(inpControlTools);
        }
        /// <summary>
        /// Setup the connection tool.
        /// </summary>
        /// <param name="inpConnectionParams">Parameter controller, where system parameters are retreived, overriding the default.</param>
        public BrickLinkInventoryApiTools(IConnectionParameters inpConnectionParams)
        {
            connectionControl = new OAuth1Connect(inpConnectionParams);
        }
        /// <summary>
        /// Setup the connection tool.
        /// </summary>
        /// <param name="inpConfigFile">Configuration file where the system parameters are stored, over-riding the default.</param>
        public BrickLinkInventoryApiTools(IConfigurationFile inpConfigFile)
        {
            connectionControl = new OAuth1Connect(inpConfigFile);
        }
        #endregion

        #region PrivateToolMethods
        private static string AddConnectorCharacter(string inpParameters)
        {
            if (inpParameters == "")
            {
                inpParameters = "?" + inpParameters;
            }
            else
            {
                inpParameters = "&" + inpParameters;
            }

            return inpParameters;
        }
        #endregion

        #region Inventories
        /// <summary>
        /// Get the list of items in the Inventory.
        /// </summary>
        /// <returns>JSON of Inventory Item details.</returns>
        public string GetInventoryList()
        {
            return GetInventoryList("", "", "", "");
        }
        /// <summary>
        /// Get the list of items in the Inventory.
        /// </summary>
        /// <param name="inpType">The Item Type to restrict the output to.</param>
        /// <returns>JSON of Inventory Item details.</returns>
        public string GetInventoryList(string inpType)
        {
            return GetInventoryList(inpType, "", "", "");
        }
        /// <summary>
        /// Get the list of items in the Inventory.
        /// </summary>
        /// <param name="inpType">The Item Type to restrict the output to.</param>
        /// <param name="inpStatus">The Status of the Items to be output.</param>
        /// <returns>JSON of Inventory Item details.</returns>
        public string GetInventoryList(string inpType, string inpStatus)
        {
            return GetInventoryList(inpType, inpStatus, "", "");
        }
        /// <summary>
        /// Get the list of items in the Inventory.
        /// </summary>
        /// <param name="inpType">The Item Type to restrict the output to.</param>
        /// <param name="inpStatus">The Status of the Items to be output.</param>
        /// <param name="inpCategory">This is not used by BrickOwl.</param>
        /// <returns>JSON of Inventory Item details.</returns>
        public string GetInventoryList(string inpType, string inpStatus, string inpCategory)
        {
            return GetInventoryList(inpType, inpStatus, inpCategory, "");
        }
        /// <summary>
        /// Get the list of items in the Inventory.
        /// </summary>
        /// <param name="inpType">The Item Type to restrict the output to.</param>
        /// <param name="inpStatus">The Status of the Items to be output.</param>
        /// <param name="inpCategory">This is not used by BrickOwl.</param>
        /// <param name="inpColour">This is not used by BrickOwl.</param>
        /// <returns>JSON of Inventory Item details.</returns>
        public string GetInventoryList(string inpType, string inpStatus, string inpCategory, string inpColour)
        {
            string parametersToAdd = "";

            if (inpType != "")
            {
                //The type of the item to include or exclude
                //- If you don't specify this value, this method retrieves inventories with any type of item.
                //- You can pass a comma-separated string to specify multiple item types to include/ exclude.
                //- You can add a minus( - ) sign to specify a type to exclude
                parametersToAdd += AddConnectorCharacter("item_type=" + inpType);
            }

            if (inpStatus != "")
            {
                //The status of the inventory to include or exclude
                //- Available values are:
                //--"Y" : available
                //--"S" : in stockroom A
                //--"B" : in stockroom B
                //--"C" : in stockroom C
                //--"N" : unavailable
                //--"R" : reserved
                //- If you don't specify this value, this method retrieves inventories in any status.
                //- You can pass a comma-separated string to specify multiple status to include / exclude.
                //- You can add a minus( - ) sign to specify a status to exclude.
                parametersToAdd += AddConnectorCharacter("status=" + inpType);
            }

            if (inpCategory != "")
            {
                //The ID of the category to include or exclude
                //- If you don't specify this value, this method retrieves inventories with any category of item.
                //- You can pass a comma-separated string to specify multiple categories to include / exclude.
                //- You can add a minus( - ) sign to specify a category to exclude.
                //- You can only specify the main category of the item.
                parametersToAdd += AddConnectorCharacter("category_id=" + inpType);
            }

            if (inpColour != "")
            {
                //The ID of the color to include or exclude
                //- If you don't specify this value, this method retrieves inventories with any color of item.
                //- You can pass a comma-separated string to specify multiple colors to include / exclude.
                //- You can add a minus( - ) sign to specify a color to exclude.
                parametersToAdd += AddConnectorCharacter("color_id=" + inpType);
            }

            string result = connectionControl.RunReadCommandOnAPI("inventories", parametersToAdd);

            string returnJson = result;

            return returnJson;
        }

        /// <summary>
        /// Get details of the Inventory Item in BrickOwl.
        /// </summary>
        /// <param name="inpInternalId">The Internal Id to search for the item by.</param>
        /// <returns>JSON of Inventory Item details.</returns>
        public string GetInventoryDetails(string inpInternalId)
        {
            return GetInventoryDetails(inpInternalId, "");
        }
        /// <summary>
        /// Get details of the Inventory Item in BrickOwl.
        /// </summary>
        /// <param name="inpInternalId">The Internal Id to search for the item by.</param>
        /// <param name="inpExternalId">The External Id to search for the item by. Only use if Internal Id is 0</param>
        /// <returns>JSON of Inventory Item details.</returns>
        public string GetInventoryDetails(string inpInternalId, string inpExternalId)
        {
            string returnJson = "";
            string actionCommand = "";

            if (inpInternalId == "" && inpExternalId == "")
            {
                throw new ArgumentException("You must provide an inventory ID to get details for.");
            }

            if (inpExternalId != "")
            {
                inpInternalId = inpExternalId;
            }

            actionCommand = "inventories/" + inpInternalId;

            var result = connectionControl.RunReadCommandOnAPI(actionCommand);

            returnJson = result;

            return returnJson;
        }
        /// <summary>
        /// Get details of the Inventory Item in BrickOwl, from the Interal ID.
        /// </summary>
        /// <param name="inpInternalId">The Internal Id to search for the item by.</param>
        /// <returns>JSON of Inventory Item details.</returns>
        public string GetInventoryInternalDetails(string inpInternalId)
        {
            return GetInventoryDetails(inpInternalId, "");
        }
        /// <summary>
        /// Get details of the Inventory Item in BrickOwl, from the Exteranl ID.
        /// </summary>
        /// <param name="inpExternalId">The External Id to search for the item by.</param>
        /// <returns>JSON of Inventory Item details.</returns>
        public string GetInventoryExternalDetails(string inpExternalId)
        {
            return GetInventoryDetails("", inpExternalId);
        }
        #endregion

        #region InventorySet
        public string SetInventoryUpdate(string inpIdValue, IdType inpIdType,
        int? inpAbsQuantity, int? inpRelQuantity, bool inpForSale, double inpPrice,
            int? inpSalePercent, double inpMyCost, double inpLotWeight, string inpPersonalNote,
            string inpPublicNote, int inpBulkQty, double inpTierPrice, Condition inpCondition,
            string inpUpdateExternalId)
        {
            string returnJson = "";
            //    string parametersToAdd = "";

            //    //// Set the ID correctly. We can only use one of them.
            //    //switch (inpIdType)
            //    //{
            //    //    case IdType.ExternalId:
            //    //        parametersToAdd += "&external_id_1=" + inpIdValue;
            //    //        break;
            //    //    case IdType.LotId:
            //    //        parametersToAdd += "&lot_id=" + inpIdValue;
            //    //        break;
            //    //    default:
            //    //        throw new ArgumentException($"Invalid ID Type parameter provided.", nameof(SetInventoryUpdate));
            //    //        break;
            //    //}

            //    //// Optionally set other values for the item.
            //    //if (inpAbsQuantity != null)
            //    //{
            //    //    parametersToAdd += "&absolute_quantity=" + inpAbsQuantity.ToString();
            //    //}

            //    //if (inpRelQuantity != null)
            //    //{
            //    //    parametersToAdd += "&relative_quantity=" + inpRelQuantity.ToString();
            //    //}

            //    //if (inpForSale == false)
            //    //{
            //    //    parametersToAdd += "&for_sale=" + inpForSale.ToString();
            //    //}

            //    //if (inpPrice > 0)
            //    //{
            //    //    parametersToAdd += "&price=" + inpPrice.ToString();
            //    //}

            //    //if (inpSalePercent != null)
            //    //{
            //    //    parametersToAdd += "&sale_percent=" + inpSalePercent.ToString();
            //    //}

            //    //if (inpMyCost > 0)
            //    //{
            //    //    parametersToAdd += "&my_cost=" + inpMyCost.ToString();
            //    //}

            //    //if (inpLotWeight > 0)
            //    //{
            //    //    parametersToAdd += "&lot_weight=" + inpLotWeight.ToString();
            //    //}

            //    //if (inpPersonalNote != "")
            //    //{
            //    //    parametersToAdd += "&personal_note=" + inpPersonalNote;
            //    //}

            //    //if (inpPublicNote != "")
            //    //{
            //    //    parametersToAdd += "&=public_note" + inpPublicNote;
            //    //}

            //    //if (inpBulkQty > 0)
            //    //{
            //    //    parametersToAdd += "&bulk_qty=" + inpBulkQty.ToString();
            //    //}

            //    //if (inpTierPrice > 0)
            //    //{
            //    //    parametersToAdd += "&tier_price=" + inpTierPrice.ToString();
            //    //}

            //    //// User has asked for a condition update.
            //    //switch (inpCondition)
            //    //{
            //    //    case Condition.New:
            //    //        parametersToAdd += "&condition=new";
            //    //        break;
            //    //    case Condition.NewSealed:
            //    //        parametersToAdd += "&condition=news";
            //    //        break;
            //    //    case Condition.NewComplete:
            //    //        parametersToAdd += "&condition=newc";
            //    //        break;
            //    //    case Condition.NewIncomplete:
            //    //        parametersToAdd += "&condition=newi";
            //    //        break;
            //    //    case Condition.UsedComplete:
            //    //        parametersToAdd += "&condition=usedc";
            //    //        break;
            //    //    case Condition.UsedIncomplete:
            //    //        parametersToAdd += "&condition=usedi";
            //    //        break;
            //    //    case Condition.UsedLikeNew:
            //    //        parametersToAdd += "&condition=usedn";
            //    //        break;
            //    //    case Condition.UsedGood:
            //    //        parametersToAdd += "&condition=usedg";
            //    //        break;
            //    //    case Condition.UsedAcceptable:
            //    //        parametersToAdd += "&condition=useda";
            //    //        break;
            //    //    case Condition.Other:
            //    //        parametersToAdd += "&condition=other";
            //    //        break;
            //    //    default:
            //    //        // No valid parameter has been passed, so don't send it to the API.
            //    //        break;
            //    //}

            //    //if (inpUpdateExternalId != "")
            //    //{
            //    //    parametersToAdd += "&update_external_id_1=" + inpUpdateExternalId;
            //    //}

            //    //// This runs the above method, passing the output to a varible.
            //    //var result = BrickOwlConnect.ConnectToAPI(inpApiKey, "inventory/update", parametersToAdd).Result;

            //    //returnJson = result;

            return returnJson;
        }
        public string SetInventoryDelete(string inpExternalId, string inpLotId)
        {
            string returnJson = "";

            return returnJson;
        }
        public string SetInventoryAdd(string inpBoId, string inpColorId, int inpQuantity, decimal inpPrice, string inpCondition, string inpExternalId)
        {
            string returnJson = "";

            return returnJson;
        }





        public void CreateInventoryData(IInventoryItemData inpInventoryItem)
        {
            throw new NotImplementedException();
        }

        public void DeleteInventoryData(IInventoryItemData inpInventoryItem)
        {
            throw new NotImplementedException();
        }

        public void GetFullInventory(ref IInventoryManager inpInventory)
        {
            throw new NotImplementedException();
        }

        public IInventoryItemData GetInventoryDataFor(string inpItemId)
        {
            throw new NotImplementedException();
        }

        public void UpdateInventoryData(IInventoryItemData inpInventoryItem)
        {
            throw new NotImplementedException();
        }

        public void CreateOrderData(IOrderData inpOrderData)
        {
            throw new NotImplementedException();
        }

        public void DeleteOrderData(IOrderData inpOrderData)
        {
            throw new NotImplementedException();
        }

        public void GetOutstandingOrders(ref IOrderManager inpOrders)
        {
            throw new NotImplementedException();
        }

        public IOrderData GetOrderDataFor(string inpOrdereId)
        {
            throw new NotImplementedException();
        }

        public void UpdateOrderData(IOrderData inpOrderData)
        {
            throw new NotImplementedException();
        }
        #endregion



        //#region Catalog
        //public string GetCatalogLookup(string inpBoId)
        //{
        //    string returnJson = "";

        //    return returnJson;
        //}
        //public string GetCatalogSuperset()
        //{
        //    return "";
        //}
        //public string GetCatalogSubset()
        //{
        //    return "";
        //}
        //public string GetCatalogPriceGuide()
        //{
        //    return "";
        //}
        //#endregion

        //#region Colours
        //public string GetCatalogColorList()
        //{
        //    return "";
        //}
        //public string GetColourDetails()
        //{
        //    return "";
        //}
        //#endregion

        //#region Categories
        //public string GetCatagoryList()
        //{
        //    return "";
        //}
        //public string GetCatagoryDetails()
        //{
        //    return "";
        //}

        //public string GetCatalog(string inpItemType, string inpItemBrand)
        //{
        //    throw new NotImplementedException();
        //}

        //public string GetCatalogAvailability(string inpBoId, int inpQty, string inpCountry)
        //{
        //    throw new NotImplementedException();
        //}

        //public string GetCatalogConditionList()
        //{
        //    throw new NotImplementedException();
        //}

        //public string GetCatalogFieldOptionsList(string inpOpType, string inpLanguage)
        //{
        //    throw new NotImplementedException();
        //}

        //public string GetCatalogInventory(string inpBoId)
        //{
        //    throw new NotImplementedException();
        //}

        //public string SetCatalog(string inpBoId, string inpSubType, string inpSubValue, bool inpAutoApprove)
        //{
        //    throw new NotImplementedException();
        //}
        //#endregion
    }
}
