using CM.SendBrickCore.Interfaces.FunctionModules;
using CM.SendbrickShared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CM.SendbrickShared.Enums.ProductProperties;

namespace CM.SendBrickCore.FunctionModules.Inventory
{
    /// <summary>
    /// Stores the data of each item in the inventory
    /// </summary>
    public class InventoryItemData : IInventoryItemData
    {
        #region Variables
        // control variables
        private SystemTypes.SourceSystemType sourceSystem;

        private string inventoryId;
        private string legoNumber;
        private string legoDescription;
        private string legoType;
        private string legoCategory;
        private int colourCode;
        private string colourName;
        private int quantity;
        private Condition itemCondition;
        private decimal salePrice;
        private decimal purchasePrice;
        private decimal basePrice;
        private decimal finalPrice;
        private string location;
        private string comments;
        private int bulk;
        private double salePercent;
        private bool isRetained;
        private int reservedIt;
        private bool isStockRoom;
        private DateTime dateCreated;
        private decimal weight;
        private string url;
        private string permaLink;   // Catalog List

        private int saleRate;

        private int bindId;
        private string description;

        // class control variables
        private PriceTier tier;     //Class
        private AlternateId altId;  //Class
        private List<PriceTier> tierList;
        private List<AlternateId> altIdList;
        int currentTier = -1;
        int currentAltId = -1;
        #endregion  // Variables

        #region ControlProperties
        // control variables
        public SystemTypes.SourceSystemType SourceSystem
        {
            get { return sourceSystem; }
            set { sourceSystem = value; }
        }
        #endregion  ControlProperties

        #region InventoryProperties
        public string InventoryId
        {
            get { return inventoryId; }
            set { inventoryId = value; }
        }
        public string LegoNumber
        {
            get { return legoNumber; }
            set { legoNumber = value; }
        }
        public string LegoDescription
        {
            get { return legoDescription; }
            set { legoDescription = value; }
        }
        public string LegoType
        {
            get { return legoType; }
            set { legoType = value; }
        }
        public string LegoCategory
        {
            get { return legoCategory; }
            set { legoCategory = value; }
        }
        public int ColourCode
        {
            get { return colourCode; }
            set { colourCode = value; }
        }
        public string ColourName
        {
            get { return colourName; }
            set { colourName = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        public Condition ItemCondition
        {
            get { return itemCondition; }
            set { itemCondition = value; }
        }
        public decimal SalePrice
        {
            get { return salePrice; }
            set { salePrice = value; }
        }
        public decimal PurchasePrice
        {
            get { return purchasePrice; }
            set { purchasePrice = value; }
        }
        public decimal BasePrice
        {
            get { return basePrice; }
            set { basePrice = value; }
        }
        public decimal FinalPrice
        {
            get { return finalPrice; }
            set { finalPrice = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public string Comments
        {
            get { return comments; }
            set { comments = value; }
        }
        public int Bulk
        {
            get { return bulk; }
            set { bulk = value; }
        }
        public double SalePercent
        {
            get { return salePercent; }
            set { salePercent = value; }
        }
        public bool IsRetained
        {
            get { return isRetained; }
            set { isRetained = value; }
        }
        public int ReservedIt
        {
            get { return reservedIt; }
            set { reservedIt = value; }
        }
        public bool IsStockRoom
        {
            get { return isStockRoom; }
            set { isStockRoom = value; }
        }
        public DateTime DateCreated
        {
            get { return dateCreated; }
            set { dateCreated = value; }
        }
        public decimal Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public string Url
        {
            get { return url; }
            set { url = value; }
        }
        public string PermaLink   // Catalog List
        {
            get { return permaLink; }
            set { permaLink = value; }
        }

        public int SaleRate
        {
            get { return saleRate; }
            set { saleRate = value; }
        }

        public int BindId
        {
            get { return bindId; }
            set { bindId = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        #endregion  // InventoryProperties

        #region PriceTierProperties
        public int PriceTierQuantity
        {
            get
            {
                tier = GetCurrentTier();
                return tier.TierQuantity;
            }
            set
            {
                tier = GetCurrentTier();
                tier.TierQuantity = value;
            }
        }
        public decimal PriceTierPrice
        {
            get
            {
                tier = GetCurrentTier();
                return tier.TierPrice;
            }
            set
            {
                tier = GetCurrentTier();
                tier.TierPrice = value;
            }
        }
        #endregion // PriceTierProperties
        #region AlternateIdProperties
        public SystemTypes.SourceSystemType AltIdSourceSystem
        {
            get
            {
                altId = GetCurrentAlternateId();
                return altId.SourceSystem;
            }
            set
            {
                altId = GetCurrentAlternateId();
                altId.SourceSystem = value;
            }
        }
        public string AlternateIdName
        {
            get
            {
                altId = GetCurrentAlternateId();
                return altId.IdName;
            }
            set
            {
                altId = GetCurrentAlternateId();
                altId.IdName = value;
            }
        }
        public string AlternateIdValue
        {
            get
            {
                altId = GetCurrentAlternateId();
                return altId.IdValue;
            }
            set
            {
                altId = GetCurrentAlternateId();
                altId.IdValue = value;
            }
        }
        #endregion // AlternateIdProperties

        #region Constructors
        public InventoryItemData()
        {

        }
        public InventoryItemData(IInventoryItemData inpSourceData) : this()
        {

            if (inpSourceData == null)
            {
                throw new NullReferenceException("No source object provided.");
            }
            else
            {
                sourceSystem = inpSourceData.SourceSystem;
                inventoryId = inpSourceData.InventoryId;
                legoNumber = inpSourceData.LegoNumber;
                legoDescription = inpSourceData.LegoDescription;
                legoType = inpSourceData.LegoType;
                legoCategory = inpSourceData.LegoCategory;
                colourCode = inpSourceData.ColourCode;
                colourName = inpSourceData.ColourName;
                quantity = inpSourceData.Quantity;
                itemCondition = inpSourceData.ItemCondition;
                salePrice = inpSourceData.SalePrice;
                purchasePrice = inpSourceData.PurchasePrice;
                basePrice = inpSourceData.BasePrice;
                finalPrice = inpSourceData.FinalPrice;
                location = inpSourceData.Location;
                comments = inpSourceData.Comments;
                bulk = inpSourceData.Bulk;
                salePercent = inpSourceData.SalePercent;
                isRetained = inpSourceData.IsRetained;
                reservedIt = inpSourceData.ReservedIt;
                isStockRoom = inpSourceData.IsStockRoom;
                dateCreated = inpSourceData.DateCreated;
                weight = inpSourceData.Weight;
                url = inpSourceData.Url;
                permaLink = inpSourceData.PermaLink;
                saleRate = inpSourceData.SaleRate;
                bindId = inpSourceData.BindId;
                description = inpSourceData.Description;

                if (inpSourceData.FindFirstPriceTier())
                {
                    do
                    {
                        this.AddPriceTier(inpSourceData.PriceTierQuantity,
                            inpSourceData.PriceTierPrice);
                    } while (inpSourceData.FindNextPriceTier());
                }

                if (inpSourceData.FindFirstAlternateId())
                {
                    do
                    {
                        this.AddAlternateId(inpSourceData.AltIdSourceSystem,
                            inpSourceData.AlternateIdName,
                            inpSourceData.AlternateIdValue);
                    } while (inpSourceData.FindNextAlternateId());
                }
            }
        }
        #endregion // Constructors

        #region PriceTierMethods
        private PriceTier GetCurrentTier()
        {
            if (currentTier > -1 && currentTier < tierList.Count)
            {
                tier = tierList[currentTier];
                if (tier == null)
                {
                    throw new NullReferenceException("Selected price tier is invalid");
                }
                else
                {
                    return tier;
                }
            }
            else
            {
                throw new IndexOutOfRangeException("No price tier selected");
            }
        }
        public void AddPriceTier()
        {
            this.tierList.Add(new PriceTier());
            this.currentTier = this.tierList.Count - 1;
        }
        public void AddPriceTier(int inpTierQuantity)
        {
            this.tierList.Add(new PriceTier(inpTierQuantity));
            this.currentTier = this.tierList.Count - 1;
        }
        public void AddPriceTier(int inpTierQuantity,
                decimal inpTierPrice)
        {
            this.tierList.Add(new PriceTier(inpTierQuantity,
                inpTierPrice));
            this.currentTier = this.tierList.Count - 1;
        }
        public bool FindFirstPriceTier()
        {
            return SubclassNavigation.FindFirstRecord<PriceTier>(ref currentTier, ref tierList);
        }
        public bool FindNextPriceTier()
        {
            return SubclassNavigation.FindNextRecord<PriceTier>(ref currentTier, ref tierList);
        }
        public bool FindPrevPriceTier()
        {
            return SubclassNavigation.FindPrevRecord<PriceTier>(ref currentTier, ref tierList);
        }
        public bool FindLastPriceTier()
        {
            return SubclassNavigation.FindLastRecord<PriceTier>(ref currentTier, ref tierList);
        }
        public bool FindSpecificPriceTier(int inpTierIndex)
        {
            return SubclassNavigation.FindSpecificRecord<PriceTier>(inpTierIndex, ref currentTier, ref tierList);
        }
        #endregion
        #region AlternateIdMethods
        private AlternateId GetCurrentAlternateId()
        {
            if (currentAltId > -1 && currentAltId < altIdList.Count)
            {
                altId = altIdList[currentAltId];
                if (altId == null)
                {
                    throw new NullReferenceException("Selected alternate ID is invalid");
                }
                else
                {
                    return altId;
                }
            }
            else
            {
                throw new IndexOutOfRangeException("No alternate ID selected");
            }
        }
        public void AddAlternateId()
        {
            this.altIdList.Add(new AlternateId());
            this.currentAltId = this.altIdList.Count - 1;
        }
        public void AddAlternateId(SystemTypes.SourceSystemType inpSourceSystem)
        {
            this.altIdList.Add(new AlternateId(inpSourceSystem));
            this.currentAltId = this.altIdList.Count - 1;
        }
        public void AddAlternateId(SystemTypes.SourceSystemType inpSourceSystem,
                                string inpIdName)
        {
            this.altIdList.Add(new AlternateId(inpSourceSystem,
                inpIdName));
            this.currentAltId = this.altIdList.Count - 1;
        }
        public void AddAlternateId(SystemTypes.SourceSystemType inpSourceSystem,
                                string inpIdName,
                                string inpIdValue)
        {
            this.altIdList.Add(new AlternateId(inpSourceSystem,
                inpIdName,
                inpIdValue));
            this.currentAltId = this.altIdList.Count - 1;
        }
        public bool FindFirstAlternateId()
        {
            return SubclassNavigation.FindFirstRecord<AlternateId>(ref currentTier, ref altIdList);
        }
        public bool FindNextAlternateId()
        {
            return SubclassNavigation.FindNextRecord<AlternateId>(ref currentTier, ref altIdList);
        }
        public bool FindPrevAlternateId()
        {
            return SubclassNavigation.FindPrevRecord<AlternateId>(ref currentTier, ref altIdList);
        }
        public bool FindLastAlternateId()
        {
            return SubclassNavigation.FindLastRecord<AlternateId>(ref currentTier, ref altIdList);
        }
        public bool FindSpecificAlternateId(int inpAltIdIndex)
        {
            return SubclassNavigation.FindSpecificRecord<AlternateId>(inpAltIdIndex, ref currentTier, ref altIdList);
        }
        #endregion

        public class PriceTier
        {
            #region Variables
            private int tierQuantity;
            private decimal tierPrice;
            #endregion // Variables

            #region Properties
            public int TierQuantity
            {
                get { return tierQuantity; }
                set { tierQuantity = value; }
            }
            public decimal TierPrice
            {
                get { return tierPrice; }
                set { tierPrice = value; }
            }
            #endregion // Properties

            #region Constructors
            public PriceTier()
            {
                tierQuantity = 0;
                tierPrice = 0;
            }
            public PriceTier(int inpTierQuantity)
            {
                tierQuantity = inpTierQuantity;
                tierPrice = 0;
            }
            public PriceTier(int inpTierQuantity,
                decimal inpTierPrice)
            {
                tierQuantity = inpTierQuantity;
                tierPrice = inpTierPrice;
            }
            #endregion // Constructors
        }

        public class AlternateId
        {
            #region Variables
            private SystemTypes.SourceSystemType sourceSystem;
            private string idName;
            private string idValue;
            #endregion // Variables

            #region Properties
            public SystemTypes.SourceSystemType SourceSystem
            {
                get { return sourceSystem; }
                set { sourceSystem = value; }
            }
            public string IdName
            {
                get { return idName; }
                set { idName = value; }
            }
            public string IdValue
            {
                get { return idValue; }
                set { idValue = value; }
            }
            #endregion // Properties

            #region Constructors
            public AlternateId()
            {
                sourceSystem = SystemTypes.SourceSystemType.Unset;
                idName = "";
                idValue = "";
            }
            public AlternateId(SystemTypes.SourceSystemType inpSourceSystem)
            {
                sourceSystem = inpSourceSystem;
                idName = "";
                idValue = "";
            }
            public AlternateId(SystemTypes.SourceSystemType inpSourceSystem,
                                string inpIdName)
            {
                sourceSystem = inpSourceSystem;
                idName = inpIdName;
                idValue = "";
            }
            public AlternateId(SystemTypes.SourceSystemType inpSourceSystem,
                                string inpIdName,
                                string inpIdValue)
            {
                sourceSystem = inpSourceSystem;
                idName = inpIdName;
                idValue = inpIdValue;
            }
            #endregion // Constructors
        }

        #region CopyMethods
        public object Clone()
        {
            InventoryItemData cloneOrderData = new InventoryItemData(this);

            return cloneOrderData;
        }
        #endregion
    }


    //BrickOwl Inventory
    //    {
    //        "con":"new",
    //        "full_con":"new",
    //        "qty":"2",
    //        "lot_id":"97624985",
    //        "price":"2.633",
    //        "base_price":"2.633",
    //        "final_price":"2.633",
    //        "url":"https:\/\/bricksinbloom.brickowl.com\/store\/lego-sersi-minifigure",
    //        "owl_id":"478011",
    //        "public_note":"null",
    //        "personal_note":"b 595",
    //        "sale_percent":"0",
    //        "bulk_qty":"1",
    //        "for_sale":"1",
    //        "my_cost":"null",
    //        "lot_weight":"null",
    //        "reserve_uid":"null",
    //        "boid":"1299842",
    //        "external_lot_ids":{
    //            "other":"321501076"
    //        },
    //        "type":"Minifigure",
    //        "ids":[
    //            {
    //                "id":"1299842",
    //                "type":"boid"
    //            }
    //        ],
    //        "tier_price":[
    //            "":""
    //        ]
    //},

    //BrickOwl Catalog List (Minifigures)
    //    {
    //        "boid":"1299842",
    //        "type":"Minifigure",
    //        "name":"LEGO Sersi Minifigure",
    //        "permalink":"https:\/\/www.brickowl.com\/boid\/1299842"
    //    },

    //BrickLink Inventory
    //    {
    //            "inventory_id":321501076,
    //            "item":{
    //            "no":"sh765",
    //                "name":"Sersi",
    //                "type":"MINIFIG",
    //                "category_id":768
    //            },
    //            "color_id":0,
    //            "color_name":"(Not Applicable)",
    //            "quantity":2,
    //            "new_or_used":"N",
    //            "unit_price":"2.6330",
    //            "bind_id":0,
    //            "description":"",
    //            "remarks":"b 595",
    //            "bulk":1,
    //            "is_retain":false,
    //            "is_stock_room":false,
    //            "date_created":"2022-11-13T05:00:00.000Z",
    //            "my_cost":"0.0000",
    //            "sale_rate":0,
    //            "tier_quantity1":0,
    //            "tier_price1":"0.0000",
    //            "tier_quantity2":0,
    //            "tier_price2":"0.0000",
    //            "tier_quantity3":0,
    //            "tier_price3":"0.0000",
    //            "my_weight":"0.0000"
    //        },

}
