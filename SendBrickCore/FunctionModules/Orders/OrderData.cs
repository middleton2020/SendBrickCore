using CM.SendbrickShared.Enums;
using SendBrickCore.Interfaces.FunctionModules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SendBrickCore.FunctionModules.Orders
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




        public string SupplierId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SupplierBusinessName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SupplierContactName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Department { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SupplierAddressLine1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SupplierAddressLine2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SupplierAddressLine3 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SupplierAddressLine4 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SupplierAddressPostcode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SupplierAddressTown { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SupplierAddressCounty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SupplierCountryCode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SupplierPhoneNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SupplierEmailAddress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SupplierReference1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SupplierReference2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SupplierVatNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CustomerId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CustomerContactName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CustomerBusinessName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public long AddresseeIdentificationReferenceNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CustomerAddressLine1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CustomerAddressLine2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CustomerAddressLine3 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CustomerAddressLine4 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CustomerAddressTown { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CustomerAddressCounty { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CustomerAddressPostcode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CustomerCountryCode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CustomerPhoneNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CustomerEmailAddress { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CustomerSafeplace { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CustomerVatNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CustomsCurrency { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CustomsDescriptionOfGoods { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool CustomsExportLicence { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CustomsIncoterms { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CustomsInvoiceDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CustomsInvoiceNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CustomsLabelFormat { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double CustomsOtherCharges { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CustomsPreRegistrationNumber { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CustomsPreRegistrationType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CustomsProduct { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double CustomsQuotedLandedCost { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CustomsReasonForExport { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CustomsShipmentAction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double CustomsShippingCharges { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string CustomsSilentPrintProfile { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double CustomsValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ItemId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ItemDescription { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ItemParcelInstance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ItemQuantity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double ItemValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double ItemWeight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ItemCountryOfOrigin { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ItemHsCode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ItemSkuCode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ItemImageUrl { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string ParcelId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ParcelInstance { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double ParcelWeight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ParcelHeight { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ParcelLength { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int ParcelWidth { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PostageType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime PostingDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PostingServiceFormat { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PostingServiceLevel { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int PostingTotalPackages => throw new NotImplementedException();

        public double PostingTotalWeight => throw new NotImplementedException();

        public string PostingWeightUOM { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PostingConsequentialLoss { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool PostingLocalCollect { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PostingLocation { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool PostingRecordedSignedFor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool PostingSaturdayGuaranteed { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string PostingTrackingNotifications { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int TotalItemCount => throw new NotImplementedException();

        public void AddItem()
        {
            throw new NotImplementedException();
        }

        public void AddParcel()
        {
            throw new NotImplementedException();
        }

        public bool FindFirstItem()
        {
            throw new NotImplementedException();
        }

        public bool FindFirstParcel()
        {
            throw new NotImplementedException();
        }

        public bool FindLastItem()
        {
            throw new NotImplementedException();
        }

        public bool FindLastParcel()
        {
            throw new NotImplementedException();
        }

        public bool FindNextItem()
        {
            throw new NotImplementedException();
        }

        public bool FindNextParcel()
        {
            throw new NotImplementedException();
        }

        public bool FindPrevItem()
        {
            throw new NotImplementedException();
        }

        public bool FindPrevParcel()
        {
            throw new NotImplementedException();
        }

        public bool FindSpecificItem(int inpItemIndex)
        {
            throw new NotImplementedException();
        }

        public bool FindSpecificParcel(int inpParcelIndex)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}