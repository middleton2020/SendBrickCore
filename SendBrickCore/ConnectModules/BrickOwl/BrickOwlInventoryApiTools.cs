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

namespace CM.SendBrickCore.ConnectModules.BrickOwl
{
    /// <summary>
    /// Commands to send to BrickOwl.
    /// </summary>
    public class BrickOwlInventoryApiTools : IInventoryCommands
    {
        #region Variables
        // The controller class for handling connections.
        IApiConnect connectionControl;
        #endregion

        #region Constructors
        /// <summary>
        ///  Setup the connection tool.
        /// </summary>
        /// <param name="inpControlTools">System controller, where all control settings are initiated.</param>
        public BrickOwlInventoryApiTools(ISetControlTools inpControlTools)
        {
            connectionControl = new PublicKeyConnect(inpControlTools);
        }
        /// <summary>
        /// Setup the connection tool.
        /// </summary>
        /// <param name="inpConnectionParams">Parameter controller, where system parameters are retreived, overriding the default.</param>
        public BrickOwlInventoryApiTools(IConnectionParameters inpConnectionParams)
        {
            connectionControl = new PublicKeyConnect(inpConnectionParams);
        }
        /// <summary>
        /// Setup the connection tool.
        /// </summary>
        /// <param name="inpConfigFile">Configuration file where the system parameters are stored, over-riding the default.</param>
        public BrickOwlInventoryApiTools(IConfigurationFile inpConfigFile)
        {
            connectionControl = new PublicKeyConnect(inpConfigFile);
        }
        #endregion

        #region InventoryGet
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
                parametersToAdd += "&type=" + inpType;
            }

            switch (inpStatus)
            {
                case "A":
                    parametersToAdd += "&active_only=1";
                    break;
                case "":
                case "*":
                    parametersToAdd += "&active_only=0";
                    break;
                default:
                    // Default is to only show active records.
                    parametersToAdd += "&active_only=1";
                    break;
            }

            if (inpCategory != "")
            {
                // Do nothing as BrickOwl doesn't filter the inventory by Category.
            }

            if (inpColour != "")
            {
                // Do nothing as BrickOwl doesn't filter the inventory by colour.
            }

            // This runs the above method, passing the output to a varible.
            var result = connectionControl.RunReadCommandOnAPI("inventory/list", parametersToAdd);

            return result;
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
            string parametersToAdd = "";

            if (inpInternalId == "" && inpExternalId == "")
            {
                throw new ArgumentException("You must specify a Lot ID or an External ID to get details for.");
            }

            if (inpInternalId != "")
            {
                parametersToAdd += "&lot_id=" + inpInternalId;
            }

            if (inpExternalId != "")
            {
                parametersToAdd += "&external_id_1=" + inpExternalId;
            }

            // This runs the above method, passing the output to a varible.
            var result = connectionControl.RunReadCommandOnAPI("inventory/list", parametersToAdd);

            return result;
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
            string parametersToAdd = "";

            // Set the ID correctly. We can only use one of them.
            switch (inpIdType)
            {
                case IdType.ExternalId:
                    parametersToAdd += "&external_id_1=" + inpIdValue;
                    break;
                case IdType.LotId:
                    parametersToAdd += "&lot_id=" + inpIdValue;
                    break;
                default:
                    throw new ArgumentException($"Invalid ID Type parameter provided.", nameof(SetInventoryUpdate));
                    break;
            }

            // Optionally set other values for the item.
            if (inpAbsQuantity != null)
            {
                parametersToAdd += "&absolute_quantity=" + inpAbsQuantity.ToString();
            }

            if (inpRelQuantity != null)
            {
                parametersToAdd += "&relative_quantity=" + inpRelQuantity.ToString();
            }

            if (inpForSale == false)
            {
                parametersToAdd += "&for_sale=" + inpForSale.ToString();
            }

            if (inpPrice > 0)
            {
                parametersToAdd += "&price=" + inpPrice.ToString();
            }

            if (inpSalePercent != null)
            {
                parametersToAdd += "&sale_percent=" + inpSalePercent.ToString();
            }

            if (inpMyCost > 0)
            {
                parametersToAdd += "&my_cost=" + inpMyCost.ToString();
            }

            if (inpLotWeight > 0)
            {
                parametersToAdd += "&lot_weight=" + inpLotWeight.ToString();
            }

            if (inpPersonalNote != "")
            {
                parametersToAdd += "&personal_note=" + inpPersonalNote;
            }

            if (inpPublicNote != "")
            {
                parametersToAdd += "&=public_note" + inpPublicNote;
            }

            if (inpBulkQty > 0)
            {
                parametersToAdd += "&bulk_qty=" + inpBulkQty.ToString();
            }

            if (inpTierPrice > 0)
            {
                parametersToAdd += "&tier_price=" + inpTierPrice.ToString();
            }

            // User has asked for a condition update.
            switch (inpCondition)
            {
                case Condition.New:
                    parametersToAdd += "&condition=new";
                    break;
                case Condition.NewSealed:
                    parametersToAdd += "&condition=news";
                    break;
                case Condition.NewComplete:
                    parametersToAdd += "&condition=newc";
                    break;
                case Condition.NewIncomplete:
                    parametersToAdd += "&condition=newi";
                    break;
                case Condition.UsedComplete:
                    parametersToAdd += "&condition=usedc";
                    break;
                case Condition.UsedIncomplete:
                    parametersToAdd += "&condition=usedi";
                    break;
                case Condition.UsedLikeNew:
                    parametersToAdd += "&condition=usedn";
                    break;
                case Condition.UsedGood:
                    parametersToAdd += "&condition=usedg";
                    break;
                case Condition.UsedAcceptable:
                    parametersToAdd += "&condition=useda";
                    break;
                case Condition.Other:
                    parametersToAdd += "&condition=other";
                    break;
                default:
                    // No valid parameter has been passed, so don't send it to the API.
                    break;
            }

            if (inpUpdateExternalId != "")
            {
                parametersToAdd += "&update_external_id_1=" + inpUpdateExternalId;
            }

            // This runs the above method, passing the output to a varible.
            var result = connectionControl.RunReadCommandOnAPI("inventory/update", parametersToAdd);

            return result;
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
        #endregion

        #region CatalogGet
        /// <summary>
        /// Get details of all items in the BrickOwl Catalog.
        /// </summary>
        /// <param name="inpItemType">The Item Type to restrict the output to.</param>
        /// <returns>JSON of all the item details.</returns>
        public string GetCatalog(string inpItemType)
        {
            return GetCatalog(inpItemType, "");
        }
        /// <summary>
        /// Get details of all items in the BrickOwl Catalog.
        /// </summary>
        /// <param name="inpItemType">The Item Type to restrict the output to.</param>
        /// <param name="inpItemBrand">The Brand to restrcit the output to.</param>
        /// <returns>JSON of all the item details.</returns>
        public string GetCatalog(string inpItemType, string inpItemBrand)
        {
            string parametersToAdd = "";

            parametersToAdd += "&type=" + ValidateItemType(inpItemType);

            if (inpItemBrand != "")
            {
                parametersToAdd += "&brand=" + inpItemBrand;
            }

            // This runs the above method, passing the output to a varible.
            var result = connectionControl.RunReadCommandOnAPI("catalog/list", parametersToAdd);

            return result;
        }
        /// <summary>
        /// Get details of a single Item from the BrickOwl Catalog.
        /// </summary>
        /// <param name="inpBoId">BrickOwl item ID.</param>
        /// <returns>JSON of the Item details.</returns>
        public string GetCatalogLookup(string inpBoId)
        {
            string parametersToAdd = "";

            parametersToAdd += "&boid=" + ValidateBoId(inpBoId);

            // This runs the above method, passing the output to a varible.
            var result = connectionControl.RunReadCommandOnAPI("catalog/lookup", parametersToAdd);

            return result;
        }
        /// <summary>
        /// Get the availability of items in the BrickOwl Catalog. This assumes the the country is Great Britain.
        /// </summary>
        /// <param name="inpBoId">BrickOwl item ID.</param>
        /// <returns>JSON of the item availability.</returns>
        public string GetCatalogAvailability(string inpBoId)
        {
            return GetCatalogAvailability(inpBoId, "GB", 0);
        }
        /// <summary>
        /// Get the availability of items in the BrickOwl Catalog.
        /// </summary>
        /// <param name="inpBoId">BrickOwl item ID.</param>
        /// <param name="inpCountry">2 character code for the country that we're interested in.</param>
        /// <returns>JSON of the item availability.</returns>
        public string GetCatalogAvailability(string inpBoId, string inpCountry)
        {
            return GetCatalogAvailability(inpBoId, inpCountry, 0);
        }
        /// <summary>
        /// Get the availability of items in the BrickOwl Catalog.
        /// </summary>
        /// <param name="inpBoId">BrickOwl item ID.</param>
        /// <param name="inpCountry">2 character code for the country that we're interested in.</param>
        /// <param name="inpQty">Optional, the quantity of the item.</param>
        /// <returns>JSON of the item availability.</returns>
        public string GetCatalogAvailability(string inpBoId, string inpCountry, int inpQty)
        {
            string parametersToAdd = "";

            parametersToAdd += "&boid=" + ValidateBoId(inpBoId);
            parametersToAdd += "&country=" + ValidateCountry(inpCountry);

            if (inpQty > 0)
            {
                parametersToAdd += "&quantity=" + inpQty.ToString();
            }

            // This runs the above method, passing the output to a varible.
            var result = connectionControl.RunReadCommandOnAPI("catalog/availability", parametersToAdd);

            return result;
        }
        /// <summary>
        /// Get a list of valid Conditions for entries in the BrickOwl Catalog.
        /// </summary>
        /// <returns>JSON of condition values.</returns>
        public string GetCatalogConditionList()
        {
            string parametersToAdd = "";

            // This runs the above method, passing the output to a varible.
            var result = connectionControl.RunReadCommandOnAPI("catalog/condition_list", parametersToAdd);

            return result;
        }
        /// <summary>
        /// Get a list of Field Values for an Option type, from the BrickOwl Catalog. Defaults to English language
        /// </summary>
        /// <param name="inpOpType">The Type of the field that we're interested in.</param>
        /// <returns>JSON of type values.</returns>
        public string GetCatalogFieldOptionsList(string inpOpType)
        {
            return GetCatalogFieldOptionsList(inpOpType, "EN");
        }
        /// <summary>
        /// Get a list of Field Values for an Option type, from the BrickOwl Catalog.
        /// </summary>
        /// <param name="inpOpType">The Type of the field that we're interested in.</param>
        /// <param name="inpLanguage">The language (2 character code) that we want the properties returned in.</param>
        /// <returns>JSON of type values.</returns>
        public string GetCatalogFieldOptionsList(string inpOpType, string inpLanguage)
        {
            string parametersToAdd = "";

            parametersToAdd += "&type=" + ValidateOptionType(inpOpType);

            if (string.IsNullOrWhiteSpace(inpLanguage) == false)
            {
                parametersToAdd += "&language=" + ValidateLanguage(inpLanguage);
            }

            // This runs the above method, passing the output to a varible.
            var result = connectionControl.RunReadCommandOnAPI("catalog/field_option_list", parametersToAdd);

            return result;
        }
        /// <summary>
        /// Gets the list of colours from the BrickOwl Catalog.
        /// </summary>
        /// <returns>JSON of colour data.</returns>
        public string GetCatalogColorList()
        {
            string parametersToAdd = "";

            // This runs the above method, passing the output to a varible.
            var result = connectionControl.RunReadCommandOnAPI("catalog/color_list", parametersToAdd);

            return result;
        }
        //public string GetCatalogIdLookup(string inpBoId, string inpItemType, string inpIdType)
        //{
        //        string returnJson = "";

        //        return returnJson;
        //}
        //public string GetCatalogSearch(string inpQuery, int inpPage)
        //{
        //        string returnJson = "";

        //        return returnJson;
        //}
        //public string GetCatalogInventory(string inpBoId)
        //{
        //    string returnJson = "";

        //    return returnJson;
        //}
        //public string GetCatalogCart(string inpItemsJson, string inpCondition, string inpCounry)
        //{
        //    // inpItemsJson receives a JSON structure in the format { "items":[{ "design_id":"3034","color_id":21,"qty":"1"},{ "design_id":"3004","color_id":23,"qty":"2"}]}
        //        string returnJson = "";

        //        return returnJson;
        //}
        #endregion

        #region CatalogSet
        public string SetCatalog(string inpBoId, string inpSubType, string inpSubValue, bool inpAutoApprove)
        {
            string parametersToAdd = "";

            parametersToAdd += "&boid=" + ValidateBoId(inpBoId);

            parametersToAdd += "&type=" + ValidateFieldType(inpSubType);

            parametersToAdd += "&value=" + ValidateFieldValue(inpSubType, inpSubValue);

            if (inpAutoApprove)
            { parametersToAdd += "&auto_approve = 0"; }
            else
            { parametersToAdd += "&auto_approve = 1"; }

            // This runs the above method, passing the output to a varible.
            var result = connectionControl.RunUpdateCommandOnAPI("catalog_edit/basic_edit", parametersToAdd);

            return result;
        }
        //public string SetCatalogInventory(string inpBoId, string inpChildBoId, int inpQuantity, int inpSeqId, bool inpAutoApprove)
        //{
        //        string returnJson = "";

        //        return returnJson;
        //}
        //public string SetCatalogAddItem(string inpItemType, string inpItemName, bool inpAutoApprove)
        //{
        //        string returnJson = "";

        //        return returnJson;
        //}
        //public string SetCatalogEditFile(string inpBoId, string inpSubType, object inpData, string inpContentType, bool inpAutoApprove)
        //{
        //        string returnJson = "";

        //        return returnJson;
        //}
        //public string SetCatalogAddTaxonomy(string inpName, string inpDescription, string inpParentTaxonId, string inpTaxonomyType, bool inpAutoApprove)
        //{ 
        //        string returnJson = "";

        //        return returnJson;
        //}
        #endregion

        #region AffiliateStores
        //public string GetAffiliateStores(string inpStoreId, string inpItemType)
        //{
        //        string returnJson = "";

        //        return returnJson;
        //}
        //public string GetAffliliateLots(string inpItemType, string inpLotId, string inpIdType)
        //{
        //        string returnJson = "";

        //        return returnJson;
        //}
        #endregion

        #region Collections
        //public string GetCollectionLots()
        //{
        //        string returnJson = "";

        //        return returnJson;
        //}
        //public string SetCollectionLots(string inpLotId, int inpQuantity, decimal inpPrice, string inpNote, string inpCondition)
        //{
        //        string returnJson = "";

        //        return returnJson;
        //}
        //public string SetCollectionDeleteLot(string inpLotId)
        //{
        //        string returnJson = "";

        //        return returnJson;
        //}
        //public string SetCollectionAddLot(string inpBoId, string inpColorId)
        //{
        //        string returnJson = "";

        //        return returnJson;
        //}
        #endregion

        #region Validators
        /// <summary>
        /// Check that the BO Id is in the right format
        /// </summary>
        /// <param name="inpBoId">Value to check</param>
        /// <returns>Validated BO Id.</returns>
        private string ValidateBoId(string inpBoId)
        {
            string confBoId = inpBoId;

            if (string.IsNullOrWhiteSpace(inpBoId))
            {
                throw new ArgumentNullException($"You must provide an ID for us to find.");
            }

            return confBoId;
        }
        /// <summary>
        /// Check that the Country code is in the right format.
        /// </summary>
        /// <param name="inpCountry">Value to check</param>
        /// <returns>Validated country code.</returns>
        private string ValidateCountry(string inpCountry)
        {
            string confCountry = inpCountry;

            if (inpCountry.Length != 2)
            {
                throw new ArgumentOutOfRangeException($"Country code must be 2 chracters long.");
            }

            return confCountry;
        }
        /// <summary>
        /// Suck that the Sub Type is in the right format.
        /// </summary>
        /// <param name="inpSubType">Value to check</param>
        /// <returns>Validated sub type.</returns>
        private string ValidateFieldType(string inpSubType)
        {
            string confSubmissionType = inpSubType;

            if (string.IsNullOrWhiteSpace(inpSubType))
            {
                throw new ArgumentNullException($"You must provide a valid type for us to update.");
            }

            switch (inpSubType.ToLower())
            {
                case "base_name":
                case "base name":
                case "name":
                    confSubmissionType = "base_name";
                    break;
                case "basic_decoration_description":
                case "basic decoration description":
                case "basic decoration":
                case "basic decor":
                case "decoration description":
                case "decor description":
                case "decoration desc":
                case "decor desc":
                    confSubmissionType = "basic_decoration_description";
                    break;
                case "category_0":
                case "category 0":
                case "category":
                    confSubmissionType = "category_0";
                    break;
                case "cleaned_lego_name":
                case "cleaned lego name":
                case "cleaned name":
                case "lego name":
                    confSubmissionType = "cleaned_lego_name";
                    break;
                case "delete":
                    confSubmissionType = "delete";
                    break;
                case "delete_scheduled":
                case "delete scheduled":
                case "delete sched":
                case "del sched":
                    confSubmissionType = "delete_scheduled";
                    break;
                case "description":
                case "desc":
                    confSubmissionType = "description";
                    break;
                case "eye_color":
                case "eye_colour":
                case "eye color":
                case "eye colour":
                case "eyes":
                    confSubmissionType = "eye_color";
                    break;
                case "eyebrow_color":
                case "eyebrow_colour":
                case "eyebrow color":
                case "eyebrow colour":
                case "eyebrows":
                case "brows":
                    confSubmissionType = "eyebrow_color";
                    break;
                case "facial_expression":
                case "facial expression":
                case "experession":
                    confSubmissionType = "facial_expression";
                    break;
                case "facial_hair_color":
                case "facial_hair_colour":
                case "facial hair color":
                case "facial hair colour":
                case "beard color":
                case "beard colour":
                case "moustache color":
                case "moustache colour":
                    confSubmissionType = "facial_hair_color";
                    break;
                case "facial_hair_type":
                case "facial hair type":
                case "facial hair":
                case "beard":
                case "moustache":
                    confSubmissionType = "facial_hair_type";
                    break;
                case "first_available":
                case "first available":
                case "first avail":
                case "1st available":
                case "1st avail":
                case "available":
                case "avail":
                    confSubmissionType = "first_available";
                    break;
                case "gender":
                case "sex":
                    confSubmissionType = "gender";
                    break;
                case "height":
                    confSubmissionType = "height";
                    break;
                case "our_asin":
                case "id - asin":
                case "asin":
                    confSubmissionType = "our_asin";
                    break;
                case "our_bl_item_no":
                case "id - bl id":
                case "bl id":
                case "bl":
                    confSubmissionType = "our_bl_item_no";
                    break;
                case "our_set_number":
                case "id - brickset set number":
                case "id - brickset set no":
                case "brickset set number":
                case "brickset set no":
                case "brickset set":
                case "brickset number":
                case "brickset no":
                case "brickset":
                    confSubmissionType = "our_set_number";
                    break;
                case "our_design_id":
                case "id - design id":
                case "design id":
                case "design":
                    confSubmissionType = "our_design_id";
                    break;
                case "our_ean":
                case "id - ean barcode":
                case "ean barcode":
                case "ean code":
                case "ean":
                    confSubmissionType = "our_ean";
                    break;
                case "our_isbn":
                case "id - isbn":
                case "isbn":
                    confSubmissionType = "our_isbn";
                    break;
                case "our_ldraw":
                case "id - ldraw item id":
                case "ldraw item id":
                case "ldraw item":
                case "ldraw id":
                case "id":
                    confSubmissionType = "our_ldraw";
                    break;
                case "our_cs_set_number":
                case "id - lego cs set number":
                case "id - lego cs set no":
                case "lego cs set number":
                case "lego cs set no":
                case "lego cs number":
                case "lego cs no":
                case "cs set number":
                case "cs set no":
                case "cs number":
                case "cs no":
                    confSubmissionType = "our_cs_set_number";
                    break;
                case "our_item_no":
                case "id - lego item number":
                case "id - lego item no":
                case "id - lego item code":
                case "id - lego item":
                case "lego item number":
                case "lego item no":
                case "lego item code":
                case "lego item":
                case "item number":
                case "item no":
                case "item code":
                case "official item number":
                case "official item no":
                case "official item code":
                case "official item":
                    confSubmissionType = "our_item_no";
                    break;
                case "our_obsolete_design_id":
                case "id - obsolete design id":
                case "obsolete design id":
                case "obsolete design":
                case "obsolete id":
                case "old design id":
                case "old design":
                case "old id":
                    confSubmissionType = "our_obsolete_design_id";
                    break;
                case "our_official_set_number":
                case "id - official set number":
                case "official set number":
                case "official number":
                case "official set":
                case "lego set number":
                case "lego set":
                case "lego number":
                case "lego set code":
                case "lego code":
                case "set number":
                case "set no":
                case "set code":
                    confSubmissionType = "our_official_set_number";
                    break;
                case "our_other":
                case "id - other id":
                case "other id":
                    confSubmissionType = "our_other";
                    break;
                case "our_peeron_id":
                case "id - peeron id":
                case "peeron id":
                case "peeron":
                    confSubmissionType = "our_peeron_id";
                    break;
                case "our_upc":
                case "id - upc barcode":
                case "upc barcode":
                case "upc":
                    confSubmissionType = "our_upc";
                    break;
                case "instructions_booklets":
                case "instructions booklets":
                case "instructions":
                case "booklets":
                    confSubmissionType = "instructions_booklets";
                    break;
                case "instructions_pages":
                case "instructions pages":
                case "booklet pages":
                case "pages":
                    confSubmissionType = "instructions_pages";
                    break;
                case "length":
                    confSubmissionType = "length";
                    break;
                case "material_type":
                case "material type":
                case "material":
                    confSubmissionType = "material_type";
                    break;
                case "packaging_type":
                case "packaging type":
                case "packaging":
                    confSubmissionType = "packaging_type";
                    break;
                case "remove_id_our_asin":
                case "remove id - asin":
                case "remove asin":
                    confSubmissionType = "remove_id_our_asin";
                    break;
                case "remove_id_our_bl_item_no":
                case "remove id - bl id":
                case "remove bl id":
                case "remove bl":
                    confSubmissionType = "remove_id_our_bl_item_no";
                    break;
                case "remove_id_our_set_number":
                case "remove id - brickset set number":
                case "remove id - brickset set no":
                case "remove brickset set number":
                case "remove brickset set no":
                case "remove brickset number":
                case "remove brickset no":
                case "remove brickset":
                    confSubmissionType = "remove_id_our_set_number";
                    break;
                case "remove_id_our_design_id":
                case "remove id - design id":
                case "remove design id":
                case "remove design":
                    confSubmissionType = "remove_id_our_design_id";
                    break;
                case "remove_id_our_ean":
                case "remove id - ean barcode":
                case "remove ean barcode":
                case "remove barcode":
                case "remove ean":
                    confSubmissionType = "remove_id_our_ean";
                    break;
                case "remove_id_our_isbn":
                case "remove id - isbn":
                case "remove isbn":
                    confSubmissionType = "remove_id_our_isbn";
                    break;
                case "remove_id_our_ldraw":
                case "remove id - ldraw item id":
                case "remove ldraw item id":
                case "remove ldraw item":
                case "remove ldraw id":
                case "remove ldraw":
                    confSubmissionType = "remove_id_our_ldraw";
                    break;
                case "remove_id_our_cs_set_number":
                case "remove id - lego cs set number":
                case "remove id - lego cs set no":
                case "remove lego cs set number":
                case "remove lego cs set no":
                case "remove lego cs number":
                case "remove lego cs no":
                case "remove lego cs set":
                case "remove lego set number":
                case "remove lego set no":
                case "remove lego number":
                case "remove lego no":
                case "remove lego set":
                case "remove cs set number":
                case "remove cs set no":
                case "remove cs number":
                case "remove cs no":
                    confSubmissionType = "remove_id_our_cs_set_number";
                    break;
                case "remove_id_our_item_no":
                case "remove id - lego item number":
                case "remove id - lego item no":
                case "remove lego item number":
                case "remove lego item no":
                case "remove item number":
                case "remove item no":
                    confSubmissionType = "remove_id_our_item_no";
                    break;
                case "remove_id_our_obsolete_design_id":
                case "remove id - obsolete design id":
                case "remove obsolete design id":
                case "remove obsolete design":
                case "remove obsolete id":
                case "remove obsolete":
                    confSubmissionType = "remove_id_our_obsolete_design_id";
                    break;
                case "remove_id_our_official_set_number":
                case "remove id - official set number":
                case "remove id - official set no":
                case "remove official set number":
                case "remove official set no":
                case "remove set number":
                case "remove set no":
                case "remove set":
                    confSubmissionType = "remove_id_our_official_set_number";
                    break;
                case "remove_id_our_other":
                case "remove id - other id":
                case "remove other id":
                case "remove other":
                    confSubmissionType = "remove_id_our_other";
                    break;
                case "remove_id_our_peeron_id":
                case "remove id - peeron id":
                case "remove peeron id":
                case "remove peeron":
                    confSubmissionType = "remove_id_our_peeron_id";
                    break;
                case "remove_id_our_upc":
                case "remove id - upc barcode":
                case "remove upc barcode":
                case "remove upc code":
                case "remove upc":
                    confSubmissionType = "remove_id_our_upc";
                    break;
                case "remove_image":
                case "remove image":
                case "image":
                    confSubmissionType = "remove_image";
                    break;
                case "ship_height":
                case "ship height":
                    confSubmissionType = "ship_height";
                    break;
                case "ship_length":
                case "ship length":
                    confSubmissionType = "ship_length";
                    break;
                case "ship_width":
                case "ship width":
                    confSubmissionType = "ship_width";
                    break;
                case "sides_printed":
                case "sides printed":
                case "sides":
                    confSubmissionType = "sides_printed";
                    break;
                case "sticker_sheet_color":
                case "sticker sheet color":
                case "sticker sheet colour":
                case "sticker sheet":
                case "stickers":
                    confSubmissionType = "sticker_sheet_color";
                    break;
                case "stud_height":
                case "stud height":
                    confSubmissionType = "stud_height";
                    break;
                case "stud_length":
                case "stud length":
                    confSubmissionType = "stud_length";
                    break;
                case "stud_width":
                case "stud width":
                    confSubmissionType = "stud_width";
                    break;
                case "theme_0":
                case "theme 0":
                case "theme":
                    confSubmissionType = "theme_0";
                    break;
                case "type":
                    confSubmissionType = "type";
                    break;
                case "variant_child_assembly_mask":
                case "variant child assembly mask":
                case "variant assembly mask":
                case "variant assembly":
                    confSubmissionType = "variant_child_assembly_mask";
                    break;
                case "variant_child_decoration_mask":
                case "variant child decoration mask":
                case "variant decoration mask":
                case "variant decoration":
                    confSubmissionType = "variant_child_decoration_mask";
                    break;
                case "variant_desc":
                case "variant desc":
                    confSubmissionType = "variant_desc";
                    break;
                case "weight":
                    confSubmissionType = "weight";
                    break;
                case "width":
                    confSubmissionType = "width";
                    break;
                default:
                    throw new ArgumentOutOfRangeException($"{inpSubType} is not a known type.");
            }
            return confSubmissionType;
        }
        /// <summary>
        /// Check that the Field Value is in the right format for the sub type.
        /// </summary>
        /// <param name="inpSubType">The type (validated with ValidateFieldType) to which the value belongs.</param>
        /// <param name="inpSubValue">Value to check</param>
        /// <returns>Validated field type.</returns>
        private string ValidateFieldValue(string inpSubType, string inpSubValue)
        {
            string confSubmissionValue = inpSubValue;

            inpSubType = ValidateFieldType(inpSubType);

            switch (inpSubType.ToLower())
            {
                // string values
                case "base_name":
                case "basic_decoration_description":
                case "cleaned_lego_name":
                case "description":
                case "our_asin":
                case "our_bl_item_no":
                case "our_set_number":
                case "our_design_id":
                case "our_ean":
                case "our_isbn":
                case "our_ldraw":
                case "our_cs_set_number":
                case "our_item_no":
                case "our_obsolete_design_id":
                case "our_official_set_number":
                case "our_other":
                case "our_peeron_id":
                case "id - peeron id":
                case "our_upc":
                case "remove_id_our_asin":
                case "remove_id_our_bl_item_no":
                case "remove_id_our_set_number":
                case "remove_id_our_design_id":
                case "remove_id_our_ean":
                case "remove_id_our_isbn":
                case "remove_id_our_ldraw":
                case "remove_id_our_cs_set_number":
                case "remove_id_our_item_no":
                case "remove_id_our_obsolete_design_id":
                case "remove_id_our_official_set_number":
                case "remove_id_our_other":
                case "remove_id_our_peeron_id":
                case "remove_id_our_upc":
                case "variant_child_assembly_mask":
                case "variant_child_decoration_mask":
                case "variant_desc":
                    confSubmissionValue = inpSubValue;
                    break;
                // option values
                case "category_0":
                case "eye_color":
                case "eyebrow_color":
                case "facial_expression":
                case "facial_hair_color":
                case "facial_hair_type":
                case "gender":
                case "material_type":
                case "packaging_type":
                case "remove_image":
                case "sides_printed":
                case "sticker_sheet_color":
                case "theme_0":
                case "type":
                    confSubmissionValue = inpSubValue;
                    break;
                // boolean values
                case "delete":
                case "delete_scheduled":
                    bool boolValue = false;
                    if (bool.TryParse(inpSubValue, out boolValue))
                    {
                        if (boolValue)
                        { confSubmissionValue = "1"; }
                        else
                        { confSubmissionValue = "0"; }
                    }
                    else
                    { confSubmissionValue = "0"; }
                    break;
                // number values
                case "first_available":
                case "height":
                case "instructions_booklets":
                case "instructions_pages":
                case "length":
                case "ship_height":
                case "ship_length":
                case "ship_width":
                case "stud_height":
                case "stud_length":
                case "stud_width":
                case "weight":
                case "width":
                    int numberValue = 0;
                    if (int.TryParse(inpSubValue, out numberValue))
                    { confSubmissionValue = numberValue.ToString(); }
                    else
                    { confSubmissionValue = "0"; }
                    break;
                default:
                    throw new ArgumentOutOfRangeException($"{inpSubType} is not a known type.");
            }
            return confSubmissionValue;
        }
        /// <summary>
        /// Check that the Item Type is in the right format
        /// </summary>
        /// <param name="inpItemType">Value to check</param>
        /// <returns>Validated field value.</returns>
        private string ValidateItemType(string inpItemType)
        {
            string confItemType = "";

            if (string.IsNullOrWhiteSpace(inpItemType))
            {
                throw new ArgumentNullException("You must provide an Item Type, or the results are too large to manage.");
            }
            switch (inpItemType.ToLower())
            {
                case "part":
                    confItemType = "Part";
                    break;
                case "set":
                    confItemType = "Set";
                    break;
                case "minifigure":
                    confItemType = "Minifigure";
                    break;
                case "gear":
                    confItemType = "Gear";
                    break;
                case "sticker":
                    confItemType = "Sticker";
                    break;
                case "minibuild":
                    confItemType = "Minibuild";
                    break;
                case "instructions":
                    confItemType = "Instructions";
                    break;
                case "packaging":
                    confItemType = "Packaging";
                    break;
                default:
                    // Default is to not filter.
                    break;
            }

            return confItemType;
        }
        /// <summary>
        /// Check that the Option Type is in the right format.
        /// </summary>
        /// <param name="inpOpType">Value to check</param>
        /// <returns>Validated option type.</returns>
        private string ValidateOptionType(string inpOpType)
        {
            string confOpType = "";

            if (string.IsNullOrWhiteSpace(inpOpType))
            {
                throw new ArgumentNullException($"The Option Type cannot be blank.");
            }

            switch (inpOpType.ToLower())
            {
                case "category_0":
                case "category 0":
                case "category":
                    confOpType = "category_0";
                    break;
                case "eye_color":
                case "eye color":
                case "eye colour":
                case "eyes":
                    confOpType = "eye_color";
                    break;
                case "eyebrow_color":
                case "eyebrow color":
                case "eyebrow colour":
                case "eyebrows":
                case "brows":
                    confOpType = "eyebrow_color";
                    break;
                case "facial_expression":
                case "facial expression":
                case "experession":
                    confOpType = "facial_expression";
                    break;
                case "facial_hair_color":
                case "facial_hair_colour":
                case "facial hair color":
                case "facial hair colour":
                case "beard color":
                case "beard colour":
                case "moustache color":
                case "moustache colour":
                    confOpType = "facial_hair_color";
                    break;
                case "facial_hair_type":
                case "facial hair type":
                case "facial hair":
                case "beard":
                case "moustache":
                    confOpType = "facial_hair_type";
                    break;
                case "gender":
                case "sex":
                    confOpType = "gender";
                    break;
                case "material_type":
                case "material type":
                case "material":
                    confOpType = "material_type";
                    break;
                case "packaging_type":
                case "packaging type":
                case "packaging":
                    confOpType = "packaging_type";
                    break;
                case "remove_image":
                case "remove image":
                case "image":
                    confOpType = "remove_image";
                    break;
                case "sides_printed":
                case "sides printed":
                case "sides":
                    confOpType = "sides_printed";
                    break;
                case "sticker_sheet_color":
                case "sticker sheet color":
                case "sticker sheet colour":
                case "sticker sheet":
                case "stickers":
                    confOpType = "sticker_sheet_color";
                    break;
                case "theme_0":
                case "theme 0":
                case "theme":
                    confOpType = "theme_0";
                    break;
                case "type":
                    confOpType = "type";
                    break;
                default:
                    throw new ArgumentOutOfRangeException($"Type of {inpOpType} is not recognised.");
            }

            return confOpType;
        }
        /// <summary>
        /// Check that the Language Code is in the right format.
        /// </summary>
        /// <param name="inpLanguage">Value to check</param>
        /// <returns>Validated language code.</returns>
        private string ValidateLanguage(string inpLanguage)
        {
            string confLanguage = "";

            switch (inpLanguage.ToLower())
            {
                case "en":
                case "english":
                case "anglais":
                case "englisch":
                case "inglés":
                case "engels":
                case "inglese":
                case "английски":
                case "angliĭski":
                case "Aangličtina":
                case "англійська":
                case "anhliysʹka":
                    confLanguage = "en";
                    break;
                case "fr":
                case "french":
                case "français":
                case "französisch":
                case "francés":
                case "frans":
                case "francese":
                case "френски":
                case "frenski":
                case "francouzština":
                case "французька":
                case "frantsuzʹka":
                    confLanguage = "fr";
                    break;
                case "de":
                case "german":
                case "allemand":
                case "deutsch":
                case "alemán":
                case "duits":
                case "tedesco":
                case "немски":
                case "nemski":
                case "němec":
                case "німецький":
                case "nimetsʹkyy":
                    confLanguage = "de";
                    break;
                case "es":
                case "spanish":
                case "espagnol":
                case "spanisch":
                case "español":
                case "spaans":
                case "spagnolo":
                case "испански":
                case "ispanski":
                case "španělština":
                case "іспанська":
                case "ispansʹka":
                    confLanguage = "es";
                    break;
                case "da":
                case "danish":
                case "danois":
                case "dänisch":
                case "danés":
                case "deens":
                case "danese":
                case "датски":
                case "dat·ski":
                case "dánština":
                case "датська":
                case "dat·sʹka":
                    confLanguage = "da";
                    break;
                case "nl":
                case "dutch":
                case "néerlandais":
                case "niederländisch":
                case "holandés":
                case "nederlands":
                case "olandese":
                case "холандски":
                case "kholandski":
                case "holandský":
                case "голландська":
                case "hollandsʹka":
                    confLanguage = "nl";
                    break;
                case "it":
                case "italian":
                case "italien":
                case "italienisch":
                case "italiano":
                case "italiaans":
                // case "italiano":     Same as the Danish version.
                case "италиански":
                case "italianski":
                case "italština":
                case "італійська":
                case "italiysʹka":
                    confLanguage = "it";
                    break;
                case "bg":
                case "bulgarian":
                case "bulgare":
                case "bulgarisch":
                case "búlgaro":
                case "bulgaars":
                case "bulgaro":
                case "български":
                case "bŭlgarski":
                case "bulharský":
                case "болгарська":
                case "bolharsʹka":
                    confLanguage = "bg";
                    break;
                case "cs":
                case "czech":
                case "tchèque":
                case "tschechisch":
                case "checo":
                case "tsjechisch":
                case "ceco":
                case "cheshki":
                case "чешки":
                case "čeština":
                case "чеська":
                case "chesʹka":
                    confLanguage = "cs";
                    break;
                case "uk":
                case "ukrainian":
                case "ukrainien":
                case "ukrainisch":
                case "ucranio":
                case "oekraïens":
                case "ucraino":
                case "ukrainski":
                case "украински":
                case "ukrajinština":
                case "українська":
                case "ukrayinsʹka":
                    confLanguage = "uk";
                    break;
                default:
                    throw new ArgumentOutOfRangeException($"The Language of {inpLanguage} is not recognised.");
            }

            return confLanguage;
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
    }
}
