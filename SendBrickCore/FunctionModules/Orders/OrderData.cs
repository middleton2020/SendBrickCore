using CM.SendBrickCore.Interfaces.FunctionModules;
using CM.SendbrickShared.Enums;

namespace CM.SendBrickCore.FunctionModules.Orders
{
    public class OrderData : IOrderData
    {
        #region Variables
        // control variables
        private SystemTypes.SourceSystemType sourceSystem;
        private SystemTypes.PostageSystemType postalSystem;
        // class control variables
        private OrderParcelData parcel;
        private OrderItemData item;

        // supplier variables
        private string supplierId;
        private string supplierContactName;
        private string supplierBusinessName;
        private string supplierReference1;
        private string supplierReference2;
        private int supplierDepartment;
        private string supplierAddressLine1;
        private string supplierAddressLine2;
        private string supplierAddressLine3;
        private string supplierAddressLine4;
        private string supplierAddressTown;
        private string supplierAddressCounty;
        private string supplierCountryCode;
        private string supplierAddressPostcode;
        private string supplierPhoneNumber;
        private string supplierEmailAddress;
        private string supplierVatNumber;

        // customer variables
        private string customerId;
        private string customerContactName;
        private string customerBusinessName;
        private string customerAddressLine1;
        private string customerAddressLine2;
        private string customerAddressLine3;
        private string customerAddressLine4;
        private string customerAddressTown;
        private string customerAddressCounty;
        private string customerCountryCode;
        private string customerAddressPostcode;
        private string customerPhoneNumber;
        private string customerEmailAddress;
        private string customerVatNumber;
        private string customerSafeplace;

        // postage variables
        private DateTime postingDate;
        private string postingType;
        private string postingWeightUOM;
        private string postingLocation;
        private string postingServiceLevel;
        private string postingServiceFormat;
        private bool postingSaturdayGuaranteed;
        private string postingConsequentialLoss;
        private bool postingLocalCollect;
        private string postingTrackingNotifications;
        private bool postingRecordedSignedFor;
        private string customsProduct;
        private string customsDescriptionOfGoods;
        private string customsReasonForExport;
        private double customsValue;
        private double customsShippingCharges;
        private double customsOtherCharges;
        private string customsCurrency;
        private string customsIncoterms;
        private string customsInvoiceNumber;
        private DateTime customsInvoiceDate;
        private string customsLabelFormat;
        private string customsSilentPrintProfile;
        private string customsShipmentAction;
        private string customsPreRegistrationNumber;
        private string customsPreRegistrationType;
        private double customsQuotedLandedCost;
        private bool customsExportLicence;
        private Int64 addresseeIdentificationReferenceNumber;

        private List<OrderParcelData> ParcelList;
        private List<OrderItemData> ItemList;
        int currentParcel = -1;
        int currentItem = -1;
        #endregion  // Variables

        #region ControlProperties
        public SystemTypes.SourceSystemType SourceSystem    // property
        {
            get
            {
                return this.sourceSystem;
            }
            set
            {
                this.sourceSystem = value;
            }
        }
        public SystemTypes.PostageSystemType PostalSystem   // property
        {
            get
            {
                return this.postalSystem;
            }
            set
            {
                this.postalSystem = value;
            }
        }
        #endregion  // ControlProperties

        #region SupplierProperties
        public string SupplierId
        {
            get
            {
                return this.supplierId;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"'{nameof(this.SupplierId)}' cannot be null.", "SupplierId");
                }
                else
                {
                    this.supplierId = value;
                }
            }
        }
        public string SupplierContactName
        {
            get
            {
                return this.supplierContactName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"'{nameof(this.SupplierContactName)}' cannot be null.", "SupplierContactName");
                }
                else
                {
                    this.supplierContactName = value;
                }
            }
        }
        public string SupplierBusinessName
        {
            get
            {
                return this.supplierBusinessName;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"'{nameof(this.SupplierBusinessName)}' cannot be null.", "SupplierBusinessName");
                }
                else
                {
                    this.supplierBusinessName = value;
                }
            }
        }
        public string SupplierReference1
        {
            get
            {
                return this.supplierReference1;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"'{nameof(this.SupplierReference1)}' cannot be null.", "SupplierReference1");
                }
                else
                {
                    this.supplierReference1 = value;
                }
            }
        }
        public string SupplierReference2
        {
            get
            {
                return this.supplierReference2;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"'{nameof(this.SupplierReference2)}' cannot be null.", "SupplierReference2");
                }
                else
                {
                    this.supplierReference2 = value;
                }
            }
        }
        public int Department
        {
            get
            {
                return this.supplierDepartment;
            }
            set
            {
                this.supplierDepartment = value;
            }
        }
        public string SupplierAddressLine1
        {
            get
            {
                return this.supplierAddressLine1;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"'{nameof(this.SupplierAddressLine1)}' cannot be null.", "SupplierAddressLine1");
                }
                else
                {
                    this.supplierAddressLine1 = value;
                }
            }
        }
        public string SupplierAddressLine2
        {
            get
            {
                return this.supplierAddressLine2;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"'{nameof(this.SupplierAddressLine2)}' cannot be null.", "SupplierAddressLine2");
                }
                else
                {
                    this.supplierAddressLine2 = value;
                }
            }
        }
        public string SupplierAddressLine3
        {
            get
            {
                return this.supplierAddressLine3;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"'{nameof(this.SupplierAddressLine3)}' cannot be null.", "SupplierAddressLine3");
                }
                else
                {
                    this.supplierAddressLine3 = value;
                }
            }
        }
        public string SupplierAddressLine4
        {
            get
            {
                return this.supplierAddressLine4;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"'{nameof(this.SupplierAddressLine4)}' cannot be null.", "SupplierAddressLine4");
                }
                else
                {
                    this.supplierAddressLine4 = value;
                }
            }
        }
        public string SupplierAddressTown
        {
            get
            {
                return this.supplierAddressTown;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"'{nameof(this.SupplierAddressTown)}' cannot be null.", "SupplierAddressTown");
                }
                else
                {
                    this.supplierAddressTown = value;
                }
            }
        }
        public string SupplierAddressCounty
        {
            get
            {
                return this.supplierAddressCounty;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"'{nameof(this.SupplierAddressCounty)}' cannot be null.", "SupplierAddressCounty");
                }
                else
                {
                    this.supplierAddressCounty = value;
                }
            }
        }
        public string SupplierCountryCode
        {
            get
            {
                return this.supplierCountryCode;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"'{nameof(this.SupplierCountryCode)}' cannot be null.", "SupplierCountryCode");
                }
                else
                {
                    this.supplierCountryCode = value;
                }
            }
        }
        public string SupplierAddressPostcode
        {
            get
            {
                return this.supplierAddressPostcode;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"'{nameof(this.SupplierAddressPostcode)}' cannot be null.", "SupplierAddressPostcode");
                }
                else
                {
                    this.supplierAddressPostcode = value;
                }
            }
        }
        public string SupplierPhoneNumber
        {
            get
            {
                return this.supplierPhoneNumber;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"'{nameof(this.SupplierPhoneNumber)}' cannot be null.", "SupplierPhoneNumber");
                }
                else
                {
                    this.supplierPhoneNumber = value;
                }
            }
        }
        public string SupplierEmailAddress
        {
            get
            {
                return this.supplierEmailAddress;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"'{nameof(this.SupplierEmailAddress)}' cannot be null.", "SupplierEmailAddress");
                }
                else
                {
                    this.supplierEmailAddress = value;
                }
            }
        }
        public string SupplierVatNumber
        {
            get
            {
                return this.supplierVatNumber;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"'{nameof(this.SupplierVatNumber)}' cannot be null.", "SupplierVatNumber");
                }
                else
                {
                    this.supplierVatNumber = value;
                }
            }
        }
        #endregion
        #region CustomerProperties
        public string CustomerId
        {
            get
            {
                return this.customerId;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"'{nameof(this.CustomerId)}' cannot be null.", "CustomerId");
                }
                else
                {
                    this.customerId = value;
                }
            }
        }
        public string CustomerContactName
        {
            get
            {
                return this.customerContactName;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"'{nameof(this.CustomerContactName)}' cannot be null.", "CustomerContactName");
                }
                else
                {
                    this.customerContactName = value;
                }
            }
        }
        public string CustomerBusinessName
        {
            get
            {
                return this.customerBusinessName;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"'{nameof(this.CustomerBusinessName)}' cannot be null.", "CustomerBusinessName");
                }
                else
                {
                    this.customerBusinessName = value;
                }
            }
        }
        public string CustomerAddressLine1
        {
            get
            {
                return this.customerAddressLine1;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"'{nameof(this.CustomerAddressLine1)}' cannot be null.", "CustomerAddressLine1");
                }
                else
                {
                    this.customerAddressLine1 = value;
                }
            }
        }
        public string CustomerAddressLine2
        {
            get
            {
                return this.customerAddressLine2;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"'{nameof(this.CustomerAddressLine2)}' cannot be null.", "CustomerAddressLine2");
                }
                else
                {
                    this.customerAddressLine2 = value;
                }
            }
        }
        public string CustomerAddressLine3
        {
            get
            {
                return this.customerAddressLine3;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"'{nameof(this.CustomerAddressLine3)}' cannot be null.", "CustomerAddressLine3");
                }
                else
                {
                    this.customerAddressLine3 = value;
                }
            }
        }
        public string CustomerAddressLine4
        {
            get
            {
                return this.customerAddressLine4;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"'{nameof(this.CustomerAddressLine4)}' cannot be null.", "CustomerAddressLine4");
                }
                else
                {
                    this.customerAddressLine4 = value;
                }
            }
        }
        public string CustomerAddressTown
        {
            get
            {
                return this.customerAddressTown;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"'{nameof(this.CustomerAddressTown)}' cannot be null.", "CustomerAddressTown");
                }
                else
                {
                    this.customerAddressTown = value;
                }
            }
        }
        public string CustomerAddressCounty
        {
            get
            {
                return this.customerAddressCounty;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"'{nameof(this.CustomerAddressCounty)}' cannot be null.", "CustomerAddressCounty");
                }
                else
                {
                    this.customerAddressCounty = value;
                }
            }
        }
        public string CustomerCountryCode
        {
            get
            {
                return this.customerCountryCode;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"'{nameof(this.CustomerCountryCode)}' cannot be null.", "CustomerCountryCode");
                }
                else
                {
                    this.customerCountryCode = value;
                }
            }
        }
        public string CustomerAddressPostcode
        {
            get
            {
                return this.customerAddressPostcode;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"'{nameof(this.CustomerAddressPostcode)}' cannot be null.", "CustomerAddressPostcode");
                }
                else
                {
                    this.customerAddressPostcode = value;
                }
            }
        }
        public string CustomerPhoneNumber
        {
            get
            {
                return this.customerPhoneNumber;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"'{nameof(this.CustomerPhoneNumber)}' cannot be null.", "CustomerPhoneNumber");
                }
                else
                {
                    this.customerPhoneNumber = value;
                }
            }
        }
        public string CustomerEmailAddress
        {
            get
            {
                return this.customerEmailAddress;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"'{nameof(this.CustomerEmailAddress)}' cannot be null.", "CustomerEmailAddress");
                }
                else
                {
                    this.customerEmailAddress = value;
                }
            }
        }
        public string CustomerVatNumber
        {
            get
            {
                return this.customerVatNumber;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"'{nameof(this.CustomerVatNumber)}' cannot be null.", "CustomerVatNumber");
                }
                else
                {
                    this.customerVatNumber = value;
                }
            }
        }
        public string CustomerSafeplace
        {
            get
            {
                return this.customerSafeplace;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException($"'{nameof(this.CustomerSafeplace)}' cannot be null.", "CustomerSafeplace");
                }
                else
                {
                    this.customerSafeplace = value;
                }
            }
        }
        #endregion
        #region PostageProperties
        public DateTime PostingDate
        {
            get
            {
                return this.postingDate;
            }
            set
            {
                this.postingDate = value;
            }
        }
        public string PostageType
        {
            get
            {
                return this.postingType;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"'{nameof(this.PostageType)}' cannot be null.", "PostageType");
                }
                else
                {
                    this.postingType = value;
                }
            }
        }
        public int PostingTotalPackages
        {
            get
            {
                return this.ParcelList.Count;
            }
        }
        public double PostingTotalWeight
        {
            get
            {
                double postingTotalWeight = 0;

                foreach (OrderParcelData p in this.ParcelList)
                {
                    postingTotalWeight += p.ParcelWeight;
                }

                return postingTotalWeight;
            }
        }
        public string PostingWeightUOM
        {
            get
            {
                return this.postingWeightUOM;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"'{nameof(this.PostingWeightUOM)}' cannot be null.", "PostingWeightUOM");
                }
                else
                {
                    this.postingWeightUOM = value;
                }
            }
        }
        public string PostingLocation
        {
            get
            {
                return this.postingLocation;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"'{nameof(this.PostingLocation)}' cannot be null.", "PostingLocation");
                }
                else
                {
                    this.postingLocation = value;
                }
            }
        }
        public string PostingServiceLevel
        {
            get
            {
                return this.postingServiceLevel;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"'{nameof(this.PostingServiceLevel)}' cannot be null.", "PostingServiceLevel");
                }
                else
                {
                    this.postingServiceLevel = value;
                }
            }
        }
        public string PostingServiceFormat
        {
            get
            {
                return this.postingServiceFormat;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"'{nameof(this.PostingServiceFormat)}' cannot be null.", "PostingServiceFormat");
                }
                else
                {
                    this.postingServiceFormat = value;
                }
            }
        }
        public bool PostingSaturdayGuaranteed
        {
            get
            {
                return this.postingSaturdayGuaranteed;
            }
            set
            {
                this.postingSaturdayGuaranteed = value;
            }
        }
        public string PostingConsequentialLoss
        {
            get
            {
                return this.postingConsequentialLoss;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"'{nameof(this.PostingConsequentialLoss)}' cannot be null.", "PostingConsequentialLoss");
                }
                else
                {
                    this.postingConsequentialLoss = value;
                }
            }
        }
        public bool PostingLocalCollect
        {
            get
            {
                return this.postingLocalCollect;
            }
            set
            {
                this.postingLocalCollect = value;
            }
        }
        public string PostingTrackingNotifications
        {
            get
            {
                return this.postingTrackingNotifications;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"'{nameof(this.PostingTrackingNotifications)}' cannot be null.", "PostingTrackingNotifications");
                }
                else
                {
                    this.postingTrackingNotifications = value;
                }
            }
        }
        public bool PostingRecordedSignedFor
        {
            get
            {
                return this.postingRecordedSignedFor;
            }
            set
            {
                this.postingRecordedSignedFor = value;
            }
        }
        public string CustomsProduct
        {
            get
            {
                return this.customsProduct;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"'{nameof(this.CustomsProduct)}' cannot be null.", "CustomsProduct");
                }
                else
                {
                    this.customsProduct = value;
                }
            }
        }
        public string CustomsDescriptionOfGoods
        {
            get
            {
                return this.customsDescriptionOfGoods;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"'{nameof(this.CustomsDescriptionOfGoods)}' cannot be null.", "CustomsDescriptionOfGoods");
                }
                else
                {
                    this.customsDescriptionOfGoods = value;
                }
            }
        }
        public string CustomsReasonForExport
        {
            get
            {
                return this.customsReasonForExport;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"'{nameof(this.CustomsReasonForExport)}' cannot be null.", "CustomsReasonForExport");
                }
                else
                {
                    this.customsReasonForExport = value;
                }
            }
        }
        public double CustomsValue
        {
            get
            {
                return this.customsValue;
            }
            set
            {

                this.customsValue = value;
            }
        }
        public double CustomsShippingCharges
        {
            get
            {
                return this.customsShippingCharges;
            }
            set
            {
                this.customsShippingCharges = value;
            }
        }
        public double CustomsOtherCharges
        {
            get
            {
                return this.customsOtherCharges;
            }
            set
            {
                this.customsOtherCharges = value;
            }
        }
        public string CustomsCurrency
        {
            get
            {
                return this.customsCurrency;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"'{nameof(this.CustomsCurrency)}' cannot be null.", "CustomsCurrency");
                }
                else
                {
                    this.customsCurrency = value;
                }
            }
        }
        public string CustomsIncoterms
        {
            get
            {
                return this.customsIncoterms;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"'{nameof(this.CustomsIncoterms)}' cannot be null.", "CustomsIncoterms");
                }
                else
                {
                    this.customsIncoterms = value;
                }
            }
        }
        public string CustomsInvoiceNumber
        {
            get
            {
                return this.customsInvoiceNumber;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"'{nameof(this.CustomsInvoiceNumber)}' cannot be null.", "CustomsInvoiceNumber");
                }
                else
                {
                    this.customsInvoiceNumber = value;
                }
            }
        }
        public DateTime CustomsInvoiceDate
        {
            get
            {
                return this.customsInvoiceDate;
            }
            set
            {
                this.customsInvoiceDate = value;
            }
        }
        public string CustomsLabelFormat
        {
            get
            {
                return this.customsLabelFormat;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"'{nameof(this.CustomsLabelFormat)}' cannot be null.", "CustomsLabelFormat");
                }
                else
                {
                    this.customsLabelFormat = value;
                }
            }
        }
        public string CustomsSilentPrintProfile
        {
            get
            {
                return this.customsSilentPrintProfile;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"'{nameof(this.CustomsSilentPrintProfile)}' cannot be null.", "CustomsSilentPrintProfile");
                }
                else
                {
                    this.customsSilentPrintProfile = value;
                }
            }
        }
        public string CustomsShipmentAction
        {
            get
            {
                return this.customsShipmentAction;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"'{nameof(this.CustomsShipmentAction)}' cannot be null.", "CustomsShipmentAction");
                }
                else
                {
                    this.customsShipmentAction = value;
                }
            }
        }
        public string CustomsPreRegistrationNumber
        {
            get
            {
                return this.customsPreRegistrationNumber;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"'{nameof(this.CustomsPreRegistrationNumber)}' cannot be null.", "CustomsPreRegistrationNumber");
                }
                else
                {
                    this.customsPreRegistrationNumber = value;
                }
            }
        }
        public string CustomsPreRegistrationType
        {
            get
            {
                return this.customsPreRegistrationType;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException($"'{nameof(this.CustomsPreRegistrationType)}' cannot be null.", "CustomsPreRegistrationType");
                }
                else
                {
                    this.customsPreRegistrationType = value;
                }
            }
        }
        public double CustomsQuotedLandedCost
        {
            get
            {
                return this.customsQuotedLandedCost;
            }
            set
            {
                this.customsQuotedLandedCost = value;
            }
        }
        public bool CustomsExportLicence
        {
            get
            {
                return this.customsExportLicence;
            }
            set
            {
                this.customsExportLicence = value;
            }
        }
        public Int64 AddresseeIdentificationReferenceNumber
        {
            get
            {
                return this.addresseeIdentificationReferenceNumber;
            }
            set
            {
                this.addresseeIdentificationReferenceNumber = value;
            }
        }
        #endregion
        #region ParcelProperties
        public int ParcelInstance
        {
            get
            {
                parcel = GetCurrentParcel();
                return parcel.ParcelInstance;
            }
            set
            {
                parcel = GetCurrentParcel();
                parcel.ParcelInstance = value;
            }
        }
        public string ParcelId
        {
            get
            {
                parcel = GetCurrentParcel();
                return parcel.ParcelId;
            }
            set
            {
                parcel = GetCurrentParcel();
                parcel.ParcelId = value;
            }
        }
        public double ParcelWeight
        {
            get
            {
                parcel = GetCurrentParcel();
                return parcel.ParcelWeight;
            }
            set
            {
                parcel = GetCurrentParcel();
                parcel.ParcelWeight = value;
            }
        }
        public int ParcelHeight
        {
            get
            {
                parcel = GetCurrentParcel();
                return parcel.ParcelHeight;
            }
            set
            {
                parcel = GetCurrentParcel();
                parcel.ParcelHeight = value;
            }
        }
        public int ParcelWidth
        {
            get
            {
                parcel = GetCurrentParcel();
                return parcel.ParcelWidth;
            }
            set
            {
                parcel = GetCurrentParcel();
                parcel.ParcelWidth = value;
            }
        }
        public int ParcelLength
        {
            get
            {
                parcel = GetCurrentParcel();
                return parcel.ParcelLength;
            }
            set
            {
                parcel = GetCurrentParcel();
                parcel.ParcelLength = value;
            }
        }
        #endregion
        #region ItemProperties
        public string ItemId
        {
            get
            {
                item = GetCurrentItem();
                return item.ItemId;
            }
            set
            {
                item = GetCurrentItem();
                item.ItemId = value;
            }
        }
        public int ItemQuantity
        {
            get
            {
                item = GetCurrentItem();
                return item.ItemQuantity;
            }
            set
            {
                item = GetCurrentItem();
                item.ItemQuantity = value;
            }
        }
        public int ItemParcelInstance
        {
            get
            {
                item = GetCurrentItem();
                return item.ParcelInstance;
            }
            set
            {
                item = GetCurrentItem();
                item.ParcelInstance = value;
            }
        }
        public string ItemDescription
        {
            get
            {
                item = GetCurrentItem();
                return item.ItemDescription;
            }
            set
            {
                item = GetCurrentItem();
                item.ItemDescription = value;
            }
        }
        public double ItemValue
        {
            get
            {
                item = GetCurrentItem();
                return item.ItemValue;
            }
            set
            {
                item = GetCurrentItem();
                item.ItemValue = value;
            }
        }
        public double ItemWeight
        {
            get
            {
                item = GetCurrentItem();
                return item.ItemWeight;
            }
            set
            {
                item = GetCurrentItem();
                item.ItemWeight = value;
            }
        }
        public string ItemHsCode
        {
            get
            {
                item = GetCurrentItem();
                return item.ItemHsCode;
            }
            set
            {
                item = GetCurrentItem();
                item.ItemHsCode = value;
            }
        }
        public string ItemSkuCode
        {
            get
            {
                item = GetCurrentItem();
                return item.ItemSkuCode;
            }
            set
            {
                item = GetCurrentItem();
                item.ItemSkuCode = value;
            }
        }
        public string ItemCountryOfOrigin
        {
            get
            {
                item = GetCurrentItem();
                return item.ItemCountryOfOrigin;
            }
            set
            {
                item = GetCurrentItem();
                item.ItemCountryOfOrigin = value;
            }
        }
        public string ItemImageUrl
        {
            get
            {
                item = GetCurrentItem();
                return item.ItemImageUrl;
            }
            set
            {
                item = GetCurrentItem();
                item.ItemImageUrl = value;
            }
        }
        public int TotalItemCount
        {
            get
            {
                return this.ItemList.Count;
            }
        }
        #endregion

        #region constructors
        /// <summary>
        /// The Transfer Order Data holds the data being transferred from the seller to the shipper.
        /// </summary>
        public OrderData()
        {
            ParcelList = new List<OrderParcelData>();
            ItemList = new List<OrderItemData>();
        }
        /// <summary>
        /// The Transfer Order Data holds the data being transferred from the seller to the shipper.
        /// </summary>
        /// <param name="inpSupplierId">Supplier's ID</param>
        /// <param name="inpSupplierContactName">Contact Name for the supplier</param>
        /// <param name="inpSupplierBusinessName">Bussiness Name of the supplier</param>
        /// <param name="inpSupplierReference1">Supplier's reference code 1</param>
        /// <param name="inpSupplierReference2">Supplier's reference code 2</param>
        /// <param name="inpSupplierDepartment">Department number of supplier</param>
        /// <param name="inpSupplierAddressLine1">Supplier's address, line 1</param>
        /// <param name="inpSupplierAddressLine2">Supplier's address, line 2</param>
        /// <param name="inpSupplierAddressLine3">Supplier's address, line 3</param>
        /// <param name="inpSupplierAddressLine4">Supplier's address, line 4</param>
        /// <param name="inpSupplierAddressTown">Supplier's address, town</param>
        /// <param name="inpSupplierAddressCounty">Supplier's address, county</param>
        /// <param name="inpSupplierCountryCode">Supplier's address, country code</param>
        /// <param name="inpSupplierAddressPostcode">Supplier's address, post code</param>
        /// <param name="inpSupplierPhoneNumber">Supplier's phone number</param>
        /// <param name="inpSupplierEmailAddress">Supplier's e-mail address</param>
        /// <param name="inpSupplierVatNumber">VAT Number for supplier</param>
        /// <param name="inpCustomerId">Customer's ID</param>
        /// <param name="inpCustomerContactName">Contact Name for the customer</param>
        /// <param name="inpCustomerBusinessName">Business Name of the customer (if they have one)</param>
        /// <param name="inpCustomerAddressLine1">Customer's address, line 1</param>
        /// <param name="inpCustomerAddressLine2">Customer's address, line 2</param>
        /// <param name="inpCustomerAddressLine3">Customer's address, line 3</param>
        /// <param name="inpCustomerAddressLine4">Customer's address, line 4</param>
        /// <param name="inpCustomerAddressTown">Customer's address, town</param>
        /// <param name="inpCustomerAddressCounty">Customer's address, county</param>
        /// <param name="inpCustomerCountryCode">Customer's address, country code</param>
        /// <param name="inpCustomerAddressPostcode">Customer's address, post code</param>
        /// <param name="inpCustomerPhoneNumber">Customer's phone number</param>
        /// <param name="inpCustomerEmailAddress">Customer's e-mail address</param>
        /// <param name="inpCustomerVatNumber">VAT Number for the customer</param>
        /// <param name="inpCustomerSafePlace">Safe place where parcels can be left</param>
        /// <param name="inpPostingDate">Date parcel sent</param>
        /// <param name="inpPostageType">Type of postage requested</param>
        /// <param name="inpPostingWeightUOM">Unit of Measure for weight (e.g. KG)</param>
        /// <param name="inpPostingLocation">Where posted from</param>
        /// <param name="inpPostingServiceLevel"></param>
        /// <param name="inpPostingServiceFormat"></param>
        /// <param name="inpPostingSaturdayGuaranteed">Is the parcel to be delivered on a Saturday</param>
        /// <param name="inpPostingConsequentialLoss"></param>
        /// <param name="inpPostingLocalCollect"></param>
        /// <param name="inpPostingTrackingNotifications">Should the parcel be tracked</param>
        /// <param name="inpPostingRecordedSignedFor">Is a signature required for the parcel</param>
        /// <param name="inpCustomsProduct">What is the type of product for customs purposes</param>
        /// <param name="inpCustomsDescriptionOfGoods">Description of the goods for customs purposes</param>
        /// <param name="inpCustomsReasonForExport">Why is the parcel being exported (e.g. sales, gifts)</param>
        /// <param name="inpCustomsShippingCharges">Shipping charges</param>
        /// <param name="inpCustomsOtherCharges">Other charges</param>
        /// <param name="inpCustomsCurrency">Currency for prices/charges</param>
        /// <param name="inpCustomsIncoterms"></param>
        /// <param name="inpCustomsInvoiceNumber">Invoice Number</param>
        /// <param name="inpCustomsInvoiceDate">Date Invoice Produced</param>
        /// <param name="inpCustomsLabelFormat">Type of label format (e.g. PDF)</param>
        /// <param name="inpCustomsSilentPrintProfile"></param>
        /// <param name="inpCustomsShipmentAction"></param>
        /// <param name="inpCustomsPreRegistrationNumber"></param>
        /// <param name="inpCustomsPreRegistrationType"></param>
        /// <param name="inpCustomsQuotedLandedCost"></param>
        /// <param name="inpCustomsExportLicence"></param>
        /// <param name="inpAddresseeIdentificationReferenceNumber"></param>
        public OrderData(string inpSupplierId,
                string inpSupplierContactName,
                string inpSupplierBusinessName,
                string inpSupplierReference1,
                string inpSupplierReference2,
                int inpSupplierDepartment,
                string inpSupplierAddressLine1,
                string inpSupplierAddressLine2,
                string inpSupplierAddressLine3,
                string inpSupplierAddressLine4,
                string inpSupplierAddressTown,
                string inpSupplierAddressCounty,
                string inpSupplierCountryCode,
                string inpSupplierAddressPostcode,
                string inpSupplierPhoneNumber,
                string inpSupplierEmailAddress,
                string inpSupplierVatNumber,
                string inpCustomerId,
                string inpCustomerContactName,
                string inpCustomerBusinessName,
                string inpCustomerAddressLine1,
                string inpCustomerAddressLine2,
                string inpCustomerAddressLine3,
                string inpCustomerAddressLine4,
                string inpCustomerAddressTown,
                string inpCustomerAddressCounty,
                string inpCustomerCountryCode,
                string inpCustomerAddressPostcode,
                string inpCustomerPhoneNumber,
                string inpCustomerEmailAddress,
                string inpCustomerVatNumber,
                string inpCustomerSafePlace,
                DateTime inpPostingDate,
                string inpPostageType,
                string inpPostingWeightUOM,
                string inpPostingLocation,
                string inpPostingServiceLevel,
                string inpPostingServiceFormat,
                bool inpPostingSaturdayGuaranteed,
                string inpPostingConsequentialLoss,
                bool inpPostingLocalCollect,
                string inpPostingTrackingNotifications,
                bool inpPostingRecordedSignedFor,
                string inpCustomsProduct,
                string inpCustomsDescriptionOfGoods,
                string inpCustomsReasonForExport,
                double inpCustomsShippingCharges,
                double inpCustomsOtherCharges,
                string inpCustomsCurrency,
                string inpCustomsIncoterms,
                string inpCustomsInvoiceNumber,
                DateTime inpCustomsInvoiceDate,
                string inpCustomsLabelFormat,
                string inpCustomsSilentPrintProfile,
                string inpCustomsShipmentAction,
                string inpCustomsPreRegistrationNumber,
                string inpCustomsPreRegistrationType,
                double inpCustomsQuotedLandedCost,
                bool inpCustomsExportLicence,
                long inpAddresseeIdentificationReferenceNumber) : this()
        {
            this.supplierId = inpSupplierId;
            this.supplierContactName = inpSupplierContactName;
            this.supplierBusinessName = inpSupplierBusinessName;
            this.supplierReference1 = inpSupplierReference1;
            this.supplierReference2 = inpSupplierReference2;
            this.supplierDepartment = inpSupplierDepartment;
            this.supplierAddressLine1 = inpSupplierAddressLine1;
            this.supplierAddressLine2 = inpSupplierAddressLine2;
            this.supplierAddressLine3 = inpSupplierAddressLine3;
            this.supplierAddressLine4 = inpSupplierAddressLine4;
            this.supplierAddressTown = inpSupplierAddressTown;
            this.supplierAddressCounty = inpSupplierAddressCounty;
            this.supplierCountryCode = inpSupplierCountryCode;
            this.supplierAddressPostcode = inpSupplierAddressPostcode;
            this.supplierPhoneNumber = inpSupplierPhoneNumber;
            this.supplierEmailAddress = inpSupplierEmailAddress;
            this.supplierVatNumber = inpSupplierVatNumber;

            this.customerId = inpCustomerId;
            this.customerContactName = inpCustomerContactName;
            this.customerBusinessName = inpCustomerBusinessName;
            this.customerAddressLine1 = inpCustomerAddressLine1;
            this.customerAddressLine2 = inpCustomerAddressLine2;
            this.customerAddressLine3 = inpCustomerAddressLine3;
            this.customerAddressLine4 = inpCustomerAddressLine4;
            this.customerAddressTown = inpCustomerAddressTown;
            this.customerAddressCounty = inpCustomerAddressCounty;
            this.customerCountryCode = inpCustomerCountryCode;
            this.customerAddressPostcode = inpCustomerAddressPostcode;
            this.customerPhoneNumber = inpCustomerPhoneNumber;
            this.customerEmailAddress = inpCustomerEmailAddress;
            this.customerVatNumber = inpCustomerVatNumber;
            this.customerSafeplace = inpCustomerSafePlace;

            this.postingDate = inpPostingDate;
            this.postingType = inpPostageType;
            this.postingWeightUOM = inpPostingWeightUOM;
            this.postingLocation = inpPostingLocation;
            this.postingServiceLevel = inpPostingServiceLevel;
            this.postingServiceFormat = inpPostingServiceFormat;
            this.postingSaturdayGuaranteed = inpPostingSaturdayGuaranteed;
            this.postingConsequentialLoss = inpPostingConsequentialLoss;
            this.postingLocalCollect = inpPostingLocalCollect;
            this.postingTrackingNotifications = inpPostingTrackingNotifications;
            this.postingRecordedSignedFor = inpPostingRecordedSignedFor;
            this.customsProduct = inpCustomsProduct;
            this.customsDescriptionOfGoods = inpCustomsDescriptionOfGoods;
            this.customsReasonForExport = inpCustomsReasonForExport;
            this.customsShippingCharges = inpCustomsShippingCharges;
            this.customsOtherCharges = inpCustomsOtherCharges;
            this.customsCurrency = inpCustomsCurrency;
            this.customsIncoterms = inpCustomsIncoterms;
            this.customsInvoiceNumber = inpCustomsInvoiceNumber;
            this.customsInvoiceDate = inpCustomsInvoiceDate;
            this.customsLabelFormat = inpCustomsLabelFormat;
            this.customsSilentPrintProfile = inpCustomsSilentPrintProfile;
            this.customsShipmentAction = inpCustomsShipmentAction;
            this.customsPreRegistrationNumber = inpCustomsPreRegistrationNumber;
            this.customsPreRegistrationType = inpCustomsPreRegistrationType;
            this.customsQuotedLandedCost = inpCustomsQuotedLandedCost;
            this.customsExportLicence = inpCustomsExportLicence;
            this.addresseeIdentificationReferenceNumber = inpAddresseeIdentificationReferenceNumber;
        }

        /// <summary>
        /// The Transfer Order Data holds the data being transferred from the seller to the shipper.
        /// </summary>
        /// <param name="SourceOrderData">A source data file of type IOrderData to copy to here</param>
        public OrderData(IOrderData SourceOrderData) : this()
        {
            if (SourceOrderData == null)
            {
                throw new NullReferenceException("No source object provided.");
            }
            else
            {
                this.supplierId = SourceOrderData.SupplierId;
                this.supplierContactName = SourceOrderData.SupplierContactName;
                this.supplierBusinessName = SourceOrderData.SupplierBusinessName;
                this.supplierReference1 = SourceOrderData.SupplierReference1;
                this.supplierReference2 = SourceOrderData.SupplierReference2;
                this.supplierDepartment = SourceOrderData.Department;
                this.supplierAddressLine1 = SourceOrderData.SupplierAddressLine1;
                this.supplierAddressLine2 = SourceOrderData.SupplierAddressLine2;
                this.supplierAddressLine3 = SourceOrderData.SupplierAddressLine3;
                this.supplierAddressLine4 = SourceOrderData.SupplierAddressLine4;
                this.supplierAddressTown = SourceOrderData.SupplierAddressTown;
                this.supplierAddressCounty = SourceOrderData.SupplierAddressCounty;
                this.supplierCountryCode = SourceOrderData.SupplierCountryCode;
                this.supplierAddressPostcode = SourceOrderData.SupplierAddressPostcode;
                this.supplierPhoneNumber = SourceOrderData.SupplierPhoneNumber;
                this.supplierEmailAddress = SourceOrderData.SupplierEmailAddress;
                this.supplierVatNumber = SourceOrderData.SupplierVatNumber;

                this.customerId = SourceOrderData.CustomerId;
                this.customerContactName = SourceOrderData.CustomerContactName;
                this.customerBusinessName = SourceOrderData.CustomerBusinessName;
                this.customerAddressLine1 = SourceOrderData.CustomerAddressLine1;
                this.customerAddressLine2 = SourceOrderData.CustomerAddressLine2;
                this.customerAddressLine3 = SourceOrderData.CustomerAddressLine3;
                this.customerAddressLine4 = SourceOrderData.CustomerAddressLine4;
                this.customerAddressTown = SourceOrderData.CustomerAddressTown;
                this.customerAddressCounty = SourceOrderData.CustomerAddressCounty;
                this.customerCountryCode = SourceOrderData.CustomerCountryCode;
                this.customerAddressPostcode = SourceOrderData.CustomerAddressPostcode;
                this.customerPhoneNumber = SourceOrderData.CustomerPhoneNumber;
                this.customerEmailAddress = SourceOrderData.CustomerEmailAddress;
                this.customerVatNumber = SourceOrderData.CustomerVatNumber;
                this.customerSafeplace = SourceOrderData.CustomerSafeplace;

                this.postingDate = SourceOrderData.PostingDate;
                this.postingType = SourceOrderData.PostageType;
                this.postingWeightUOM = SourceOrderData.PostingWeightUOM;
                this.postingLocation = SourceOrderData.PostingLocation;
                this.postingServiceLevel = SourceOrderData.PostingServiceLevel;
                this.postingServiceFormat = SourceOrderData.PostingServiceFormat;
                this.postingSaturdayGuaranteed = SourceOrderData.PostingSaturdayGuaranteed;
                this.postingConsequentialLoss = SourceOrderData.PostingConsequentialLoss;
                this.postingLocalCollect = SourceOrderData.PostingLocalCollect;
                this.postingTrackingNotifications = SourceOrderData.PostingTrackingNotifications;
                this.postingRecordedSignedFor = SourceOrderData.PostingRecordedSignedFor;
                this.customsProduct = SourceOrderData.CustomsProduct;
                this.customsDescriptionOfGoods = SourceOrderData.CustomsDescriptionOfGoods;
                this.customsReasonForExport = SourceOrderData.CustomsReasonForExport;
                this.customsShippingCharges = SourceOrderData.CustomsShippingCharges;
                this.customsOtherCharges = SourceOrderData.CustomsOtherCharges;
                this.customsCurrency = SourceOrderData.CustomsCurrency;
                this.customsIncoterms = SourceOrderData.CustomsIncoterms;
                this.customsInvoiceNumber = SourceOrderData.CustomsInvoiceNumber;
                this.customsInvoiceDate = SourceOrderData.CustomsInvoiceDate;
                this.customsLabelFormat = SourceOrderData.CustomsLabelFormat;
                this.customsSilentPrintProfile = SourceOrderData.CustomsSilentPrintProfile;
                this.customsShipmentAction = SourceOrderData.CustomsShipmentAction;
                this.customsPreRegistrationNumber = SourceOrderData.CustomsPreRegistrationNumber;
                this.customsPreRegistrationType = SourceOrderData.CustomsPreRegistrationType;
                this.customsQuotedLandedCost = SourceOrderData.CustomsQuotedLandedCost;
                this.customsExportLicence = SourceOrderData.CustomsExportLicence;
                this.addresseeIdentificationReferenceNumber = SourceOrderData.AddresseeIdentificationReferenceNumber;

                if (SourceOrderData.FindFirstParcel())
                {
                    do
                    {
                        this.AddParcel(SourceOrderData.ParcelInstance,
                                SourceOrderData.ParcelId,
                                SourceOrderData.ParcelWeight,
                                SourceOrderData.ParcelLength,
                                SourceOrderData.ParcelWidth,
                                SourceOrderData.ParcelHeight);
                    } while (SourceOrderData.FindNextParcel());
                }
                if (SourceOrderData.FindFirstItem())
                {
                    do
                    {
                        this.AddItem(SourceOrderData.ItemId,
                            SourceOrderData.ItemQuantity,
                            SourceOrderData.ItemParcelInstance,
                            SourceOrderData.ItemDescription,
                            SourceOrderData.ItemValue,
                            SourceOrderData.ItemWeight,
                            SourceOrderData.ItemHsCode,
                            SourceOrderData.ItemSkuCode,
                            SourceOrderData.ItemCountryOfOrigin,
                            SourceOrderData.ItemImageUrl);
                    } while (SourceOrderData.FindNextItem());
                }
            }
        }
        #endregion


        #region ParcelMethods
        /// <summary>
        /// Sets the current parcel object to return data from
        /// </summary>
        /// <returns>Returns the selected parcel object</returns>
        private OrderParcelData GetCurrentParcel()
        {
            // Check for the current parcel being off the end of the list.
            if (currentParcel > -1 && currentParcel < ParcelList.Count)
            {
                // Set the parcel selected
                parcel = ParcelList[currentParcel];
                // If no parcel is found, return an error.
                if (parcel == null)
                {
                    throw new NullReferenceException("Selected parcel is invalid");
                }
                else
                {
                    return parcel;
                }
            }
            else
            {
                throw new IndexOutOfRangeException("No parcel selected");
            }
        }
        /// <summary>
        /// Add a new, blank parcel to the list
        /// </summary>
        public void AddParcel()
        {
            this.ParcelList.Add(new OrderParcelData());
            this.currentParcel = this.ParcelList.Count - 1;
        }
        /// <summary>
        /// Add a new, partially populated parcel to the list.
        /// </summary>
        /// <param name="inpParcelInstance">Parcel instance (int) to set</param>
        /// <param name="inpParcelId">Parcel ID to set</param>
        public void AddParcel(int inpParcelInstance,
                              string inpParcelId)
        {
            this.ParcelList.Add(new OrderParcelData(inpParcelInstance,
                inpParcelId));
            this.currentParcel = this.ParcelList.Count - 1;
        }
        /// <summary>
        /// Add a new, partially populated parcel to the list.
        /// </summary>
        /// <param name="inpParcelInstance">Parcel instance (int) to set</param>
        /// <param name="inpParcelId">Parcel ID to set</param>
        /// <param name="inpParcelWeight">Weight to set for the parcel</param>
        public void AddParcel(int inpParcelInstance,
                              string inpParcelId,
                              double inpParcelWeight)
        {
            this.ParcelList.Add(new OrderParcelData(inpParcelInstance,
                                            inpParcelId,
                                            inpParcelWeight));
            this.currentParcel = this.ParcelList.Count - 1;
        }
        /// <summary>
        /// Add a new, fully populated parcel to the list.
        /// </summary>
        /// <param name="inpParcelInstance">Parcel instance (int) to set</param>
        /// <param name="inpParcelId">Parcel ID to set</param>
        /// <param name="inpParcelWeight">Weight to set for the parcel</param>
        /// <param name="inpParcelLength">Lenght to set for the parcel</param>
        /// <param name="inpParcelWidth">Width  to set for the parcel</param>
        /// <param name="inpParcelHeight">Height  to set for the parcel</param>
        public void AddParcel(int inpParcelInstance,
                              string inpParcelId,
                              double inpParcelWeight,
                              int inpParcelLength,
                              int inpParcelWidth,
                              int inpParcelHeight)
        {
            this.ParcelList.Add(new OrderParcelData(inpParcelInstance,
                                            inpParcelId,
                                            inpParcelWeight,
                                            inpParcelLength,
                                            inpParcelWidth,
                                            inpParcelHeight));
            this.currentParcel = this.ParcelList.Count - 1;
        }
        /// <summary>
        /// Set the current parcel to the first in the list
        /// </summary>
        /// <returns>Was there a parcel found?</returns>
        public bool FindFirstParcel()
        {
            return SubclassNavigation.FindFirstRecord<OrderParcelData>(ref currentParcel, ref ParcelList);
        }
        /// <summary>
        /// Set the current parcel to the next in the list
        /// </summary>
        /// <returns>Was there a parcel found?</returns>
        public bool FindNextParcel()
        {
            return SubclassNavigation.FindNextRecord<OrderParcelData>(ref currentParcel, ref ParcelList);
        }
        /// <summary>
        /// Set the current parcel to the previous in the list
        /// </summary>
        /// <returns>Was there a parcel found?</returns>
        public bool FindPrevParcel()
        {
            return SubclassNavigation.FindPrevRecord<OrderParcelData>(ref currentParcel, ref ParcelList);
        }
        /// <summary>
        /// Set the current parcel to the last in the list
        /// </summary>
        /// <returns>Was there a parcel found?</returns>
        public bool FindLastParcel()
        {
            return SubclassNavigation.FindLastRecord<OrderParcelData>(ref currentParcel, ref ParcelList);
        }
        /// <summary>
        /// Set the current parcel to a specified place in the list
        /// </summary>
        /// <param name="inpParcelIndex">Index of the parcel desired</param>
        /// <returns>Was there a parcel found?</returns>
        public bool FindSpecificParcel(int inpParcelIndex)
        {
            return SubclassNavigation.FindSpecificRecord<OrderParcelData>(inpParcelIndex, ref currentParcel, ref ParcelList);
        }
        #endregion
        #region ItemMethods
        private OrderItemData GetCurrentItem()
        {
            if (currentItem > -1 && currentItem < ItemList.Count)
            {
                item = ItemList[currentItem];
                if (item == null)
                {
                    throw new NullReferenceException("Selected item is invalid");
                }
                else
                {
                    return item;
                }
            }
            else
            {
                throw new IndexOutOfRangeException("No item selected");
            }
        }
        public void AddItem()
        {
            this.ItemList.Add(new OrderItemData());
            this.currentItem = this.ItemList.Count - 1;
        }
        public void AddItem(string inpPurchaseId,
                int inpQuantity)
        {
            this.ItemList.Add(new OrderItemData(inpPurchaseId,
                inpQuantity));
            this.currentItem = this.ItemList.Count - 1;
        }
        public void AddItem(string inpItemId,
                     int inpItemQuantity,
                     int inpParcelInstance)
        {
            this.ItemList.Add(new OrderItemData(inpItemId,
                 inpItemQuantity,
                 inpParcelInstance));
            this.currentItem = this.ItemList.Count - 1;
        }
        public void AddItem(string inpItemId,
                     int inpItemQuantity,
                     int inpParcelInstance,
                     string inpItemDescription,
                     double inpItemValue,
                     double inpItemWeight)
        {
            this.ItemList.Add(new OrderItemData(inpItemId,
                 inpItemQuantity,
                 inpParcelInstance,
                 inpItemDescription,
                 inpItemValue,
                 inpItemWeight));
            this.currentItem = this.ItemList.Count - 1;
        }
        public void AddItem(string inpItemId,
                     int inpItemQuantity,
                     int inpParcelInstance,
                     string inpItemDescription,
                     double inpItemValue,
                     double inpItemWeight,
                     string inpItemHsCode,
                     string inpItemSkuCode)
        {
            this.ItemList.Add(new OrderItemData(inpItemId,
                 inpItemQuantity,
                 inpParcelInstance,
                 inpItemDescription,
                 inpItemValue,
                 inpItemWeight,
                 inpItemHsCode,
                 inpItemSkuCode));
            this.currentItem = this.ItemList.Count - 1;
        }
        public void AddItem(string inpItemId,
                     int inpItemQuantity,
                     int inpParcelInstance,
                     string inpItemDescription,
                     double inpItemValue,
                     double inpItemWeight,
                     string inpItemHsCode,
                     string inpItemSkuCode,
                     string inpItemCountryOfOrigin)
        {
            this.ItemList.Add(new OrderItemData(inpItemId,
                 inpItemQuantity,
                 inpParcelInstance,
                 inpItemDescription,
                 inpItemValue,
                 inpItemWeight,
                 inpItemHsCode,
                 inpItemSkuCode,
                 inpItemCountryOfOrigin));
            this.currentItem = this.ItemList.Count - 1;
        }
        public void AddItem(string inpItemId,
                     int inpItemQuantity,
                     int inpParcelInstance,
                     string inpItemDescription,
                     double inpItemValue,
                     double inpItemWeight,
                     string inpItemHsCode,
                     string inpItemSkuCode,
                     string inpItemCountryOfOrigin,
                     string inpItemImageUrl)
        {
            this.ItemList.Add(new OrderItemData(inpItemId,
                 inpItemQuantity,
                 inpParcelInstance,
                 inpItemDescription,
                 inpItemValue,
                 inpItemWeight,
                 inpItemHsCode,
                 inpItemSkuCode,
                 inpItemCountryOfOrigin,
                 inpItemImageUrl));
            this.currentItem = this.ItemList.Count - 1;
        }
        public bool FindFirstItem()
        {
            return SubclassNavigation.FindFirstRecord<OrderItemData>(ref currentItem, ref ItemList);
        }
        public bool FindNextItem()
        {
            return SubclassNavigation.FindNextRecord<OrderItemData>(ref currentItem, ref ItemList);
        }
        public bool FindPrevItem()
        {
            return SubclassNavigation.FindPrevRecord<OrderItemData>(ref currentItem, ref ItemList);
        }
        public bool FindLastItem()
        {
            return SubclassNavigation.FindLastRecord<OrderItemData>(ref currentItem, ref ItemList);
        }
        public bool FindSpecificItem(int inpItemIndex)
        {
            return SubclassNavigation.FindSpecificRecord<OrderItemData>(inpItemIndex, ref currentItem, ref ItemList);
        }
        #endregion

        #region CopyMethods
        public object Clone()
        {
            OrderData cloneOrderData = new OrderData(this);

            return cloneOrderData;
        }
        #endregion

    }
}