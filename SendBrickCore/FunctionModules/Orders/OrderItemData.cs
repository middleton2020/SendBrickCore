using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CM.SendBrickCore.Interfaces.FunctionModules;

namespace SendBrickCore.FunctionModules.Orders
{
    public class OrderItemData : IOrderItemData
    {
        #region Variables
        private string itemId;
        private int itemQuantity;
        private int parcelInstance;
        private string itemDescription;
        private double itemValue;
        private double itemWeight;
        private string itemHsCode;
        private string itemSkuCode;
        private string itemCountryOfOrigin;
        private string itemImageUrl;
        #endregion

        #region Properties
        public string ItemId
        {
            get
            {
                return this.itemId;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"'{nameof(this.ItemId)}' cannot be null.", "ItemId");
                }
                else
                {
                    this.itemId = value;
                }
            }
        }
        public int ItemQuantity
        {
            get
            {
                return this.itemQuantity;
            }
            set
            {
                this.itemQuantity = value;
            }
        }
        public int ParcelInstance
        {
            get
            {
                return this.parcelInstance;
            }
            set
            {
                this.parcelInstance = value;
            }
        }
        public string ItemDescription
        {
            get
            {
                return this.itemDescription;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"'{nameof(this.ItemDescription)}' cannot be null.", "ItemDescription");
                }
                else
                {
                    this.itemDescription = value;
                }
            }
        }
        public double ItemValue
        {
            get
            {
                return this.itemValue;
            }
            set
            {
                this.itemValue = value;
            }
        }
        public double ItemWeight
        {
            get
            {
                return this.itemWeight;
            }
            set
            {
                this.itemWeight = value;
            }
        }
        public string ItemHsCode
        {
            get
            {
                return this.itemHsCode;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"'{nameof(this.ItemHsCode)}' cannot be null.", "ItemHsCode");
                }
                else
                {
                    this.itemHsCode = value;
                }
            }
        }
        public string ItemSkuCode
        {
            get
            {
                return this.itemSkuCode;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"'{nameof(this.ItemSkuCode)}' cannot be null.", "ItemSkuCode");
                }
                else
                {
                    this.itemSkuCode = value;
                }
            }
        }
        public string ItemCountryOfOrigin
        {
            get
            {
                return this.itemCountryOfOrigin;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"'{nameof(this.ItemCountryOfOrigin)}' cannot be null.", "ItemCountryOfOrigin");
                }
                else
                {
                    this.itemCountryOfOrigin = value;
                }
            }
        }
        public string ItemImageUrl
        {
            get
            {
                return this.itemImageUrl;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"'{nameof(this.ItemImageUrl)}' cannot be null.", "ItemImageUrl");
                }
                else
                {
                    this.itemImageUrl = value;
                }
            }
        }
        #endregion

        #region Constructors
        public OrderItemData()
        {
            this.itemId = "";
            this.itemQuantity = 0;
        }
        public OrderItemData(string inpItemId,
                     int inpItemQuantity) : this()
        {
            this.ItemId = inpItemId;
            this.ItemQuantity = inpItemQuantity;
        }
        public OrderItemData(string inpItemId,
                     int inpItemQuantity,
                     int inpParcelInstance) : this(inpItemId, inpItemQuantity)
        {
            this.ParcelInstance = inpParcelInstance;
        }
        public OrderItemData(string inpItemId,
                     int inpItemQuantity,
                     int inpParcelInstance,
                     string inpItemDescription,
                     double inpItemValue,
                     double inpItemWeight) : this(inpItemId, inpItemQuantity, inpParcelInstance)
        {
            this.ItemDescription = inpItemDescription;
            this.ItemValue = inpItemValue;
            this.ItemWeight = inpItemWeight;
        }
        public OrderItemData(string inpItemId,
                     int inpItemQuantity,
                     int inpParcelInstance,
                     string inpItemDescription,
                     double inpItemValue,
                     double inpItemWeight,
                     string inpItemHsCode,
                     string inpItemSkuCode) : this(inpItemId, inpItemQuantity, inpParcelInstance, inpItemDescription, inpItemValue, inpItemWeight)
        {
            this.ItemHsCode = inpItemHsCode;
            this.ItemSkuCode = inpItemSkuCode;
        }
        public OrderItemData(string inpItemId,
                     int inpItemQuantity,
                     int inpParcelInstance,
                     string inpItemDescription,
                     double inpItemValue,
                     double inpItemWeight,
                     string inpItemHsCode,
                     string inpItemSkuCode,
                     string inpItemCountryOfOrigin) : this(inpItemId, inpItemQuantity, inpParcelInstance, inpItemDescription, inpItemValue, inpItemWeight, inpItemHsCode, inpItemSkuCode)
        {
            this.ItemCountryOfOrigin = inpItemCountryOfOrigin;
        }
        public OrderItemData(string inpItemId,
                     int inpItemQuantity,
                     int inpParcelInstance,
                     string inpItemDescription,
                     double inpItemValue,
                     double inpItemWeight,
                     string inpItemHsCode,
                     string inpItemSkuCode,
                     string inpItemCountryOfOrigin,
                     string inpItemImageUrl) : this(inpItemId, inpItemQuantity, inpParcelInstance, inpItemDescription, inpItemValue, inpItemWeight, inpItemHsCode, inpItemSkuCode, inpItemCountryOfOrigin)
        {
            this.ItemImageUrl = inpItemImageUrl;
        }
        #endregion
    }
}
