using CM.SendBrickCore.Interfaces.FunctionModules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CM.SendBrickCoreTests.FunctionModules.Orders
{
    static class SampleOrder1
    {
        #region SupplierValues
        public static string SupplierId
        {
            //Shipper.addressId
            get
            {
                return "bricksinbloom7308";
            }
        }
        public static string SupplierBusinessName
        {
            //Shipper.companyName
            get
            {
                return "Bricks In  Bloom";
            }
        }
        public static string SupplierContactName
        {
            //Shipper.contactName
            get
            {
                return "Leigha Middleton";
            }
        }
        public static int Department
        {
            //Shipper.shipperDepartment
            get
            {
                return 7308;
            }
        }
        public static string SupplierAddressLine1
        {
            //Shipper.addressLine1
            get
            {
                return "Unit 4";
            }
        }
        public static string SupplierAddressLine2
        {
            //Shipper.addressLine2
            get
            {
                return "Candy Works";
            }
        }
        public static string SupplierAddressLine3
        {
            //Shipper.addressLine3
            get
            {
                return "15 Parkhouse Road";
            }
        }
        public static string SupplierAddressLine4
        {
            //N/A
            get
            {
                return "";
            }
        }
        public static string SupplierAddressPostcode
        {
            //Shipper.postcode
            get
            {
                return "CA3 0JU";
            }
        }
        public static string SupplierAddressTown
        {
            //Shipper.town
            get
            {
                return "Carlisle";
            }
        }
        public static string SupplierAddressCounty
        {
            //Shipper.county
            get
            {
                return "Cumbria";
            }
        }
        public static string SupplierCountryCode
        {
            //Shipper.countryCode
            get
            {
                return "GB";
            }
        }
        public static string SupplierPhoneNumber
        {
            //Shipper.phoneNumber
            get
            {
                return "1228511030";
            }
        }
        public static string SupplierEmailAddress
        {
            //Shipper.emailAddress
            get
            {
                return "bricksinbloom@bricklink.com";
            }
        }
        public static string SupplierReference1
        {
            //Shipper.shipperReference
            get
            {
                return "7308";
            }
        }
        public static string SupplierReference2
        {
            //Shipper.shipperReference2
            get
            {
                return "BrickLink";
            }
        }
        public static string SupplierVatNumber
        {
            //Shipper.vatNumber
            get
            {
                return "GB123 4567 89";
            }
        }
        #endregion

        #region CustomerValues
        public static string CustomerId
        {
            //Destination.addressId
            get
            {
                return "BL15748250";
            }
        }
        public static string CustomerContactName
        {
            //Destination.contactName
            get
            {
                return "Colin Middleton";
            }
        }
        public static string CustomerBusinessName
        {
            //Destination.companyName
            get
            {
                return "";
            }
        }
        public static Int64 AddresseeIdentificationReferenceNumber
        {
            //CustomsInformation.addresseeIdentificationReferenceNumber
            get
            {
                return 1234567890;
            }
        }
        public static string CustomerAddressLine1
        {
            //Destination.addressLine1
            get
            {
                return "257 Ecclesall Road";
            }
        }
        public static string CustomerAddressLine2
        {
            //Destination.addressLine2
            get
            {
                return "";
            }
        }
        public static string CustomerAddressLine3
        {
            //Destination.addressLine3
            get
            {
                return "Sheffield";
            }
        }
        public static string CustomerAddressLine4
        {
            //N/A
            get
            {
                return "";
            }
        }
        public static string CustomerAddressTown
        {
            //Destination.town
            get
            {
                return "";
            }
        }
        public static string CustomerAddressCounty
        {
            //Destination.county
            get
            {
                return "South Yorkshire";
            }
        }
        public static string CustomerAddressPostcode
        {
            //Destination.postcode
            get
            {
                return "S5 7HJ";
            }
        }
        public static string CustomerCountryCode
        {
            //Destination.countryCode
            get
            {
                return "GB";
            }
        }
        public static string CustomerPhoneNumber
        {
            //Destination.phoneNumber
            get
            {
                return "7505363818";
            }
        }
        public static string CustomerEmailAddress
        {
            //Destination.emailAddress
            get
            {
                return "colin@test.com";
            }
        }
        public static string CustomerSafeplace
        {
            //ShipmentInformation.ServiceOptions.safeplace
            get
            {
                return "Front Porch";
            }
        }
        public static string CustomerVatNumber
        {
            //Destination.vatNumber
            get
            {
                return "";
            }
        }
        #endregion

        #region CustomsValues
        public static string CustomsCurrency
        {
            //ShipmentInformation.currency
            get
            {
                return "GBP";
            }
        }
        public static string CustomsDescriptionOfGoods
        {
            //ShipmentInformation.descriptionOfGoods
            get
            {
                return "LEGO sets";
            }
        }
        public static bool CustomsExportLicence
        {
            //CustomsInformation.exportLicence
            get
            {
                return false;
            }
        }
        public static string CustomsIncoterms
        {
            //ShipmentInformation.incoterms
            get
            {
                return "DDU";
            }
        }
        public static string CustomsInvoiceDate
        {
            //CustomsInformation.invoiceDate
            get
            {
                return "2022-01-16";
            }
        }
        public static string CustomsInvoiceNumber
        {
            //CustomsInformation.invoiceNumber (Int32)
            get
            {
                return "15748250";
            }
        }
        public static string CustomsLabelFormat
        {
            //ShipmentInformation.labelFormat
            get
            {
                return "PDF";
            }
        }
        public static double CustomsOtherCharges
        {
            //CustomsInformation.otherCharges
            get
            {
                return 0.00;
            }
        }
        public static string CustomsPreRegistrationNumber
        {
            //CustomsInformation.preRegistrationNumber
            get
            {
                return "GB15748250";
            }
        }
        public static string CustomsPreRegistrationType
        {
            //CustomsInformation.preRegistrationType
            get
            {
                return "EORI";
            }
        }
        public static string CustomsProduct
        {
            //ShipmentInformation.product
            get
            {
                return "LEGO";
            }
        }
        public static double CustomsQuotedLandedCost
        {
            //CustomsInformation.quotedLandedCost
            get
            {
                return 0.00;
            }
        }
        public static string CustomsReasonForExport
        {
            //ShipmentInformation.reasonForExport
            get
            {
                return "Sale of goods";
            }
        }
        public static string CustomsShipmentAction
        {
            //ShipmentInformation.shipmentAction
            get
            {
                return "Process";
            }
        }
        public static double CustomsShippingCharges
        {
            //CustomsInformation.shippingCharges
            get
            {
                return 10.42;
            }
        }
        public static string CustomsSilentPrintProfile
        {
            //ShipmentInformation.silentPrintProfile
            get
            {
                return "75b59db8-3cd3-4578-888e-54be016f07cc";
            }
        }
        public static double CustomsValue
        {
            //ShipmentInformation.value
            get
            {
                return 112.97;
            }
        }
        #endregion

        #region PostageValues
        public static string PostageType
        {
            //ShipmentInformation.serviceCode
            get
            {
                return "TPLN";
            }
        }
        public static string PostingDate
        {
            //ShipmentInformation.shipmentDate
            get
            {
                return "2022-01-16";
            }
        }
        public static string PostingServiceFormat
        {
            //ShipmentInformation.ServiceOptions.serviceFormat
            get
            {
                return "P";
            }
        }
        public static string PostingServiceLevel
        {
            //ShipmentInformation.ServiceOptions.serviceLevel
            get
            {
                return "01";
            }
        }
        public static int PostingTotalPackages
        {
            //Calculated
            get
            {
                return 2;
            }
        }
        public static double PostingTotalWeight
        {
            //Calculated
            get
            {
                return 3.1;
            }
        }
        public static string PostingWeightUOM
        {
            //ShipmentInformation.weightUnitOfMeasure
            get
            {
                return "KG";
            }
        }
        public static string PostingConsequentialLoss
        {
            //ShipmentInformation.ServiceOptions.consequentialLoss
            get
            {
                return "Level5";
            }
        }
        public static bool PostingLocalCollect
        {
            //ShipmentInformation.ServiceOptions.localCollect
            get
            {
                return false;
            }
        }
        public static string PostingLocation
        {
            //ShipmentInformation.ServiceOptions.postingLocation
            get
            {
                return "123456789";
            }
        }
        public static bool PostingRecordedSignedFor
        {
            //ShipmentInformation.ServiceOptions.recordedSignedFor
            get
            {
                return false;
            }
        }
        public static bool PostingSaturdayGuaranteed
        {
            //ShipmentInformation.ServiceOptions.saturdayGuaranteed
            get
            {
                return false;
            }
        }
        public static string PostingTrackingNotifications
        {
            //ShipmentInformation.ServiceOptions.trackingNotifications
            get
            {
                return "EmailAndSMS";
            }
        }
        public static int TotalItemCount
        {
            //Calculated
            get
            {
                return 3;
            }
        }
        #endregion

        #region Item1Values
        public static string Item1Id
        {
            //Items.itemId
            get
            {
                return "10782";
            }
        }
        public static string Item1Description
        {
            //Items.description
            get
            {
                return "Hulk vs. Rhino Truck Showdown";
            }
        }
        public static int Item1ParcelInstance
        {
            //Items.packageOccurrence
            get
            {
                return 2;
            }
        }
        public static int Item1Quantity
        {
            //Items.quantity
            get
            {
                return 1;
            }
        }
        public static double Item1Value
        {
            //Items.valueData
            get
            {
                return 17.99;
            }
        }
        public static double Item1Weight
        {
            //Items.weight
            get
            {
                return 0.9;
            }
        }
        public static string Item1CountryOfOrigin
        {
            //Items.countryOfOrigin
            get
            {
                return "GB";
            }
        }
        public static string Item1HsCode
        {
            //Items.hsCode
            get
            {
                return "652534";
            }
        }
        public static string Item1SkuCode
        {
            //Items.skuCode
            get
            {
                return "SKU3455692";
            }
        }
        public static string Item1ImageUrl
        {
            //Item.imageUrl
            get
            {
                return "https://images.brickset.com/sets/large/10782-1.jpg?202109211242";
            }
        }
        #endregion

        #region Item2Values
        public static string Item2Id
        {
            //Items.itemId
            get
            {
                return "76205";
            }
        }
        public static string Item2Description
        {
            //Items.description
            get
            {
                return "Gargantos Showdown";
            }
        }
        public static int Item2ParcelInstance
        {
            //Items.packageOccurrence
            get
            {
                return 1;
            }
        }
        public static int Item2Quantity
        {
            //Items.quantity
            get
            {
                return 1;
            }
        }
        public static double Item2Value
        {
            //Items.valueData
            get
            {
                return 24.99;
            }
        }
        public static double Item2Weight
        {
            //Items.weight
            get
            {
                return 1.0;
            }
        }
        public static string Item2CountryOfOrigin
        {
            //Items.countryOfOrigin
            get
            {
                return "GB";
            }
        }
        public static string Item2HsCode
        {
            //Items.hsCode
            get
            {
                return "652584";
            }
        }
        public static string Item2SkuCode
        {
            //Items.skuCode
            get
            {
                return "SKU3455682";
            }
        }
        public static string Item2ImageUrl
        {
            //Item.imageUrl
            get
            {
                return "https://images.brickset.com/sets/images/76205-1.jpg?202109211239";
            }
        }
        #endregion

        #region Item3Values
        public static string Item3Id
        {
            //Items.itemId
            get
            {
                return "76175";
            }
        }
        public static string Item3Description
        {
            //Items.description
            get
            {
                return "Attack on the Spider Lair";
            }
        }
        public static int Item3ParcelInstance
        {
            //Items.packageOccurrence
            get
            {
                return 1;
            }
        }
        public static int Item3Quantity
        {
            //Items.quantity
            get
            {
                return 1;
            }
        }
        public static double Item3Value
        {
            //Items.valueData
            get
            {
                return 69.99;
            }
        }
        public static double Item3Weight
        {
            //Items.weight
            get
            {
                return 1.2;
            }
        }
        public static string Item3CountryOfOrigin
        {
            //Items.countryOfOrigin
            get
            {
                return "CN";
            }
        }
        public static string Item3HsCode
        {
            //Items.hsCode
            get
            {
                return "659534";
            }
        }
        public static string Item3SkuCode
        {
            //Items.skuCode
            get
            {
                return "SKU3499692";
            }
        }
        public static string Item3ImageUrl
        {
            //Item.imageUrl
            get
            {
                return "https://images.brickset.com/sets/images/76175-1.jpg?202009170531";
            }
        }
        #endregion

        #region Parcel1Values
        public static string Parcel1Id
        {
            //Packages.packagingId
            get
            {
                return "17968198-1";
            }
        }
        public static int Parcel1Instance
        {
            //Packages.packageOccurrence
            get
            {
                return 1;
            }
        }
        public static double Parcel1Weight
        {
            //Packages.weight
            get
            {
                return 2.2;
            }
        }
        public static int Parcel1Height
        {
            //Packages.height
            get
            {
                return 5;
            }
        }
        public static int Parcel1Length
        {
            //Packages.length
            get
            {
                return 15;
            }
        }
        public static int Parcel1Width
        {
            //Packages.width
            get
            {
                return 15;
            }
        }
        #endregion

        #region Parcel2Values
        public static string Parcel2Id
        {
            //Packages.packagingId
            get
            {
                return "17968198-2";
            }
        }
        public static int Parcel2Instance
        {
            //Packages.packageOccurrence
            get
            {
                return 2;
            }
        }
        public static double Parcel2Weight
        {
            //Packages.weight
            get
            {
                return 0.9;
            }
        }
        public static int Parcel2Height
        {
            //Packages.height
            get
            {
                return 3;
            }
        }
        public static int Parcel2Length
        {
            //Packages.length
            get
            {
                return 45;
            }
        }
        public static int Parcel2Width
        {
            //Packages.width
            get
            {
                return 10;
            }
        }
        #endregion

        /// <summary>
        /// Populate an order object with all the values for this Sample.
        /// </summary>
        /// <param name="inpOrder">Order object to be populated</param>
        /// <returns>Populated order object</returns>
        public static IOrderData PopulateOrder(IOrderData inpOrder)
        {
            inpOrder.AddresseeIdentificationReferenceNumber = SampleOrder1.AddresseeIdentificationReferenceNumber;
            inpOrder.CustomerAddressCounty = SampleOrder1.CustomerAddressCounty;
            inpOrder.CustomerAddressLine1 = SampleOrder1.CustomerAddressLine1;
            inpOrder.CustomerAddressLine2 = SampleOrder1.CustomerAddressLine2;
            inpOrder.CustomerAddressLine3 = SampleOrder1.CustomerAddressLine3;
            inpOrder.CustomerAddressLine4 = SampleOrder1.CustomerAddressLine4;
            inpOrder.CustomerAddressPostcode = SampleOrder1.CustomerAddressPostcode;
            inpOrder.CustomerAddressTown = SampleOrder1.CustomerAddressTown;
            inpOrder.CustomerBusinessName = SampleOrder1.CustomerBusinessName;
            inpOrder.CustomerContactName = SampleOrder1.CustomerContactName;
            inpOrder.CustomerCountryCode = SampleOrder1.CustomerCountryCode;
            inpOrder.CustomerEmailAddress = SampleOrder1.CustomerEmailAddress;
            inpOrder.CustomerId = SampleOrder1.CustomerId;
            inpOrder.CustomerPhoneNumber = SampleOrder1.CustomerPhoneNumber;
            inpOrder.CustomerSafeplace = SampleOrder1.CustomerSafeplace;
            inpOrder.CustomerVatNumber = SampleOrder1.CustomerVatNumber;
            inpOrder.CustomsCurrency = SampleOrder1.CustomsCurrency;
            inpOrder.CustomsDescriptionOfGoods = SampleOrder1.CustomsDescriptionOfGoods;
            inpOrder.CustomsExportLicence = SampleOrder1.CustomsExportLicence;
            inpOrder.CustomsIncoterms = SampleOrder1.CustomsIncoterms;
            inpOrder.CustomsInvoiceDate = Convert.ToDateTime(SampleOrder1.CustomsInvoiceDate);
            inpOrder.CustomsInvoiceNumber = SampleOrder1.CustomsInvoiceNumber;
            inpOrder.CustomsLabelFormat = SampleOrder1.CustomsLabelFormat;
            inpOrder.CustomsOtherCharges = SampleOrder1.CustomsOtherCharges;
            inpOrder.CustomsPreRegistrationNumber = SampleOrder1.CustomsPreRegistrationNumber;
            inpOrder.CustomsPreRegistrationType = SampleOrder1.CustomsPreRegistrationType;
            inpOrder.CustomsProduct = SampleOrder1.CustomsProduct;
            inpOrder.CustomsQuotedLandedCost = SampleOrder1.CustomsQuotedLandedCost;
            inpOrder.CustomsReasonForExport = SampleOrder1.CustomsReasonForExport;
            inpOrder.CustomsShipmentAction = SampleOrder1.CustomsShipmentAction;
            inpOrder.CustomsShippingCharges = SampleOrder1.CustomsShippingCharges;
            inpOrder.CustomsSilentPrintProfile = SampleOrder1.CustomsSilentPrintProfile;
            inpOrder.CustomsValue = SampleOrder1.CustomsValue;
            inpOrder.Department = SampleOrder1.Department;
            inpOrder.PostageType = SampleOrder1.PostageType;
            inpOrder.PostingConsequentialLoss = SampleOrder1.PostingConsequentialLoss;
            inpOrder.PostingDate = Convert.ToDateTime(SampleOrder1.PostingDate);
            inpOrder.PostingLocalCollect = SampleOrder1.PostingLocalCollect;
            inpOrder.PostingLocation = SampleOrder1.PostingLocation;
            inpOrder.PostingRecordedSignedFor = SampleOrder1.PostingRecordedSignedFor;
            inpOrder.PostingSaturdayGuaranteed = SampleOrder1.PostingSaturdayGuaranteed;
            inpOrder.PostingServiceFormat = SampleOrder1.PostingServiceFormat;
            inpOrder.PostingServiceLevel = SampleOrder1.PostingServiceLevel;
            inpOrder.PostingTrackingNotifications = SampleOrder1.PostingTrackingNotifications;
            inpOrder.PostingWeightUOM = SampleOrder1.PostingWeightUOM;
            inpOrder.SupplierAddressCounty = SampleOrder1.SupplierAddressCounty;
            inpOrder.SupplierAddressLine1 = SampleOrder1.SupplierAddressLine1;
            inpOrder.SupplierAddressLine2 = SampleOrder1.SupplierAddressLine2;
            inpOrder.SupplierAddressLine3 = SampleOrder1.SupplierAddressLine3;
            inpOrder.SupplierAddressLine4 = SampleOrder1.SupplierAddressLine4;
            inpOrder.SupplierAddressPostcode = SampleOrder1.SupplierAddressPostcode;
            inpOrder.SupplierAddressTown = SampleOrder1.SupplierAddressTown;
            inpOrder.SupplierBusinessName = SampleOrder1.SupplierBusinessName;
            inpOrder.SupplierContactName = SampleOrder1.SupplierCountryCode;
            inpOrder.SupplierCountryCode = SampleOrder1.SupplierCountryCode;
            inpOrder.SupplierEmailAddress = SampleOrder1.SupplierEmailAddress;
            inpOrder.SupplierId = SampleOrder1.SupplierId;
            inpOrder.SupplierPhoneNumber = SampleOrder1.SupplierPhoneNumber;
            inpOrder.SupplierReference1 = SampleOrder1.SupplierReference1;
            inpOrder.SupplierReference2 = SampleOrder1.SupplierReference2;
            inpOrder.SupplierVatNumber = SampleOrder1.SupplierVatNumber;

            inpOrder.AddItem();
            inpOrder.ItemCountryOfOrigin = SampleOrder1.Item1CountryOfOrigin;
            inpOrder.ItemDescription = SampleOrder1.Item1Description;
            inpOrder.ItemHsCode = SampleOrder1.Item1HsCode;
            inpOrder.ItemId = SampleOrder1.Item1Id;
            inpOrder.ItemImageUrl = SampleOrder1.Item1ImageUrl;
            inpOrder.ItemParcelInstance = SampleOrder1.Item1ParcelInstance;
            inpOrder.ItemQuantity = SampleOrder1.Item1Quantity;
            inpOrder.ItemSkuCode = SampleOrder1.Item1SkuCode;
            inpOrder.ItemValue = SampleOrder1.Item1Value;
            inpOrder.ItemWeight = SampleOrder1.Item1Weight;

            inpOrder.AddItem();
            inpOrder.ItemCountryOfOrigin = SampleOrder1.Item2CountryOfOrigin;
            inpOrder.ItemDescription = SampleOrder1.Item2Description;
            inpOrder.ItemHsCode = SampleOrder1.Item2HsCode;
            inpOrder.ItemId = SampleOrder1.Item2Id;
            inpOrder.ItemImageUrl = SampleOrder1.Item2ImageUrl;
            inpOrder.ItemParcelInstance = SampleOrder1.Item2ParcelInstance;
            inpOrder.ItemQuantity = SampleOrder1.Item2Quantity;
            inpOrder.ItemSkuCode = SampleOrder1.Item2SkuCode;
            inpOrder.ItemValue = SampleOrder1.Item2Value;
            inpOrder.ItemWeight = SampleOrder1.Item2Weight;

            inpOrder.AddItem();
            inpOrder.ItemCountryOfOrigin = SampleOrder1.Item3CountryOfOrigin;
            inpOrder.ItemDescription = SampleOrder1.Item3Description;
            inpOrder.ItemHsCode = SampleOrder1.Item3HsCode;
            inpOrder.ItemId = SampleOrder1.Item3Id;
            inpOrder.ItemImageUrl = SampleOrder1.Item3ImageUrl;
            inpOrder.ItemParcelInstance = SampleOrder1.Item3ParcelInstance;
            inpOrder.ItemQuantity = SampleOrder1.Item3Quantity;
            inpOrder.ItemSkuCode = SampleOrder1.Item3SkuCode;
            inpOrder.ItemValue = SampleOrder1.Item3Value;
            inpOrder.ItemWeight = SampleOrder1.Item3Weight;

            inpOrder.AddParcel();
            inpOrder.ParcelHeight = SampleOrder1.Parcel1Height;
            inpOrder.ParcelId = SampleOrder1.Parcel1Id;
            inpOrder.ParcelInstance = SampleOrder1.Parcel1Instance;
            inpOrder.ParcelLength = SampleOrder1.Parcel1Length;
            inpOrder.ParcelWeight = SampleOrder1.Parcel1Weight;
            inpOrder.ParcelWidth = SampleOrder1.Parcel1Width;

            inpOrder.AddParcel();
            inpOrder.ParcelHeight = SampleOrder1.Parcel2Height;
            inpOrder.ParcelId = SampleOrder1.Parcel2Id;
            inpOrder.ParcelInstance = SampleOrder1.Parcel2Instance;
            inpOrder.ParcelLength = SampleOrder1.Parcel2Length;
            inpOrder.ParcelWeight = SampleOrder1.Parcel2Weight;
            inpOrder.ParcelWidth = SampleOrder1.Parcel2Width;

            return inpOrder;
        }
    }

    static class SampleOrder2
    {
        #region SupplierValues
        public static string SupplierId
        {
            //Shipper.addressId
            get
            {
                return "bricksinbloom7308";
            }
        }
        public static string SupplierBusinessName
        {
            //Shipper.companyName
            get
            {
                return "Bricks In  Bloom";
            }
        }
        public static string SupplierContactName
        {
            //Shipper.contactName
            get
            {
                return "Leigha Middleton";
            }
        }
        public static int Department
        {
            //Shipper.shipperDepartment
            get
            {
                return 7308;
            }
        }
        public static string SupplierAddressLine1
        {
            //Shipper.addressLine1
            get
            {
                return "Unit 5";
            }
        }
        public static string SupplierAddressLine2
        {
            //Shipper.addressLine2
            get
            {
                return "Candy Works";
            }
        }
        public static string SupplierAddressLine3
        {
            //Shipper.addressLine3
            get
            {
                return "15 Parkhouse Road";
            }
        }
        public static string SupplierAddressLine4
        {
            //N/A
            get
            {
                return "";
            }
        }
        public static string SupplierAddressPostcode
        {
            //Shipper.postcode
            get
            {
                return "CA3 0JU";
            }
        }
        public static string SupplierAddressTown
        {
            //Shipper.town
            get
            {
                return "Carlisle";
            }
        }
        public static string SupplierAddressCounty
        {
            //Shipper.county
            get
            {
                return "Cumbria";
            }
        }
        public static string SupplierCountryCode
        {
            //Shipper.countryCode
            get
            {
                return "GB";
            }
        }
        public static string SupplierPhoneNumber
        {
            //Shipper.phoneNumber
            get
            {
                return "1228511030";
            }
        }
        public static string SupplierEmailAddress
        {
            //Shipper.emailAddress
            get
            {
                return "bricksinbloom@bricklink.com";
            }
        }
        public static string SupplierReference1
        {
            //Shipper.shipperReference
            get
            {
                return "7308";
            }
        }
        public static string SupplierReference2
        {
            //Shipper.shipperReference2
            get
            {
                return "BrickLink";
            }
        }
        public static string SupplierVatNumber
        {
            //Shipper.vatNumber
            get
            {
                return "GB123 4567 89";
            }
        }
        #endregion

        #region CustomerValues
        public static string CustomerId
        {
            //Destination.addressId
            get
            {
                return "BL15748250";
            }
        }
        public static string CustomerContactName
        {
            //Destination.contactName
            get
            {
                return "Colin Middleton";
            }
        }
        public static string CustomerBusinessName
        {
            //Destination.companyName
            get
            {
                return "";
            }
        }
        public static Int64 AddresseeIdentificationReferenceNumber
        {
            //CustomsInformation.addresseeIdentificationReferenceNumber
            get
            {
                return 1234567890;
            }
        }
        public static string CustomerAddressLine1
        {
            //Destination.addressLine1
            get
            {
                return "257 Ecclesall Road";
            }
        }
        public static string CustomerAddressLine2
        {
            //Destination.addressLine2
            get
            {
                return "";
            }
        }
        public static string CustomerAddressLine3
        {
            //Destination.addressLine3
            get
            {
                return "";
            }
        }
        public static string CustomerAddressLine4
        {
            //N/A
            get
            {
                return "";
            }
        }
        public static string CustomerAddressTown
        {
            //Destination.town
            get
            {
                return "Sheffield";
            }
        }
        public static string CustomerAddressCounty
        {
            //Destination.county
            get
            {
                return "South Yorkshire";
            }
        }
        public static string CustomerAddressPostcode
        {
            //Destination.postcode
            get
            {
                return "S5 7HJ";
            }
        }
        public static string CustomerCountryCode
        {
            //Destination.countryCode
            get
            {
                return "GB";
            }
        }
        public static string CustomerPhoneNumber
        {
            //Destination.phoneNumber
            get
            {
                return "7505363818";
            }
        }
        public static string CustomerEmailAddress
        {
            //Destination.emailAddress
            get
            {
                return "colin@test.com";
            }
        }
        public static string CustomerSafeplace
        {
            //ShipmentInformation.ServiceOptions.safeplace
            get
            {
                return "Front Porch";
            }
        }
        public static string CustomerVatNumber
        {
            //Destination.vatNumber
            get
            {
                return "";
            }
        }
        #endregion

        #region CustomsValues
        public static string CustomsCurrency
        {
            //ShipmentInformation.currency
            get
            {
                return "GBP";
            }
        }
        public static string CustomsDescriptionOfGoods
        {
            //ShipmentInformation.descriptionOfGoods
            get
            {
                return "LEGO sets";
            }
        }
        public static bool CustomsExportLicence
        {
            //CustomsInformation.exportLicence
            get
            {
                return false;
            }
        }
        public static string CustomsIncoterms
        {
            //ShipmentInformation.incoterms
            get
            {
                return "DDU";
            }
        }
        public static string CustomsInvoiceDate
        {
            //CustomsInformation.invoiceDate
            get
            {
                return "2022-01-16";
            }
        }
        public static string CustomsInvoiceNumber
        {
            //CustomsInformation.invoiceNumber (Int32)
            get
            {
                return "15748251";
            }
        }
        public static string CustomsLabelFormat
        {
            //ShipmentInformation.labelFormat
            get
            {
                return "PDF";
            }
        }
        public static double CustomsOtherCharges
        {
            //CustomsInformation.otherCharges
            get
            {
                return 0.00;
            }
        }
        public static string CustomsPreRegistrationNumber
        {
            //CustomsInformation.preRegistrationNumber
            get
            {
                return "GB15748250";
            }
        }
        public static string CustomsPreRegistrationType
        {
            //CustomsInformation.preRegistrationType
            get
            {
                return "EORI";
            }
        }
        public static string CustomsProduct
        {
            //ShipmentInformation.product
            get
            {
                return "LEGO";
            }
        }
        public static double CustomsQuotedLandedCost
        {
            //CustomsInformation.quotedLandedCost
            get
            {
                return 0.00;
            }
        }
        public static string CustomsReasonForExport
        {
            //ShipmentInformation.reasonForExport
            get
            {
                return "Sale of goods";
            }
        }
        public static string CustomsShipmentAction
        {
            //ShipmentInformation.shipmentAction
            get
            {
                return "Process";
            }
        }
        public static double CustomsShippingCharges
        {
            //CustomsInformation.shippingCharges
            get
            {
                return 10.42;
            }
        }
        public static string CustomsSilentPrintProfile
        {
            //ShipmentInformation.silentPrintProfile
            get
            {
                return "75b59db8-3cd3-4578-888e-54be016f07cc";
            }
        }
        public static double CustomsValue
        {
            //ShipmentInformation.valueData
            get
            {
                return 112.97;
            }
        }
        #endregion

        #region PostageValues
        public static string PostageType
        {
            //ShipmentInformation.serviceCode
            get
            {
                return "TPLN";
            }
        }
        public static string PostingDate
        {
            //ShipmentInformation.shipmentDate
            get
            {
                return "2022-01-16";
            }
        }
        public static string PostingServiceFormat
        {
            //ShipmentInformation.ServiceOptions.serviceFormat
            get
            {
                return "P";
            }
        }
        public static string PostingServiceLevel
        {
            //ShipmentInformation.ServiceOptions.serviceLevel
            get
            {
                return "01";
            }
        }
        public static int PostingTotalPackages
        {
            //Calculated
            get
            {
                return 2;
            }
        }
        public static double PostingTotalWeight
        {
            //Calculated
            get
            {
                return 3.1;
            }
        }
        public static string PostingWeightUOM
        {
            //ShipmentInformation.weightUnitOfMeasure
            get
            {
                return "KG";
            }
        }
        public static string PostingConsequentialLoss
        {
            //ShipmentInformation.ServiceOptions.consequentialLoss
            get
            {
                return "Level5";
            }
        }
        public static bool PostingLocalCollect
        {
            //ShipmentInformation.ServiceOptions.localCollect
            get
            {
                return false;
            }
        }
        public static string PostingLocation
        {
            //ShipmentInformation.ServiceOptions.postingLocation
            get
            {
                return "123456789";
            }
        }
        public static bool PostingRecordedSignedFor
        {
            //ShipmentInformation.ServiceOptions.recordedSignedFor
            get
            {
                return false;
            }
        }
        public static bool PostingSaturdayGuaranteed
        {
            //ShipmentInformation.ServiceOptions.saturdayGuaranteed
            get
            {
                return false;
            }
        }
        public static string PostingTrackingNotifications
        {
            //ShipmentInformation.ServiceOptions.trackingNotifications
            get
            {
                return "EmailAndSMS";
            }
        }
        public static int TotalItemCount
        {
            //Calculated
            get
            {
                return 3;
            }
        }
        #endregion

        #region Item1Values
        public static string Item1Id
        {
            //Items.itemId
            get
            {
                return "10782";
            }
        }
        public static string Item1Description
        {
            //Items.description
            get
            {
                return "Hulk vs. Rhino Truck Showdown";
            }
        }
        public static int Item1ParcelInstance
        {
            //Items.packageOccurrence
            get
            {
                return 2;
            }
        }
        public static int Item1Quantity
        {
            //Items.quantity
            get
            {
                return 1;
            }
        }
        public static double Item1Value
        {
            //Items.valueData
            get
            {
                return 17.99;
            }
        }
        public static double Item1Weight
        {
            //Items.weight
            get
            {
                return 0.9;
            }
        }
        public static string Item1CountryOfOrigin
        {
            //Items.countryOfOrigin
            get
            {
                return "GB";
            }
        }
        public static string Item1HsCode
        {
            //Items.hsCode
            get
            {
                return "652534";
            }
        }
        public static string Item1SkuCode
        {
            //Items.skuCode
            get
            {
                return "SKU3455692";
            }
        }
        public static string Item1ImageUrl
        {
            //Item.imageUrl
            get
            {
                return "https://images.brickset.com/sets/large/10782-1.jpg?202109211242";
            }
        }
        #endregion

        #region Item2Values
        public static string Item2Id
        {
            //Items.itemId
            get
            {
                return "76205";
            }
        }
        public static string Item2Description
        {
            //Items.description
            get
            {
                return "Gargantos Showdown";
            }
        }
        public static int Item2ParcelInstance
        {
            //Items.packageOccurrence
            get
            {
                return 1;
            }
        }
        public static int Item2Quantity
        {
            //Items.quantity
            get
            {
                return 1;
            }
        }
        public static double Item2Value
        {
            //Items.valueData
            get
            {
                return 24.99;
            }
        }
        public static double Item2Weight
        {
            //Items.weight
            get
            {
                return 1.0;
            }
        }
        public static string Item2CountryOfOrigin
        {
            //Items.countryOfOrigin
            get
            {
                return "GB";
            }
        }
        public static string Item2HsCode
        {
            //Items.hsCode
            get
            {
                return "652584";
            }
        }
        public static string Item2SkuCode
        {
            //Items.skuCode
            get
            {
                return "SKU3455682";
            }
        }
        public static string Item2ImageUrl
        {
            //Item.imageUrl
            get
            {
                return "https://images.brickset.com/sets/images/76205-1.jpg?202109211239";
            }
        }
        #endregion

        #region Item3Values
        public static string Item3Id
        {
            //Items.itemId
            get
            {
                return "76175";
            }
        }
        public static string Item3Description
        {
            //Items.description
            get
            {
                return "Attack on the Spider Lair";
            }
        }
        public static int Item3ParcelInstance
        {
            //Items.packageOccurrence
            get
            {
                return 1;
            }
        }
        public static int Item3Quantity
        {
            //Items.quantity
            get
            {
                return 1;
            }
        }
        public static double Item3Value
        {
            //Items.valueData
            get
            {
                return 69.99;
            }
        }
        public static double Item3Weight
        {
            //Items.weight
            get
            {
                return 1.2;
            }
        }
        public static string Item3CountryOfOrigin
        {
            //Items.countryOfOrigin
            get
            {
                return "CN";
            }
        }
        public static string Item3HsCode
        {
            //Items.hsCode
            get
            {
                return "659534";
            }
        }
        public static string Item3SkuCode
        {
            //Items.skuCode
            get
            {
                return "SKU3499692";
            }
        }
        public static string Item3ImageUrl
        {
            //Item.imageUrl
            get
            {
                return "https://images.brickset.com/sets/images/76175-1.jpg?202009170531";
            }
        }
        #endregion

        #region Parcel1Values
        public static string Parcel1Id
        {
            //Packages.packagingId
            get
            {
                return "17968198-1";
            }
        }
        public static int Parcel1Instance
        {
            //Packages.packageOccurrence
            get
            {
                return 1;
            }
        }
        public static double Parcel1Weight
        {
            //Packages.weight
            get
            {
                return 2.2;
            }
        }
        public static int Parcel1Height
        {
            //Packages.height
            get
            {
                return 5;
            }
        }
        public static int Parcel1Length
        {
            //Packages.length
            get
            {
                return 15;
            }
        }
        public static int Parcel1Width
        {
            //Packages.width
            get
            {
                return 15;
            }
        }
        #endregion

        #region Parcel2Values
        public static string Parcel2Id
        {
            //Packages.packagingId
            get
            {
                return "17968198-2";
            }
        }
        public static int Parcel2Instance
        {
            //Packages.packageOccurrence
            get
            {
                return 2;
            }
        }
        public static double Parcel2Weight
        {
            //Packages.weight
            get
            {
                return 0.9;
            }
        }
        public static int Parcel2Height
        {
            //Packages.height
            get
            {
                return 3;
            }
        }
        public static int Parcel2Length
        {
            //Packages.length
            get
            {
                return 45;
            }
        }
        public static int Parcel2Width
        {
            //Packages.width
            get
            {
                return 10;
            }
        }
        #endregion

        /// <summary>
        /// Populate an order object with all the values for this Sample.
        /// </summary>
        /// <param name="inpOrder">Order object to be populated</param>
        /// <returns>Populated order object</returns>
        public static IOrderData PopulateOrder(IOrderData inpOrder)
        {
            inpOrder.AddresseeIdentificationReferenceNumber = SampleOrder2.AddresseeIdentificationReferenceNumber;
            inpOrder.CustomerAddressCounty = SampleOrder2.CustomerAddressCounty;
            inpOrder.CustomerAddressLine1 = SampleOrder2.CustomerAddressLine1;
            inpOrder.CustomerAddressLine2 = SampleOrder2.CustomerAddressLine2;
            inpOrder.CustomerAddressLine3 = SampleOrder2.CustomerAddressLine3;
            inpOrder.CustomerAddressLine4 = SampleOrder2.CustomerAddressLine4;
            inpOrder.CustomerAddressPostcode = SampleOrder2.CustomerAddressPostcode;
            inpOrder.CustomerAddressTown = SampleOrder2.CustomerAddressTown;
            inpOrder.CustomerBusinessName = SampleOrder2.CustomerBusinessName;
            inpOrder.CustomerContactName = SampleOrder2.CustomerContactName;
            inpOrder.CustomerCountryCode = SampleOrder2.CustomerCountryCode;
            inpOrder.CustomerEmailAddress = SampleOrder2.CustomerEmailAddress;
            inpOrder.CustomerId = SampleOrder2.CustomerId;
            inpOrder.CustomerPhoneNumber = SampleOrder2.CustomerPhoneNumber;
            inpOrder.CustomerSafeplace = SampleOrder2.CustomerSafeplace;
            inpOrder.CustomerVatNumber = SampleOrder2.CustomerVatNumber;
            inpOrder.CustomsCurrency = SampleOrder2.CustomsCurrency;
            inpOrder.CustomsDescriptionOfGoods = SampleOrder2.CustomsDescriptionOfGoods;
            inpOrder.CustomsExportLicence = SampleOrder2.CustomsExportLicence;
            inpOrder.CustomsIncoterms = SampleOrder2.CustomsIncoterms;
            inpOrder.CustomsInvoiceDate = Convert.ToDateTime(SampleOrder2.CustomsInvoiceDate);
            inpOrder.CustomsInvoiceNumber = SampleOrder2.CustomsInvoiceNumber;
            inpOrder.CustomsLabelFormat = SampleOrder2.CustomsLabelFormat;
            inpOrder.CustomsOtherCharges = SampleOrder2.CustomsOtherCharges;
            inpOrder.CustomsPreRegistrationNumber = SampleOrder2.CustomsPreRegistrationNumber;
            inpOrder.CustomsPreRegistrationType = SampleOrder2.CustomsPreRegistrationType;
            inpOrder.CustomsProduct = SampleOrder2.CustomsProduct;
            inpOrder.CustomsQuotedLandedCost = SampleOrder2.CustomsQuotedLandedCost;
            inpOrder.CustomsReasonForExport = SampleOrder2.CustomsReasonForExport;
            inpOrder.CustomsShipmentAction = SampleOrder2.CustomsShipmentAction;
            inpOrder.CustomsShippingCharges = SampleOrder2.CustomsShippingCharges;
            inpOrder.CustomsSilentPrintProfile = SampleOrder2.CustomsSilentPrintProfile;
            inpOrder.CustomsValue = SampleOrder2.CustomsValue;
            inpOrder.Department = SampleOrder2.Department;
            inpOrder.PostageType = SampleOrder2.PostageType;
            inpOrder.PostingConsequentialLoss = SampleOrder2.PostingConsequentialLoss;
            inpOrder.PostingDate = Convert.ToDateTime(SampleOrder2.PostingDate);
            inpOrder.PostingLocalCollect = SampleOrder2.PostingLocalCollect;
            inpOrder.PostingLocation = SampleOrder2.PostingLocation;
            inpOrder.PostingRecordedSignedFor = SampleOrder2.PostingRecordedSignedFor;
            inpOrder.PostingSaturdayGuaranteed = SampleOrder2.PostingSaturdayGuaranteed;
            inpOrder.PostingServiceFormat = SampleOrder2.PostingServiceFormat;
            inpOrder.PostingServiceLevel = SampleOrder2.PostingServiceLevel;
            inpOrder.PostingTrackingNotifications = SampleOrder2.PostingTrackingNotifications;
            inpOrder.PostingWeightUOM = SampleOrder2.PostingWeightUOM;
            inpOrder.SupplierAddressCounty = SampleOrder2.SupplierAddressCounty;
            inpOrder.SupplierAddressLine1 = SampleOrder2.SupplierAddressLine1;
            inpOrder.SupplierAddressLine2 = SampleOrder2.SupplierAddressLine2;
            inpOrder.SupplierAddressLine3 = SampleOrder2.SupplierAddressLine3;
            inpOrder.SupplierAddressLine4 = SampleOrder2.SupplierAddressLine4;
            inpOrder.SupplierAddressPostcode = SampleOrder2.SupplierAddressPostcode;
            inpOrder.SupplierAddressTown = SampleOrder2.SupplierAddressTown;
            inpOrder.SupplierBusinessName = SampleOrder2.SupplierBusinessName;
            inpOrder.SupplierContactName = SampleOrder2.SupplierCountryCode;
            inpOrder.SupplierCountryCode = SampleOrder2.SupplierCountryCode;
            inpOrder.SupplierEmailAddress = SampleOrder2.SupplierEmailAddress;
            inpOrder.SupplierId = SampleOrder2.SupplierId;
            inpOrder.SupplierPhoneNumber = SampleOrder2.SupplierPhoneNumber;
            inpOrder.SupplierReference1 = SampleOrder2.SupplierReference1;
            inpOrder.SupplierReference2 = SampleOrder2.SupplierReference2;
            inpOrder.SupplierVatNumber = SampleOrder2.SupplierVatNumber;

            inpOrder.AddItem();
            inpOrder.ItemCountryOfOrigin = SampleOrder2.Item1CountryOfOrigin;
            inpOrder.ItemDescription = SampleOrder2.Item1Description;
            inpOrder.ItemHsCode = SampleOrder2.Item1HsCode;
            inpOrder.ItemId = SampleOrder2.Item1Id;
            inpOrder.ItemImageUrl = SampleOrder2.Item1ImageUrl;
            inpOrder.ItemParcelInstance = SampleOrder2.Item1ParcelInstance;
            inpOrder.ItemQuantity = SampleOrder2.Item1Quantity;
            inpOrder.ItemSkuCode = SampleOrder2.Item1SkuCode;
            inpOrder.ItemValue = SampleOrder2.Item1Value;
            inpOrder.ItemWeight = SampleOrder2.Item1Weight;

            inpOrder.AddItem();
            inpOrder.ItemCountryOfOrigin = SampleOrder2.Item2CountryOfOrigin;
            inpOrder.ItemDescription = SampleOrder2.Item2Description;
            inpOrder.ItemHsCode = SampleOrder2.Item2HsCode;
            inpOrder.ItemId = SampleOrder2.Item2Id;
            inpOrder.ItemImageUrl = SampleOrder2.Item2ImageUrl;
            inpOrder.ItemParcelInstance = SampleOrder2.Item2ParcelInstance;
            inpOrder.ItemQuantity = SampleOrder2.Item2Quantity;
            inpOrder.ItemSkuCode = SampleOrder2.Item2SkuCode;
            inpOrder.ItemValue = SampleOrder2.Item2Value;
            inpOrder.ItemWeight = SampleOrder2.Item2Weight;

            inpOrder.AddItem();
            inpOrder.ItemCountryOfOrigin = SampleOrder2.Item3CountryOfOrigin;
            inpOrder.ItemDescription = SampleOrder2.Item3Description;
            inpOrder.ItemHsCode = SampleOrder2.Item3HsCode;
            inpOrder.ItemId = SampleOrder2.Item3Id;
            inpOrder.ItemImageUrl = SampleOrder2.Item3ImageUrl;
            inpOrder.ItemParcelInstance = SampleOrder2.Item3ParcelInstance;
            inpOrder.ItemQuantity = SampleOrder2.Item3Quantity;
            inpOrder.ItemSkuCode = SampleOrder2.Item3SkuCode;
            inpOrder.ItemValue = SampleOrder2.Item3Value;
            inpOrder.ItemWeight = SampleOrder2.Item3Weight;

            inpOrder.AddParcel();
            inpOrder.ParcelHeight = SampleOrder2.Parcel1Height;
            inpOrder.ParcelId = SampleOrder2.Parcel1Id;
            inpOrder.ParcelInstance = SampleOrder2.Parcel1Instance;
            inpOrder.ParcelLength = SampleOrder2.Parcel1Length;
            inpOrder.ParcelWeight = SampleOrder2.Parcel1Weight;
            inpOrder.ParcelWidth = SampleOrder2.Parcel1Width;

            inpOrder.AddParcel();
            inpOrder.ParcelHeight = SampleOrder2.Parcel2Height;
            inpOrder.ParcelId = SampleOrder2.Parcel2Id;
            inpOrder.ParcelInstance = SampleOrder2.Parcel2Instance;
            inpOrder.ParcelLength = SampleOrder2.Parcel2Length;
            inpOrder.ParcelWeight = SampleOrder2.Parcel2Weight;
            inpOrder.ParcelWidth = SampleOrder2.Parcel2Width;

            return inpOrder;
        }
    }

    static class SampleOrder3
    {
        #region SupplierValues
        public static string SupplierId
        {
            //Shipper.addressId
            get
            {
                return "bricksinbloom7308";
            }
        }
        public static string SupplierBusinessName
        {
            //Shipper.companyName
            get
            {
                return "BrickLane";
            }
        }
        public static string SupplierContactName
        {
            //Shipper.contactName
            get
            {
                return "Leigha Middleton";
            }
        }
        public static int Department
        {
            //Shipper.shipperDepartment
            get
            {
                return 7308;
            }
        }
        public static string SupplierAddressLine1
        {
            //Shipper.addressLine1
            get
            {
                return "Unit 4";
            }
        }
        public static string SupplierAddressLine2
        {
            //Shipper.addressLine2
            get
            {
                return "Candy Works";
            }
        }
        public static string SupplierAddressLine3
        {
            //Shipper.addressLine3
            get
            {
                return "15 Parkhouse Road";
            }
        }
        public static string SupplierAddressLine4
        {
            //N/A
            get
            {
                return "";
            }
        }
        public static string SupplierAddressPostcode
        {
            //Shipper.postcode
            get
            {
                return "CA3 0JU";
            }
        }
        public static string SupplierAddressTown
        {
            //Shipper.town
            get
            {
                return "Carlisle";
            }
        }
        public static string SupplierAddressCounty
        {
            //Shipper.county
            get
            {
                return "Cumbria";
            }
        }
        public static string SupplierCountryCode
        {
            //Shipper.countryCode
            get
            {
                return "GB";
            }
        }
        public static string SupplierPhoneNumber
        {
            //Shipper.phoneNumber
            get
            {
                return "1228511030";
            }
        }
        public static string SupplierEmailAddress
        {
            //Shipper.emailAddress
            get
            {
                return "bricksinbloom@bricklink.com";
            }
        }
        public static string SupplierReference1
        {
            //Shipper.shipperReference
            get
            {
                return "7308";
            }
        }
        public static string SupplierReference2
        {
            //Shipper.shipperReference2
            get
            {
                return "BrickLink";
            }
        }
        public static string SupplierVatNumber
        {
            //Shipper.vatNumber
            get
            {
                return "GB123 4567 89";
            }
        }
        #endregion

        #region CustomerValues
        public static string CustomerId
        {
            //Destination.addressId
            get
            {
                return "BL15748250";
            }
        }
        public static string CustomerContactName
        {
            //Destination.contactName
            get
            {
                return "Bad Bob";
            }
        }
        public static string CustomerBusinessName
        {
            //Destination.companyName
            get
            {
                return "";
            }
        }
        public static Int64 AddresseeIdentificationReferenceNumber
        {
            //CustomsInformation.addresseeIdentificationReferenceNumber
            get
            {
                return 1234567890;
            }
        }
        public static string CustomerAddressLine1
        {
            //Destination.addressLine1
            get
            {
                return "257 Ecclesall Road";
            }
        }
        public static string CustomerAddressLine2
        {
            //Destination.addressLine2
            get
            {
                return "";
            }
        }
        public static string CustomerAddressLine3
        {
            //Destination.addressLine3
            get
            {
                return "";
            }
        }
        public static string CustomerAddressLine4
        {
            //N/A
            get
            {
                return "";
            }
        }
        public static string CustomerAddressTown
        {
            //Destination.town
            get
            {
                return "Sheffield";
            }
        }
        public static string CustomerAddressCounty
        {
            //Destination.county
            get
            {
                return "South Yorkshire";
            }
        }
        public static string CustomerAddressPostcode
        {
            //Destination.postcode
            get
            {
                return "S5 7HJ";
            }
        }
        public static string CustomerCountryCode
        {
            //Destination.countryCode
            get
            {
                return "GB";
            }
        }
        public static string CustomerPhoneNumber
        {
            //Destination.phoneNumber
            get
            {
                return "7505363818";
            }
        }
        public static string CustomerEmailAddress
        {
            //Destination.emailAddress
            get
            {
                return "colin@test.com";
            }
        }
        public static string CustomerSafeplace
        {
            //ShipmentInformation.ServiceOptions.safeplace
            get
            {
                return "Front Porch";
            }
        }
        public static string CustomerVatNumber
        {
            //Destination.vatNumber
            get
            {
                return "";
            }
        }
        #endregion

        #region CustomsValues
        public static string CustomsCurrency
        {
            //ShipmentInformation.currency
            get
            {
                return "GBP";
            }
        }
        public static string CustomsDescriptionOfGoods
        {
            //ShipmentInformation.descriptionOfGoods
            get
            {
                return "LEGO bricks";
            }
        }
        public static bool CustomsExportLicence
        {
            //CustomsInformation.exportLicence
            get
            {
                return false;
            }
        }
        public static string CustomsIncoterms
        {
            //ShipmentInformation.incoterms
            get
            {
                return "DDU";
            }
        }
        public static string CustomsInvoiceDate
        {
            //CustomsInformation.invoiceDate
            get
            {
                return "2022-01-16";
            }
        }
        public static string CustomsInvoiceNumber
        {
            //CustomsInformation.invoiceNumber (Int32)
            get
            {
                return "15748255";
            }
        }
        public static string CustomsLabelFormat
        {
            //ShipmentInformation.labelFormat
            get
            {
                return "PDF";
            }
        }
        public static double CustomsOtherCharges
        {
            //CustomsInformation.otherCharges
            get
            {
                return 0.00;
            }
        }
        public static string CustomsPreRegistrationNumber
        {
            //CustomsInformation.preRegistrationNumber
            get
            {
                return "GB15748250";
            }
        }
        public static string CustomsPreRegistrationType
        {
            //CustomsInformation.preRegistrationType
            get
            {
                return "EORI";
            }
        }
        public static string CustomsProduct
        {
            //ShipmentInformation.product
            get
            {
                return "LEGO";
            }
        }
        public static double CustomsQuotedLandedCost
        {
            //CustomsInformation.quotedLandedCost
            get
            {
                return 0.00;
            }
        }
        public static string CustomsReasonForExport
        {
            //ShipmentInformation.reasonForExport
            get
            {
                return "Sale of goods";
            }
        }
        public static string CustomsShipmentAction
        {
            //ShipmentInformation.shipmentAction
            get
            {
                return "Process";
            }
        }
        public static double CustomsShippingCharges
        {
            //CustomsInformation.shippingCharges
            get
            {
                return 12.44;
            }
        }
        public static string CustomsSilentPrintProfile
        {
            //ShipmentInformation.silentPrintProfile
            get
            {
                return "75b59db8-3cd3-4578-888e-54be016f07cc";
            }
        }
        public static double CustomsValue
        {
            //ShipmentInformation.valueData
            get
            {
                return 112.97;
            }
        }
        #endregion

        #region PostageValues
        public static string PostageType
        {
            //ShipmentInformation.serviceCode
            get
            {
                return "TPLN";
            }
        }
        public static string PostingDate
        {
            //ShipmentInformation.shipmentDate
            get
            {
                return "2022-01-16";
            }
        }
        public static string PostingServiceFormat
        {
            //ShipmentInformation.ServiceOptions.serviceFormat
            get
            {
                return "P";
            }
        }
        public static string PostingServiceLevel
        {
            //ShipmentInformation.ServiceOptions.serviceLevel
            get
            {
                return "01";
            }
        }
        public static int PostingTotalPackages
        {
            //Calculated
            get
            {
                return 2;
            }
        }
        public static double PostingTotalWeight
        {
            //Calculated
            get
            {
                return 3.1;
            }
        }
        public static string PostingWeightUOM
        {
            //ShipmentInformation.weightUnitOfMeasure
            get
            {
                return "KG";
            }
        }
        public static string PostingConsequentialLoss
        {
            //ShipmentInformation.ServiceOptions.consequentialLoss
            get
            {
                return "Level5";
            }
        }
        public static bool PostingLocalCollect
        {
            //ShipmentInformation.ServiceOptions.localCollect
            get
            {
                return false;
            }
        }
        public static string PostingLocation
        {
            //ShipmentInformation.ServiceOptions.postingLocation
            get
            {
                return "123456789";
            }
        }
        public static bool PostingRecordedSignedFor
        {
            //ShipmentInformation.ServiceOptions.recordedSignedFor
            get
            {
                return false;
            }
        }
        public static bool PostingSaturdayGuaranteed
        {
            //ShipmentInformation.ServiceOptions.saturdayGuaranteed
            get
            {
                return true;
            }
        }
        public static string PostingTrackingNotifications
        {
            //ShipmentInformation.ServiceOptions.trackingNotifications
            get
            {
                return "EmailAndSMS";
            }
        }
        public static int TotalItemCount
        {
            //Calculated
            get
            {
                return 4;
            }
        }
        #endregion

        #region Item1Values
        public static string Item1Id
        {
            //Items.itemId
            get
            {
                return "10782";
            }
        }
        public static string Item1Description
        {
            //Items.description
            get
            {
                return "Hulk vs. Rhino Truck Showdown";
            }
        }
        public static int Item1ParcelInstance
        {
            //Items.packageOccurrence
            get
            {
                return 2;
            }
        }
        public static int Item1Quantity
        {
            //Items.quantity
            get
            {
                return 1;
            }
        }
        public static double Item1Value
        {
            //Items.valueData
            get
            {
                return 17.99;
            }
        }
        public static double Item1Weight
        {
            //Items.weight
            get
            {
                return 0.9;
            }
        }
        public static string Item1CountryOfOrigin
        {
            //Items.countryOfOrigin
            get
            {
                return "GB";
            }
        }
        public static string Item1HsCode
        {
            //Items.hsCode
            get
            {
                return "652534";
            }
        }
        public static string Item1SkuCode
        {
            //Items.skuCode
            get
            {
                return "SKU3455692";
            }
        }
        public static string Item1ImageUrl
        {
            //Item.imageUrl
            get
            {
                return "https://images.brickset.com/sets/large/10782-1.jpg?202109211242";
            }
        }
        #endregion

        #region Item2Values
        public static string Item2Id
        {
            //Items.itemId
            get
            {
                return "76205";
            }
        }
        public static string Item2Description
        {
            //Items.description
            get
            {
                return "Gargantos Showdown";
            }
        }
        public static int Item2ParcelInstance
        {
            //Items.packageOccurrence
            get
            {
                return 3;
            }
        }
        public static int Item2Quantity
        {
            //Items.quantity
            get
            {
                return 1;
            }
        }
        public static double Item2Value
        {
            //Items.valueData
            get
            {
                return 24.99;
            }
        }
        public static double Item2Weight
        {
            //Items.weight
            get
            {
                return 1.0;
            }
        }
        public static string Item2CountryOfOrigin
        {
            //Items.countryOfOrigin
            get
            {
                return "GB";
            }
        }
        public static string Item2HsCode
        {
            //Items.hsCode
            get
            {
                return "652584";
            }
        }
        public static string Item2SkuCode
        {
            //Items.skuCode
            get
            {
                return "SKU3455682";
            }
        }
        public static string Item2ImageUrl
        {
            //Item.imageUrl
            get
            {
                return "https://images.brickset.com/sets/images/76205-1.jpg?202109211239";
            }
        }
        #endregion

        #region Item3Values
        public static string Item3Id
        {
            //Items.itemId
            get
            {
                return "76175";
            }
        }
        public static string Item3Description
        {
            //Items.description
            get
            {
                return "Attack on the Spider Lair";
            }
        }
        public static int Item3ParcelInstance
        {
            //Items.packageOccurrence
            get
            {
                return 1;
            }
        }
        public static int Item3Quantity
        {
            //Items.quantity
            get
            {
                return 1;
            }
        }
        public static double Item3Value
        {
            //Items.valueData
            get
            {
                return 69.99;
            }
        }
        public static double Item3Weight
        {
            //Items.weight
            get
            {
                return 1.2;
            }
        }
        public static string Item3CountryOfOrigin
        {
            //Items.countryOfOrigin
            get
            {
                return "CN";
            }
        }
        public static string Item3HsCode
        {
            //Items.hsCode
            get
            {
                return "659534";
            }
        }
        public static string Item3SkuCode
        {
            //Items.skuCode
            get
            {
                return "SKU3499692";
            }
        }
        public static string Item3ImageUrl
        {
            //Item.imageUrl
            get
            {
                return "https://images.brickset.com/sets/images/76175-1.jpg?202009170531";
            }
        }
        #endregion

        #region Item4Values
        public static string Item4Id
        {
            //Items.itemId
            get
            {
                return "10783";
            }
        }
        public static string Item4Description
        {
            //Items.description
            get
            {
                return "Spider-Man at Doc Ock's Lab";
            }
        }
        public static int Item4ParcelInstance
        {
            //Items.packageOccurrence
            get
            {
                return 1;
            }
        }
        public static int Item4Quantity
        {
            //Items.quantity
            get
            {
                return 1;
            }
        }
        public static double Item4Value
        {
            //Items.valueData
            get
            {
                return 24.99;
            }
        }
        public static double Item4Weight
        {
            //Items.weight
            get
            {
                return 0.6;
            }
        }
        public static string Item4CountryOfOrigin
        {
            //Items.countryOfOrigin
            get
            {
                return "CN";
            }
        }
        public static string Item4HsCode
        {
            //Items.hsCode
            get
            {
                return "655534";
            }
        }
        public static string Item4SkuCode
        {
            //Items.skuCode
            get
            {
                return "SKU3499699";
            }
        }
        public static string Item4ImageUrl
        {
            //Item.imageUrl
            get
            {
                return "https://images.brickset.com/sets/images/10783-1.jpg?202109211239";
            }
        }
        #endregion

        #region Parcel1Values
        public static string Parcel1Id
        {
            //Packages.packagingId
            get
            {
                return "17968198-1";
            }
        }
        public static int Parcel1Instance
        {
            //Packages.packageOccurrence
            get
            {
                return 1;
            }
        }
        public static double Parcel1Weight
        {
            //Packages.weight
            get
            {
                return 1.8;
            }
        }
        public static int Parcel1Height
        {
            //Packages.height
            get
            {
                return 5;
            }
        }
        public static int Parcel1Length
        {
            //Packages.length
            get
            {
                return 15;
            }
        }
        public static int Parcel1Width
        {
            //Packages.width
            get
            {
                return 15;
            }
        }
        #endregion

        #region Parcel2Values
        public static string Parcel2Id
        {
            //Packages.packagingId
            get
            {
                return "17968198-2";
            }
        }
        public static int Parcel2Instance
        {
            //Packages.packageOccurrence
            get
            {
                return 2;
            }
        }
        public static double Parcel2Weight
        {
            //Packages.weight
            get
            {
                return 0.9;
            }
        }
        public static int Parcel2Height
        {
            //Packages.height
            get
            {
                return 3;
            }
        }
        public static int Parcel2Length
        {
            //Packages.length
            get
            {
                return 45;
            }
        }
        public static int Parcel2Width
        {
            //Packages.width
            get
            {
                return 10;
            }
        }
        #endregion

        #region Parcel3Values
        public static string Parcel3Id
        {
            //Packages.packagingId
            get
            {
                return "17968198-3";
            }
        }
        public static int Parcel3Instance
        {
            //Packages.packageOccurrence
            get
            {
                return 3;
            }
        }
        public static double Parcel3Weight
        {
            //Packages.weight
            get
            {
                return 1;
            }
        }
        public static int Parcel3Height
        {
            //Packages.height
            get
            {
                return 5;
            }
        }
        public static int Parcel3Length
        {
            //Packages.length
            get
            {
                return 35;
            }
        }
        public static int Parcel3Width
        {
            //Packages.width
            get
            {
                return 20;
            }
        }
        #endregion

        /// <summary>
        /// Populate an order object with all the values for this Sample.
        /// </summary>
        /// <param name="inpOrder">Order object to be populated</param>
        /// <returns>Populated order object</returns>
        public static IOrderData PopulateOrder(IOrderData inpOrder)
        {
            inpOrder.AddresseeIdentificationReferenceNumber = SampleOrder3.AddresseeIdentificationReferenceNumber;
            inpOrder.CustomerAddressCounty = SampleOrder3.CustomerAddressCounty;
            inpOrder.CustomerAddressLine1 = SampleOrder3.CustomerAddressLine1;
            inpOrder.CustomerAddressLine2 = SampleOrder3.CustomerAddressLine2;
            inpOrder.CustomerAddressLine3 = SampleOrder3.CustomerAddressLine3;
            inpOrder.CustomerAddressLine4 = SampleOrder3.CustomerAddressLine4;
            inpOrder.CustomerAddressPostcode = SampleOrder3.CustomerAddressPostcode;
            inpOrder.CustomerAddressTown = SampleOrder3.CustomerAddressTown;
            inpOrder.CustomerBusinessName = SampleOrder3.CustomerBusinessName;
            inpOrder.CustomerContactName = SampleOrder3.CustomerContactName;
            inpOrder.CustomerCountryCode = SampleOrder3.CustomerCountryCode;
            inpOrder.CustomerEmailAddress = SampleOrder3.CustomerEmailAddress;
            inpOrder.CustomerId = SampleOrder3.CustomerId;
            inpOrder.CustomerPhoneNumber = SampleOrder3.CustomerPhoneNumber;
            inpOrder.CustomerSafeplace = SampleOrder3.CustomerSafeplace;
            inpOrder.CustomerVatNumber = SampleOrder3.CustomerVatNumber;
            inpOrder.CustomsCurrency = SampleOrder3.CustomsCurrency;
            inpOrder.CustomsDescriptionOfGoods = SampleOrder3.CustomsDescriptionOfGoods;
            inpOrder.CustomsExportLicence = SampleOrder3.CustomsExportLicence;
            inpOrder.CustomsIncoterms = SampleOrder3.CustomsIncoterms;
            inpOrder.CustomsInvoiceDate = Convert.ToDateTime(SampleOrder3.CustomsInvoiceDate);
            inpOrder.CustomsInvoiceNumber = SampleOrder3.CustomsInvoiceNumber;
            inpOrder.CustomsLabelFormat = SampleOrder3.CustomsLabelFormat;
            inpOrder.CustomsOtherCharges = SampleOrder3.CustomsOtherCharges;
            inpOrder.CustomsPreRegistrationNumber = SampleOrder3.CustomsPreRegistrationNumber;
            inpOrder.CustomsPreRegistrationType = SampleOrder3.CustomsPreRegistrationType;
            inpOrder.CustomsProduct = SampleOrder3.CustomsProduct;
            inpOrder.CustomsQuotedLandedCost = SampleOrder3.CustomsQuotedLandedCost;
            inpOrder.CustomsReasonForExport = SampleOrder3.CustomsReasonForExport;
            inpOrder.CustomsShipmentAction = SampleOrder3.CustomsShipmentAction;
            inpOrder.CustomsShippingCharges = SampleOrder3.CustomsShippingCharges;
            inpOrder.CustomsSilentPrintProfile = SampleOrder3.CustomsSilentPrintProfile;
            inpOrder.CustomsValue = SampleOrder3.CustomsValue;
            inpOrder.Department = SampleOrder3.Department;
            inpOrder.PostageType = SampleOrder3.PostageType;
            inpOrder.PostingConsequentialLoss = SampleOrder3.PostingConsequentialLoss;
            inpOrder.PostingDate = Convert.ToDateTime(SampleOrder3.PostingDate);
            inpOrder.PostingLocalCollect = SampleOrder3.PostingLocalCollect;
            inpOrder.PostingLocation = SampleOrder3.PostingLocation;
            inpOrder.PostingRecordedSignedFor = SampleOrder3.PostingRecordedSignedFor;
            inpOrder.PostingSaturdayGuaranteed = SampleOrder3.PostingSaturdayGuaranteed;
            inpOrder.PostingServiceFormat = SampleOrder3.PostingServiceFormat;
            inpOrder.PostingServiceLevel = SampleOrder3.PostingServiceLevel;
            inpOrder.PostingTrackingNotifications = SampleOrder3.PostingTrackingNotifications;
            inpOrder.PostingWeightUOM = SampleOrder3.PostingWeightUOM;
            inpOrder.SupplierAddressCounty = SampleOrder3.SupplierAddressCounty;
            inpOrder.SupplierAddressLine1 = SampleOrder3.SupplierAddressLine1;
            inpOrder.SupplierAddressLine2 = SampleOrder3.SupplierAddressLine2;
            inpOrder.SupplierAddressLine3 = SampleOrder3.SupplierAddressLine3;
            inpOrder.SupplierAddressLine4 = SampleOrder3.SupplierAddressLine4;
            inpOrder.SupplierAddressPostcode = SampleOrder3.SupplierAddressPostcode;
            inpOrder.SupplierAddressTown = SampleOrder3.SupplierAddressTown;
            inpOrder.SupplierBusinessName = SampleOrder3.SupplierBusinessName;
            inpOrder.SupplierContactName = SampleOrder3.SupplierCountryCode;
            inpOrder.SupplierCountryCode = SampleOrder3.SupplierCountryCode;
            inpOrder.SupplierEmailAddress = SampleOrder3.SupplierEmailAddress;
            inpOrder.SupplierId = SampleOrder3.SupplierId;
            inpOrder.SupplierPhoneNumber = SampleOrder3.SupplierPhoneNumber;
            inpOrder.SupplierReference1 = SampleOrder3.SupplierReference1;
            inpOrder.SupplierReference2 = SampleOrder3.SupplierReference2;
            inpOrder.SupplierVatNumber = SampleOrder3.SupplierVatNumber;

            inpOrder.AddItem();
            inpOrder.ItemCountryOfOrigin = SampleOrder3.Item1CountryOfOrigin;
            inpOrder.ItemDescription = SampleOrder3.Item1Description;
            inpOrder.ItemHsCode = SampleOrder3.Item1HsCode;
            inpOrder.ItemId = SampleOrder3.Item1Id;
            inpOrder.ItemImageUrl = SampleOrder3.Item1ImageUrl;
            inpOrder.ItemParcelInstance = SampleOrder3.Item1ParcelInstance;
            inpOrder.ItemQuantity = SampleOrder3.Item1Quantity;
            inpOrder.ItemSkuCode = SampleOrder3.Item1SkuCode;
            inpOrder.ItemValue = SampleOrder3.Item1Value;
            inpOrder.ItemWeight = SampleOrder3.Item1Weight;

            inpOrder.AddItem();
            inpOrder.ItemCountryOfOrigin = SampleOrder3.Item2CountryOfOrigin;
            inpOrder.ItemDescription = SampleOrder3.Item2Description;
            inpOrder.ItemHsCode = SampleOrder3.Item2HsCode;
            inpOrder.ItemId = SampleOrder3.Item2Id;
            inpOrder.ItemImageUrl = SampleOrder3.Item2ImageUrl;
            inpOrder.ItemParcelInstance = SampleOrder3.Item2ParcelInstance;
            inpOrder.ItemQuantity = SampleOrder3.Item2Quantity;
            inpOrder.ItemSkuCode = SampleOrder3.Item2SkuCode;
            inpOrder.ItemValue = SampleOrder3.Item2Value;
            inpOrder.ItemWeight = SampleOrder3.Item2Weight;

            inpOrder.AddItem();
            inpOrder.ItemCountryOfOrigin = SampleOrder3.Item3CountryOfOrigin;
            inpOrder.ItemDescription = SampleOrder3.Item3Description;
            inpOrder.ItemHsCode = SampleOrder3.Item3HsCode;
            inpOrder.ItemId = SampleOrder3.Item3Id;
            inpOrder.ItemImageUrl = SampleOrder3.Item3ImageUrl;
            inpOrder.ItemParcelInstance = SampleOrder3.Item3ParcelInstance;
            inpOrder.ItemQuantity = SampleOrder3.Item3Quantity;
            inpOrder.ItemSkuCode = SampleOrder3.Item3SkuCode;
            inpOrder.ItemValue = SampleOrder3.Item3Value;
            inpOrder.ItemWeight = SampleOrder3.Item3Weight;

            inpOrder.AddItem();
            inpOrder.ItemCountryOfOrigin = SampleOrder3.Item4CountryOfOrigin;
            inpOrder.ItemDescription = SampleOrder3.Item4Description;
            inpOrder.ItemHsCode = SampleOrder3.Item4HsCode;
            inpOrder.ItemId = SampleOrder3.Item4Id;
            inpOrder.ItemImageUrl = SampleOrder3.Item4ImageUrl;
            inpOrder.ItemParcelInstance = SampleOrder3.Item4ParcelInstance;
            inpOrder.ItemQuantity = SampleOrder3.Item4Quantity;
            inpOrder.ItemSkuCode = SampleOrder3.Item4SkuCode;
            inpOrder.ItemValue = SampleOrder3.Item4Value;
            inpOrder.ItemWeight = SampleOrder3.Item4Weight;

            inpOrder.AddParcel();
            inpOrder.ParcelHeight = SampleOrder3.Parcel1Height;
            inpOrder.ParcelId = SampleOrder3.Parcel1Id;
            inpOrder.ParcelInstance = SampleOrder3.Parcel1Instance;
            inpOrder.ParcelLength = SampleOrder3.Parcel1Length;
            inpOrder.ParcelWeight = SampleOrder3.Parcel1Weight;
            inpOrder.ParcelWidth = SampleOrder3.Parcel1Width;

            inpOrder.AddParcel();
            inpOrder.ParcelHeight = SampleOrder3.Parcel2Height;
            inpOrder.ParcelId = SampleOrder3.Parcel2Id;
            inpOrder.ParcelInstance = SampleOrder3.Parcel2Instance;
            inpOrder.ParcelLength = SampleOrder3.Parcel2Length;
            inpOrder.ParcelWeight = SampleOrder3.Parcel2Weight;
            inpOrder.ParcelWidth = SampleOrder3.Parcel2Width;

            inpOrder.AddParcel();
            inpOrder.ParcelHeight = SampleOrder3.Parcel3Height;
            inpOrder.ParcelId = SampleOrder3.Parcel3Id;
            inpOrder.ParcelInstance = SampleOrder3.Parcel3Instance;
            inpOrder.ParcelLength = SampleOrder3.Parcel3Length;
            inpOrder.ParcelWeight = SampleOrder3.Parcel3Weight;
            inpOrder.ParcelWidth = SampleOrder3.Parcel3Width;

            return inpOrder;
        }
    }

    static class SampleOrder4
    {
        #region SupplierValues
        public static string SupplierId
        {
            //Shipper.addressId
            get
            {
                return "";
            }
        }
        public static string SupplierBusinessName
        {
            //Shipper.companyName
            get
            {
                return "";
            }
        }
        public static string SupplierContactName
        {
            //Shipper.contactName
            get
            {
                return "";
            }
        }
        public static int Department
        {
            //Shipper.shipperDepartment
            get
            {
                return 0;
            }
        }
        public static string SupplierAddressLine1
        {
            //Shipper.addressLine1
            get
            {
                return "";
            }
        }
        public static string SupplierAddressLine2
        {
            //Shipper.addressLine2
            get
            {
                return "";
            }
        }
        public static string SupplierAddressLine3
        {
            //Shipper.addressLine3
            get
            {
                return "";
            }
        }
        public static string SupplierAddressLine4
        {
            //N/A
            get
            {
                return "";
            }
        }
        public static string SupplierAddressPostcode
        {
            //Shipper.postcode
            get
            {
                return "";
            }
        }
        public static string SupplierAddressTown
        {
            //Shipper.town
            get
            {
                return "";
            }
        }
        public static string SupplierAddressCounty
        {
            //Shipper.county
            get
            {
                return "";
            }
        }
        public static string SupplierCountryCode
        {
            //Shipper.countryCode
            get
            {
                return "";
            }
        }
        public static string SupplierPhoneNumber
        {
            //Shipper.phoneNumber
            get
            {
                return "";
            }
        }
        public static string SupplierEmailAddress
        {
            //Shipper.emailAddress
            get
            {
                return "";
            }
        }
        public static string SupplierReference1
        {
            //Shipper.shipperReference
            get
            {
                return "";
            }
        }
        public static string SupplierReference2
        {
            //Shipper.shipperReference2
            get
            {
                return "";
            }
        }
        public static string SupplierVatNumber
        {
            //Shipper.vatNumber
            get
            {
                return "";
            }
        }
        #endregion

        #region CustomerValues
        public static string CustomerId
        {
            //Destination.addressId
            get
            {
                return "";
            }
        }
        public static string CustomerContactName
        {
            //Destination.contactName
            get
            {
                return "";
            }
        }
        public static string CustomerBusinessName
        {
            //Destination.companyName
            get
            {
                return "";
            }
        }
        public static Int64 AddresseeIdentificationReferenceNumber
        {
            //CustomsInformation.addresseeIdentificationReferenceNumber
            get
            {
                return 0;
            }
        }
        public static string CustomerAddressLine1
        {
            //Destination.addressLine1
            get
            {
                return "";
            }
        }
        public static string CustomerAddressLine2
        {
            //Destination.addressLine2
            get
            {
                return "";
            }
        }
        public static string CustomerAddressLine3
        {
            //Destination.addressLine3
            get
            {
                return "";
            }
        }
        public static string CustomerAddressLine4
        {
            //N/A
            get
            {
                return "";
            }
        }
        public static string CustomerAddressTown
        {
            //Destination.town
            get
            {
                return "";
            }
        }
        public static string CustomerAddressCounty
        {
            //Destination.county
            get
            {
                return "";
            }
        }
        public static string CustomerAddressPostcode
        {
            //Destination.postcode
            get
            {
                return "";
            }
        }
        public static string CustomerCountryCode
        {
            //Destination.countryCode
            get
            {
                return "";
            }
        }
        public static string CustomerPhoneNumber
        {
            //Destination.phoneNumber
            get
            {
                return "";
            }
        }
        public static string CustomerEmailAddress
        {
            //Destination.emailAddress
            get
            {
                return "";
            }
        }
        public static string CustomerSafeplace
        {
            //ShipmentInformation.ServiceOptions.safeplace
            get
            {
                return "";
            }
        }
        public static string CustomerVatNumber
        {
            //Destination.vatNumber
            get
            {
                return "";
            }
        }
        #endregion

        #region CustomsValues
        public static string CustomsCurrency
        {
            //ShipmentInformation.currency
            get
            {
                return "";
            }
        }
        public static string CustomsDescriptionOfGoods
        {
            //ShipmentInformation.descriptionOfGoods
            get
            {
                return "";
            }
        }
        public static bool CustomsExportLicence
        {
            //CustomsInformation.exportLicence
            get
            {
                return false;
            }
        }
        public static string CustomsIncoterms
        {
            //ShipmentInformation.incoterms
            get
            {
                return "";
            }
        }
        public static string CustomsInvoiceDate
        {
            //CustomsInformation.invoiceDate
            get
            {
                return "";
            }
        }
        public static string CustomsInvoiceNumber
        {
            //CustomsInformation.invoiceNumber (Int32)
            get
            {
                return "";
            }
        }
        public static string CustomsLabelFormat
        {
            //ShipmentInformation.labelFormat
            get
            {
                return "";
            }
        }
        public static double CustomsOtherCharges
        {
            //CustomsInformation.otherCharges
            get
            {
                return 0.00;
            }
        }
        public static string CustomsPreRegistrationNumber
        {
            //CustomsInformation.preRegistrationNumber
            get
            {
                return "";
            }
        }
        public static string CustomsPreRegistrationType
        {
            //CustomsInformation.preRegistrationType
            get
            {
                return "";
            }
        }
        public static string CustomsProduct
        {
            //ShipmentInformation.product
            get
            {
                return "";
            }
        }
        public static double CustomsQuotedLandedCost
        {
            //CustomsInformation.quotedLandedCost
            get
            {
                return 0.00;
            }
        }
        public static string CustomsReasonForExport
        {
            //ShipmentInformation.reasonForExport
            get
            {
                return "";
            }
        }
        public static string CustomsShipmentAction
        {
            //ShipmentInformation.shipmentAction
            get
            {
                return "";
            }
        }
        public static double CustomsShippingCharges
        {
            //CustomsInformation.shippingCharges
            get
            {
                return 0.00;
            }
        }
        public static string CustomsSilentPrintProfile
        {
            //ShipmentInformation.silentPrintProfile
            get
            {
                return "";
            }
        }
        public static double CustomsValue
        {
            //ShipmentInformation.valueData
            get
            {
                return 0.00;
            }
        }
        #endregion

        #region PostageValues
        public static string PostageType
        {
            //ShipmentInformation.serviceCode
            get
            {
                return "";
            }
        }
        public static string PostingDate
        {
            //ShipmentInformation.shipmentDate
            get
            {
                return "";
            }
        }
        public static string PostingServiceFormat
        {
            //ShipmentInformation.ServiceOptions.serviceFormat
            get
            {
                return "";
            }
        }
        public static string PostingServiceLevel
        {
            //ShipmentInformation.ServiceOptions.serviceLevel
            get
            {
                return "";
            }
        }
        public static int PostingTotalPackages
        {
            //Calculated
            get
            {
                return 0;
            }
        }
        public static double PostingTotalWeight
        {
            //Calculated
            get
            {
                return 0.00;
            }
        }
        public static string PostingWeightUOM
        {
            //ShipmentInformation.weightUnitOfMeasure
            get
            {
                return "";
            }
        }
        public static string PostingConsequentialLoss
        {
            //ShipmentInformation.ServiceOptions.consequentialLoss
            get
            {
                return "";
            }
        }
        public static bool PostingLocalCollect
        {
            //ShipmentInformation.ServiceOptions.localCollect
            get
            {
                return false;
            }
        }
        public static string PostingLocation
        {
            //ShipmentInformation.ServiceOptions.postingLocation
            get
            {
                return "";
            }
        }
        public static bool PostingRecordedSignedFor
        {
            //ShipmentInformation.ServiceOptions.recordedSignedFor
            get
            {
                return false;
            }
        }
        public static bool PostingSaturdayGuaranteed
        {
            //ShipmentInformation.ServiceOptions.saturdayGuaranteed
            get
            {
                return false;
            }
        }
        public static string PostingTrackingNotifications
        {
            //ShipmentInformation.ServiceOptions.trackingNotifications
            get
            {
                return "";
            }
        }
        public static int TotalItemCount
        {
            //Calculated
            get
            {
                return 0;
            }
        }
        #endregion

        #region Item1Values
        public static string Item1Id
        {
            //Items.itemId
            get
            {
                return "";
            }
        }
        public static string Item1Description
        {
            //Items.description
            get
            {
                return "";
            }
        }
        public static int Item1ParcelInstance
        {
            //Items.packageOccurrence
            get
            {
                return 0;
            }
        }
        public static int Item1Quantity
        {
            //Items.quantity
            get
            {
                return 0;
            }
        }
        public static double Item1Value
        {
            //Items.valueData
            get
            {
                return 0.00;
            }
        }
        public static double Item1Weight
        {
            //Items.weight
            get
            {
                return 0.00;
            }
        }
        public static string Item1CountryOfOrigin
        {
            //Items.countryOfOrigin
            get
            {
                return "";
            }
        }
        public static string Item1HsCode
        {
            //Items.hsCode
            get
            {
                return "";
            }
        }
        public static string Item1SkuCode
        {
            //Items.skuCode
            get
            {
                return "";
            }
        }
        public static string Item1ImageUrl
        {
            //Item.imageUrl
            get
            {
                return "";
            }
        }
        #endregion

        #region Parcel1Values
        public static string Parcel1Id
        {
            //Packages.packagingId
            get
            {
                return "";
            }
        }
        public static int Parcel1Instance
        {
            //Packages.packageOccurrence
            get
            {
                return 0;
            }
        }
        public static double Parcel1Weight
        {
            //Packages.weight
            get
            {
                return 0.00;
            }
        }
        public static int Parcel1Height
        {
            //Packages.height
            get
            {
                return 0;
            }
        }
        public static int Parcel1Length
        {
            //Packages.length
            get
            {
                return 0;
            }
        }
        public static int Parcel1Width
        {
            //Packages.width
            get
            {
                return 0;
            }
        }
        #endregion

        /// <summary>
        /// Populate an order object with all the values for this Sample.
        /// </summary>
        /// <param name="inpOrder">Order object to be populated</param>
        /// <returns>Populated order object</returns>
        public static IOrderData PopulateOrder(IOrderData inpOrder)
        {
            inpOrder.AddresseeIdentificationReferenceNumber = SampleOrder4.AddresseeIdentificationReferenceNumber;
            inpOrder.CustomerAddressCounty = SampleOrder4.CustomerAddressCounty;
            inpOrder.CustomerAddressLine1 = SampleOrder4.CustomerAddressLine1;
            inpOrder.CustomerAddressLine2 = SampleOrder4.CustomerAddressLine2;
            inpOrder.CustomerAddressLine3 = SampleOrder4.CustomerAddressLine3;
            inpOrder.CustomerAddressLine4 = SampleOrder4.CustomerAddressLine4;
            inpOrder.CustomerAddressPostcode = SampleOrder4.CustomerAddressPostcode;
            inpOrder.CustomerAddressTown = SampleOrder4.CustomerAddressTown;
            inpOrder.CustomerBusinessName = SampleOrder4.CustomerBusinessName;
            inpOrder.CustomerContactName = SampleOrder4.CustomerContactName;
            inpOrder.CustomerCountryCode = SampleOrder4.CustomerCountryCode;
            inpOrder.CustomerEmailAddress = SampleOrder4.CustomerEmailAddress;
            inpOrder.CustomerId = SampleOrder4.CustomerId;
            inpOrder.CustomerPhoneNumber = SampleOrder4.CustomerPhoneNumber;
            inpOrder.CustomerSafeplace = SampleOrder4.CustomerSafeplace;
            inpOrder.CustomerVatNumber = SampleOrder4.CustomerVatNumber;
            inpOrder.CustomsCurrency = SampleOrder4.CustomsCurrency;
            inpOrder.CustomsDescriptionOfGoods = SampleOrder4.CustomsDescriptionOfGoods;
            inpOrder.CustomsExportLicence = SampleOrder4.CustomsExportLicence;
            inpOrder.CustomsIncoterms = SampleOrder4.CustomsIncoterms;
            inpOrder.CustomsInvoiceDate = Convert.ToDateTime(SampleOrder4.CustomsInvoiceDate);
            inpOrder.CustomsInvoiceNumber = SampleOrder4.CustomsInvoiceNumber;
            inpOrder.CustomsLabelFormat = SampleOrder4.CustomsLabelFormat;
            inpOrder.CustomsOtherCharges = SampleOrder4.CustomsOtherCharges;
            inpOrder.CustomsPreRegistrationNumber = SampleOrder4.CustomsPreRegistrationNumber;
            inpOrder.CustomsPreRegistrationType = SampleOrder4.CustomsPreRegistrationType;
            inpOrder.CustomsProduct = SampleOrder4.CustomsProduct;
            inpOrder.CustomsQuotedLandedCost = SampleOrder4.CustomsQuotedLandedCost;
            inpOrder.CustomsReasonForExport = SampleOrder4.CustomsReasonForExport;
            inpOrder.CustomsShipmentAction = SampleOrder4.CustomsShipmentAction;
            inpOrder.CustomsShippingCharges = SampleOrder4.CustomsShippingCharges;
            inpOrder.CustomsSilentPrintProfile = SampleOrder4.CustomsSilentPrintProfile;
            inpOrder.CustomsValue = SampleOrder4.CustomsValue;
            inpOrder.Department = SampleOrder4.Department;
            inpOrder.PostageType = SampleOrder4.PostageType;
            inpOrder.PostingConsequentialLoss = SampleOrder4.PostingConsequentialLoss;
            inpOrder.PostingDate = Convert.ToDateTime(SampleOrder4.PostingDate);
            inpOrder.PostingLocalCollect = SampleOrder4.PostingLocalCollect;
            inpOrder.PostingLocation = SampleOrder4.PostingLocation;
            inpOrder.PostingRecordedSignedFor = SampleOrder4.PostingRecordedSignedFor;
            inpOrder.PostingSaturdayGuaranteed = SampleOrder4.PostingSaturdayGuaranteed;
            inpOrder.PostingServiceFormat = SampleOrder4.PostingServiceFormat;
            inpOrder.PostingServiceLevel = SampleOrder4.PostingServiceLevel;
            inpOrder.PostingTrackingNotifications = SampleOrder4.PostingTrackingNotifications;
            inpOrder.PostingWeightUOM = SampleOrder4.PostingWeightUOM;
            inpOrder.SupplierAddressCounty = SampleOrder4.SupplierAddressCounty;
            inpOrder.SupplierAddressLine1 = SampleOrder4.SupplierAddressLine1;
            inpOrder.SupplierAddressLine2 = SampleOrder4.SupplierAddressLine2;
            inpOrder.SupplierAddressLine3 = SampleOrder4.SupplierAddressLine3;
            inpOrder.SupplierAddressLine4 = SampleOrder4.SupplierAddressLine4;
            inpOrder.SupplierAddressPostcode = SampleOrder4.SupplierAddressPostcode;
            inpOrder.SupplierAddressTown = SampleOrder4.SupplierAddressTown;
            inpOrder.SupplierBusinessName = SampleOrder4.SupplierBusinessName;
            inpOrder.SupplierContactName = SampleOrder4.SupplierCountryCode;
            inpOrder.SupplierCountryCode = SampleOrder4.SupplierCountryCode;
            inpOrder.SupplierEmailAddress = SampleOrder4.SupplierEmailAddress;
            inpOrder.SupplierId = SampleOrder4.SupplierId;
            inpOrder.SupplierPhoneNumber = SampleOrder4.SupplierPhoneNumber;
            inpOrder.SupplierReference1 = SampleOrder4.SupplierReference1;
            inpOrder.SupplierReference2 = SampleOrder4.SupplierReference2;
            inpOrder.SupplierVatNumber = SampleOrder4.SupplierVatNumber;

            inpOrder.AddItem();
            inpOrder.ItemCountryOfOrigin = SampleOrder4.Item1CountryOfOrigin;
            inpOrder.ItemDescription = SampleOrder4.Item1Description;
            inpOrder.ItemHsCode = SampleOrder4.Item1HsCode;
            inpOrder.ItemId = SampleOrder4.Item1Id;
            inpOrder.ItemImageUrl = SampleOrder4.Item1ImageUrl;
            inpOrder.ItemParcelInstance = SampleOrder4.Item1ParcelInstance;
            inpOrder.ItemQuantity = SampleOrder4.Item1Quantity;
            inpOrder.ItemSkuCode = SampleOrder4.Item1SkuCode;
            inpOrder.ItemValue = SampleOrder4.Item1Value;
            inpOrder.ItemWeight = SampleOrder4.Item1Weight;

            inpOrder.AddParcel();
            inpOrder.ParcelHeight = SampleOrder4.Parcel1Height;
            inpOrder.ParcelId = SampleOrder4.Parcel1Id;
            inpOrder.ParcelInstance = SampleOrder4.Parcel1Instance;
            inpOrder.ParcelLength = SampleOrder4.Parcel1Length;
            inpOrder.ParcelWeight = SampleOrder4.Parcel1Weight;
            inpOrder.ParcelWidth = SampleOrder4.Parcel1Width;

            return inpOrder;
        }
    }

    static class SampleOrder5
    {
        #region SupplierValues
        public static string SupplierId
        {
            //Shipper.addressId
            get
            {
                return "";
            }
        }
        public static string SupplierBusinessName
        {
            //Shipper.companyName
            get
            {
                return "";
            }
        }
        public static string SupplierContactName
        {
            //Shipper.contactName
            get
            {
                return "";
            }
        }
        public static int Department
        {
            //Shipper.shipperDepartment
            get
            {
                return 0;
            }
        }
        public static string SupplierAddressLine1
        {
            //Shipper.addressLine1
            get
            {
                return "";
            }
        }
        public static string SupplierAddressLine2
        {
            //Shipper.addressLine2
            get
            {
                return "";
            }
        }
        public static string SupplierAddressLine3
        {
            //Shipper.addressLine3
            get
            {
                return "";
            }
        }
        public static string SupplierAddressLine4
        {
            //N/A
            get
            {
                return "";
            }
        }
        public static string SupplierAddressPostcode
        {
            //Shipper.postcode
            get
            {
                return "";
            }
        }
        public static string SupplierAddressTown
        {
            //Shipper.town
            get
            {
                return "";
            }
        }
        public static string SupplierAddressCounty
        {
            //Shipper.county
            get
            {
                return "";
            }
        }
        public static string SupplierCountryCode
        {
            //Shipper.countryCode
            get
            {
                return "";
            }
        }
        public static string SupplierPhoneNumber
        {
            //Shipper.phoneNumber
            get
            {
                return "";
            }
        }
        public static string SupplierEmailAddress
        {
            //Shipper.emailAddress
            get
            {
                return "";
            }
        }
        public static string SupplierReference1
        {
            //Shipper.shipperReference
            get
            {
                return "";
            }
        }
        public static string SupplierReference2
        {
            //Shipper.shipperReference2
            get
            {
                return "";
            }
        }
        public static string SupplierVatNumber
        {
            //Shipper.vatNumber
            get
            {
                return "";
            }
        }
        #endregion

        #region CustomerValues
        public static string CustomerId
        {
            //Destination.addressId
            get
            {
                return "";
            }
        }
        public static string CustomerContactName
        {
            //Destination.contactName
            get
            {
                return "";
            }
        }
        public static string CustomerBusinessName
        {
            //Destination.companyName
            get
            {
                return "";
            }
        }
        public static Int64 AddresseeIdentificationReferenceNumber
        {
            //CustomsInformation.addresseeIdentificationReferenceNumber
            get
            {
                return 0;
            }
        }
        public static string CustomerAddressLine1
        {
            //Destination.addressLine1
            get
            {
                return "";
            }
        }
        public static string CustomerAddressLine2
        {
            //Destination.addressLine2
            get
            {
                return "";
            }
        }
        public static string CustomerAddressLine3
        {
            //Destination.addressLine3
            get
            {
                return "";
            }
        }
        public static string CustomerAddressLine4
        {
            //N/A
            get
            {
                return "";
            }
        }
        public static string CustomerAddressTown
        {
            //Destination.town
            get
            {
                return "";
            }
        }
        public static string CustomerAddressCounty
        {
            //Destination.county
            get
            {
                return "";
            }
        }
        public static string CustomerAddressPostcode
        {
            //Destination.postcode
            get
            {
                return "";
            }
        }
        public static string CustomerCountryCode
        {
            //Destination.countryCode
            get
            {
                return "";
            }
        }
        public static string CustomerPhoneNumber
        {
            //Destination.phoneNumber
            get
            {
                return "";
            }
        }
        public static string CustomerEmailAddress
        {
            //Destination.emailAddress
            get
            {
                return "";
            }
        }
        public static string CustomerSafeplace
        {
            //ShipmentInformation.ServiceOptions.safeplace
            get
            {
                return "";
            }
        }
        public static string CustomerVatNumber
        {
            //Destination.vatNumber
            get
            {
                return "";
            }
        }
        #endregion

        #region CustomsValues
        public static string CustomsCurrency
        {
            //ShipmentInformation.currency
            get
            {
                return "";
            }
        }
        public static string CustomsDescriptionOfGoods
        {
            //ShipmentInformation.descriptionOfGoods
            get
            {
                return "";
            }
        }
        public static bool CustomsExportLicence
        {
            //CustomsInformation.exportLicence
            get
            {
                return false;
            }
        }
        public static string CustomsIncoterms
        {
            //ShipmentInformation.incoterms
            get
            {
                return "";
            }
        }
        public static string CustomsInvoiceDate
        {
            //CustomsInformation.invoiceDate
            get
            {
                return "";
            }
        }
        public static string CustomsInvoiceNumber
        {
            //CustomsInformation.invoiceNumber (Int32)
            get
            {
                return "";
            }
        }
        public static string CustomsLabelFormat
        {
            //ShipmentInformation.labelFormat
            get
            {
                return "";
            }
        }
        public static double CustomsOtherCharges
        {
            //CustomsInformation.otherCharges
            get
            {
                return 0.00;
            }
        }
        public static string CustomsPreRegistrationNumber
        {
            //CustomsInformation.preRegistrationNumber
            get
            {
                return "";
            }
        }
        public static string CustomsPreRegistrationType
        {
            //CustomsInformation.preRegistrationType
            get
            {
                return "";
            }
        }
        public static string CustomsProduct
        {
            //ShipmentInformation.product
            get
            {
                return "";
            }
        }
        public static double CustomsQuotedLandedCost
        {
            //CustomsInformation.quotedLandedCost
            get
            {
                return 0.00;
            }
        }
        public static string CustomsReasonForExport
        {
            //ShipmentInformation.reasonForExport
            get
            {
                return "";
            }
        }
        public static string CustomsShipmentAction
        {
            //ShipmentInformation.shipmentAction
            get
            {
                return "";
            }
        }
        public static double CustomsShippingCharges
        {
            //CustomsInformation.shippingCharges
            get
            {
                return 0.00;
            }
        }
        public static string CustomsSilentPrintProfile
        {
            //ShipmentInformation.silentPrintProfile
            get
            {
                return "";
            }
        }
        public static double CustomsValue
        {
            //ShipmentInformation.valueData
            get
            {
                return 0.00;
            }
        }
        #endregion

        #region PostageValues
        public static string PostageType
        {
            //ShipmentInformation.serviceCode
            get
            {
                return "";
            }
        }
        public static string PostingDate
        {
            //ShipmentInformation.shipmentDate
            get
            {
                return "";
            }
        }
        public static string PostingServiceFormat
        {
            //ShipmentInformation.ServiceOptions.serviceFormat
            get
            {
                return "";
            }
        }
        public static string PostingServiceLevel
        {
            //ShipmentInformation.ServiceOptions.serviceLevel
            get
            {
                return "";
            }
        }
        public static int PostingTotalPackages
        {
            //Calculated
            get
            {
                return 0;
            }
        }
        public static double PostingTotalWeight
        {
            //Calculated
            get
            {
                return 0.00;
            }
        }
        public static string PostingWeightUOM
        {
            //ShipmentInformation.weightUnitOfMeasure
            get
            {
                return "";
            }
        }
        public static string PostingConsequentialLoss
        {
            //ShipmentInformation.ServiceOptions.consequentialLoss
            get
            {
                return "";
            }
        }
        public static bool PostingLocalCollect
        {
            //ShipmentInformation.ServiceOptions.localCollect
            get
            {
                return false;
            }
        }
        public static string PostingLocation
        {
            //ShipmentInformation.ServiceOptions.postingLocation
            get
            {
                return "";
            }
        }
        public static bool PostingRecordedSignedFor
        {
            //ShipmentInformation.ServiceOptions.recordedSignedFor
            get
            {
                return false;
            }
        }
        public static bool PostingSaturdayGuaranteed
        {
            //ShipmentInformation.ServiceOptions.saturdayGuaranteed
            get
            {
                return false;
            }
        }
        public static string PostingTrackingNotifications
        {
            //ShipmentInformation.ServiceOptions.trackingNotifications
            get
            {
                return "";
            }
        }
        public static int TotalItemCount
        {
            //Calculated
            get
            {
                return 0;
            }
        }
        #endregion

        #region Item1Values
        public static string Item1Id
        {
            //Items.itemId
            get
            {
                return "";
            }
        }
        public static string Item1Description
        {
            //Items.description
            get
            {
                return "";
            }
        }
        public static int Item1ParcelInstance
        {
            //Items.packageOccurrence
            get
            {
                return 0;
            }
        }
        public static int Item1Quantity
        {
            //Items.quantity
            get
            {
                return 0;
            }
        }
        public static double Item1Value
        {
            //Items.valueData
            get
            {
                return 0.00;
            }
        }
        public static double Item1Weight
        {
            //Items.weight
            get
            {
                return 0.00;
            }
        }
        public static string Item1CountryOfOrigin
        {
            //Items.countryOfOrigin
            get
            {
                return "";
            }
        }
        public static string Item1HsCode
        {
            //Items.hsCode
            get
            {
                return "";
            }
        }
        public static string Item1SkuCode
        {
            //Items.skuCode
            get
            {
                return "";
            }
        }
        public static string Item1ImageUrl
        {
            //Item.imageUrl
            get
            {
                return "";
            }
        }
        #endregion

        #region Parcel1Values
        public static string Parcel1Id
        {
            //Packages.packagingId
            get
            {
                return "";
            }
        }
        public static int Parcel1Instance
        {
            //Packages.packageOccurrence
            get
            {
                return 0;
            }
        }
        public static double Parcel1Weight
        {
            //Packages.weight
            get
            {
                return 0.00;
            }
        }
        public static int Parcel1Height
        {
            //Packages.height
            get
            {
                return 0;
            }
        }
        public static int Parcel1Length
        {
            //Packages.length
            get
            {
                return 0;
            }
        }
        public static int Parcel1Width
        {
            //Packages.width
            get
            {
                return 0;
            }
        }
        #endregion

        /// <summary>
        /// Populate an order object with all the values for this Sample.
        /// </summary>
        /// <param name="inpOrder">Order object to be populated</param>
        /// <returns>Populated order object</returns>
        public static IOrderData PopulateOrder(IOrderData inpOrder)
        {
            inpOrder.AddresseeIdentificationReferenceNumber = SampleOrder5.AddresseeIdentificationReferenceNumber;
            inpOrder.CustomerAddressCounty = SampleOrder5.CustomerAddressCounty;
            inpOrder.CustomerAddressLine1 = SampleOrder5.CustomerAddressLine1;
            inpOrder.CustomerAddressLine2 = SampleOrder5.CustomerAddressLine2;
            inpOrder.CustomerAddressLine3 = SampleOrder5.CustomerAddressLine3;
            inpOrder.CustomerAddressLine4 = SampleOrder5.CustomerAddressLine4;
            inpOrder.CustomerAddressPostcode = SampleOrder5.CustomerAddressPostcode;
            inpOrder.CustomerAddressTown = SampleOrder5.CustomerAddressTown;
            inpOrder.CustomerBusinessName = SampleOrder5.CustomerBusinessName;
            inpOrder.CustomerContactName = SampleOrder5.CustomerContactName;
            inpOrder.CustomerCountryCode = SampleOrder5.CustomerCountryCode;
            inpOrder.CustomerEmailAddress = SampleOrder5.CustomerEmailAddress;
            inpOrder.CustomerId = SampleOrder5.CustomerId;
            inpOrder.CustomerPhoneNumber = SampleOrder5.CustomerPhoneNumber;
            inpOrder.CustomerSafeplace = SampleOrder5.CustomerSafeplace;
            inpOrder.CustomerVatNumber = SampleOrder5.CustomerVatNumber;
            inpOrder.CustomsCurrency = SampleOrder5.CustomsCurrency;
            inpOrder.CustomsDescriptionOfGoods = SampleOrder5.CustomsDescriptionOfGoods;
            inpOrder.CustomsExportLicence = SampleOrder5.CustomsExportLicence;
            inpOrder.CustomsIncoterms = SampleOrder5.CustomsIncoterms;
            inpOrder.CustomsInvoiceDate = Convert.ToDateTime(SampleOrder5.CustomsInvoiceDate);
            inpOrder.CustomsInvoiceNumber = SampleOrder5.CustomsInvoiceNumber;
            inpOrder.CustomsLabelFormat = SampleOrder5.CustomsLabelFormat;
            inpOrder.CustomsOtherCharges = SampleOrder5.CustomsOtherCharges;
            inpOrder.CustomsPreRegistrationNumber = SampleOrder5.CustomsPreRegistrationNumber;
            inpOrder.CustomsPreRegistrationType = SampleOrder5.CustomsPreRegistrationType;
            inpOrder.CustomsProduct = SampleOrder5.CustomsProduct;
            inpOrder.CustomsQuotedLandedCost = SampleOrder5.CustomsQuotedLandedCost;
            inpOrder.CustomsReasonForExport = SampleOrder5.CustomsReasonForExport;
            inpOrder.CustomsShipmentAction = SampleOrder5.CustomsShipmentAction;
            inpOrder.CustomsShippingCharges = SampleOrder5.CustomsShippingCharges;
            inpOrder.CustomsSilentPrintProfile = SampleOrder5.CustomsSilentPrintProfile;
            inpOrder.CustomsValue = SampleOrder5.CustomsValue;
            inpOrder.Department = SampleOrder5.Department;
            inpOrder.PostageType = SampleOrder5.PostageType;
            inpOrder.PostingConsequentialLoss = SampleOrder5.PostingConsequentialLoss;
            inpOrder.PostingDate = Convert.ToDateTime(SampleOrder5.PostingDate);
            inpOrder.PostingLocalCollect = SampleOrder5.PostingLocalCollect;
            inpOrder.PostingLocation = SampleOrder5.PostingLocation;
            inpOrder.PostingRecordedSignedFor = SampleOrder5.PostingRecordedSignedFor;
            inpOrder.PostingSaturdayGuaranteed = SampleOrder5.PostingSaturdayGuaranteed;
            inpOrder.PostingServiceFormat = SampleOrder5.PostingServiceFormat;
            inpOrder.PostingServiceLevel = SampleOrder5.PostingServiceLevel;
            inpOrder.PostingTrackingNotifications = SampleOrder5.PostingTrackingNotifications;
            inpOrder.PostingWeightUOM = SampleOrder5.PostingWeightUOM;
            inpOrder.SupplierAddressCounty = SampleOrder5.SupplierAddressCounty;
            inpOrder.SupplierAddressLine1 = SampleOrder5.SupplierAddressLine1;
            inpOrder.SupplierAddressLine2 = SampleOrder5.SupplierAddressLine2;
            inpOrder.SupplierAddressLine3 = SampleOrder5.SupplierAddressLine3;
            inpOrder.SupplierAddressLine4 = SampleOrder5.SupplierAddressLine4;
            inpOrder.SupplierAddressPostcode = SampleOrder5.SupplierAddressPostcode;
            inpOrder.SupplierAddressTown = SampleOrder5.SupplierAddressTown;
            inpOrder.SupplierBusinessName = SampleOrder5.SupplierBusinessName;
            inpOrder.SupplierContactName = SampleOrder5.SupplierCountryCode;
            inpOrder.SupplierCountryCode = SampleOrder5.SupplierCountryCode;
            inpOrder.SupplierEmailAddress = SampleOrder5.SupplierEmailAddress;
            inpOrder.SupplierId = SampleOrder5.SupplierId;
            inpOrder.SupplierPhoneNumber = SampleOrder5.SupplierPhoneNumber;
            inpOrder.SupplierReference1 = SampleOrder5.SupplierReference1;
            inpOrder.SupplierReference2 = SampleOrder5.SupplierReference2;
            inpOrder.SupplierVatNumber = SampleOrder5.SupplierVatNumber;

            inpOrder.AddItem();
            inpOrder.ItemCountryOfOrigin = SampleOrder5.Item1CountryOfOrigin;
            inpOrder.ItemDescription = SampleOrder5.Item1Description;
            inpOrder.ItemHsCode = SampleOrder5.Item1HsCode;
            inpOrder.ItemId = SampleOrder5.Item1Id;
            inpOrder.ItemImageUrl = SampleOrder5.Item1ImageUrl;
            inpOrder.ItemParcelInstance = SampleOrder5.Item1ParcelInstance;
            inpOrder.ItemQuantity = SampleOrder5.Item1Quantity;
            inpOrder.ItemSkuCode = SampleOrder5.Item1SkuCode;
            inpOrder.ItemValue = SampleOrder5.Item1Value;
            inpOrder.ItemWeight = SampleOrder5.Item1Weight;

            inpOrder.AddParcel();
            inpOrder.ParcelHeight = SampleOrder5.Parcel1Height;
            inpOrder.ParcelId = SampleOrder5.Parcel1Id;
            inpOrder.ParcelInstance = SampleOrder5.Parcel1Instance;
            inpOrder.ParcelLength = SampleOrder5.Parcel1Length;
            inpOrder.ParcelWeight = SampleOrder5.Parcel1Weight;
            inpOrder.ParcelWidth = SampleOrder5.Parcel1Width;

            return inpOrder;
        }
    }
}
