/* 
 Licensed under the Apache License, Version 2.0

 http://www.apache.org/licenses/LICENSE-2.0
 */
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Xml;

namespace Sitecore.Feature.Commerce.Orders.Website.Templates
{


    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class ociXML : XmlDocumentBase
    {

        private object catalogHeaderField;

        private BusinessDocumentCatalog catalogField;

        /// <remarks/>
        public object CatalogHeader
        {
            get
            {
                return this.catalogHeaderField;
            }
            set
            {
                this.catalogHeaderField = value;
            }
        }

        /// <remarks/>
        public BusinessDocumentCatalog Catalog
        {
            get
            {
                return this.catalogField;
            }
            set
            {
                this.catalogField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BusinessDocumentCatalog
    {

        private byte catalogIDField;

        private BusinessDocumentCatalogProduct[] productField;

        /// <remarks/>
        public byte CatalogID
        {
            get
            {
                return this.catalogIDField;
            }
            set
            {
                this.catalogIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Product")]
        public BusinessDocumentCatalogProduct[] Product
        {
            get
            {
                return this.productField;
            }
            set
            {
                this.productField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BusinessDocumentCatalogProduct
    {

        private BusinessDocumentCatalogProductProductID productIDField;

        private ushort catalogKeyField;

        private uint parentCategoryIDField;

        private bool parentCategoryIDFieldSpecified;

        private BusinessDocumentCatalogProductDescription descriptionField;

        private BusinessDocumentCatalogProductShoppingBasketItem shoppingBasketItemField;

        private BusinessDocumentCatalogProductManufacturerDescription manufacturerDescriptionField;

        private BusinessDocumentCatalogProductVendorDescription vendorDescriptionField;

        private string[] textField;

        private string productTypeField;

        /// <remarks/>
        public BusinessDocumentCatalogProductProductID ProductID
        {
            get
            {
                return this.productIDField;
            }
            set
            {
                this.productIDField = value;
            }
        }

        /// <remarks/>
        public ushort CatalogKey
        {
            get
            {
                return this.catalogKeyField;
            }
            set
            {
                this.catalogKeyField = value;
            }
        }

        /// <remarks/>
        public uint ParentCategoryID
        {
            get
            {
                return this.parentCategoryIDField;
            }
            set
            {
                this.parentCategoryIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ParentCategoryIDSpecified
        {
            get
            {
                return this.parentCategoryIDFieldSpecified;
            }
            set
            {
                this.parentCategoryIDFieldSpecified = value;
            }
        }

        /// <remarks/>
        public BusinessDocumentCatalogProductDescription Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public BusinessDocumentCatalogProductShoppingBasketItem ShoppingBasketItem
        {
            get
            {
                return this.shoppingBasketItemField;
            }
            set
            {
                this.shoppingBasketItemField = value;
            }
        }

        /// <remarks/>
        public BusinessDocumentCatalogProductManufacturerDescription ManufacturerDescription
        {
            get
            {
                return this.manufacturerDescriptionField;
            }
            set
            {
                this.manufacturerDescriptionField = value;
            }
        }

        /// <remarks/>
        public BusinessDocumentCatalogProductVendorDescription VendorDescription
        {
            get
            {
                return this.vendorDescriptionField;
            }
            set
            {
                this.vendorDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProductType
        {
            get
            {
                return this.productTypeField;
            }
            set
            {
                this.productTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BusinessDocumentCatalogProductProductID
    {

        private string codeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BusinessDocumentCatalogProductDescription
    {

        private string languageField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BusinessDocumentCatalogProductShoppingBasketItem
    {

        private BusinessDocumentCatalogProductShoppingBasketItemQuantity quantityField;

        private BusinessDocumentCatalogProductShoppingBasketItemNetPrice netPriceField;

        private byte leadTimeField;

        private BusinessDocumentCatalogProductShoppingBasketItemQuote quoteField;

        private BusinessDocumentCatalogProductShoppingBasketItemItemText itemTextField;

        private string[] textField;

        private byte refVendorDescriptionField;

        private byte refManufacturerDescriptionField;

        /// <remarks/>
        public BusinessDocumentCatalogProductShoppingBasketItemQuantity Quantity
        {
            get
            {
                return this.quantityField;
            }
            set
            {
                this.quantityField = value;
            }
        }

        /// <remarks/>
        public BusinessDocumentCatalogProductShoppingBasketItemNetPrice NetPrice
        {
            get
            {
                return this.netPriceField;
            }
            set
            {
                this.netPriceField = value;
            }
        }

        /// <remarks/>
        public byte LeadTime
        {
            get
            {
                return this.leadTimeField;
            }
            set
            {
                this.leadTimeField = value;
            }
        }

        /// <remarks/>
        public BusinessDocumentCatalogProductShoppingBasketItemQuote Quote
        {
            get
            {
                return this.quoteField;
            }
            set
            {
                this.quoteField = value;
            }
        }

        /// <remarks/>
        public BusinessDocumentCatalogProductShoppingBasketItemItemText ItemText
        {
            get
            {
                return this.itemTextField;
            }
            set
            {
                this.itemTextField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string[] Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte RefVendorDescription
        {
            get
            {
                return this.refVendorDescriptionField;
            }
            set
            {
                this.refVendorDescriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte RefManufacturerDescription
        {
            get
            {
                return this.refManufacturerDescriptionField;
            }
            set
            {
                this.refManufacturerDescriptionField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BusinessDocumentCatalogProductShoppingBasketItemQuantity
    {

        private string uoMField;

        private byte valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UoM
        {
            get
            {
                return this.uoMField;
            }
            set
            {
                this.uoMField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public byte Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BusinessDocumentCatalogProductShoppingBasketItemNetPrice
    {

        private BusinessDocumentCatalogProductShoppingBasketItemNetPricePrice priceField;

        private byte priceUnitField;

        private bool priceUnitFieldSpecified;

        /// <remarks/>
        public BusinessDocumentCatalogProductShoppingBasketItemNetPricePrice Price
        {
            get
            {
                return this.priceField;
            }
            set
            {
                this.priceField = value;
            }
        }

        /// <remarks/>
        public byte PriceUnit
        {
            get
            {
                return this.priceUnitField;
            }
            set
            {
                this.priceUnitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PriceUnitSpecified
        {
            get
            {
                return this.priceUnitFieldSpecified;
            }
            set
            {
                this.priceUnitFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BusinessDocumentCatalogProductShoppingBasketItemNetPricePrice
    {

        private string currencyField;

        private decimal valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Currency
        {
            get
            {
                return this.currencyField;
            }
            set
            {
                this.currencyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BusinessDocumentCatalogProductShoppingBasketItemQuote
    {

        private ushort quoteIDField;

        private ushort quoteItemIDField;

        /// <remarks/>
        public ushort QuoteID
        {
            get
            {
                return this.quoteIDField;
            }
            set
            {
                this.quoteIDField = value;
            }
        }

        /// <remarks/>
        public ushort QuoteItemID
        {
            get
            {
                return this.quoteItemIDField;
            }
            set
            {
                this.quoteItemIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BusinessDocumentCatalogProductShoppingBasketItemItemText
    {

        private string languageField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Language
        {
            get
            {
                return this.languageField;
            }
            set
            {
                this.languageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BusinessDocumentCatalogProductManufacturerDescription
    {

        private BusinessDocumentCatalogProductManufacturerDescriptionPartnerProductID partnerProductIDField;

        private BusinessDocumentCatalogProductManufacturerDescriptionPartnerID partnerIDField;

        private byte idField;

        /// <remarks/>
        public BusinessDocumentCatalogProductManufacturerDescriptionPartnerProductID PartnerProductID
        {
            get
            {
                return this.partnerProductIDField;
            }
            set
            {
                this.partnerProductIDField = value;
            }
        }

        /// <remarks/>
        public BusinessDocumentCatalogProductManufacturerDescriptionPartnerID PartnerID
        {
            get
            {
                return this.partnerIDField;
            }
            set
            {
                this.partnerIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BusinessDocumentCatalogProductManufacturerDescriptionPartnerProductID
    {

        private string codeField;

        private ushort valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public ushort Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BusinessDocumentCatalogProductManufacturerDescriptionPartnerID
    {

        private string codeField;

        private ushort valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public ushort Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BusinessDocumentCatalogProductVendorDescription
    {

        private BusinessDocumentCatalogProductVendorDescriptionPartnerProductID partnerProductIDField;

        private BusinessDocumentCatalogProductVendorDescriptionPartnerID partnerIDField;

        private byte leadTimeField;

        private BusinessDocumentCatalogProductVendorDescriptionBuyerContract buyerContractField;

        private byte idField;

        /// <remarks/>
        public BusinessDocumentCatalogProductVendorDescriptionPartnerProductID PartnerProductID
        {
            get
            {
                return this.partnerProductIDField;
            }
            set
            {
                this.partnerProductIDField = value;
            }
        }

        /// <remarks/>
        public BusinessDocumentCatalogProductVendorDescriptionPartnerID PartnerID
        {
            get
            {
                return this.partnerIDField;
            }
            set
            {
                this.partnerIDField = value;
            }
        }

        /// <remarks/>
        public byte LeadTime
        {
            get
            {
                return this.leadTimeField;
            }
            set
            {
                this.leadTimeField = value;
            }
        }

        /// <remarks/>
        public BusinessDocumentCatalogProductVendorDescriptionBuyerContract BuyerContract
        {
            get
            {
                return this.buyerContractField;
            }
            set
            {
                this.buyerContractField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte ID
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BusinessDocumentCatalogProductVendorDescriptionPartnerProductID
    {

        private string codeField;

        private uint valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public uint Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BusinessDocumentCatalogProductVendorDescriptionPartnerID
    {

        private string codeField;

        private ushort valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Code
        {
            get
            {
                return this.codeField;
            }
            set
            {
                this.codeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public ushort Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class BusinessDocumentCatalogProductVendorDescriptionBuyerContract
    {

        private ushort contractIDField;

        private ushort contractItemIDField;

        /// <remarks/>
        public ushort ContractID
        {
            get
            {
                return this.contractIDField;
            }
            set
            {
                this.contractIDField = value;
            }
        }

        /// <remarks/>
        public ushort ContractItemID
        {
            get
            {
                return this.contractItemIDField;
            }
            set
            {
                this.contractItemIDField = value;
            }
        }
    }


}