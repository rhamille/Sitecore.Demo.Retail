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
    public partial class oagXML : XmlDocumentBase
    {
     
   
        private responseHeader headerField;

        private responseBody bodyField;

        /// <remarks/>
        public responseHeader header
        {
            get
            {
                return this.headerField;
            }
            set
            {
                this.headerField = value;
            }
        }

        /// <remarks/>
        public responseBody body
        {
            get
            {
                return this.bodyField;
            }
            set
            {
                this.bodyField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseHeader
    {

        private responseHeaderReturn returnField;

        private decimal versionField;

        /// <remarks/>
        public responseHeaderReturn @return
        {
            get
            {
                return this.returnField;
            }
            set
            {
                this.returnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal version
        {
            get
            {
                return this.versionField;
            }
            set
            {
                this.versionField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseHeaderReturn
    {

        private string returnCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string returnCode
        {
            get
            {
                return this.returnCodeField;
            }
            set
            {
                this.returnCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseBody
    {

        private responseBodyOrderLine[] orderLinesDataElementsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("orderLine", IsNullable = false)]
        public responseBodyOrderLine[] OrderLinesDataElements
        {
            get
            {
                return this.orderLinesDataElementsField;
            }
            set
            {
                this.orderLinesDataElementsField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseBodyOrderLine
    {

        private responseBodyOrderLineItem itemField;

        private responseBodyOrderLineCategory categoryField;

        private responseBodyOrderLinePrice priceField;

        private responseBodyOrderLineSupplier supplierField;

        private responseBodyOrderLineAdditionalAttributes additionalAttributesField;

        /// <remarks/>
        public responseBodyOrderLineItem item
        {
            get
            {
                return this.itemField;
            }
            set
            {
                this.itemField = value;
            }
        }

        /// <remarks/>
        public responseBodyOrderLineCategory category
        {
            get
            {
                return this.categoryField;
            }
            set
            {
                this.categoryField = value;
            }
        }

        /// <remarks/>
        public responseBodyOrderLinePrice price
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
        public responseBodyOrderLineSupplier supplier
        {
            get
            {
                return this.supplierField;
            }
            set
            {
                this.supplierField = value;
            }
        }

        /// <remarks/>
        public responseBodyOrderLineAdditionalAttributes additionalAttributes
        {
            get
            {
                return this.additionalAttributesField;
            }
            set
            {
                this.additionalAttributesField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseBodyOrderLineItem
    {

        private responseBodyOrderLineItemItemNumber itemNumberField;

        private string itemDescriptionField;

        private responseBodyOrderLineItemUnitOfMeasure unitOfMeasureField;

        private string lineTypeField;

        private byte quantityField;

        /// <remarks/>
        public responseBodyOrderLineItemItemNumber itemNumber
        {
            get
            {
                return this.itemNumberField;
            }
            set
            {
                this.itemNumberField = value;
            }
        }

        /// <remarks/>
        public string itemDescription
        {
            get
            {
                return this.itemDescriptionField;
            }
            set
            {
                this.itemDescriptionField = value;
            }
        }

        /// <remarks/>
        public responseBodyOrderLineItemUnitOfMeasure unitOfMeasure
        {
            get
            {
                return this.unitOfMeasureField;
            }
            set
            {
                this.unitOfMeasureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lineType
        {
            get
            {
                return this.lineTypeField;
            }
            set
            {
                this.lineTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte quantity
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
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseBodyOrderLineItemItemNumber
    {

        private responseBodyOrderLineItemItemNumberSupplierItemNumber supplierItemNumberField;

        /// <remarks/>
        public responseBodyOrderLineItemItemNumberSupplierItemNumber supplierItemNumber
        {
            get
            {
                return this.supplierItemNumberField;
            }
            set
            {
                this.supplierItemNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseBodyOrderLineItemItemNumberSupplierItemNumber
    {

        private string itemIDField;

        /// <remarks/>
        public string itemID
        {
            get
            {
                return this.itemIDField;
            }
            set
            {
                this.itemIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseBodyOrderLineItemUnitOfMeasure
    {

        private responseBodyOrderLineItemUnitOfMeasureSupplierUnitOfMeasure supplierUnitOfMeasureField;

        /// <remarks/>
        public responseBodyOrderLineItemUnitOfMeasureSupplierUnitOfMeasure supplierUnitOfMeasure
        {
            get
            {
                return this.supplierUnitOfMeasureField;
            }
            set
            {
                this.supplierUnitOfMeasureField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseBodyOrderLineItemUnitOfMeasureSupplierUnitOfMeasure
    {

        private string supplierUOMTypeField;

        private object supplierUOMQuantityField;

        /// <remarks/>
        public string supplierUOMType
        {
            get
            {
                return this.supplierUOMTypeField;
            }
            set
            {
                this.supplierUOMTypeField = value;
            }
        }

        /// <remarks/>
        public object supplierUOMQuantity
        {
            get
            {
                return this.supplierUOMQuantityField;
            }
            set
            {
                this.supplierUOMQuantityField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseBodyOrderLineCategory
    {

        private responseBodyOrderLineCategoryCategoryCode categoryCodeField;

        /// <remarks/>
        public responseBodyOrderLineCategoryCategoryCode categoryCode
        {
            get
            {
                return this.categoryCodeField;
            }
            set
            {
                this.categoryCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseBodyOrderLineCategoryCategoryCode
    {

        private string categoryCodeIdentifierField;

        private uint valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string categoryCodeIdentifier
        {
            get
            {
                return this.categoryCodeIdentifierField;
            }
            set
            {
                this.categoryCodeIdentifierField = value;
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
    public partial class responseBodyOrderLinePrice
    {

        private string currencyField;

        private decimal unitPriceField;

        /// <remarks/>
        public string currency
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
        public decimal unitPrice
        {
            get
            {
                return this.unitPriceField;
            }
            set
            {
                this.unitPriceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseBodyOrderLineSupplier
    {

        private uint supplierDUNSField;

        private string supplierNameField;

        /// <remarks/>
        public uint supplierDUNS
        {
            get
            {
                return this.supplierDUNSField;
            }
            set
            {
                this.supplierDUNSField = value;
            }
        }

        /// <remarks/>
        public string supplierName
        {
            get
            {
                return this.supplierNameField;
            }
            set
            {
                this.supplierNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseBodyOrderLineAdditionalAttributes
    {

        private responseBodyOrderLineAdditionalAttribute[] attributes;


        /// <remarks/>
        public responseBodyOrderLineAdditionalAttribute[] Attributes
        {
            get
            {
                return this.attributes;
            }
            set
            {
                this.attributes = value;
            }
        }

    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class responseBodyOrderLineAdditionalAttribute
    {

        private string nameField;

        private string typeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this.typeField;
            }
            set
            {
                this.typeField = value;
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

   


}