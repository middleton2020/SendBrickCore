using CM.SendbrickShared.Enums;

namespace SendBrickCore.Interfaces.FunctionModules
{
    /// <summary>
    /// Stores the data of each order
    /// </summary>
    public interface IOrderData
    {
        // Control values
        SystemTypes.PostageSystemType PostalSystem { get; }
        SystemTypes.SourceSystemType SourceSystem { get; }

        // Supplier values
        string SupplierId { get; set; }
        string SupplierBusinessName { get; set; }
        string SupplierContactName { get; set; }
        int Department { get; set; }
        string SupplierAddressLine1 { get; set; }
        string SupplierAddressLine2 { get; set; }
        string SupplierAddressLine3 { get; set; }
        string SupplierAddressLine4 { get; set; }
        string SupplierAddressPostcode { get; set; }
        string SupplierAddressTown { get; set; }
        string SupplierAddressCounty { get; set; }
        string SupplierCountryCode { get; set; }
        string SupplierPhoneNumber { get; set; }
        string SupplierEmailAddress { get; set; }
        string SupplierReference1 { get; set; }
        string SupplierReference2 { get; set; }
        string SupplierVatNumber { get; set; }

        // Customer values
        string CustomerId { get; set; }
        string CustomerContactName { get; set; }
        string CustomerBusinessName { get; set; }
        Int64 AddresseeIdentificationReferenceNumber { get; set; }
        string CustomerAddressLine1 { get; set; }
        string CustomerAddressLine2 { get; set; }
        string CustomerAddressLine3 { get; set; }
        string CustomerAddressLine4 { get; set; }
        string CustomerAddressTown { get; set; }
        string CustomerAddressCounty { get; set; }
        string CustomerAddressPostcode { get; set; }
        string CustomerCountryCode { get; set; }
        string CustomerPhoneNumber { get; set; }
        string CustomerEmailAddress { get; set; }
        string CustomerSafeplace { get; set; }
        string CustomerVatNumber { get; set; }

        // Customs values
        string CustomsCurrency { get; set; }
        string CustomsDescriptionOfGoods { get; set; }
        bool CustomsExportLicence { get; set; }
        string CustomsIncoterms { get; set; }
        DateTime CustomsInvoiceDate { get; set; }
        string CustomsInvoiceNumber { get; set; }
        string CustomsLabelFormat { get; set; }
        double CustomsOtherCharges { get; set; }
        string CustomsPreRegistrationNumber { get; set; }
        string CustomsPreRegistrationType { get; set; }
        string CustomsProduct { get; set; }
        double CustomsQuotedLandedCost { get; set; }
        string CustomsReasonForExport { get; set; }
        string CustomsShipmentAction { get; set; }
        double CustomsShippingCharges { get; set; }
        string CustomsSilentPrintProfile { get; set; }
        double CustomsValue { get; set; }

        // Item values
        string ItemId { get; set; }
        string ItemDescription { get; set; }
        int ItemParcelInstance { get; set; }
        int ItemQuantity { get; set; }
        double ItemValue { get; set; }
        double ItemWeight { get; set; }
        string ItemCountryOfOrigin { get; set; }
        string ItemHsCode { get; set; }
        string ItemSkuCode { get; set; }
        string ItemImageUrl { get; set; }

        // Parcel values
        string ParcelId { get; set; }
        int ParcelInstance { get; set; }
        double ParcelWeight { get; set; }
        int ParcelHeight { get; set; }
        int ParcelLength { get; set; }
        int ParcelWidth { get; set; }

        // Postage values
        string PostageType { get; set; }
        DateTime PostingDate { get; set; }
        string PostingServiceFormat { get; set; }
        string PostingServiceLevel { get; set; }
        int PostingTotalPackages { get; }
        double PostingTotalWeight { get; }
        string PostingWeightUOM { get; set; }
        string PostingConsequentialLoss { get; set; }
        bool PostingLocalCollect { get; set; }
        string PostingLocation { get; set; }
        bool PostingRecordedSignedFor { get; set; }
        bool PostingSaturdayGuaranteed { get; set; }
        string PostingTrackingNotifications { get; set; }
        int TotalItemCount { get; }

        void AddItem();
        void AddParcel();

        bool FindFirstItem();
        bool FindFirstParcel();
        bool FindLastItem();
        bool FindLastParcel();
        bool FindNextItem();
        bool FindNextParcel();
        bool FindPrevItem();
        bool FindPrevParcel();
        bool FindSpecificItem(int inpItemIndex);
        bool FindSpecificParcel(int inpParcelIndex);
    }
    //TYPE TRANSFER OD		POSTOFFICE OD

    //// Supplier values
    //string	SupplierId	                Shipper.addressId
    //string	SupplierBusinessName	    Shipper.companyName
    //string	SupplierContactName	        Shipper.contactName
    //int	    Department	                Shipper.shipperDepartment
    //string	SupplierAddressLine1	    Shipper.addressLine1
    //string	SupplierAddressLine2	    Shipper.addressLine2
    //string	SupplierAddressLine3	    Shipper.addressLine3
    //string	SupplierAddressLine4	    N/A
    //string	SupplierAddressPostcode	    Shipper.postcode
    //string	SupplierAddressTown	        Shipper.town
    //string	SupplierAddressCounty	    Shipper.county
    //string	SupplierCountryCode	        Shipper.countryCode
    //string	SupplierPhoneNumber	        Shipper.phoneNumber
    //string	SupplierEmailAddress	    Shipper.emailAddress
    //string	SupplierReference1	        Shipper.shipperReference
    //string	SupplierReference2	        Shipper.shipperReference2
    //string	SupplierVatNumber	        Shipper.vatNumber

    //// Customer values
    //string	CustomerId	                Destination.addressId
    //string	CustomerContactName	        Destination.contactName
    //string	CustomerBusinessName	    Destination.companyName
    //Int64	    AddresseeIdentificationReferenceNumber	    CustomsInformation.addresseeIdentificationReferenceNumber
    //string	CustomerAddressLine1	    Destination.addressLine1
    //string	CustomerAddressLine2	    Destination.addressLine2
    //string	CustomerAddressLine3	    Destination.addressLine3
    //string	CustomerAddressLine4	    N/A
    //string	CustomerAddressTown	        Destination.town
    //string	CustomerAddressCounty	    Destination.county
    //string	CustomerAddressPostcode	    Destination.postcode
    //string	CustomerCountryCode	        Destination.countryCode
    //string	CustomerPhoneNumber	        Destination.phoneNumber
    //string	CustomerEmailAddress	    Destination.emailAddress
    //string	CustomerSafeplace	        ShipmentInformation.ServiceOptions.safeplace
    //string	CustomerVatNumber	        Destination.vatNumber

    //// Customs values
    //string	CustomsCurrency 	        ShipmentInformation.currency
    //string	CustomsDescriptionOfGoods	ShipmentInformation.descriptionOfGoods
    //bool	    CustomsExportLicence	    CustomsInformation.exportLicence
    //string	CustomsIncoterms	        ShipmentInformation.incoterms
    //DateTime	CustomsInvoiceDate	        CustomsInformation.invoiceDate
    //string	CustomsInvoiceNumber	    Int32 CustomsInformation.invoiceNumber
    //string	CustomsLabelFormat	        ShipmentInformation.labelFormat
    //double	CustomsOtherCharges	        CustomsInformation.otherCharges
    //string	CustomsPreRegistrationNumber	CustomsInformation.preRegistrationNumber
    //string	CustomsPreRegistrationType	CustomsInformation.preRegistrationType
    //string	CustomsProduct	            ShipmentInformation.product
    //double	CustomsQuotedLandedCost	    CustomsInformation.quotedLandedCost
    //string	CustomsReasonForExport	    ShipmentInformation.reasonForExport
    //string	CustomsShipmentAction	    ShipmentInformation.shipmentAction
    //double	CustomsShippingCharges	    CustomsInformation.shippingCharges
    //string	CustomsSilentPrintProfile	ShipmentInformation.silentPrintProfile
    //double	CustomsValue	            ShipmentInformation.valueData

    //// Postage values
    //string	PostageType	                ShipmentInformation.serviceCode
    //DateTime	PostingDate	                ShipmentInformation.shipmentDate
    //string	PostingServiceFormat	    ShipmentInformation.ServiceOptions.serviceFormat
    //string	PostingServiceLevel	        ShipmentInformation.ServiceOptions.serviceLevel
    //int	    PostingTotalPackages	    Calculated
    //double	PostingTotalWeight	        Calculated
    //string	PostingWeightUOM	        ShipmentInformation.weightUnitOfMeasure
    //string	PostingConsequentialLoss	ShipmentInformation.ServiceOptions.consequentialLoss
    //bool	    PostingLocalCollect	        ShipmentInformation.ServiceOptions.localCollect
    //string	PostingLocation	            ShipmentInformation.ServiceOptions.postingLocation
    //bool	    PostingRecordedSignedFor	ShipmentInformation.ServiceOptions.recordedSignedFor
    //bool	    PostingSaturdayGuaranteed	ShipmentInformation.ServiceOptions.saturdayGuaranteed
    //string	PostingTrackingNotifications	ShipmentInformation.ServiceOptions.trackingNotifications
    //int	    TotalItemCount  	        Calculated

    //// Item values
    //string	ItemId  	                Items.itemId
    //string	ItemDescription	            Items.description
    //int	    ItemParcelInstance	        Items.packageOccurrence
    //int	    ItemQuantity	            Items.quantity
    //double	ItemValue	                Items.valueData
    //double	ItemWeight	                Items.weight
    //string	ItemCountryOfOrigin	        Items.countryOfOrigin
    //string	ItemHsCode	                Items.hsCode
    //string	ItemSkuCode	                Items.skuCode
    //string	ItemImageUrl	            Item.imageUrl

    //// Parcel values
    //string	ParcelId	                Packages.packagingId
    //int	    ParcelInstance	            Packages.packageOccurrence
    //double	ParcelWeight	            Packages.weight
    //int	    ParcelHeight	            Packages.height
    //int	    ParcelLength	            Packages.length
    //int	    ParcelWidth	                Packages.width
}
