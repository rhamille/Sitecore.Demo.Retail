using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Xml.Serialization;
namespace Sitecore.Feature.Commerce.Orders.Website.Templates
{/*

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Name
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Extrinsic
    {

        private System.Xml.XmlNode[] anyField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Description
    {

        private string[] itemsField;

        private string[] textField;

        private string langField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShortName")]
        public string[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class CountryCode
    {

        private string isoCountryCodeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string isoCountryCode
        {
            get
            {
                return this.isoCountryCodeField;
            }
            set
            {
                this.isoCountryCodeField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class TelephoneNumber
    {

        private CountryCode countryCodeField;

        private string areaOrCityCodeField;

        private string numberField;

        private string extensionField;

        /// <remarks/>
        public CountryCode CountryCode
        {
            get
            {
                return this.countryCodeField;
            }
            set
            {
                this.countryCodeField = value;
            }
        }

        /// <remarks/>
        public string AreaOrCityCode
        {
            get
            {
                return this.areaOrCityCodeField;
            }
            set
            {
                this.areaOrCityCodeField = value;
            }
        }

        /// <remarks/>
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        public string Extension
        {
            get
            {
                return this.extensionField;
            }
            set
            {
                this.extensionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Phone
    {

        private TelephoneNumber telephoneNumberField;

        private string nameField;

        /// <remarks/>
        public TelephoneNumber TelephoneNumber
        {
            get
            {
                return this.telephoneNumberField;
            }
            set
            {
                this.telephoneNumberField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Fax
    {

        private object itemField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Email", typeof(Email))]
        [System.Xml.Serialization.XmlElementAttribute("TelephoneNumber", typeof(TelephoneNumber))]
        [System.Xml.Serialization.XmlElementAttribute("URL", typeof(URL))]
        public object Item
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Email
    {

        private string nameField;

        private string preferredLangField;

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
        public string preferredLang
        {
            get
            {
                return this.preferredLangField;
            }
            set
            {
                this.preferredLangField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class URL
    {

        private string nameField;

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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Contact
    {

        private Name nameField;

        private PostalAddress[] postalAddressField;

        private Email[] emailField;

        private Phone[] phoneField;

        private Fax[] faxField;

        private URL[] uRLField;

        private IdReference[] idReferenceField;

        private Extrinsic[] extrinsicField;

        private string roleField;

        private string addressIDField;

        private string addressIDDomainField;

        /// <remarks/>
        public Name Name
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
        [System.Xml.Serialization.XmlElementAttribute("PostalAddress")]
        public PostalAddress[] PostalAddress
        {
            get
            {
                return this.postalAddressField;
            }
            set
            {
                this.postalAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Email")]
        public Email[] Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Phone")]
        public Phone[] Phone
        {
            get
            {
                return this.phoneField;
            }
            set
            {
                this.phoneField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Fax")]
        public Fax[] Fax
        {
            get
            {
                return this.faxField;
            }
            set
            {
                this.faxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("URL")]
        public URL[] URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IdReference")]
        public IdReference[] IdReference
        {
            get
            {
                return this.idReferenceField;
            }
            set
            {
                this.idReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Extrinsic")]
        public Extrinsic[] Extrinsic
        {
            get
            {
                return this.extrinsicField;
            }
            set
            {
                this.extrinsicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string role
        {
            get
            {
                return this.roleField;
            }
            set
            {
                this.roleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string addressID
        {
            get
            {
                return this.addressIDField;
            }
            set
            {
                this.addressIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string addressIDDomain
        {
            get
            {
                return this.addressIDDomainField;
            }
            set
            {
                this.addressIDDomainField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class PostalAddress
    {

        private string[] deliverToField;

        private string[] streetField;

        private City cityField;

        private Municipality municipalityField;

        private State stateField;

        private string postalCodeField;

        private Country countryField;

        private Extrinsic[] extrinsicField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeliverTo")]
        public string[] DeliverTo
        {
            get
            {
                return this.deliverToField;
            }
            set
            {
                this.deliverToField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Street")]
        public string[] Street
        {
            get
            {
                return this.streetField;
            }
            set
            {
                this.streetField = value;
            }
        }

        /// <remarks/>
        public City City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public Municipality Municipality
        {
            get
            {
                return this.municipalityField;
            }
            set
            {
                this.municipalityField = value;
            }
        }

        /// <remarks/>
        public State State
        {
            get
            {
                return this.stateField;
            }
            set
            {
                this.stateField = value;
            }
        }

        /// <remarks/>
        public string PostalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }

        /// <remarks/>
        public Country Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Extrinsic")]
        public Extrinsic[] Extrinsic
        {
            get
            {
                return this.extrinsicField;
            }
            set
            {
                this.extrinsicField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class City
    {

        private string cityCodeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cityCode
        {
            get
            {
                return this.cityCodeField;
            }
            set
            {
                this.cityCodeField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Municipality
    {

        private string municipalityCodeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string municipalityCode
        {
            get
            {
                return this.municipalityCodeField;
            }
            set
            {
                this.municipalityCodeField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class State
    {

        private string isoStateCodeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string isoStateCode
        {
            get
            {
                return this.isoStateCodeField;
            }
            set
            {
                this.isoStateCodeField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Country
    {

        private string isoCountryCodeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string isoCountryCode
        {
            get
            {
                return this.isoCountryCodeField;
            }
            set
            {
                this.isoCountryCodeField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class IdReference
    {

        private Creator creatorField;

        private Description descriptionField;

        private string identifierField;

        private string domainField;

        /// <remarks/>
        public Creator Creator
        {
            get
            {
                return this.creatorField;
            }
            set
            {
                this.creatorField = value;
            }
        }

        /// <remarks/>
        public Description Description
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string domain
        {
            get
            {
                return this.domainField;
            }
            set
            {
                this.domainField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Creator
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Address
    {

        private Name nameField;

        private PostalAddress postalAddressField;

        private Email emailField;

        private Phone phoneField;

        private Fax faxField;

        private URL uRLField;

        private string isoCountryCodeField;

        private string addressIDField;

        private string addressIDDomainField;

        /// <remarks/>
        public Name Name
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
        public PostalAddress PostalAddress
        {
            get
            {
                return this.postalAddressField;
            }
            set
            {
                this.postalAddressField = value;
            }
        }

        /// <remarks/>
        public Email Email
        {
            get
            {
                return this.emailField;
            }
            set
            {
                this.emailField = value;
            }
        }

        /// <remarks/>
        public Phone Phone
        {
            get
            {
                return this.phoneField;
            }
            set
            {
                this.phoneField = value;
            }
        }

        /// <remarks/>
        public Fax Fax
        {
            get
            {
                return this.faxField;
            }
            set
            {
                this.faxField = value;
            }
        }

        /// <remarks/>
        public URL URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string isoCountryCode
        {
            get
            {
                return this.isoCountryCodeField;
            }
            set
            {
                this.isoCountryCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string addressID
        {
            get
            {
                return this.addressIDField;
            }
            set
            {
                this.addressIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string addressIDDomain
        {
            get
            {
                return this.addressIDDomainField;
            }
            set
            {
                this.addressIDDomainField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class PartnerContact
    {

        private Contact contactField;

        private IdReference[] idReferenceField;

        /// <remarks/>
        public Contact Contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IdReference")]
        public IdReference[] IdReference
        {
            get
            {
                return this.idReferenceField;
            }
            set
            {
                this.idReferenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Issuer
    {

        private Address addressField;

        /// <remarks/>
        public Address Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Money
    {

        private string currencyField;

        private string alternateAmountField;

        private string alternateCurrencyField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string alternateAmount
        {
            get
            {
                return this.alternateAmountField;
            }
            set
            {
                this.alternateAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string alternateCurrency
        {
            get
            {
                return this.alternateCurrencyField;
            }
            set
            {
                this.alternateCurrencyField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Comments
    {

        private Attachment[] itemsField;

        private string[] textField;

        private string langField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Attachment")]
        public Attachment[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Attachment
    {

        private URL uRLField;

        private AttachmentVisibility visibilityField;

        private bool visibilityFieldSpecified;

        /// <remarks/>
        public URL URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AttachmentVisibility visibility
        {
            get
            {
                return this.visibilityField;
            }
            set
            {
                this.visibilityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool visibilitySpecified
        {
            get
            {
                return this.visibilityFieldSpecified;
            }
            set
            {
                this.visibilityFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum AttachmentVisibility
    {

        /// <remarks/>
        @internal,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class AttachmentReference
    {

        private Name nameField;

        private Description descriptionField;

        private InternalID internalIDField;

        private URL uRLField;

        private string lengthField;

        private string versionField;

        /// <remarks/>
        public Name Name
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
        public Description Description
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
        public InternalID InternalID
        {
            get
            {
                return this.internalIDField;
            }
            set
            {
                this.internalIDField = value;
            }
        }

        /// <remarks/>
        public URL URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string length
        {
            get
            {
                return this.lengthField;
            }
            set
            {
                this.lengthField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InternalID
    {

        private string domainField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string domain
        {
            get
            {
                return this.domainField;
            }
            set
            {
                this.domainField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class UnitPrice
    {

        private Money moneyField;

        private Modification[] modificationsField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Modification", IsNullable = false)]
        public Modification[] Modifications
        {
            get
            {
                return this.modificationsField;
            }
            set
            {
                this.modificationsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Modification
    {

        private OriginalPrice originalPriceField;

        private object itemField;

        private Tax taxField;

        private ModificationDetail modificationDetailField;

        private string levelField;

        /// <remarks/>
        public OriginalPrice OriginalPrice
        {
            get
            {
                return this.originalPriceField;
            }
            set
            {
                this.originalPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AdditionalCost", typeof(AdditionalCost))]
        [System.Xml.Serialization.XmlElementAttribute("AdditionalDeduction", typeof(AdditionalDeduction))]
        public object Item
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
        public Tax Tax
        {
            get
            {
                return this.taxField;
            }
            set
            {
                this.taxField = value;
            }
        }

        /// <remarks/>
        public ModificationDetail ModificationDetail
        {
            get
            {
                return this.modificationDetailField;
            }
            set
            {
                this.modificationDetailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string level
        {
            get
            {
                return this.levelField;
            }
            set
            {
                this.levelField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class OriginalPrice
    {

        private Money moneyField;

        private string typeField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class AdditionalCost
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Money", typeof(Money))]
        [System.Xml.Serialization.XmlElementAttribute("Percentage", typeof(Percentage))]
        public object Item
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Percentage
    {

        private string percentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string percent
        {
            get
            {
                return this.percentField;
            }
            set
            {
                this.percentField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class AdditionalDeduction
    {

        private object itemField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeductedPrice", typeof(DeductedPrice))]
        [System.Xml.Serialization.XmlElementAttribute("DeductionAmount", typeof(DeductionAmount))]
        [System.Xml.Serialization.XmlElementAttribute("DeductionPercent", typeof(DeductionPercent))]
        public object Item
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class DeductedPrice
    {

        private Money moneyField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class DeductionAmount
    {

        private Money moneyField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class DeductionPercent
    {

        private string percentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string percent
        {
            get
            {
                return this.percentField;
            }
            set
            {
                this.percentField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Tax
    {

        private Money moneyField;

        private Description descriptionField;

        private TaxDetail[] taxDetailField;

        private Distribution[] distributionField;

        private Extrinsic[] extrinsicField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }

        /// <remarks/>
        public Description Description
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
        [System.Xml.Serialization.XmlElementAttribute("TaxDetail")]
        public TaxDetail[] TaxDetail
        {
            get
            {
                return this.taxDetailField;
            }
            set
            {
                this.taxDetailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Distribution")]
        public Distribution[] Distribution
        {
            get
            {
                return this.distributionField;
            }
            set
            {
                this.distributionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Extrinsic")]
        public Extrinsic[] Extrinsic
        {
            get
            {
                return this.extrinsicField;
            }
            set
            {
                this.extrinsicField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class TaxDetail
    {

        private TaxableAmount taxableAmountField;

        private TaxAmount taxAmountField;

        private TaxLocation taxLocationField;

        private Description descriptionField;

        private TriangularTransactionLawReference triangularTransactionLawReferenceField;

        private string taxRegimeField;

        private TaxExemption taxExemptionField;

        private Extrinsic[] extrinsicField;

        private string taxedElementField;

        private string purposeField;

        private string categoryField;

        private string percentageRateField;

        private TaxDetailIsVatRecoverable isVatRecoverableField;

        private bool isVatRecoverableFieldSpecified;

        private string taxPointDateField;

        private string paymentDateField;

        private TaxDetailIsTriangularTransaction isTriangularTransactionField;

        private bool isTriangularTransactionFieldSpecified;

        private TaxDetailExemptDetail exemptDetailField;

        private bool exemptDetailFieldSpecified;

        private TaxDetailIsWithholdingTax isWithholdingTaxField;

        private bool isWithholdingTaxFieldSpecified;

        private string taxRateTypeField;

        private string basePercentageRateField;

        private TaxDetailIsIncludedInPrice isIncludedInPriceField;

        private bool isIncludedInPriceFieldSpecified;

        /// <remarks/>
        public TaxableAmount TaxableAmount
        {
            get
            {
                return this.taxableAmountField;
            }
            set
            {
                this.taxableAmountField = value;
            }
        }

        /// <remarks/>
        public TaxAmount TaxAmount
        {
            get
            {
                return this.taxAmountField;
            }
            set
            {
                this.taxAmountField = value;
            }
        }

        /// <remarks/>
        public TaxLocation TaxLocation
        {
            get
            {
                return this.taxLocationField;
            }
            set
            {
                this.taxLocationField = value;
            }
        }

        /// <remarks/>
        public Description Description
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
        public TriangularTransactionLawReference TriangularTransactionLawReference
        {
            get
            {
                return this.triangularTransactionLawReferenceField;
            }
            set
            {
                this.triangularTransactionLawReferenceField = value;
            }
        }

        /// <remarks/>
        public string TaxRegime
        {
            get
            {
                return this.taxRegimeField;
            }
            set
            {
                this.taxRegimeField = value;
            }
        }

        /// <remarks/>
        public TaxExemption TaxExemption
        {
            get
            {
                return this.taxExemptionField;
            }
            set
            {
                this.taxExemptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Extrinsic")]
        public Extrinsic[] Extrinsic
        {
            get
            {
                return this.extrinsicField;
            }
            set
            {
                this.extrinsicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "IDREF")]
        public string taxedElement
        {
            get
            {
                return this.taxedElementField;
            }
            set
            {
                this.taxedElementField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string purpose
        {
            get
            {
                return this.purposeField;
            }
            set
            {
                this.purposeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string category
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string percentageRate
        {
            get
            {
                return this.percentageRateField;
            }
            set
            {
                this.percentageRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TaxDetailIsVatRecoverable isVatRecoverable
        {
            get
            {
                return this.isVatRecoverableField;
            }
            set
            {
                this.isVatRecoverableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isVatRecoverableSpecified
        {
            get
            {
                return this.isVatRecoverableFieldSpecified;
            }
            set
            {
                this.isVatRecoverableFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string taxPointDate
        {
            get
            {
                return this.taxPointDateField;
            }
            set
            {
                this.taxPointDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string paymentDate
        {
            get
            {
                return this.paymentDateField;
            }
            set
            {
                this.paymentDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TaxDetailIsTriangularTransaction isTriangularTransaction
        {
            get
            {
                return this.isTriangularTransactionField;
            }
            set
            {
                this.isTriangularTransactionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isTriangularTransactionSpecified
        {
            get
            {
                return this.isTriangularTransactionFieldSpecified;
            }
            set
            {
                this.isTriangularTransactionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TaxDetailExemptDetail exemptDetail
        {
            get
            {
                return this.exemptDetailField;
            }
            set
            {
                this.exemptDetailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool exemptDetailSpecified
        {
            get
            {
                return this.exemptDetailFieldSpecified;
            }
            set
            {
                this.exemptDetailFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TaxDetailIsWithholdingTax isWithholdingTax
        {
            get
            {
                return this.isWithholdingTaxField;
            }
            set
            {
                this.isWithholdingTaxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isWithholdingTaxSpecified
        {
            get
            {
                return this.isWithholdingTaxFieldSpecified;
            }
            set
            {
                this.isWithholdingTaxFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string taxRateType
        {
            get
            {
                return this.taxRateTypeField;
            }
            set
            {
                this.taxRateTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string basePercentageRate
        {
            get
            {
                return this.basePercentageRateField;
            }
            set
            {
                this.basePercentageRateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TaxDetailIsIncludedInPrice isIncludedInPrice
        {
            get
            {
                return this.isIncludedInPriceField;
            }
            set
            {
                this.isIncludedInPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isIncludedInPriceSpecified
        {
            get
            {
                return this.isIncludedInPriceFieldSpecified;
            }
            set
            {
                this.isIncludedInPriceFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class TaxableAmount
    {

        private Money moneyField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class TaxAmount
    {

        private Money moneyField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class TaxLocation
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class TriangularTransactionLawReference
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class TaxExemption
    {

        private ExemptReason exemptReasonField;

        private string exemptCodeField;

        /// <remarks/>
        public ExemptReason ExemptReason
        {
            get
            {
                return this.exemptReasonField;
            }
            set
            {
                this.exemptReasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string exemptCode
        {
            get
            {
                return this.exemptCodeField;
            }
            set
            {
                this.exemptCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ExemptReason
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum TaxDetailIsVatRecoverable
    {

        /// <remarks/>
        yes,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum TaxDetailIsTriangularTransaction
    {

        /// <remarks/>
        yes,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum TaxDetailExemptDetail
    {

        /// <remarks/>
        zeroRated,

        /// <remarks/>
        exempt,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum TaxDetailIsWithholdingTax
    {

        /// <remarks/>
        yes,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum TaxDetailIsIncludedInPrice
    {

        /// <remarks/>
        yes,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Distribution
    {

        private Accounting accountingField;

        private Charge chargeField;

        /// <remarks/>
        public Accounting Accounting
        {
            get
            {
                return this.accountingField;
            }
            set
            {
                this.accountingField = value;
            }
        }

        /// <remarks/>
        public Charge Charge
        {
            get
            {
                return this.chargeField;
            }
            set
            {
                this.chargeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Accounting
    {

        private object[] itemsField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AccountingSegment", typeof(AccountingSegment))]
        [System.Xml.Serialization.XmlElementAttribute("Segment", typeof(Segment))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class AccountingSegment
    {

        private Name nameField;

        private Description descriptionField;

        private string idField;

        /// <remarks/>
        public Name Name
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
        public Description Description
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Segment
    {

        private string typeField;

        private string idField;

        private string descriptionField;

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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string description
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Charge
    {

        private Money moneyField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ModificationDetail
    {

        private Description descriptionField;

        private Extrinsic[] extrinsicField;

        private string nameField;

        private string codeField;

        private string startDateField;

        private string endDateField;

        /// <remarks/>
        public Description Description
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
        [System.Xml.Serialization.XmlElementAttribute("Extrinsic")]
        public Extrinsic[] Extrinsic
        {
            get
            {
                return this.extrinsicField;
            }
            set
            {
                this.extrinsicField = value;
            }
        }

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
        public string code
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string startDate
        {
            get
            {
                return this.startDateField;
            }
            set
            {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string endDate
        {
            get
            {
                return this.endDateField;
            }
            set
            {
                this.endDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class DocumentReference
    {

        private string payloadIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string payloadID
        {
            get
            {
                return this.payloadIDField;
            }
            set
            {
                this.payloadIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class BrowserFormPost
    {

        private URL uRLField;

        /// <remarks/>
        public URL URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class StartPage
    {

        private URL uRLField;

        /// <remarks/>
        public URL URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ReturnData
    {

        private string returnValueField;

        private Name nameField;

        private string nameField1;

        /// <remarks/>
        public string ReturnValue
        {
            get
            {
                return this.returnValueField;
            }
            set
            {
                this.returnValueField = value;
            }
        }

        /// <remarks/>
        public Name Name
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
        public string name
        {
            get
            {
                return this.nameField1;
            }
            set
            {
                this.nameField1 = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class TimeRange
    {

        private string startDateField;

        private string endDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string startDate
        {
            get
            {
                return this.startDateField;
            }
            set
            {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string endDate
        {
            get
            {
                return this.endDateField;
            }
            set
            {
                this.endDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Period
    {

        private string startDateField;

        private string endDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string startDate
        {
            get
            {
                return this.startDateField;
            }
            set
            {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string endDate
        {
            get
            {
                return this.endDateField;
            }
            set
            {
                this.endDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class PriceBasisQuantity
    {

        private string unitOfMeasureField;

        private Description descriptionField;

        private string quantityField;

        private string conversionFactorField;

        /// <remarks/>
        public string UnitOfMeasure
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
        public Description Description
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string quantity
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string conversionFactor
        {
            get
            {
                return this.conversionFactorField;
            }
            set
            {
                this.conversionFactorField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class TermReference
    {

        private string termNameField;

        private string termField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string termName
        {
            get
            {
                return this.termNameField;
            }
            set
            {
                this.termNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string term
        {
            get
            {
                return this.termField;
            }
            set
            {
                this.termField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class UnitRate
    {

        private Money moneyField;

        private string unitOfMeasureField;

        private PriceBasisQuantity priceBasisQuantityField;

        private TermReference termReferenceField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }

        /// <remarks/>
        public string UnitOfMeasure
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
        public PriceBasisQuantity PriceBasisQuantity
        {
            get
            {
                return this.priceBasisQuantityField;
            }
            set
            {
                this.priceBasisQuantityField = value;
            }
        }

        /// <remarks/>
        public TermReference TermReference
        {
            get
            {
                return this.termReferenceField;
            }
            set
            {
                this.termReferenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Rate
    {

        private Total totalField;

        private UnitRate unitRateField;

        private Description descriptionField;

        private string quantityField;

        /// <remarks/>
        public Total Total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        public UnitRate UnitRate
        {
            get
            {
                return this.unitRateField;
            }
            set
            {
                this.unitRateField = value;
            }
        }

        /// <remarks/>
        public Description Description
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string quantity
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Total
    {

        private Money moneyField;

        private Modification[] modificationsField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Modification", IsNullable = false)]
        public Modification[] Modifications
        {
            get
            {
                return this.modificationsField;
            }
            set
            {
                this.modificationsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Tolerances
    {

        private QuantityTolerance quantityToleranceField;

        private PriceTolerance priceToleranceField;

        private TimeTolerance timeToleranceField;

        /// <remarks/>
        public QuantityTolerance QuantityTolerance
        {
            get
            {
                return this.quantityToleranceField;
            }
            set
            {
                this.quantityToleranceField = value;
            }
        }

        /// <remarks/>
        public PriceTolerance PriceTolerance
        {
            get
            {
                return this.priceToleranceField;
            }
            set
            {
                this.priceToleranceField = value;
            }
        }

        /// <remarks/>
        public TimeTolerance TimeTolerance
        {
            get
            {
                return this.timeToleranceField;
            }
            set
            {
                this.timeToleranceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class QuantityTolerance
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Percentage", typeof(Percentage))]
        [System.Xml.Serialization.XmlElementAttribute("Value", typeof(Value))]
        public object Item
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Value
    {

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class PriceTolerance
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Money", typeof(Money))]
        [System.Xml.Serialization.XmlElementAttribute("Percentage", typeof(Percentage))]
        public object Item
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class TimeTolerance
    {

        private string limitField;

        private TimeToleranceType typeField;

        public TimeTolerance()
        {
            this.typeField = TimeToleranceType.days;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string limit
        {
            get
            {
                return this.limitField;
            }
            set
            {
                this.limitField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(TimeToleranceType.days)]
        public TimeToleranceType type
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum TimeToleranceType
    {

        /// <remarks/>
        minutes,

        /// <remarks/>
        hours,

        /// <remarks/>
        days,

        /// <remarks/>
        weeks,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Upper
    {

        private Tolerances tolerancesField;

        /// <remarks/>
        public Tolerances Tolerances
        {
            get
            {
                return this.tolerancesField;
            }
            set
            {
                this.tolerancesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Lower
    {

        private Tolerances tolerancesField;

        /// <remarks/>
        public Tolerances Tolerances
        {
            get
            {
                return this.tolerancesField;
            }
            set
            {
                this.tolerancesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Modifications
    {

        private Modification[] modificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Modification")]
        public Modification[] Modification
        {
            get
            {
                return this.modificationField;
            }
            set
            {
                this.modificationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Discount
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DiscountAmount", typeof(DiscountAmount))]
        [System.Xml.Serialization.XmlElementAttribute("DiscountPercent", typeof(DiscountPercent))]
        public object Item
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class DiscountAmount
    {

        private Money moneyField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class DiscountPercent
    {

        private string percentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string percent
        {
            get
            {
                return this.percentField;
            }
            set
            {
                this.percentField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class DiscountBasis
    {

        private Money moneyField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class TaxAdjustmentDetail
    {

        private Money moneyField;

        private string categoryField;

        private string regionField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string category
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string region
        {
            get
            {
                return this.regionField;
            }
            set
            {
                this.regionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class TaxAdjustment
    {

        private Money moneyField;

        private TaxAdjustmentDetail[] taxAdjustmentDetailField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TaxAdjustmentDetail")]
        public TaxAdjustmentDetail[] TaxAdjustmentDetail
        {
            get
            {
                return this.taxAdjustmentDetailField;
            }
            set
            {
                this.taxAdjustmentDetailField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ProductMovementItemIDInfo
    {

        private IdReference[] idReferenceField;

        private string movementLineNumberField;

        private string movementIDField;

        private string movementDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IdReference")]
        public IdReference[] IdReference
        {
            get
            {
                return this.idReferenceField;
            }
            set
            {
                this.idReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string movementLineNumber
        {
            get
            {
                return this.movementLineNumberField;
            }
            set
            {
                this.movementLineNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string movementID
        {
            get
            {
                return this.movementIDField;
            }
            set
            {
                this.movementIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string movementDate
        {
            get
            {
                return this.movementDateField;
            }
            set
            {
                this.movementDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceItemIDInfo
    {

        private IdReference[] idReferenceField;

        private string invoiceLineNumberField;

        private string invoiceIDField;

        private string invoiceDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IdReference")]
        public IdReference[] IdReference
        {
            get
            {
                return this.idReferenceField;
            }
            set
            {
                this.idReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string invoiceLineNumber
        {
            get
            {
                return this.invoiceLineNumberField;
            }
            set
            {
                this.invoiceLineNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string invoiceID
        {
            get
            {
                return this.invoiceIDField;
            }
            set
            {
                this.invoiceIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string invoiceDate
        {
            get
            {
                return this.invoiceDateField;
            }
            set
            {
                this.invoiceDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ReturnQuantity
    {

        private string unitOfMeasureField;

        private string quantityField;

        /// <remarks/>
        public string UnitOfMeasure
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
        public string quantity
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Characteristic
    {

        private string domainField;

        private string valueField;

        private string codeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string domain
        {
            get
            {
                return this.domainField;
            }
            set
            {
                this.domainField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class TotalRetailAmount
    {

        private Money moneyField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InformationalAmount
    {

        private Money moneyField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class GrossProgressPaymentAmount
    {

        private Money moneyField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class TotalReturnableItemsDepositAmount
    {

        private Money moneyField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class GoodsAndServiceAmount
    {

        private Money moneyField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ExactAmount
    {

        private Money moneyField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class AdditionalAmounts
    {

        private TotalRetailAmount totalRetailAmountField;

        private InformationalAmount informationalAmountField;

        private GrossProgressPaymentAmount grossProgressPaymentAmountField;

        private TotalReturnableItemsDepositAmount totalReturnableItemsDepositAmountField;

        private GoodsAndServiceAmount goodsAndServiceAmountField;

        private ExactAmount exactAmountField;

        /// <remarks/>
        public TotalRetailAmount TotalRetailAmount
        {
            get
            {
                return this.totalRetailAmountField;
            }
            set
            {
                this.totalRetailAmountField = value;
            }
        }

        /// <remarks/>
        public InformationalAmount InformationalAmount
        {
            get
            {
                return this.informationalAmountField;
            }
            set
            {
                this.informationalAmountField = value;
            }
        }

        /// <remarks/>
        public GrossProgressPaymentAmount GrossProgressPaymentAmount
        {
            get
            {
                return this.grossProgressPaymentAmountField;
            }
            set
            {
                this.grossProgressPaymentAmountField = value;
            }
        }

        /// <remarks/>
        public TotalReturnableItemsDepositAmount TotalReturnableItemsDepositAmount
        {
            get
            {
                return this.totalReturnableItemsDepositAmountField;
            }
            set
            {
                this.totalReturnableItemsDepositAmountField = value;
            }
        }

        /// <remarks/>
        public GoodsAndServiceAmount GoodsAndServiceAmount
        {
            get
            {
                return this.goodsAndServiceAmountField;
            }
            set
            {
                this.goodsAndServiceAmountField = value;
            }
        }

        /// <remarks/>
        public ExactAmount ExactAmount
        {
            get
            {
                return this.exactAmountField;
            }
            set
            {
                this.exactAmountField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class UnitGrossPrice
    {

        private Money moneyField;

        private PriceBasisQuantity priceBasisQuantityField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }

        /// <remarks/>
        public PriceBasisQuantity PriceBasisQuantity
        {
            get
            {
                return this.priceBasisQuantityField;
            }
            set
            {
                this.priceBasisQuantityField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InformationalPrice
    {

        private Money moneyField;

        private PriceBasisQuantity priceBasisQuantityField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }

        /// <remarks/>
        public PriceBasisQuantity PriceBasisQuantity
        {
            get
            {
                return this.priceBasisQuantityField;
            }
            set
            {
                this.priceBasisQuantityField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InformationalPriceExclTax
    {

        private Money moneyField;

        private PriceBasisQuantity priceBasisQuantityField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }

        /// <remarks/>
        public PriceBasisQuantity PriceBasisQuantity
        {
            get
            {
                return this.priceBasisQuantityField;
            }
            set
            {
                this.priceBasisQuantityField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class UnitNetPriceCorrection
    {

        private Money moneyField;

        private PriceBasisQuantity priceBasisQuantityField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }

        /// <remarks/>
        public PriceBasisQuantity PriceBasisQuantity
        {
            get
            {
                return this.priceBasisQuantityField;
            }
            set
            {
                this.priceBasisQuantityField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class AdditionalPrices
    {

        private UnitGrossPrice unitGrossPriceField;

        private InformationalPrice informationalPriceField;

        private InformationalPriceExclTax informationalPriceExclTaxField;

        private UnitNetPriceCorrection unitNetPriceCorrectionField;

        /// <remarks/>
        public UnitGrossPrice UnitGrossPrice
        {
            get
            {
                return this.unitGrossPriceField;
            }
            set
            {
                this.unitGrossPriceField = value;
            }
        }

        /// <remarks/>
        public InformationalPrice InformationalPrice
        {
            get
            {
                return this.informationalPriceField;
            }
            set
            {
                this.informationalPriceField = value;
            }
        }

        /// <remarks/>
        public InformationalPriceExclTax InformationalPriceExclTax
        {
            get
            {
                return this.informationalPriceExclTaxField;
            }
            set
            {
                this.informationalPriceExclTaxField = value;
            }
        }

        /// <remarks/>
        public UnitNetPriceCorrection UnitNetPriceCorrection
        {
            get
            {
                return this.unitNetPriceCorrectionField;
            }
            set
            {
                this.unitNetPriceCorrectionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ItemIndicator
    {

        private string domainField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string domain
        {
            get
            {
                return this.domainField;
            }
            set
            {
                this.domainField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Supplier
    {

        private Name nameField;

        private Comments commentsField;

        private SupplierID[] supplierIDField;

        private SupplierLocation[] supplierLocationField;

        private string corporateURLField;

        private string storeFrontURLField;

        /// <remarks/>
        public Name Name
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
        public Comments Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SupplierID")]
        public SupplierID[] SupplierID
        {
            get
            {
                return this.supplierIDField;
            }
            set
            {
                this.supplierIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SupplierLocation")]
        public SupplierLocation[] SupplierLocation
        {
            get
            {
                return this.supplierLocationField;
            }
            set
            {
                this.supplierLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string corporateURL
        {
            get
            {
                return this.corporateURLField;
            }
            set
            {
                this.corporateURLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string storeFrontURL
        {
            get
            {
                return this.storeFrontURLField;
            }
            set
            {
                this.storeFrontURLField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class SupplierID
    {

        private string domainField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string domain
        {
            get
            {
                return this.domainField;
            }
            set
            {
                this.domainField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class SupplierLocation
    {

        private Address addressField;

        private OrderMethods orderMethodsField;

        /// <remarks/>
        public Address Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        public OrderMethods OrderMethods
        {
            get
            {
                return this.orderMethodsField;
            }
            set
            {
                this.orderMethodsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class OrderMethods
    {

        private OrderMethod[] orderMethodField;

        private Contact contactField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OrderMethod")]
        public OrderMethod[] OrderMethod
        {
            get
            {
                return this.orderMethodField;
            }
            set
            {
                this.orderMethodField = value;
            }
        }

        /// <remarks/>
        public Contact Contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class OrderMethod
    {

        private OrderTarget orderTargetField;

        private string orderProtocolField;

        /// <remarks/>
        public OrderTarget OrderTarget
        {
            get
            {
                return this.orderTargetField;
            }
            set
            {
                this.orderTargetField = value;
            }
        }

        /// <remarks/>
        public string OrderProtocol
        {
            get
            {
                return this.orderProtocolField;
            }
            set
            {
                this.orderProtocolField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class OrderTarget
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Email", typeof(Email))]
        [System.Xml.Serialization.XmlElementAttribute("Fax", typeof(Fax))]
        [System.Xml.Serialization.XmlElementAttribute("OtherOrderTarget", typeof(OtherOrderTarget))]
        [System.Xml.Serialization.XmlElementAttribute("Phone", typeof(Phone))]
        [System.Xml.Serialization.XmlElementAttribute("URL", typeof(URL))]
        public object Item
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class OtherOrderTarget
    {

        private System.Xml.XmlNode[] anyField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class SupplierList
    {

        private Supplier[] supplierField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Supplier")]
        public Supplier[] Supplier
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ManufacturerName
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Classification
    {

        private string domainField;

        private string codeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string domain
        {
            get
            {
                return this.domainField;
            }
            set
            {
                this.domainField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class SupplierPartID
    {

        private string revisionIDField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string revisionID
        {
            get
            {
                return this.revisionIDField;
            }
            set
            {
                this.revisionIDField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class SupplierPartAuxiliaryID
    {

       private string valueField;

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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ItemID
    {

        private SupplierPartID supplierPartIDField;

        private SupplierPartAuxiliaryID supplierPartAuxiliaryIDField;

        private string buyerPartIDField;

        private IdReference[] idReferenceField;

        /// <remarks/>
        public SupplierPartID SupplierPartID
        {
            get
            {
                return this.supplierPartIDField;
            }
            set
            {
                this.supplierPartIDField = value;
            }
        }

        /// <remarks/>
        public SupplierPartAuxiliaryID SupplierPartAuxiliaryID
        {
            get
            {
                return this.supplierPartAuxiliaryIDField;
            }
            set
            {
                this.supplierPartAuxiliaryIDField = value;
            }
        }

        /// <remarks/>
        public string BuyerPartID
        {
            get
            {
                return this.buyerPartIDField;
            }
            set
            {
                this.buyerPartIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IdReference")]
        public IdReference[] IdReference
        {
            get
            {
                return this.idReferenceField;
            }
            set
            {
                this.idReferenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ItemDetail
    {

        private UnitPrice unitPriceField;

        private Description[] descriptionField;

        private OverallLimit overallLimitField;

        private ExpectedLimit expectedLimitField;

        private string unitOfMeasureField;

        private PriceBasisQuantity priceBasisQuantityField;

        private Classification[] classificationField;

        private string manufacturerPartIDField;

        private ManufacturerName manufacturerNameField;

        private URL uRLField;

        private string leadTimeField;

        private Dimension[] dimensionField;

        private ItemDetailIndustry itemDetailIndustryField;

        private AttachmentReference[] attachmentReferenceField;

        private string plannedAcceptanceDaysField;

        private Extrinsic[] extrinsicField;

        /// <remarks/>
        public UnitPrice UnitPrice
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

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public Description[] Description
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
        public OverallLimit OverallLimit
        {
            get
            {
                return this.overallLimitField;
            }
            set
            {
                this.overallLimitField = value;
            }
        }

        /// <remarks/>
        public ExpectedLimit ExpectedLimit
        {
            get
            {
                return this.expectedLimitField;
            }
            set
            {
                this.expectedLimitField = value;
            }
        }

        /// <remarks/>
        public string UnitOfMeasure
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
        public PriceBasisQuantity PriceBasisQuantity
        {
            get
            {
                return this.priceBasisQuantityField;
            }
            set
            {
                this.priceBasisQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Classification")]
        public Classification[] Classification
        {
            get
            {
                return this.classificationField;
            }
            set
            {
                this.classificationField = value;
            }
        }

        /// <remarks/>
        public string ManufacturerPartID
        {
            get
            {
                return this.manufacturerPartIDField;
            }
            set
            {
                this.manufacturerPartIDField = value;
            }
        }

        /// <remarks/>
        public ManufacturerName ManufacturerName
        {
            get
            {
                return this.manufacturerNameField;
            }
            set
            {
                this.manufacturerNameField = value;
            }
        }

        /// <remarks/>
        public URL URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }

        /// <remarks/>
        public string LeadTime
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
        [System.Xml.Serialization.XmlElementAttribute("Dimension")]
        public Dimension[] Dimension
        {
            get
            {
                return this.dimensionField;
            }
            set
            {
                this.dimensionField = value;
            }
        }

        /// <remarks/>
        public ItemDetailIndustry ItemDetailIndustry
        {
            get
            {
                return this.itemDetailIndustryField;
            }
            set
            {
                this.itemDetailIndustryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AttachmentReference")]
        public AttachmentReference[] AttachmentReference
        {
            get
            {
                return this.attachmentReferenceField;
            }
            set
            {
                this.attachmentReferenceField = value;
            }
        }

        /// <remarks/>
        public string PlannedAcceptanceDays
        {
            get
            {
                return this.plannedAcceptanceDaysField;
            }
            set
            {
                this.plannedAcceptanceDaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Extrinsic")]
        public Extrinsic[] Extrinsic
        {
            get
            {
                return this.extrinsicField;
            }
            set
            {
                this.extrinsicField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class OverallLimit
    {

        private Money moneyField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ExpectedLimit
    {

        private Money moneyField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Dimension
    {

        private string unitOfMeasureField;

        private string quantityField;

        private DimensionType typeField;

        /// <remarks/>
        public string UnitOfMeasure
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
        public string quantity
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DimensionType type
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum DimensionType
    {

        /// <remarks/>
        length,

        /// <remarks/>
        width,

        /// <remarks/>
        height,

        /// <remarks/>
        weight,

        /// <remarks/>
        volume,

        /// <remarks/>
        stackHeight,

        /// <remarks/>
        grossWeight,

        /// <remarks/>
        grossVolume,

        /// <remarks/>
        unitGrossWeight,

        /// <remarks/>
        unitNetWeight,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ItemDetailIndustry
    {

        private ItemDetailRetail itemDetailRetailField;

        private ItemDetailIndustryIsConfigurableMaterial isConfigurableMaterialField;

        private bool isConfigurableMaterialFieldSpecified;

        /// <remarks/>
        public ItemDetailRetail ItemDetailRetail
        {
            get
            {
                return this.itemDetailRetailField;
            }
            set
            {
                this.itemDetailRetailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ItemDetailIndustryIsConfigurableMaterial isConfigurableMaterial
        {
            get
            {
                return this.isConfigurableMaterialField;
            }
            set
            {
                this.isConfigurableMaterialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isConfigurableMaterialSpecified
        {
            get
            {
                return this.isConfigurableMaterialFieldSpecified;
            }
            set
            {
                this.isConfigurableMaterialFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ItemDetailRetail
    {

        private string eANIDField;

        private string europeanWasteCatalogIDField;

        private Characteristic[] characteristicField;

        /// <remarks/>
        public string EANID
        {
            get
            {
                return this.eANIDField;
            }
            set
            {
                this.eANIDField = value;
            }
        }

        /// <remarks/>
        public string EuropeanWasteCatalogID
        {
            get
            {
                return this.europeanWasteCatalogIDField;
            }
            set
            {
                this.europeanWasteCatalogIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Characteristic")]
        public Characteristic[] Characteristic
        {
            get
            {
                return this.characteristicField;
            }
            set
            {
                this.characteristicField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum ItemDetailIndustryIsConfigurableMaterial
    {

        /// <remarks/>
        yes,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class BlanketItemDetail
    {

        private Description[] descriptionField;

        private MaxAmount maxAmountField;

        private MinAmount minAmountField;

        private string maxQuantityField;

        private string minQuantityField;

        private UnitPrice unitPriceField;

        private string unitOfMeasureField;

        private PriceBasisQuantity priceBasisQuantityField;

        private Classification[] classificationField;

        private Extrinsic[] extrinsicField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public Description[] Description
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
        public MaxAmount MaxAmount
        {
            get
            {
                return this.maxAmountField;
            }
            set
            {
                this.maxAmountField = value;
            }
        }

        /// <remarks/>
        public MinAmount MinAmount
        {
            get
            {
                return this.minAmountField;
            }
            set
            {
                this.minAmountField = value;
            }
        }

        /// <remarks/>
        public string MaxQuantity
        {
            get
            {
                return this.maxQuantityField;
            }
            set
            {
                this.maxQuantityField = value;
            }
        }

        /// <remarks/>
        public string MinQuantity
        {
            get
            {
                return this.minQuantityField;
            }
            set
            {
                this.minQuantityField = value;
            }
        }

        /// <remarks/>
        public UnitPrice UnitPrice
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

        /// <remarks/>
        public string UnitOfMeasure
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
        public PriceBasisQuantity PriceBasisQuantity
        {
            get
            {
                return this.priceBasisQuantityField;
            }
            set
            {
                this.priceBasisQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Classification")]
        public Classification[] Classification
        {
            get
            {
                return this.classificationField;
            }
            set
            {
                this.classificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Extrinsic")]
        public Extrinsic[] Extrinsic
        {
            get
            {
                return this.extrinsicField;
            }
            set
            {
                this.extrinsicField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class MaxAmount
    {

        private Money moneyField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class MinAmount
    {

        private Money moneyField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Product
    {

        private SupplierPartID supplierPartIDField;

        private SupplierPartAuxiliaryID supplierPartAuxiliaryIDField;

        private string buyerPartIDField;

        private IdReference[] idReferenceField;

        /// <remarks/>
        public SupplierPartID SupplierPartID
        {
            get
            {
                return this.supplierPartIDField;
            }
            set
            {
                this.supplierPartIDField = value;
            }
        }

        /// <remarks/>
        public SupplierPartAuxiliaryID SupplierPartAuxiliaryID
        {
            get
            {
                return this.supplierPartAuxiliaryIDField;
            }
            set
            {
                this.supplierPartAuxiliaryIDField = value;
            }
        }

        /// <remarks/>
        public string BuyerPartID
        {
            get
            {
                return this.buyerPartIDField;
            }
            set
            {
                this.buyerPartIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IdReference")]
        public IdReference[] IdReference
        {
            get
            {
                return this.idReferenceField;
            }
            set
            {
                this.idReferenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Batch
    {

        private string buyerBatchIDField;

        private string supplierBatchIDField;

        private PropertyValuation[] propertyValuationField;

        private string productionDateField;

        private string expirationDateField;

        private string inspectionDateField;

        private string originCountryCodeField;

        /// <remarks/>
        public string BuyerBatchID
        {
            get
            {
                return this.buyerBatchIDField;
            }
            set
            {
                this.buyerBatchIDField = value;
            }
        }

        /// <remarks/>
        public string SupplierBatchID
        {
            get
            {
                return this.supplierBatchIDField;
            }
            set
            {
                this.supplierBatchIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PropertyValuation")]
        public PropertyValuation[] PropertyValuation
        {
            get
            {
                return this.propertyValuationField;
            }
            set
            {
                this.propertyValuationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string productionDate
        {
            get
            {
                return this.productionDateField;
            }
            set
            {
                this.productionDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string expirationDate
        {
            get
            {
                return this.expirationDateField;
            }
            set
            {
                this.expirationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inspectionDate
        {
            get
            {
                return this.inspectionDateField;
            }
            set
            {
                this.inspectionDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string originCountryCode
        {
            get
            {
                return this.originCountryCodeField;
            }
            set
            {
                this.originCountryCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class PropertyValuation
    {

        private IdReference[] propertyReferenceField;

        private ValueGroup[] valueGroupField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("IdReference", IsNullable = false)]
        public IdReference[] PropertyReference
        {
            get
            {
                return this.propertyReferenceField;
            }
            set
            {
                this.propertyReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ValueGroup")]
        public ValueGroup[] ValueGroup
        {
            get
            {
                return this.valueGroupField;
            }
            set
            {
                this.valueGroupField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ValueGroup
    {

        private IdReference idReferenceField;

        private string parentIDField;

        private PropertyValue[] propertyValueField;

        /// <remarks/>
        public IdReference IdReference
        {
            get
            {
                return this.idReferenceField;
            }
            set
            {
                this.idReferenceField = value;
            }
        }

        /// <remarks/>
        public string ParentID
        {
            get
            {
                return this.parentIDField;
            }
            set
            {
                this.parentIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PropertyValue")]
        public PropertyValue[] PropertyValue
        {
            get
            {
                return this.propertyValueField;
            }
            set
            {
                this.propertyValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class PropertyValue
    {

        private Characteristic[] characteristicField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Characteristic")]
        public Characteristic[] Characteristic
        {
            get
            {
                return this.characteristicField;
            }
            set
            {
                this.characteristicField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class PropertyReference
    {

        private IdReference[] idReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IdReference")]
        public IdReference[] IdReference
        {
            get
            {
                return this.idReferenceField;
            }
            set
            {
                this.idReferenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ControlKeys
    {

        private OCInstruction oCInstructionField;

        private ASNInstruction aSNInstructionField;

        private InvoiceInstruction invoiceInstructionField;

        private SESInstruction sESInstructionField;

        /// <remarks/>
        public OCInstruction OCInstruction
        {
            get
            {
                return this.oCInstructionField;
            }
            set
            {
                this.oCInstructionField = value;
            }
        }

        /// <remarks/>
        public ASNInstruction ASNInstruction
        {
            get
            {
                return this.aSNInstructionField;
            }
            set
            {
                this.aSNInstructionField = value;
            }
        }

        /// <remarks/>
        public InvoiceInstruction InvoiceInstruction
        {
            get
            {
                return this.invoiceInstructionField;
            }
            set
            {
                this.invoiceInstructionField = value;
            }
        }

        /// <remarks/>
        public SESInstruction SESInstruction
        {
            get
            {
                return this.sESInstructionField;
            }
            set
            {
                this.sESInstructionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class OCInstruction
    {

        private Lower lowerField;

        private Upper upperField;

        private OCInstructionValue valueField;

        /// <remarks/>
        public Lower Lower
        {
            get
            {
                return this.lowerField;
            }
            set
            {
                this.lowerField = value;
            }
        }

        /// <remarks/>
        public Upper Upper
        {
            get
            {
                return this.upperField;
            }
            set
            {
                this.upperField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OCInstructionValue value
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum OCInstructionValue
    {

        /// <remarks/>
        allowed,

        /// <remarks/>
        notAllowed,

        /// <remarks/>
        requiredBeforeASN,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ASNInstruction
    {

        private Lower lowerField;

        private Upper upperField;

        private ASNInstructionValue valueField;

        /// <remarks/>
        public Lower Lower
        {
            get
            {
                return this.lowerField;
            }
            set
            {
                this.lowerField = value;
            }
        }

        /// <remarks/>
        public Upper Upper
        {
            get
            {
                return this.upperField;
            }
            set
            {
                this.upperField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ASNInstructionValue value
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum ASNInstructionValue
    {

        /// <remarks/>
        allowed,

        /// <remarks/>
        notAllowed,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceInstruction
    {

        private TemporaryPrice temporaryPriceField;

        private InvoiceInstructionValue valueField;

        private bool valueFieldSpecified;

        private InvoiceInstructionVerificationType verificationTypeField;

        private bool verificationTypeFieldSpecified;

        /// <remarks/>
        public TemporaryPrice TemporaryPrice
        {
            get
            {
                return this.temporaryPriceField;
            }
            set
            {
                this.temporaryPriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public InvoiceInstructionValue value
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

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool valueSpecified
        {
            get
            {
                return this.valueFieldSpecified;
            }
            set
            {
                this.valueFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public InvoiceInstructionVerificationType verificationType
        {
            get
            {
                return this.verificationTypeField;
            }
            set
            {
                this.verificationTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool verificationTypeSpecified
        {
            get
            {
                return this.verificationTypeFieldSpecified;
            }
            set
            {
                this.verificationTypeFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class TemporaryPrice
    {

        private TemporaryPriceValue valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TemporaryPriceValue value
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum TemporaryPriceValue
    {

        /// <remarks/>
        yes,

        /// <remarks/>
        no,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum InvoiceInstructionValue
    {

        /// <remarks/>
        isERS,

        /// <remarks/>
        isNotERS,

        /// <remarks/>
        allowed,

        /// <remarks/>
        notAllowed,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum InvoiceInstructionVerificationType
    {

        /// <remarks/>
        goodsReceipt,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class SESInstruction
    {

        private SESInstructionValue valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SESInstructionValue value
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum SESInstructionValue
    {

        /// <remarks/>
        allowed,

        /// <remarks/>
        notAllowed,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Hazard
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Classification", typeof(Classification))]
        [System.Xml.Serialization.XmlElementAttribute("Description", typeof(Description))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class TravelDetail
    {

        private object itemField;

        private PolicyViolation[] policyViolationField;

        private Comments commentsField;

        private Description[] termsAndConditionsField;

        private string confirmationNumberField;

        private string pnrLocatorField;

        private string quoteExpirationTimeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AirDetail", typeof(AirDetail))]
        [System.Xml.Serialization.XmlElementAttribute("CarRentalDetail", typeof(CarRentalDetail))]
        [System.Xml.Serialization.XmlElementAttribute("HotelDetail", typeof(HotelDetail))]
        [System.Xml.Serialization.XmlElementAttribute("RailDetail", typeof(RailDetail))]
        public object Item
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
        [System.Xml.Serialization.XmlElementAttribute("PolicyViolation")]
        public PolicyViolation[] PolicyViolation
        {
            get
            {
                return this.policyViolationField;
            }
            set
            {
                this.policyViolationField = value;
            }
        }

        /// <remarks/>
        public Comments Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Description", IsNullable = false)]
        public Description[] TermsAndConditions
        {
            get
            {
                return this.termsAndConditionsField;
            }
            set
            {
                this.termsAndConditionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string confirmationNumber
        {
            get
            {
                return this.confirmationNumberField;
            }
            set
            {
                this.confirmationNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string pnrLocator
        {
            get
            {
                return this.pnrLocatorField;
            }
            set
            {
                this.pnrLocatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string quoteExpirationTime
        {
            get
            {
                return this.quoteExpirationTimeField;
            }
            set
            {
                this.quoteExpirationTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class AirDetail
    {

        private TripType tripTypeField;

        private AirLeg[] airLegField;

        private AvailablePrice[] availablePriceField;

        private Penalty penaltyField;

        /// <remarks/>
        public TripType TripType
        {
            get
            {
                return this.tripTypeField;
            }
            set
            {
                this.tripTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AirLeg")]
        public AirLeg[] AirLeg
        {
            get
            {
                return this.airLegField;
            }
            set
            {
                this.airLegField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AvailablePrice")]
        public AvailablePrice[] AvailablePrice
        {
            get
            {
                return this.availablePriceField;
            }
            set
            {
                this.availablePriceField = value;
            }
        }

        /// <remarks/>
        public Penalty Penalty
        {
            get
            {
                return this.penaltyField;
            }
            set
            {
                this.penaltyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class TripType
    {

        private TripTypeType typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TripTypeType type
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum TripTypeType
    {

        /// <remarks/>
        round,

        /// <remarks/>
        oneWay,

        /// <remarks/>
        multiLeg,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class AirLeg
    {

        private Vendor vendorField;

        private AirLegOrigin airLegOriginField;

        private AirLegDestination airLegDestinationField;

        private BookingClassCode bookingClassCodeField;

        private Rate rateField;

        private Meal[] mealField;

        private string travelSegmentField;

        private string departureTimeField;

        private string arrivalTimeField;

        private string flightNumberField;

        private string seatNumberField;

        private AirLegSeatType seatTypeField;

        private bool seatTypeFieldSpecified;

        private AirLegUpgrade upgradeField;

        private bool upgradeFieldSpecified;

        private string stopsField;

        private string equipmentField;

        /// <remarks/>
        public Vendor Vendor
        {
            get
            {
                return this.vendorField;
            }
            set
            {
                this.vendorField = value;
            }
        }

        /// <remarks/>
        public AirLegOrigin AirLegOrigin
        {
            get
            {
                return this.airLegOriginField;
            }
            set
            {
                this.airLegOriginField = value;
            }
        }

        /// <remarks/>
        public AirLegDestination AirLegDestination
        {
            get
            {
                return this.airLegDestinationField;
            }
            set
            {
                this.airLegDestinationField = value;
            }
        }

        /// <remarks/>
        public BookingClassCode BookingClassCode
        {
            get
            {
                return this.bookingClassCodeField;
            }
            set
            {
                this.bookingClassCodeField = value;
            }
        }

        /// <remarks/>
        public Rate Rate
        {
            get
            {
                return this.rateField;
            }
            set
            {
                this.rateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Meal")]
        public Meal[] Meal
        {
            get
            {
                return this.mealField;
            }
            set
            {
                this.mealField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string travelSegment
        {
            get
            {
                return this.travelSegmentField;
            }
            set
            {
                this.travelSegmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string departureTime
        {
            get
            {
                return this.departureTimeField;
            }
            set
            {
                this.departureTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string arrivalTime
        {
            get
            {
                return this.arrivalTimeField;
            }
            set
            {
                this.arrivalTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string flightNumber
        {
            get
            {
                return this.flightNumberField;
            }
            set
            {
                this.flightNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string seatNumber
        {
            get
            {
                return this.seatNumberField;
            }
            set
            {
                this.seatNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AirLegSeatType seatType
        {
            get
            {
                return this.seatTypeField;
            }
            set
            {
                this.seatTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool seatTypeSpecified
        {
            get
            {
                return this.seatTypeFieldSpecified;
            }
            set
            {
                this.seatTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AirLegUpgrade upgrade
        {
            get
            {
                return this.upgradeField;
            }
            set
            {
                this.upgradeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool upgradeSpecified
        {
            get
            {
                return this.upgradeFieldSpecified;
            }
            set
            {
                this.upgradeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string stops
        {
            get
            {
                return this.stopsField;
            }
            set
            {
                this.stopsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string equipment
        {
            get
            {
                return this.equipmentField;
            }
            set
            {
                this.equipmentField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Vendor
    {

        private Address addressField;

        private SupplierID[] supplierIDField;

        private VendorPreferred preferredField;

        /// <remarks/>
        public Address Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SupplierID")]
        public SupplierID[] SupplierID
        {
            get
            {
                return this.supplierIDField;
            }
            set
            {
                this.supplierIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public VendorPreferred preferred
        {
            get
            {
                return this.preferredField;
            }
            set
            {
                this.preferredField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum VendorPreferred
    {

        /// <remarks/>
        yes,

        /// <remarks/>
        no,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class AirLegOrigin
    {

        private Airport airportField;

        /// <remarks/>
        public Airport Airport
        {
            get
            {
                return this.airportField;
            }
            set
            {
                this.airportField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Airport
    {

        private Address addressField;

        private string airportCodeField;

        /// <remarks/>
        public Address Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string airportCode
        {
            get
            {
                return this.airportCodeField;
            }
            set
            {
                this.airportCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class AirLegDestination
    {

        private Airport airportField;

        /// <remarks/>
        public Airport Airport
        {
            get
            {
                return this.airportField;
            }
            set
            {
                this.airportField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class BookingClassCode
    {

        private Description descriptionField;

        private string domainField;

        private string codeField;

        /// <remarks/>
        public Description Description
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string domain
        {
            get
            {
                return this.domainField;
            }
            set
            {
                this.domainField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Meal
    {

        private BookingClassCode bookingClassCodeField;

        private Description descriptionField;

        /// <remarks/>
        public BookingClassCode BookingClassCode
        {
            get
            {
                return this.bookingClassCodeField;
            }
            set
            {
                this.bookingClassCodeField = value;
            }
        }

        /// <remarks/>
        public Description Description
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum AirLegSeatType
    {

        /// <remarks/>
        window,

        /// <remarks/>
        aisle,

        /// <remarks/>
        middle,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum AirLegUpgrade
    {

        /// <remarks/>
        yes,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class AvailablePrice
    {

        private Money moneyField;

        private Description descriptionField;

        private AvailablePriceType typeField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }

        /// <remarks/>
        public Description Description
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public AvailablePriceType type
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum AvailablePriceType
    {

        /// <remarks/>
        lowest,

        /// <remarks/>
        lowestCompliant,

        /// <remarks/>
        highestCompliant,

        /// <remarks/>
        highest,

        /// <remarks/>
        other,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Penalty
    {

        private Money moneyField;

        private Description descriptionField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }

        /// <remarks/>
        public Description Description
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class CarRentalDetail
    {

        private Vendor vendorField;

        private CarRentalPickup carRentalPickupField;

        private CarRentalDropoff carRentalDropoffField;

        private BookingClassCode bookingClassCodeField;

        private CarRentalFee[] carRentalFeeField;

        private LimitedMileage limitedMileageField;

        private AvailablePrice[] availablePriceField;

        private string travelSegmentField;

        private string pickupTimeField;

        private string dropoffTimeField;

        /// <remarks/>
        public Vendor Vendor
        {
            get
            {
                return this.vendorField;
            }
            set
            {
                this.vendorField = value;
            }
        }

        /// <remarks/>
        public CarRentalPickup CarRentalPickup
        {
            get
            {
                return this.carRentalPickupField;
            }
            set
            {
                this.carRentalPickupField = value;
            }
        }

        /// <remarks/>
        public CarRentalDropoff CarRentalDropoff
        {
            get
            {
                return this.carRentalDropoffField;
            }
            set
            {
                this.carRentalDropoffField = value;
            }
        }

        /// <remarks/>
        public BookingClassCode BookingClassCode
        {
            get
            {
                return this.bookingClassCodeField;
            }
            set
            {
                this.bookingClassCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CarRentalFee")]
        public CarRentalFee[] CarRentalFee
        {
            get
            {
                return this.carRentalFeeField;
            }
            set
            {
                this.carRentalFeeField = value;
            }
        }

        /// <remarks/>
        public LimitedMileage LimitedMileage
        {
            get
            {
                return this.limitedMileageField;
            }
            set
            {
                this.limitedMileageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AvailablePrice")]
        public AvailablePrice[] AvailablePrice
        {
            get
            {
                return this.availablePriceField;
            }
            set
            {
                this.availablePriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string travelSegment
        {
            get
            {
                return this.travelSegmentField;
            }
            set
            {
                this.travelSegmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string pickupTime
        {
            get
            {
                return this.pickupTimeField;
            }
            set
            {
                this.pickupTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string dropoffTime
        {
            get
            {
                return this.dropoffTimeField;
            }
            set
            {
                this.dropoffTimeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class CarRentalPickup
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Address", typeof(Address))]
        [System.Xml.Serialization.XmlElementAttribute("Airport", typeof(Airport))]
        public object Item
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class CarRentalDropoff
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Address", typeof(Address))]
        [System.Xml.Serialization.XmlElementAttribute("Airport", typeof(Airport))]
        public object Item
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class CarRentalFee
    {

        private Total totalField;

        private Rate[] rateField;

        private CarRentalFeeType typeField;

        public CarRentalFee()
        {
            this.typeField = CarRentalFeeType.baseRate;
        }

        /// <remarks/>
        public Total Total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Rate")]
        public Rate[] Rate
        {
            get
            {
                return this.rateField;
            }
            set
            {
                this.rateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(CarRentalFeeType.baseRate)]
        public CarRentalFeeType type
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum CarRentalFeeType
    {

        /// <remarks/>
        baseRate,

        /// <remarks/>
        additionalDriver,

        /// <remarks/>
        airportAccessFee,

        /// <remarks/>
        dropOffCharge,

        /// <remarks/>
        vehicleLicensingFee,

        /// <remarks/>
        touristTax,

        /// <remarks/>
        prepaidGasoline,

        /// <remarks/>
        navigationSystem,

        /// <remarks/>
        childSeat,

        /// <remarks/>
        luggageRack,

        /// <remarks/>
        collisionDamageInsurance,

        /// <remarks/>
        liabilityInsurance,

        /// <remarks/>
        mobilePhone,

        /// <remarks/>
        other,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class LimitedMileage
    {

        private string unitOfMeasureField;

        private string quantityField;

        /// <remarks/>
        public string UnitOfMeasure
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
        public string quantity
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class HotelDetail
    {

        private Vendor vendorField;

        private Address addressField;

        private RoomType roomTypeField;

        private BookingClassCode bookingClassCodeField;

        private Meal[] mealField;

        private Rate[] rateField;

        private AvailablePrice[] availablePriceField;

        private string travelSegmentField;

        private string arrivalTimeField;

        private string departureTimeField;

        private string checkinTimeField;

        private string checkoutTimeField;

        private HotelDetailEarlyCheckinAllowed earlyCheckinAllowedField;

        private bool earlyCheckinAllowedFieldSpecified;

        private HotelDetailLateCheckoutAllowed lateCheckoutAllowedField;

        private bool lateCheckoutAllowedFieldSpecified;

        /// <remarks/>
        public Vendor Vendor
        {
            get
            {
                return this.vendorField;
            }
            set
            {
                this.vendorField = value;
            }
        }

        /// <remarks/>
        public Address Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        public RoomType RoomType
        {
            get
            {
                return this.roomTypeField;
            }
            set
            {
                this.roomTypeField = value;
            }
        }

        /// <remarks/>
        public BookingClassCode BookingClassCode
        {
            get
            {
                return this.bookingClassCodeField;
            }
            set
            {
                this.bookingClassCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Meal")]
        public Meal[] Meal
        {
            get
            {
                return this.mealField;
            }
            set
            {
                this.mealField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Rate")]
        public Rate[] Rate
        {
            get
            {
                return this.rateField;
            }
            set
            {
                this.rateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AvailablePrice")]
        public AvailablePrice[] AvailablePrice
        {
            get
            {
                return this.availablePriceField;
            }
            set
            {
                this.availablePriceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string travelSegment
        {
            get
            {
                return this.travelSegmentField;
            }
            set
            {
                this.travelSegmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string arrivalTime
        {
            get
            {
                return this.arrivalTimeField;
            }
            set
            {
                this.arrivalTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string departureTime
        {
            get
            {
                return this.departureTimeField;
            }
            set
            {
                this.departureTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string checkinTime
        {
            get
            {
                return this.checkinTimeField;
            }
            set
            {
                this.checkinTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string checkoutTime
        {
            get
            {
                return this.checkoutTimeField;
            }
            set
            {
                this.checkoutTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public HotelDetailEarlyCheckinAllowed earlyCheckinAllowed
        {
            get
            {
                return this.earlyCheckinAllowedField;
            }
            set
            {
                this.earlyCheckinAllowedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool earlyCheckinAllowedSpecified
        {
            get
            {
                return this.earlyCheckinAllowedFieldSpecified;
            }
            set
            {
                this.earlyCheckinAllowedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public HotelDetailLateCheckoutAllowed lateCheckoutAllowed
        {
            get
            {
                return this.lateCheckoutAllowedField;
            }
            set
            {
                this.lateCheckoutAllowedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool lateCheckoutAllowedSpecified
        {
            get
            {
                return this.lateCheckoutAllowedFieldSpecified;
            }
            set
            {
                this.lateCheckoutAllowedFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class RoomType
    {

        private Description descriptionField;

        private Amenities[] amenitiesField;

        private RoomTypeSmoking smokingField;

        private string numberOfBedField;

        private RoomTypeBedType bedTypeField;

        private bool bedTypeFieldSpecified;

        /// <remarks/>
        public Description Description
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
        [System.Xml.Serialization.XmlElementAttribute("Amenities")]
        public Amenities[] Amenities
        {
            get
            {
                return this.amenitiesField;
            }
            set
            {
                this.amenitiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RoomTypeSmoking smoking
        {
            get
            {
                return this.smokingField;
            }
            set
            {
                this.smokingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string numberOfBed
        {
            get
            {
                return this.numberOfBedField;
            }
            set
            {
                this.numberOfBedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RoomTypeBedType bedType
        {
            get
            {
                return this.bedTypeField;
            }
            set
            {
                this.bedTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bedTypeSpecified
        {
            get
            {
                return this.bedTypeFieldSpecified;
            }
            set
            {
                this.bedTypeFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Amenities
    {

        private Description descriptionField;

        /// <remarks/>
        public Description Description
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum RoomTypeSmoking
    {

        /// <remarks/>
        yes,

        /// <remarks/>
        no,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum RoomTypeBedType
    {

        /// <remarks/>
        king,

        /// <remarks/>
        queen,

        /// <remarks/>
        full,

        /// <remarks/>
        @double,

        /// <remarks/>
        single,

        /// <remarks/>
        other,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum HotelDetailEarlyCheckinAllowed
    {

        /// <remarks/>
        yes,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum HotelDetailLateCheckoutAllowed
    {

        /// <remarks/>
        yes,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class RailDetail
    {

        private TripType tripTypeField;

        private RailLeg[] railLegField;

        private AvailablePrice[] availablePriceField;

        private Penalty penaltyField;

        /// <remarks/>
        public TripType TripType
        {
            get
            {
                return this.tripTypeField;
            }
            set
            {
                this.tripTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RailLeg")]
        public RailLeg[] RailLeg
        {
            get
            {
                return this.railLegField;
            }
            set
            {
                this.railLegField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AvailablePrice")]
        public AvailablePrice[] AvailablePrice
        {
            get
            {
                return this.availablePriceField;
            }
            set
            {
                this.availablePriceField = value;
            }
        }

        /// <remarks/>
        public Penalty Penalty
        {
            get
            {
                return this.penaltyField;
            }
            set
            {
                this.penaltyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class RailLeg
    {

        private Vendor vendorField;

        private RailLegOrigin railLegOriginField;

        private RailLegDestination railLegDestinationField;

        private BookingClassCode bookingClassCodeField;

        private Rate rateField;

        private Meal[] mealField;

        private string travelSegmentField;

        private string departureTimeField;

        private string arrivalTimeField;

        private string trainNumberField;

        private string seatNumberField;

        private RailLegCarType carTypeField;

        private bool carTypeFieldSpecified;

        /// <remarks/>
        public Vendor Vendor
        {
            get
            {
                return this.vendorField;
            }
            set
            {
                this.vendorField = value;
            }
        }

        /// <remarks/>
        public RailLegOrigin RailLegOrigin
        {
            get
            {
                return this.railLegOriginField;
            }
            set
            {
                this.railLegOriginField = value;
            }
        }

        /// <remarks/>
        public RailLegDestination RailLegDestination
        {
            get
            {
                return this.railLegDestinationField;
            }
            set
            {
                this.railLegDestinationField = value;
            }
        }

        /// <remarks/>
        public BookingClassCode BookingClassCode
        {
            get
            {
                return this.bookingClassCodeField;
            }
            set
            {
                this.bookingClassCodeField = value;
            }
        }

        /// <remarks/>
        public Rate Rate
        {
            get
            {
                return this.rateField;
            }
            set
            {
                this.rateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Meal")]
        public Meal[] Meal
        {
            get
            {
                return this.mealField;
            }
            set
            {
                this.mealField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string travelSegment
        {
            get
            {
                return this.travelSegmentField;
            }
            set
            {
                this.travelSegmentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string departureTime
        {
            get
            {
                return this.departureTimeField;
            }
            set
            {
                this.departureTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string arrivalTime
        {
            get
            {
                return this.arrivalTimeField;
            }
            set
            {
                this.arrivalTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string trainNumber
        {
            get
            {
                return this.trainNumberField;
            }
            set
            {
                this.trainNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string seatNumber
        {
            get
            {
                return this.seatNumberField;
            }
            set
            {
                this.seatNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RailLegCarType carType
        {
            get
            {
                return this.carTypeField;
            }
            set
            {
                this.carTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool carTypeSpecified
        {
            get
            {
                return this.carTypeFieldSpecified;
            }
            set
            {
                this.carTypeFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class RailLegOrigin
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Address", typeof(Address))]
        [System.Xml.Serialization.XmlElementAttribute("Airport", typeof(Airport))]
        public object Item
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class RailLegDestination
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Address", typeof(Address))]
        [System.Xml.Serialization.XmlElementAttribute("Airport", typeof(Airport))]
        public object Item
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum RailLegCarType
    {

        /// <remarks/>
        sleeper,

        /// <remarks/>
        seat,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class PolicyViolation
    {

        private Description descriptionField;

        private PolicyViolationJustification policyViolationJustificationField;

        private Comments commentsField;

        private PolicyViolationLevel levelField;

        /// <remarks/>
        public Description Description
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
        public PolicyViolationJustification PolicyViolationJustification
        {
            get
            {
                return this.policyViolationJustificationField;
            }
            set
            {
                this.policyViolationJustificationField = value;
            }
        }

        /// <remarks/>
        public Comments Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PolicyViolationLevel level
        {
            get
            {
                return this.levelField;
            }
            set
            {
                this.levelField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class PolicyViolationJustification
    {

        private Description descriptionField;

        /// <remarks/>
        public Description Description
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum PolicyViolationLevel
    {

        /// <remarks/>
        warning,

        /// <remarks/>
        violation,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class TermsAndConditions
    {

        private Description[] descriptionField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public Description[] Description
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Place
    {

        private Address addressField;

        private string codeField;

        private string domainField;

        /// <remarks/>
        public Address Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string domain
        {
            get
            {
                return this.domainField;
            }
            set
            {
                this.domainField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class LegOrigin
    {

        private Place placeField;

        /// <remarks/>
        public Place Place
        {
            get
            {
                return this.placeField;
            }
            set
            {
                this.placeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class LegDestination
    {

        private Place placeField;

        /// <remarks/>
        public Place Place
        {
            get
            {
                return this.placeField;
            }
            set
            {
                this.placeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class AssetInfo
    {

        private Extrinsic[] extrinsicField;

        private string tagNumberField;

        private string serialNumberField;

        private string locationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Extrinsic")]
        public Extrinsic[] Extrinsic
        {
            get
            {
                return this.extrinsicField;
            }
            set
            {
                this.extrinsicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tagNumber
        {
            get
            {
                return this.tagNumberField;
            }
            set
            {
                this.tagNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string serialNumber
        {
            get
            {
                return this.serialNumberField;
            }
            set
            {
                this.serialNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string location
        {
            get
            {
                return this.locationField;
            }
            set
            {
                this.locationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class TotalAmountInPostedCurrency
    {

        private Money moneyField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class TotalAmountInBillingCurrency
    {

        private Money moneyField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class BillTo
    {

        private Address addressField;

        private IdReference[] idReferenceField;

        /// <remarks/>
        public Address Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IdReference")]
        public IdReference[] IdReference
        {
            get
            {
                return this.idReferenceField;
            }
            set
            {
                this.idReferenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ShipTo
    {

        private Address addressField;

        private CarrierIdentifier[] carrierIdentifierField;

        private TransportInformation[] transportInformationField;

        private IdReference[] idReferenceField;

        /// <remarks/>
        public Address Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CarrierIdentifier")]
        public CarrierIdentifier[] CarrierIdentifier
        {
            get
            {
                return this.carrierIdentifierField;
            }
            set
            {
                this.carrierIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TransportInformation")]
        public TransportInformation[] TransportInformation
        {
            get
            {
                return this.transportInformationField;
            }
            set
            {
                this.transportInformationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IdReference")]
        public IdReference[] IdReference
        {
            get
            {
                return this.idReferenceField;
            }
            set
            {
                this.idReferenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class CarrierIdentifier
    {

        private string domainField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string domain
        {
            get
            {
                return this.domainField;
            }
            set
            {
                this.domainField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class TransportInformation
    {

        private Route routeField;

        private string shippingContractNumberField;

        private ShippingInstructions shippingInstructionsField;

        /// <remarks/>
        public Route Route
        {
            get
            {
                return this.routeField;
            }
            set
            {
                this.routeField = value;
            }
        }

        /// <remarks/>
        public string ShippingContractNumber
        {
            get
            {
                return this.shippingContractNumberField;
            }
            set
            {
                this.shippingContractNumberField = value;
            }
        }

        /// <remarks/>
        public ShippingInstructions ShippingInstructions
        {
            get
            {
                return this.shippingInstructionsField;
            }
            set
            {
                this.shippingInstructionsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Route
    {

        private Contact[] itemsField;

        private string[] textField;

        private RouteMethod methodField;

        private string meansField;

        private string startDateField;

        private string endDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Contact")]
        public Contact[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
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
        public RouteMethod method
        {
            get
            {
                return this.methodField;
            }
            set
            {
                this.methodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "NMTOKEN")]
        public string means
        {
            get
            {
                return this.meansField;
            }
            set
            {
                this.meansField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string startDate
        {
            get
            {
                return this.startDateField;
            }
            set
            {
                this.startDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string endDate
        {
            get
            {
                return this.endDateField;
            }
            set
            {
                this.endDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum RouteMethod
    {

        /// <remarks/>
        air,

        /// <remarks/>
        motor,

        /// <remarks/>
        rail,

        /// <remarks/>
        ship,

        /// <remarks/>
        mail,

        /// <remarks/>
        multimodal,

        /// <remarks/>
        fixedTransport,

        /// <remarks/>
        inlandWater,

        /// <remarks/>
        unknown,

        /// <remarks/>
        custom,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ShippingInstructions
    {

        private Description descriptionField;

        /// <remarks/>
        public Description Description
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Shipping
    {

        private Money moneyField;

        private Description descriptionField;

        private Modification[] modificationsField;

        private string trackingDomainField;

        private string trackingIdField;

        private string trackingField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }

        /// <remarks/>
        public Description Description
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
        [System.Xml.Serialization.XmlArrayItemAttribute("Modification", IsNullable = false)]
        public Modification[] Modifications
        {
            get
            {
                return this.modificationsField;
            }
            set
            {
                this.modificationsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string trackingDomain
        {
            get
            {
                return this.trackingDomainField;
            }
            set
            {
                this.trackingDomainField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string trackingId
        {
            get
            {
                return this.trackingIdField;
            }
            set
            {
                this.trackingIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string tracking
        {
            get
            {
                return this.trackingField;
            }
            set
            {
                this.trackingField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class PaymentTerms
    {

        private PaymentTerm[] paymentTermField;

        private Description descriptionField;

        private Extrinsic[] extrinsicField;

        private string paymentTermCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentTerm")]
        public PaymentTerm[] PaymentTerm
        {
            get
            {
                return this.paymentTermField;
            }
            set
            {
                this.paymentTermField = value;
            }
        }

        /// <remarks/>
        public Description Description
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
        [System.Xml.Serialization.XmlElementAttribute("Extrinsic")]
        public Extrinsic[] Extrinsic
        {
            get
            {
                return this.extrinsicField;
            }
            set
            {
                this.extrinsicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string paymentTermCode
        {
            get
            {
                return this.paymentTermCodeField;
            }
            set
            {
                this.paymentTermCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class PaymentTerm
    {

        private Discount discountField;

        private Extrinsic[] extrinsicField;

        private string payInNumberOfDaysField;

        /// <remarks/>
        public Discount Discount
        {
            get
            {
                return this.discountField;
            }
            set
            {
                this.discountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Extrinsic")]
        public Extrinsic[] Extrinsic
        {
            get
            {
                return this.extrinsicField;
            }
            set
            {
                this.extrinsicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string payInNumberOfDays
        {
            get
            {
                return this.payInNumberOfDaysField;
            }
            set
            {
                this.payInNumberOfDaysField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Payment
    {

        private PCard pCardField;

        /// <remarks/>
        public PCard PCard
        {
            get
            {
                return this.pCardField;
            }
            set
            {
                this.pCardField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class PCard
    {

        private PostalAddress postalAddressField;

        private string numberField;

        private string expirationField;

        private string nameField;

        /// <remarks/>
        public PostalAddress PostalAddress
        {
            get
            {
                return this.postalAddressField;
            }
            set
            {
                this.postalAddressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string expiration
        {
            get
            {
                return this.expirationField;
            }
            set
            {
                this.expirationField = value;
            }
        }

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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ItemOut
    {

        private ItemID itemIDField;

        private Node[] pathField;

        private object itemField;

        private object item1Field;

        private ShipTo shipToField;

        private Shipping shippingField;

        private Tax taxField;

        private SpendDetail spendDetailField;

        private Distribution[] distributionField;

        private Contact[] contactField;

        private TermsOfDelivery termsOfDeliveryField;

        private Comments commentsField;

        private Tolerances tolerancesField;

        private ControlKeys controlKeysField;

        private ScheduleLine[] scheduleLineField;

        private object item2Field;

        private ItemOutIndustry itemOutIndustryField;

        private Packaging[] packagingField;

        private ReleaseInfo releaseInfoField;

        private Batch batchField;

        private string quantityField;

        private string lineNumberField;

        private string requisitionIDField;

        private string agreementItemNumberField;

        private string requestedDeliveryDateField;

        private ItemOutIsAdHoc isAdHocField;

        private bool isAdHocFieldSpecified;

        private string parentLineNumberField;

        private ItemOutItemType itemTypeField;

        private bool itemTypeFieldSpecified;

        private ItemOutRequiresServiceEntry requiresServiceEntryField;

        private bool requiresServiceEntryFieldSpecified;

        private string confirmationDueDateField;

        private ItemOutCompositeItemType compositeItemTypeField;

        private bool compositeItemTypeFieldSpecified;

        private ItemOutItemCategory itemCategoryField;

        private bool itemCategoryFieldSpecified;

        private ItemOutSubcontractingType subcontractingTypeField;

        private bool subcontractingTypeFieldSpecified;

        private string requestedShipmentDateField;

        private ItemOutIsReturn isReturnField;

        private bool isReturnFieldSpecified;

        private string returnAuthorizationNumberField;

        private ItemOutIsDeliveryCompleted isDeliveryCompletedField;

        private bool isDeliveryCompletedFieldSpecified;

        /// <remarks/>
        public ItemID ItemID
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

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Node", IsNullable = false)]
        public Node[] Path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BlanketItemDetail", typeof(BlanketItemDetail))]
        [System.Xml.Serialization.XmlElementAttribute("ItemDetail", typeof(ItemDetail))]
        public object Item
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
        [System.Xml.Serialization.XmlElementAttribute("SupplierID", typeof(SupplierID))]
        [System.Xml.Serialization.XmlElementAttribute("SupplierList", typeof(SupplierList))]
        public object Item1
        {
            get
            {
                return this.item1Field;
            }
            set
            {
                this.item1Field = value;
            }
        }

        /// <remarks/>
        public ShipTo ShipTo
        {
            get
            {
                return this.shipToField;
            }
            set
            {
                this.shipToField = value;
            }
        }

        /// <remarks/>
        public Shipping Shipping
        {
            get
            {
                return this.shippingField;
            }
            set
            {
                this.shippingField = value;
            }
        }

        /// <remarks/>
        public Tax Tax
        {
            get
            {
                return this.taxField;
            }
            set
            {
                this.taxField = value;
            }
        }

        /// <remarks/>
        public SpendDetail SpendDetail
        {
            get
            {
                return this.spendDetailField;
            }
            set
            {
                this.spendDetailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Distribution")]
        public Distribution[] Distribution
        {
            get
            {
                return this.distributionField;
            }
            set
            {
                this.distributionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Contact")]
        public Contact[] Contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
            }
        }

        /// <remarks/>
        public TermsOfDelivery TermsOfDelivery
        {
            get
            {
                return this.termsOfDeliveryField;
            }
            set
            {
                this.termsOfDeliveryField = value;
            }
        }

        /// <remarks/>
        public Comments Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        public Tolerances Tolerances
        {
            get
            {
                return this.tolerancesField;
            }
            set
            {
                this.tolerancesField = value;
            }
        }

        /// <remarks/>
        public ControlKeys ControlKeys
        {
            get
            {
                return this.controlKeysField;
            }
            set
            {
                this.controlKeysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ScheduleLine")]
        public ScheduleLine[] ScheduleLine
        {
            get
            {
                return this.scheduleLineField;
            }
            set
            {
                this.scheduleLineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MasterAgreementIDInfo", typeof(MasterAgreementIDInfo))]
        [System.Xml.Serialization.XmlElementAttribute("MasterAgreementReference", typeof(MasterAgreementReference))]
        public object Item2
        {
            get
            {
                return this.item2Field;
            }
            set
            {
                this.item2Field = value;
            }
        }

        /// <remarks/>
        public ItemOutIndustry ItemOutIndustry
        {
            get
            {
                return this.itemOutIndustryField;
            }
            set
            {
                this.itemOutIndustryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Packaging")]
        public Packaging[] Packaging
        {
            get
            {
                return this.packagingField;
            }
            set
            {
                this.packagingField = value;
            }
        }

        /// <remarks/>
        public ReleaseInfo ReleaseInfo
        {
            get
            {
                return this.releaseInfoField;
            }
            set
            {
                this.releaseInfoField = value;
            }
        }

        /// <remarks/>
        public Batch Batch
        {
            get
            {
                return this.batchField;
            }
            set
            {
                this.batchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string quantity
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lineNumber
        {
            get
            {
                return this.lineNumberField;
            }
            set
            {
                this.lineNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string requisitionID
        {
            get
            {
                return this.requisitionIDField;
            }
            set
            {
                this.requisitionIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string agreementItemNumber
        {
            get
            {
                return this.agreementItemNumberField;
            }
            set
            {
                this.agreementItemNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string requestedDeliveryDate
        {
            get
            {
                return this.requestedDeliveryDateField;
            }
            set
            {
                this.requestedDeliveryDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ItemOutIsAdHoc isAdHoc
        {
            get
            {
                return this.isAdHocField;
            }
            set
            {
                this.isAdHocField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAdHocSpecified
        {
            get
            {
                return this.isAdHocFieldSpecified;
            }
            set
            {
                this.isAdHocFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string parentLineNumber
        {
            get
            {
                return this.parentLineNumberField;
            }
            set
            {
                this.parentLineNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ItemOutItemType itemType
        {
            get
            {
                return this.itemTypeField;
            }
            set
            {
                this.itemTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itemTypeSpecified
        {
            get
            {
                return this.itemTypeFieldSpecified;
            }
            set
            {
                this.itemTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ItemOutRequiresServiceEntry requiresServiceEntry
        {
            get
            {
                return this.requiresServiceEntryField;
            }
            set
            {
                this.requiresServiceEntryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool requiresServiceEntrySpecified
        {
            get
            {
                return this.requiresServiceEntryFieldSpecified;
            }
            set
            {
                this.requiresServiceEntryFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string confirmationDueDate
        {
            get
            {
                return this.confirmationDueDateField;
            }
            set
            {
                this.confirmationDueDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ItemOutCompositeItemType compositeItemType
        {
            get
            {
                return this.compositeItemTypeField;
            }
            set
            {
                this.compositeItemTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool compositeItemTypeSpecified
        {
            get
            {
                return this.compositeItemTypeFieldSpecified;
            }
            set
            {
                this.compositeItemTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ItemOutItemCategory itemCategory
        {
            get
            {
                return this.itemCategoryField;
            }
            set
            {
                this.itemCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itemCategorySpecified
        {
            get
            {
                return this.itemCategoryFieldSpecified;
            }
            set
            {
                this.itemCategoryFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ItemOutSubcontractingType subcontractingType
        {
            get
            {
                return this.subcontractingTypeField;
            }
            set
            {
                this.subcontractingTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool subcontractingTypeSpecified
        {
            get
            {
                return this.subcontractingTypeFieldSpecified;
            }
            set
            {
                this.subcontractingTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string requestedShipmentDate
        {
            get
            {
                return this.requestedShipmentDateField;
            }
            set
            {
                this.requestedShipmentDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ItemOutIsReturn isReturn
        {
            get
            {
                return this.isReturnField;
            }
            set
            {
                this.isReturnField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isReturnSpecified
        {
            get
            {
                return this.isReturnFieldSpecified;
            }
            set
            {
                this.isReturnFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string returnAuthorizationNumber
        {
            get
            {
                return this.returnAuthorizationNumberField;
            }
            set
            {
                this.returnAuthorizationNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ItemOutIsDeliveryCompleted isDeliveryCompleted
        {
            get
            {
                return this.isDeliveryCompletedField;
            }
            set
            {
                this.isDeliveryCompletedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDeliveryCompletedSpecified
        {
            get
            {
                return this.isDeliveryCompletedFieldSpecified;
            }
            set
            {
                this.isDeliveryCompletedFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Node
    {

        private Credential[] credentialField;

        private NodeType typeField;

        private NodeItemDetailsRequired itemDetailsRequiredField;

        private bool itemDetailsRequiredFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Credential")]
        public Credential[] Credential
        {
            get
            {
                return this.credentialField;
            }
            set
            {
                this.credentialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public NodeType type
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public NodeItemDetailsRequired itemDetailsRequired
        {
            get
            {
                return this.itemDetailsRequiredField;
            }
            set
            {
                this.itemDetailsRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itemDetailsRequiredSpecified
        {
            get
            {
                return this.itemDetailsRequiredFieldSpecified;
            }
            set
            {
                this.itemDetailsRequiredFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Credential
    {

        private Identity identityField;

        private object itemField;

        private string domainField;

        private CredentialType typeField;

        private bool typeFieldSpecified;

        /// <remarks/>
        public Identity Identity
        {
            get
            {
                return this.identityField;
            }
            set
            {
                this.identityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CredentialMac", typeof(CredentialMac))]
        [System.Xml.Serialization.XmlElementAttribute("DigitalSignature", typeof(DigitalSignature))]
        [System.Xml.Serialization.XmlElementAttribute("SharedSecret", typeof(SharedSecret))]
        public object Item
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string domain
        {
            get
            {
                return this.domainField;
            }
            set
            {
                this.domainField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CredentialType type
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool typeSpecified
        {
            get
            {
                return this.typeFieldSpecified;
            }
            set
            {
                this.typeFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Identity
    {

        private System.Xml.XmlNode[] anyField;

        private string lastChangedTimestampField;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lastChangedTimestamp
        {
            get
            {
                return this.lastChangedTimestampField;
            }
            set
            {
                this.lastChangedTimestampField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class CredentialMac
    {

        private string typeField;

        private string algorithmField;

        private string creationDateField;

        private string expirationDateField;

        private string valueField;

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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string creationDate
        {
            get
            {
                return this.creationDateField;
            }
            set
            {
                this.creationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string expirationDate
        {
            get
            {
                return this.expirationDateField;
            }
            set
            {
                this.expirationDateField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class DigitalSignature
    {

        private System.Xml.XmlNode[] anyField;

        private string typeField;

        private string encodingField;

        public DigitalSignature()
        {
            this.typeField = "PK7 self-contained";
            this.encodingField = "Base64";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("PK7 self-contained")]
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("Base64")]
        public string encoding
        {
            get
            {
                return this.encodingField;
            }
            set
            {
                this.encodingField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class SharedSecret
    {

        private System.Xml.XmlNode[] anyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum CredentialType
    {

        /// <remarks/>
        marketplace,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum NodeType
    {

        /// <remarks/>
        copy,

        /// <remarks/>
        route,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum NodeItemDetailsRequired
    {

        /// <remarks/>
        yes,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class SpendDetail
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Extrinsic", typeof(Extrinsic))]
        [System.Xml.Serialization.XmlElementAttribute("FeeDetail", typeof(FeeDetail))]
        [System.Xml.Serialization.XmlElementAttribute("LaborDetail", typeof(LaborDetail))]
        [System.Xml.Serialization.XmlElementAttribute("TravelDetail", typeof(TravelDetail))]
        public object Item
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class FeeDetail
    {

        private UnitRate[] unitRateField;

        private Period periodField;

        private FeeDetailIsRecurring isRecurringField;

        private bool isRecurringFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UnitRate")]
        public UnitRate[] UnitRate
        {
            get
            {
                return this.unitRateField;
            }
            set
            {
                this.unitRateField = value;
            }
        }

        /// <remarks/>
        public Period Period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public FeeDetailIsRecurring isRecurring
        {
            get
            {
                return this.isRecurringField;
            }
            set
            {
                this.isRecurringField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isRecurringSpecified
        {
            get
            {
                return this.isRecurringFieldSpecified;
            }
            set
            {
                this.isRecurringFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum FeeDetailIsRecurring
    {

        /// <remarks/>
        yes,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class LaborDetail
    {

        private UnitRate[] unitRateField;

        private Period periodField;

        private Contractor contractorField;

        private JobDescription jobDescriptionField;

        private Supervisor supervisorField;

        private WorkLocation workLocationField;

        private Extrinsic[] extrinsicField;

        private string supplierReferenceCodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UnitRate")]
        public UnitRate[] UnitRate
        {
            get
            {
                return this.unitRateField;
            }
            set
            {
                this.unitRateField = value;
            }
        }

        /// <remarks/>
        public Period Period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }

        /// <remarks/>
        public Contractor Contractor
        {
            get
            {
                return this.contractorField;
            }
            set
            {
                this.contractorField = value;
            }
        }

        /// <remarks/>
        public JobDescription JobDescription
        {
            get
            {
                return this.jobDescriptionField;
            }
            set
            {
                this.jobDescriptionField = value;
            }
        }

        /// <remarks/>
        public Supervisor Supervisor
        {
            get
            {
                return this.supervisorField;
            }
            set
            {
                this.supervisorField = value;
            }
        }

        /// <remarks/>
        public WorkLocation WorkLocation
        {
            get
            {
                return this.workLocationField;
            }
            set
            {
                this.workLocationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Extrinsic")]
        public Extrinsic[] Extrinsic
        {
            get
            {
                return this.extrinsicField;
            }
            set
            {
                this.extrinsicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string supplierReferenceCode
        {
            get
            {
                return this.supplierReferenceCodeField;
            }
            set
            {
                this.supplierReferenceCodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Contractor
    {

        private ContractorIdentifier contractorIdentifierField;

        private Contact contactField;

        /// <remarks/>
        public ContractorIdentifier ContractorIdentifier
        {
            get
            {
                return this.contractorIdentifierField;
            }
            set
            {
                this.contractorIdentifierField = value;
            }
        }

        /// <remarks/>
        public Contact Contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ContractorIdentifier
    {

        private ContractorIdentifierDomain domainField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ContractorIdentifierDomain domain
        {
            get
            {
                return this.domainField;
            }
            set
            {
                this.domainField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum ContractorIdentifierDomain
    {

        /// <remarks/>
        supplierReferenceID,

        /// <remarks/>
        buyerReferenceID,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class JobDescription
    {

        private Description descriptionField;

        /// <remarks/>
        public Description Description
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Supervisor
    {

        private Contact contactField;

        /// <remarks/>
        public Contact Contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class WorkLocation
    {

        private Address addressField;

        /// <remarks/>
        public Address Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class TermsOfDelivery
    {

        private TermsOfDeliveryCode termsOfDeliveryCodeField;

        private ShippingPaymentMethod shippingPaymentMethodField;

        private TransportTerms transportTermsField;

        private Address addressField;

        private Comments[] commentsField;

        /// <remarks/>
        public TermsOfDeliveryCode TermsOfDeliveryCode
        {
            get
            {
                return this.termsOfDeliveryCodeField;
            }
            set
            {
                this.termsOfDeliveryCodeField = value;
            }
        }

        /// <remarks/>
        public ShippingPaymentMethod ShippingPaymentMethod
        {
            get
            {
                return this.shippingPaymentMethodField;
            }
            set
            {
                this.shippingPaymentMethodField = value;
            }
        }

        /// <remarks/>
        public TransportTerms TransportTerms
        {
            get
            {
                return this.transportTermsField;
            }
            set
            {
                this.transportTermsField = value;
            }
        }

        /// <remarks/>
        public Address Address
        {
            get
            {
                return this.addressField;
            }
            set
            {
                this.addressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Comments")]
        public Comments[] Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class TermsOfDeliveryCode
    {

        private string valueField;

        private string valueField1;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
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

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField1;
            }
            set
            {
                this.valueField1 = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ShippingPaymentMethod
    {

        private string valueField;

        private string valueField1;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
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

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField1;
            }
            set
            {
                this.valueField1 = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class TransportTerms
    {

        private string valueField;

        private string valueField1;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
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

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField1;
            }
            set
            {
                this.valueField1 = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ScheduleLine
    {

        private string unitOfMeasureField;

        private ScheduleLineReleaseInfo scheduleLineReleaseInfoField;

        private SubcontractingComponent[] subcontractingComponentField;

        private Extrinsic[] extrinsicField;

        private string quantityField;

        private string requestedDeliveryDateField;

        private string lineNumberField;

        private string deliveryWindowField;

        private string requestedShipmentDateField;

        private string originalRequestedDeliveryDateField;

        /// <remarks/>
        public string UnitOfMeasure
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
        public ScheduleLineReleaseInfo ScheduleLineReleaseInfo
        {
            get
            {
                return this.scheduleLineReleaseInfoField;
            }
            set
            {
                this.scheduleLineReleaseInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SubcontractingComponent")]
        public SubcontractingComponent[] SubcontractingComponent
        {
            get
            {
                return this.subcontractingComponentField;
            }
            set
            {
                this.subcontractingComponentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Extrinsic")]
        public Extrinsic[] Extrinsic
        {
            get
            {
                return this.extrinsicField;
            }
            set
            {
                this.extrinsicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string quantity
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string requestedDeliveryDate
        {
            get
            {
                return this.requestedDeliveryDateField;
            }
            set
            {
                this.requestedDeliveryDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lineNumber
        {
            get
            {
                return this.lineNumberField;
            }
            set
            {
                this.lineNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string deliveryWindow
        {
            get
            {
                return this.deliveryWindowField;
            }
            set
            {
                this.deliveryWindowField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string requestedShipmentDate
        {
            get
            {
                return this.requestedShipmentDateField;
            }
            set
            {
                this.requestedShipmentDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string originalRequestedDeliveryDate
        {
            get
            {
                return this.originalRequestedDeliveryDateField;
            }
            set
            {
                this.originalRequestedDeliveryDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ScheduleLineReleaseInfo
    {

        private string unitOfMeasureField;

        private ScheduleLineReleaseInfoCommitmentCode commitmentCodeField;

        private string cumulativeScheduledQuantityField;

        private string receivedQuantityField;

        /// <remarks/>
        public string UnitOfMeasure
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
        public ScheduleLineReleaseInfoCommitmentCode commitmentCode
        {
            get
            {
                return this.commitmentCodeField;
            }
            set
            {
                this.commitmentCodeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cumulativeScheduledQuantity
        {
            get
            {
                return this.cumulativeScheduledQuantityField;
            }
            set
            {
                this.cumulativeScheduledQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string receivedQuantity
        {
            get
            {
                return this.receivedQuantityField;
            }
            set
            {
                this.receivedQuantityField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum ScheduleLineReleaseInfoCommitmentCode
    {

        /// <remarks/>
        firm,

        /// <remarks/>
        tradeoff,

        /// <remarks/>
        forecast,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class SubcontractingComponent
    {

        private string componentIDField;

        private string unitOfMeasureField;

        private Description descriptionField;

        private Product productField;

        private string productRevisionIDField;

        private Batch batchField;

        private string quantityField;

        private string requirementDateField;

        private SubcontractingComponentMaterialProvisionIndicator materialProvisionIndicatorField;

        private bool materialProvisionIndicatorFieldSpecified;

        /// <remarks/>
        public string ComponentID
        {
            get
            {
                return this.componentIDField;
            }
            set
            {
                this.componentIDField = value;
            }
        }

        /// <remarks/>
        public string UnitOfMeasure
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
        public Description Description
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
        public Product Product
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

        /// <remarks/>
        public string ProductRevisionID
        {
            get
            {
                return this.productRevisionIDField;
            }
            set
            {
                this.productRevisionIDField = value;
            }
        }

        /// <remarks/>
        public Batch Batch
        {
            get
            {
                return this.batchField;
            }
            set
            {
                this.batchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string quantity
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string requirementDate
        {
            get
            {
                return this.requirementDateField;
            }
            set
            {
                this.requirementDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SubcontractingComponentMaterialProvisionIndicator materialProvisionIndicator
        {
            get
            {
                return this.materialProvisionIndicatorField;
            }
            set
            {
                this.materialProvisionIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool materialProvisionIndicatorSpecified
        {
            get
            {
                return this.materialProvisionIndicatorFieldSpecified;
            }
            set
            {
                this.materialProvisionIndicatorFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum SubcontractingComponentMaterialProvisionIndicator
    {

        /// <remarks/>
        reworkTo,

        /// <remarks/>
        reworkFrom,

        /// <remarks/>
        regular,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class MasterAgreementIDInfo
    {

        private IdReference[] idReferenceField;

        private string agreementIDField;

        private string agreementDateField;

        private MasterAgreementIDInfoAgreementType agreementTypeField;

        private bool agreementTypeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IdReference")]
        public IdReference[] IdReference
        {
            get
            {
                return this.idReferenceField;
            }
            set
            {
                this.idReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string agreementID
        {
            get
            {
                return this.agreementIDField;
            }
            set
            {
                this.agreementIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string agreementDate
        {
            get
            {
                return this.agreementDateField;
            }
            set
            {
                this.agreementDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MasterAgreementIDInfoAgreementType agreementType
        {
            get
            {
                return this.agreementTypeField;
            }
            set
            {
                this.agreementTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool agreementTypeSpecified
        {
            get
            {
                return this.agreementTypeFieldSpecified;
            }
            set
            {
                this.agreementTypeFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum MasterAgreementIDInfoAgreementType
    {

        /// <remarks/>
        scheduling_agreement,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class MasterAgreementReference
    {

        private DocumentReference documentReferenceField;

        private string agreementIDField;

        private string agreementDateField;

        private MasterAgreementReferenceAgreementType agreementTypeField;

        private bool agreementTypeFieldSpecified;

        /// <remarks/>
        public DocumentReference DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string agreementID
        {
            get
            {
                return this.agreementIDField;
            }
            set
            {
                this.agreementIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string agreementDate
        {
            get
            {
                return this.agreementDateField;
            }
            set
            {
                this.agreementDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public MasterAgreementReferenceAgreementType agreementType
        {
            get
            {
                return this.agreementTypeField;
            }
            set
            {
                this.agreementTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool agreementTypeSpecified
        {
            get
            {
                return this.agreementTypeFieldSpecified;
            }
            set
            {
                this.agreementTypeFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum MasterAgreementReferenceAgreementType
    {

        /// <remarks/>
        scheduling_agreement,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ItemOutIndustry
    {

        private ItemOutRetail itemOutRetailField;

        private ReferenceDocumentInfo[] referenceDocumentInfoField;

        private Priority priorityField;

        private QualityInfo qualityInfoField;

        private ItemOutIndustryPlanningType planningTypeField;

        private bool planningTypeFieldSpecified;

        /// <remarks/>
        public ItemOutRetail ItemOutRetail
        {
            get
            {
                return this.itemOutRetailField;
            }
            set
            {
                this.itemOutRetailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReferenceDocumentInfo")]
        public ReferenceDocumentInfo[] ReferenceDocumentInfo
        {
            get
            {
                return this.referenceDocumentInfoField;
            }
            set
            {
                this.referenceDocumentInfoField = value;
            }
        }

        /// <remarks/>
        public Priority Priority
        {
            get
            {
                return this.priorityField;
            }
            set
            {
                this.priorityField = value;
            }
        }

        /// <remarks/>
        public QualityInfo QualityInfo
        {
            get
            {
                return this.qualityInfoField;
            }
            set
            {
                this.qualityInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ItemOutIndustryPlanningType planningType
        {
            get
            {
                return this.planningTypeField;
            }
            set
            {
                this.planningTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool planningTypeSpecified
        {
            get
            {
                return this.planningTypeFieldSpecified;
            }
            set
            {
                this.planningTypeFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ItemOutRetail
    {

        private string promotionVariantIDField;

        private string promotionDealIDField;

        /// <remarks/>
        public string PromotionVariantID
        {
            get
            {
                return this.promotionVariantIDField;
            }
            set
            {
                this.promotionVariantIDField = value;
            }
        }

        /// <remarks/>
        public string PromotionDealID
        {
            get
            {
                return this.promotionDealIDField;
            }
            set
            {
                this.promotionDealIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ReferenceDocumentInfo
    {

        private object itemField;

        private DateInfo[] dateInfoField;

        private Contact[] contactField;

        private Extrinsic[] extrinsicField;

        private string lineNumberField;

        private ReferenceDocumentInfoStatus statusField;

        private bool statusFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentInfo", typeof(DocumentInfo))]
        [System.Xml.Serialization.XmlElementAttribute("DocumentReference", typeof(DocumentReference))]
        public object Item
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
        [System.Xml.Serialization.XmlElementAttribute("DateInfo")]
        public DateInfo[] DateInfo
        {
            get
            {
                return this.dateInfoField;
            }
            set
            {
                this.dateInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Contact")]
        public Contact[] Contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Extrinsic")]
        public Extrinsic[] Extrinsic
        {
            get
            {
                return this.extrinsicField;
            }
            set
            {
                this.extrinsicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lineNumber
        {
            get
            {
                return this.lineNumberField;
            }
            set
            {
                this.lineNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ReferenceDocumentInfoStatus status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool statusSpecified
        {
            get
            {
                return this.statusFieldSpecified;
            }
            set
            {
                this.statusFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class DocumentInfo
    {

        private string documentIDField;

        private string documentTypeField;

        private string documentDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string documentID
        {
            get
            {
                return this.documentIDField;
            }
            set
            {
                this.documentIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string documentType
        {
            get
            {
                return this.documentTypeField;
            }
            set
            {
                this.documentTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string documentDate
        {
            get
            {
                return this.documentDateField;
            }
            set
            {
                this.documentDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class DateInfo
    {

        private Extrinsic[] extrinsicField;

        private DateInfoType typeField;

        private string dateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Extrinsic")]
        public Extrinsic[] Extrinsic
        {
            get
            {
                return this.extrinsicField;
            }
            set
            {
                this.extrinsicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DateInfoType type
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum DateInfoType
    {

        /// <remarks/>
        expectedShipmentDate,

        /// <remarks/>
        productionStartDate,

        /// <remarks/>
        productionFinishDate,

        /// <remarks/>
        requestedPickUpDate,

        /// <remarks/>
        expectedPickUpDate,

        /// <remarks/>
        actualPickUpDate,

        /// <remarks/>
        requestedDeliveryDate,

        /// <remarks/>
        expectedDeliveryDate,

        /// <remarks/>
        actualDeliveryDate,

        /// <remarks/>
        confirmedShipmentDate,

        /// <remarks/>
        confirmedDeliveryDate,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum ReferenceDocumentInfoStatus
    {

        /// <remarks/>
        created,

        /// <remarks/>
        released,

        /// <remarks/>
        open,

        /// <remarks/>
        completed,

        /// <remarks/>
        closed,

        /// <remarks/>
        cancelled,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Priority
    {

        private Description descriptionField;

        private PriorityLevel levelField;

        private string sequenceField;

        private string inventory_levelField;

        /// <remarks/>
        public Description Description
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PriorityLevel level
        {
            get
            {
                return this.levelField;
            }
            set
            {
                this.levelField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string sequence
        {
            get
            {
                return this.sequenceField;
            }
            set
            {
                this.sequenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inventory_level
        {
            get
            {
                return this.inventory_levelField;
            }
            set
            {
                this.inventory_levelField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum PriorityLevel
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1")]
        Item1,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("2")]
        Item2,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("3")]
        Item3,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("4")]
        Item4,

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("5")]
        Item5,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class QualityInfo
    {

        private IdReference[] idReferenceField;

        private QualityInfoRequiresQualityProcess requiresQualityProcessField;

        private bool requiresQualityProcessFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IdReference")]
        public IdReference[] IdReference
        {
            get
            {
                return this.idReferenceField;
            }
            set
            {
                this.idReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public QualityInfoRequiresQualityProcess requiresQualityProcess
        {
            get
            {
                return this.requiresQualityProcessField;
            }
            set
            {
                this.requiresQualityProcessField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool requiresQualityProcessSpecified
        {
            get
            {
                return this.requiresQualityProcessFieldSpecified;
            }
            set
            {
                this.requiresQualityProcessFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum QualityInfoRequiresQualityProcess
    {

        /// <remarks/>
        yes,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum ItemOutIndustryPlanningType
    {

        /// <remarks/>
        MTO,

        /// <remarks/>
        MTS,

        /// <remarks/>
        ATO,

        /// <remarks/>
        CTO,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Packaging
    {

        private object[] itemsField;

        private Description descriptionField;

        private string packagingLevelCodeField;

        private string packageTypeCodeIdentifierCodeField;

        private string shippingContainerSerialCodeField;

        private string shippingContainerSerialCodeReferenceField;

        private PackageID packageIDField;

        private string[] shippingMarkField;

        private OrderedQuantity orderedQuantityField;

        private DispatchQuantity dispatchQuantityField;

        private FreeGoodsQuantity freeGoodsQuantityField;

        private string quantityVarianceNoteField;

        private BestBeforeDate bestBeforeDateField;

        private Extrinsic[] extrinsicField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Dimension", typeof(Dimension))]
        [System.Xml.Serialization.XmlElementAttribute("PackagingCode", typeof(PackagingCode))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        public Description Description
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
        public string PackagingLevelCode
        {
            get
            {
                return this.packagingLevelCodeField;
            }
            set
            {
                this.packagingLevelCodeField = value;
            }
        }

        /// <remarks/>
        public string PackageTypeCodeIdentifierCode
        {
            get
            {
                return this.packageTypeCodeIdentifierCodeField;
            }
            set
            {
                this.packageTypeCodeIdentifierCodeField = value;
            }
        }

        /// <remarks/>
        public string ShippingContainerSerialCode
        {
            get
            {
                return this.shippingContainerSerialCodeField;
            }
            set
            {
                this.shippingContainerSerialCodeField = value;
            }
        }

        /// <remarks/>
        public string ShippingContainerSerialCodeReference
        {
            get
            {
                return this.shippingContainerSerialCodeReferenceField;
            }
            set
            {
                this.shippingContainerSerialCodeReferenceField = value;
            }
        }

        /// <remarks/>
        public PackageID PackageID
        {
            get
            {
                return this.packageIDField;
            }
            set
            {
                this.packageIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShippingMark")]
        public string[] ShippingMark
        {
            get
            {
                return this.shippingMarkField;
            }
            set
            {
                this.shippingMarkField = value;
            }
        }

        /// <remarks/>
        public OrderedQuantity OrderedQuantity
        {
            get
            {
                return this.orderedQuantityField;
            }
            set
            {
                this.orderedQuantityField = value;
            }
        }

        /// <remarks/>
        public DispatchQuantity DispatchQuantity
        {
            get
            {
                return this.dispatchQuantityField;
            }
            set
            {
                this.dispatchQuantityField = value;
            }
        }

        /// <remarks/>
        public FreeGoodsQuantity FreeGoodsQuantity
        {
            get
            {
                return this.freeGoodsQuantityField;
            }
            set
            {
                this.freeGoodsQuantityField = value;
            }
        }

        /// <remarks/>
        public string QuantityVarianceNote
        {
            get
            {
                return this.quantityVarianceNoteField;
            }
            set
            {
                this.quantityVarianceNoteField = value;
            }
        }

        /// <remarks/>
        public BestBeforeDate BestBeforeDate
        {
            get
            {
                return this.bestBeforeDateField;
            }
            set
            {
                this.bestBeforeDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Extrinsic")]
        public Extrinsic[] Extrinsic
        {
            get
            {
                return this.extrinsicField;
            }
            set
            {
                this.extrinsicField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class PackagingCode
    {

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class PackageID
    {

        private string globalIndividualAssetIDField;

        private string returnablePackageIDField;

        private string packageTrackingIDField;

        /// <remarks/>
        public string GlobalIndividualAssetID
        {
            get
            {
                return this.globalIndividualAssetIDField;
            }
            set
            {
                this.globalIndividualAssetIDField = value;
            }
        }

        /// <remarks/>
        public string ReturnablePackageID
        {
            get
            {
                return this.returnablePackageIDField;
            }
            set
            {
                this.returnablePackageIDField = value;
            }
        }

        /// <remarks/>
        public string PackageTrackingID
        {
            get
            {
                return this.packageTrackingIDField;
            }
            set
            {
                this.packageTrackingIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class OrderedQuantity
    {

        private string unitOfMeasureField;

        private string quantityField;

        /// <remarks/>
        public string UnitOfMeasure
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
        public string quantity
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class DispatchQuantity
    {

        private string unitOfMeasureField;

        private string quantityField;

        /// <remarks/>
        public string UnitOfMeasure
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
        public string quantity
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class FreeGoodsQuantity
    {

        private string unitOfMeasureField;

        private string quantityField;

        /// <remarks/>
        public string UnitOfMeasure
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
        public string quantity
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class BestBeforeDate
    {

        private string dateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ReleaseInfo
    {

        private string unitOfMeasureField;

        private ShipNoticeReleaseInfo shipNoticeReleaseInfoField;

        private Extrinsic[] extrinsicField;

        private ReleaseInfoReleaseType releaseTypeField;

        private string cumulativeReceivedQuantityField;

        private string releaseNumberField;

        private string productionGoAheadEndDateField;

        private string materialGoAheadEndDateField;

        /// <remarks/>
        public string UnitOfMeasure
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
        public ShipNoticeReleaseInfo ShipNoticeReleaseInfo
        {
            get
            {
                return this.shipNoticeReleaseInfoField;
            }
            set
            {
                this.shipNoticeReleaseInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Extrinsic")]
        public Extrinsic[] Extrinsic
        {
            get
            {
                return this.extrinsicField;
            }
            set
            {
                this.extrinsicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ReleaseInfoReleaseType releaseType
        {
            get
            {
                return this.releaseTypeField;
            }
            set
            {
                this.releaseTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string cumulativeReceivedQuantity
        {
            get
            {
                return this.cumulativeReceivedQuantityField;
            }
            set
            {
                this.cumulativeReceivedQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string releaseNumber
        {
            get
            {
                return this.releaseNumberField;
            }
            set
            {
                this.releaseNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string productionGoAheadEndDate
        {
            get
            {
                return this.productionGoAheadEndDateField;
            }
            set
            {
                this.productionGoAheadEndDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string materialGoAheadEndDate
        {
            get
            {
                return this.materialGoAheadEndDateField;
            }
            set
            {
                this.materialGoAheadEndDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ShipNoticeReleaseInfo
    {

        private object itemField;

        private string unitOfMeasureField;

        private string receivedQuantityField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShipNoticeIDInfo", typeof(ShipNoticeIDInfo))]
        [System.Xml.Serialization.XmlElementAttribute("ShipNoticeReference", typeof(ShipNoticeReference))]
        public object Item
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
        public string UnitOfMeasure
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
        public string receivedQuantity
        {
            get
            {
                return this.receivedQuantityField;
            }
            set
            {
                this.receivedQuantityField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ShipNoticeIDInfo
    {

        private IdReference[] idReferenceField;

        private string shipNoticeIDField;

        private string shipNoticeDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IdReference")]
        public IdReference[] IdReference
        {
            get
            {
                return this.idReferenceField;
            }
            set
            {
                this.idReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string shipNoticeID
        {
            get
            {
                return this.shipNoticeIDField;
            }
            set
            {
                this.shipNoticeIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string shipNoticeDate
        {
            get
            {
                return this.shipNoticeDateField;
            }
            set
            {
                this.shipNoticeDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ShipNoticeReference
    {

        private DocumentReference documentReferenceField;

        private string shipNoticeIDField;

        private string shipNoticeDateField;

        /// <remarks/>
        public DocumentReference DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string shipNoticeID
        {
            get
            {
                return this.shipNoticeIDField;
            }
            set
            {
                this.shipNoticeIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string shipNoticeDate
        {
            get
            {
                return this.shipNoticeDateField;
            }
            set
            {
                this.shipNoticeDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum ReleaseInfoReleaseType
    {

        /// <remarks/>
        forecast,

        /// <remarks/>
        jit,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum ItemOutIsAdHoc
    {

        /// <remarks/>
        yes,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum ItemOutItemType
    {

        /// <remarks/>
        composite,

        /// <remarks/>
        item,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum ItemOutRequiresServiceEntry
    {

        /// <remarks/>
        yes,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum ItemOutCompositeItemType
    {

        /// <remarks/>
        groupLevel,

        /// <remarks/>
        itemLevel,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum ItemOutItemCategory
    {

        /// <remarks/>
        subcontract,

        /// <remarks/>
        consignment,

        /// <remarks/>
        thirdParty,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum ItemOutSubcontractingType
    {

        /// <remarks/>
        regular,

        /// <remarks/>
        refurbWithoutChange,

        /// <remarks/>
        refurbWithChange,

        /// <remarks/>
        replacement,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum ItemOutIsReturn
    {

        /// <remarks/>
        yes,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum ItemOutIsDeliveryCompleted
    {

        /// <remarks/>
        yes,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ItemIn
    {

        private ItemID itemIDField;

        private Node[] pathField;

        private ItemDetail itemDetailField;

        private object itemField;

        private ShipTo shipToField;

        private Shipping shippingField;

        private Tax taxField;

        private SpendDetail spendDetailField;

        private Distribution[] distributionField;

        private Contact[] contactField;

        private Comments commentsField;

        private ScheduleLine[] scheduleLineField;

        private BillTo billToField;

        private Batch batchField;

        private DateInfo[] dateInfoField;

        private Extrinsic[] extrinsicField;

        private string quantityField;

        private string openQuantityField;

        private string promisedQuantityField;

        private string lineNumberField;

        private string parentLineNumberField;

        private ItemInItemType itemTypeField;

        private bool itemTypeFieldSpecified;

        private ItemInCompositeItemType compositeItemTypeField;

        private bool compositeItemTypeFieldSpecified;

        private ItemInItemClassification itemClassificationField;

        private bool itemClassificationFieldSpecified;

        /// <remarks/>
        public ItemID ItemID
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

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Node", IsNullable = false)]
        public Node[] Path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }

        /// <remarks/>
        public ItemDetail ItemDetail
        {
            get
            {
                return this.itemDetailField;
            }
            set
            {
                this.itemDetailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SupplierID", typeof(SupplierID))]
        [System.Xml.Serialization.XmlElementAttribute("SupplierList", typeof(SupplierList))]
        public object Item
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
        public ShipTo ShipTo
        {
            get
            {
                return this.shipToField;
            }
            set
            {
                this.shipToField = value;
            }
        }

        /// <remarks/>
        public Shipping Shipping
        {
            get
            {
                return this.shippingField;
            }
            set
            {
                this.shippingField = value;
            }
        }

        /// <remarks/>
        public Tax Tax
        {
            get
            {
                return this.taxField;
            }
            set
            {
                this.taxField = value;
            }
        }

        /// <remarks/>
        public SpendDetail SpendDetail
        {
            get
            {
                return this.spendDetailField;
            }
            set
            {
                this.spendDetailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Distribution")]
        public Distribution[] Distribution
        {
            get
            {
                return this.distributionField;
            }
            set
            {
                this.distributionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Contact")]
        public Contact[] Contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
            }
        }

        /// <remarks/>
        public Comments Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ScheduleLine")]
        public ScheduleLine[] ScheduleLine
        {
            get
            {
                return this.scheduleLineField;
            }
            set
            {
                this.scheduleLineField = value;
            }
        }

        /// <remarks/>
        public BillTo BillTo
        {
            get
            {
                return this.billToField;
            }
            set
            {
                this.billToField = value;
            }
        }

        /// <remarks/>
        public Batch Batch
        {
            get
            {
                return this.batchField;
            }
            set
            {
                this.batchField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DateInfo")]
        public DateInfo[] DateInfo
        {
            get
            {
                return this.dateInfoField;
            }
            set
            {
                this.dateInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Extrinsic")]
        public Extrinsic[] Extrinsic
        {
            get
            {
                return this.extrinsicField;
            }
            set
            {
                this.extrinsicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string quantity
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string openQuantity
        {
            get
            {
                return this.openQuantityField;
            }
            set
            {
                this.openQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string promisedQuantity
        {
            get
            {
                return this.promisedQuantityField;
            }
            set
            {
                this.promisedQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lineNumber
        {
            get
            {
                return this.lineNumberField;
            }
            set
            {
                this.lineNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string parentLineNumber
        {
            get
            {
                return this.parentLineNumberField;
            }
            set
            {
                this.parentLineNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ItemInItemType itemType
        {
            get
            {
                return this.itemTypeField;
            }
            set
            {
                this.itemTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itemTypeSpecified
        {
            get
            {
                return this.itemTypeFieldSpecified;
            }
            set
            {
                this.itemTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ItemInCompositeItemType compositeItemType
        {
            get
            {
                return this.compositeItemTypeField;
            }
            set
            {
                this.compositeItemTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool compositeItemTypeSpecified
        {
            get
            {
                return this.compositeItemTypeFieldSpecified;
            }
            set
            {
                this.compositeItemTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ItemInItemClassification itemClassification
        {
            get
            {
                return this.itemClassificationField;
            }
            set
            {
                this.itemClassificationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itemClassificationSpecified
        {
            get
            {
                return this.itemClassificationFieldSpecified;
            }
            set
            {
                this.itemClassificationFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum ItemInItemType
    {

        /// <remarks/>
        composite,

        /// <remarks/>
        item,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum ItemInCompositeItemType
    {

        /// <remarks/>
        groupLevel,

        /// <remarks/>
        itemLevel,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum ItemInItemClassification
    {

        /// <remarks/>
        material,

        /// <remarks/>
        service,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class PaymentStatus
    {

        private PCard pCardField;

        private Total totalField;

        private Shipping shippingField;

        private Tax taxField;

        private Extrinsic[] extrinsicField;

        private string orderIDField;

        private string transactionTimestampField;

        private PaymentStatusType typeField;

        private PaymentStatusIsFailed isFailedField;

        private bool isFailedFieldSpecified;

        private string transactionIDField;

        private string authorizationIDField;

        /// <remarks/>
        public PCard PCard
        {
            get
            {
                return this.pCardField;
            }
            set
            {
                this.pCardField = value;
            }
        }

        /// <remarks/>
        public Total Total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        public Shipping Shipping
        {
            get
            {
                return this.shippingField;
            }
            set
            {
                this.shippingField = value;
            }
        }

        /// <remarks/>
        public Tax Tax
        {
            get
            {
                return this.taxField;
            }
            set
            {
                this.taxField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Extrinsic")]
        public Extrinsic[] Extrinsic
        {
            get
            {
                return this.extrinsicField;
            }
            set
            {
                this.extrinsicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderID
        {
            get
            {
                return this.orderIDField;
            }
            set
            {
                this.orderIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string transactionTimestamp
        {
            get
            {
                return this.transactionTimestampField;
            }
            set
            {
                this.transactionTimestampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PaymentStatusType type
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PaymentStatusIsFailed isFailed
        {
            get
            {
                return this.isFailedField;
            }
            set
            {
                this.isFailedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isFailedSpecified
        {
            get
            {
                return this.isFailedFieldSpecified;
            }
            set
            {
                this.isFailedFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string transactionID
        {
            get
            {
                return this.transactionIDField;
            }
            set
            {
                this.transactionIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string authorizationID
        {
            get
            {
                return this.authorizationIDField;
            }
            set
            {
                this.authorizationIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum PaymentStatusType
    {

        /// <remarks/>
        Authorization,

        /// <remarks/>
        Settlement,

        /// <remarks/>
        Sale,

        /// <remarks/>
        Credit,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum PaymentStatusIsFailed
    {

        /// <remarks/>
        yes,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class PartialAmount
    {

        private Money moneyField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceStatus
    {

        private InvoiceIDInfo invoiceIDInfoField;

        private PartialAmount partialAmountField;

        private Comments[] commentsField;

        private InvoiceStatusType typeField;

        /// <remarks/>
        public InvoiceIDInfo InvoiceIDInfo
        {
            get
            {
                return this.invoiceIDInfoField;
            }
            set
            {
                this.invoiceIDInfoField = value;
            }
        }

        /// <remarks/>
        public PartialAmount PartialAmount
        {
            get
            {
                return this.partialAmountField;
            }
            set
            {
                this.partialAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Comments")]
        public Comments[] Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public InvoiceStatusType type
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceIDInfo
    {

        private string invoiceIDField;

        private string invoiceDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string invoiceID
        {
            get
            {
                return this.invoiceIDField;
            }
            set
            {
                this.invoiceIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string invoiceDate
        {
            get
            {
                return this.invoiceDateField;
            }
            set
            {
                this.invoiceDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum InvoiceStatusType
    {

        /// <remarks/>
        processing,

        /// <remarks/>
        canceled,

        /// <remarks/>
        reconciled,

        /// <remarks/>
        rejected,

        /// <remarks/>
        paying,

        /// <remarks/>
        paid,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class DeliveryPeriod
    {

        private Period periodField;

        /// <remarks/>
        public Period Period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class OrderRequest
    {

        private OrderRequestHeader orderRequestHeaderField;

        private ItemOut[] itemOutField;

        /// <remarks/>
        public OrderRequestHeader OrderRequestHeader
        {
            get
            {
                return this.orderRequestHeaderField;
            }
            set
            {
                this.orderRequestHeaderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemOut")]
        public ItemOut[] ItemOut
        {
            get
            {
                return this.itemOutField;
            }
            set
            {
                this.itemOutField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class OrderRequestHeader
    {

        private Total totalField;

        private ShipTo shipToField;

        private BillTo billToField;

        private Shipping shippingField;

        private Tax taxField;

        private Payment paymentField;

        private PaymentTerm[] paymentTermField;

        private Contact[] contactField;

        private Comments commentsField;

        private Followup followupField;

        private ControlKeys controlKeysField;

        private DocumentReference documentReferenceField;

        private SupplierOrderInfo supplierOrderInfoField;

        private TermsOfDelivery termsOfDeliveryField;

        private DeliveryPeriod deliveryPeriodField;

        private IdReference[] idReferenceField;

        private OrderRequestHeaderIndustry orderRequestHeaderIndustryField;

        private Extrinsic[] extrinsicField;

        private string orderIDField;

        private string orderDateField;

        private OrderRequestHeaderOrderType orderTypeField;

        private OrderRequestHeaderReleaseRequired releaseRequiredField;

        private bool releaseRequiredFieldSpecified;

        private OrderRequestHeaderType typeField;

        private string orderVersionField;

        private OrderRequestHeaderIsInternalVersion isInternalVersionField;

        private bool isInternalVersionFieldSpecified;

        private string parentAgreementIDField;

        private string parentAgreementPayloadIDField;

        private string effectiveDateField;

        private string expirationDateField;

        private string agreementIDField;

        private string agreementPayloadIDField;

        private string requisitionIDField;

        private OrderRequestHeaderShipComplete shipCompleteField;

        private bool shipCompleteFieldSpecified;

        private string pickUpDateField;

        private string requestedDeliveryDateField;

        public OrderRequestHeader()
        {
            this.orderTypeField = OrderRequestHeaderOrderType.regular;
            this.typeField = OrderRequestHeaderType.@new;
        }

        /// <remarks/>
        public Total Total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        public ShipTo ShipTo
        {
            get
            {
                return this.shipToField;
            }
            set
            {
                this.shipToField = value;
            }
        }

        /// <remarks/>
        public BillTo BillTo
        {
            get
            {
                return this.billToField;
            }
            set
            {
                this.billToField = value;
            }
        }

        /// <remarks/>
        public Shipping Shipping
        {
            get
            {
                return this.shippingField;
            }
            set
            {
                this.shippingField = value;
            }
        }

        /// <remarks/>
        public Tax Tax
        {
            get
            {
                return this.taxField;
            }
            set
            {
                this.taxField = value;
            }
        }

        /// <remarks/>
        public Payment Payment
        {
            get
            {
                return this.paymentField;
            }
            set
            {
                this.paymentField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PaymentTerm")]
        public PaymentTerm[] PaymentTerm
        {
            get
            {
                return this.paymentTermField;
            }
            set
            {
                this.paymentTermField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Contact")]
        public Contact[] Contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
            }
        }

        /// <remarks/>
        public Comments Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        public Followup Followup
        {
            get
            {
                return this.followupField;
            }
            set
            {
                this.followupField = value;
            }
        }

        /// <remarks/>
        public ControlKeys ControlKeys
        {
            get
            {
                return this.controlKeysField;
            }
            set
            {
                this.controlKeysField = value;
            }
        }

        /// <remarks/>
        public DocumentReference DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
            }
        }

        /// <remarks/>
        public SupplierOrderInfo SupplierOrderInfo
        {
            get
            {
                return this.supplierOrderInfoField;
            }
            set
            {
                this.supplierOrderInfoField = value;
            }
        }

        /// <remarks/>
        public TermsOfDelivery TermsOfDelivery
        {
            get
            {
                return this.termsOfDeliveryField;
            }
            set
            {
                this.termsOfDeliveryField = value;
            }
        }

        /// <remarks/>
        public DeliveryPeriod DeliveryPeriod
        {
            get
            {
                return this.deliveryPeriodField;
            }
            set
            {
                this.deliveryPeriodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IdReference")]
        public IdReference[] IdReference
        {
            get
            {
                return this.idReferenceField;
            }
            set
            {
                this.idReferenceField = value;
            }
        }

        /// <remarks/>
        public OrderRequestHeaderIndustry OrderRequestHeaderIndustry
        {
            get
            {
                return this.orderRequestHeaderIndustryField;
            }
            set
            {
                this.orderRequestHeaderIndustryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Extrinsic")]
        public Extrinsic[] Extrinsic
        {
            get
            {
                return this.extrinsicField;
            }
            set
            {
                this.extrinsicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderID
        {
            get
            {
                return this.orderIDField;
            }
            set
            {
                this.orderIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderDate
        {
            get
            {
                return this.orderDateField;
            }
            set
            {
                this.orderDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(OrderRequestHeaderOrderType.regular)]
        public OrderRequestHeaderOrderType orderType
        {
            get
            {
                return this.orderTypeField;
            }
            set
            {
                this.orderTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OrderRequestHeaderReleaseRequired releaseRequired
        {
            get
            {
                return this.releaseRequiredField;
            }
            set
            {
                this.releaseRequiredField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool releaseRequiredSpecified
        {
            get
            {
                return this.releaseRequiredFieldSpecified;
            }
            set
            {
                this.releaseRequiredFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(OrderRequestHeaderType.@new)]
        public OrderRequestHeaderType type
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderVersion
        {
            get
            {
                return this.orderVersionField;
            }
            set
            {
                this.orderVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OrderRequestHeaderIsInternalVersion isInternalVersion
        {
            get
            {
                return this.isInternalVersionField;
            }
            set
            {
                this.isInternalVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isInternalVersionSpecified
        {
            get
            {
                return this.isInternalVersionFieldSpecified;
            }
            set
            {
                this.isInternalVersionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string parentAgreementID
        {
            get
            {
                return this.parentAgreementIDField;
            }
            set
            {
                this.parentAgreementIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string parentAgreementPayloadID
        {
            get
            {
                return this.parentAgreementPayloadIDField;
            }
            set
            {
                this.parentAgreementPayloadIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string effectiveDate
        {
            get
            {
                return this.effectiveDateField;
            }
            set
            {
                this.effectiveDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string expirationDate
        {
            get
            {
                return this.expirationDateField;
            }
            set
            {
                this.expirationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string agreementID
        {
            get
            {
                return this.agreementIDField;
            }
            set
            {
                this.agreementIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string agreementPayloadID
        {
            get
            {
                return this.agreementPayloadIDField;
            }
            set
            {
                this.agreementPayloadIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string requisitionID
        {
            get
            {
                return this.requisitionIDField;
            }
            set
            {
                this.requisitionIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public OrderRequestHeaderShipComplete shipComplete
        {
            get
            {
                return this.shipCompleteField;
            }
            set
            {
                this.shipCompleteField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool shipCompleteSpecified
        {
            get
            {
                return this.shipCompleteFieldSpecified;
            }
            set
            {
                this.shipCompleteFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string pickUpDate
        {
            get
            {
                return this.pickUpDateField;
            }
            set
            {
                this.pickUpDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string requestedDeliveryDate
        {
            get
            {
                return this.requestedDeliveryDateField;
            }
            set
            {
                this.requestedDeliveryDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Followup
    {

        private URL uRLField;

        /// <remarks/>
        public URL URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class SupplierOrderInfo
    {

        private string orderIDField;

        private string orderDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderID
        {
            get
            {
                return this.orderIDField;
            }
            set
            {
                this.orderIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderDate
        {
            get
            {
                return this.orderDateField;
            }
            set
            {
                this.orderDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class OrderRequestHeaderIndustry
    {

        private ReferenceDocumentInfo[] referenceDocumentInfoField;

        private Priority priorityField;

        private ExternalDocumentType externalDocumentTypeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReferenceDocumentInfo")]
        public ReferenceDocumentInfo[] ReferenceDocumentInfo
        {
            get
            {
                return this.referenceDocumentInfoField;
            }
            set
            {
                this.referenceDocumentInfoField = value;
            }
        }

        /// <remarks/>
        public Priority Priority
        {
            get
            {
                return this.priorityField;
            }
            set
            {
                this.priorityField = value;
            }
        }

        /// <remarks/>
        public ExternalDocumentType ExternalDocumentType
        {
            get
            {
                return this.externalDocumentTypeField;
            }
            set
            {
                this.externalDocumentTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ExternalDocumentType
    {

        private Description descriptionField;

        private string documentTypeField;

        /// <remarks/>
        public Description Description
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string documentType
        {
            get
            {
                return this.documentTypeField;
            }
            set
            {
                this.documentTypeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum OrderRequestHeaderOrderType
    {

        /// <remarks/>
        release,

        /// <remarks/>
        regular,

        /// <remarks/>
        blanket,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum OrderRequestHeaderReleaseRequired
    {

        /// <remarks/>
        yes,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum OrderRequestHeaderType
    {

        /// <remarks/>
        @new,

        /// <remarks/>
        update,

        /// <remarks/>
        delete,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum OrderRequestHeaderIsInternalVersion
    {

        /// <remarks/>
        yes,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum OrderRequestHeaderShipComplete
    {

        /// <remarks/>
        yes,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class MasterAgreementRequest
    {

        private MasterAgreementRequestHeader masterAgreementRequestHeaderField;

        private AgreementItemOut[] agreementItemOutField;

        /// <remarks/>
        public MasterAgreementRequestHeader MasterAgreementRequestHeader
        {
            get
            {
                return this.masterAgreementRequestHeaderField;
            }
            set
            {
                this.masterAgreementRequestHeaderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AgreementItemOut")]
        public AgreementItemOut[] AgreementItemOut
        {
            get
            {
                return this.agreementItemOutField;
            }
            set
            {
                this.agreementItemOutField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class MasterAgreementRequestHeader
    {

        private MaxAmount maxAmountField;

        private MinAmount minAmountField;

        private MaxReleaseAmount maxReleaseAmountField;

        private MinReleaseAmount minReleaseAmountField;

        private Contact[] contactField;

        private Comments commentsField;

        private DocumentReference documentReferenceField;

        private Extrinsic[] extrinsicField;

        private string agreementIDField;

        private string agreementDateField;

        private MasterAgreementRequestHeaderType typeField;

        private string effectiveDateField;

        private string expirationDateField;

        private string parentAgreementPayloadIDField;

        private MasterAgreementRequestHeaderOperation operationField;

        public MasterAgreementRequestHeader()
        {
            this.typeField = MasterAgreementRequestHeaderType.value;
            this.operationField = MasterAgreementRequestHeaderOperation.@new;
        }

        /// <remarks/>
        public MaxAmount MaxAmount
        {
            get
            {
                return this.maxAmountField;
            }
            set
            {
                this.maxAmountField = value;
            }
        }

        /// <remarks/>
        public MinAmount MinAmount
        {
            get
            {
                return this.minAmountField;
            }
            set
            {
                this.minAmountField = value;
            }
        }

        /// <remarks/>
        public MaxReleaseAmount MaxReleaseAmount
        {
            get
            {
                return this.maxReleaseAmountField;
            }
            set
            {
                this.maxReleaseAmountField = value;
            }
        }

        /// <remarks/>
        public MinReleaseAmount MinReleaseAmount
        {
            get
            {
                return this.minReleaseAmountField;
            }
            set
            {
                this.minReleaseAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Contact")]
        public Contact[] Contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
            }
        }

        /// <remarks/>
        public Comments Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        public DocumentReference DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Extrinsic")]
        public Extrinsic[] Extrinsic
        {
            get
            {
                return this.extrinsicField;
            }
            set
            {
                this.extrinsicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string agreementID
        {
            get
            {
                return this.agreementIDField;
            }
            set
            {
                this.agreementIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string agreementDate
        {
            get
            {
                return this.agreementDateField;
            }
            set
            {
                this.agreementDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(MasterAgreementRequestHeaderType.value)]
        public MasterAgreementRequestHeaderType type
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string effectiveDate
        {
            get
            {
                return this.effectiveDateField;
            }
            set
            {
                this.effectiveDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string expirationDate
        {
            get
            {
                return this.expirationDateField;
            }
            set
            {
                this.expirationDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string parentAgreementPayloadID
        {
            get
            {
                return this.parentAgreementPayloadIDField;
            }
            set
            {
                this.parentAgreementPayloadIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(MasterAgreementRequestHeaderOperation.@new)]
        public MasterAgreementRequestHeaderOperation operation
        {
            get
            {
                return this.operationField;
            }
            set
            {
                this.operationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class MaxReleaseAmount
    {

        private Money moneyField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class MinReleaseAmount
    {

        private Money moneyField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum MasterAgreementRequestHeaderType
    {

        /// <remarks/>
        value,

        /// <remarks/>
        quantity,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum MasterAgreementRequestHeaderOperation
    {

        /// <remarks/>
        @new,

        /// <remarks/>
        update,

        /// <remarks/>
        delete,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class AgreementItemOut
    {

        private MaxAmount maxAmountField;

        private MinAmount minAmountField;

        private MaxReleaseAmount maxReleaseAmountField;

        private MinReleaseAmount minReleaseAmountField;

        private ItemOut itemOutField;

        private string maxQuantityField;

        private string minQuantityField;

        private string maxReleaseQuantityField;

        private string minReleaseQuantityField;

        /// <remarks/>
        public MaxAmount MaxAmount
        {
            get
            {
                return this.maxAmountField;
            }
            set
            {
                this.maxAmountField = value;
            }
        }

        /// <remarks/>
        public MinAmount MinAmount
        {
            get
            {
                return this.minAmountField;
            }
            set
            {
                this.minAmountField = value;
            }
        }

        /// <remarks/>
        public MaxReleaseAmount MaxReleaseAmount
        {
            get
            {
                return this.maxReleaseAmountField;
            }
            set
            {
                this.maxReleaseAmountField = value;
            }
        }

        /// <remarks/>
        public MinReleaseAmount MinReleaseAmount
        {
            get
            {
                return this.minReleaseAmountField;
            }
            set
            {
                this.minReleaseAmountField = value;
            }
        }

        /// <remarks/>
        public ItemOut ItemOut
        {
            get
            {
                return this.itemOutField;
            }
            set
            {
                this.itemOutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string maxQuantity
        {
            get
            {
                return this.maxQuantityField;
            }
            set
            {
                this.maxQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string minQuantity
        {
            get
            {
                return this.minQuantityField;
            }
            set
            {
                this.minQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string maxReleaseQuantity
        {
            get
            {
                return this.maxReleaseQuantityField;
            }
            set
            {
                this.maxReleaseQuantityField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string minReleaseQuantity
        {
            get
            {
                return this.minReleaseQuantityField;
            }
            set
            {
                this.minReleaseQuantityField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class PurchaseRequisitionRequest
    {

        private PurchaseRequisition purchaseRequisitionField;

        /// <remarks/>
        public PurchaseRequisition PurchaseRequisition
        {
            get
            {
                return this.purchaseRequisitionField;
            }
            set
            {
                this.purchaseRequisitionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class PurchaseRequisition
    {

        private PurchaseRequisitionHeader purchaseRequisitionHeaderField;

        private ItemIn[] itemInField;

        /// <remarks/>
        public PurchaseRequisitionHeader PurchaseRequisitionHeader
        {
            get
            {
                return this.purchaseRequisitionHeaderField;
            }
            set
            {
                this.purchaseRequisitionHeaderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemIn")]
        public ItemIn[] ItemIn
        {
            get
            {
                return this.itemInField;
            }
            set
            {
                this.itemInField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class PurchaseRequisitionHeader
    {

        private Shipping shippingField;

        private Tax taxField;

        private Total totalField;

        private ShipTo shipToField;

        private BillTo billToField;

        private Contact[] contactField;

        private Comments commentsField;

        private DocumentReference documentReferenceField;

        private Extrinsic[] extrinsicField;

        private string requisitionIDField;

        private string requisitionDateField;

        private PurchaseRequisitionHeaderType typeField;

        private string requisitionVersionField;

        public PurchaseRequisitionHeader()
        {
            this.typeField = PurchaseRequisitionHeaderType.@new;
        }

        /// <remarks/>
        public Shipping Shipping
        {
            get
            {
                return this.shippingField;
            }
            set
            {
                this.shippingField = value;
            }
        }

        /// <remarks/>
        public Tax Tax
        {
            get
            {
                return this.taxField;
            }
            set
            {
                this.taxField = value;
            }
        }

        /// <remarks/>
        public Total Total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        public ShipTo ShipTo
        {
            get
            {
                return this.shipToField;
            }
            set
            {
                this.shipToField = value;
            }
        }

        /// <remarks/>
        public BillTo BillTo
        {
            get
            {
                return this.billToField;
            }
            set
            {
                this.billToField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Contact")]
        public Contact[] Contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
            }
        }

        /// <remarks/>
        public Comments Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        public DocumentReference DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Extrinsic")]
        public Extrinsic[] Extrinsic
        {
            get
            {
                return this.extrinsicField;
            }
            set
            {
                this.extrinsicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string requisitionID
        {
            get
            {
                return this.requisitionIDField;
            }
            set
            {
                this.requisitionIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string requisitionDate
        {
            get
            {
                return this.requisitionDateField;
            }
            set
            {
                this.requisitionDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(PurchaseRequisitionHeaderType.@new)]
        public PurchaseRequisitionHeaderType type
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string requisitionVersion
        {
            get
            {
                return this.requisitionVersionField;
            }
            set
            {
                this.requisitionVersionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum PurchaseRequisitionHeaderType
    {

        /// <remarks/>
        @new,

        /// <remarks/>
        update,

        /// <remarks/>
        delete,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class PunchOutSetupRequest
    {

        private BuyerCookie buyerCookieField;

        private Extrinsic[] extrinsicField;

        private BrowserFormPost browserFormPostField;

        private Contact[] contactField;

        private SupplierSetup supplierSetupField;

        private ShipTo shipToField;

        private SelectedItem selectedItemField;

        private ItemOut[] itemOutField;

        private PunchOutSetupRequestOperation operationField;

        /// <remarks/>
        public BuyerCookie BuyerCookie
        {
            get
            {
                return this.buyerCookieField;
            }
            set
            {
                this.buyerCookieField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Extrinsic")]
        public Extrinsic[] Extrinsic
        {
            get
            {
                return this.extrinsicField;
            }
            set
            {
                this.extrinsicField = value;
            }
        }

        /// <remarks/>
        public BrowserFormPost BrowserFormPost
        {
            get
            {
                return this.browserFormPostField;
            }
            set
            {
                this.browserFormPostField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Contact")]
        public Contact[] Contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
            }
        }

        /// <remarks/>
        public SupplierSetup SupplierSetup
        {
            get
            {
                return this.supplierSetupField;
            }
            set
            {
                this.supplierSetupField = value;
            }
        }

        /// <remarks/>
        public ShipTo ShipTo
        {
            get
            {
                return this.shipToField;
            }
            set
            {
                this.shipToField = value;
            }
        }

        /// <remarks/>
        public SelectedItem SelectedItem
        {
            get
            {
                return this.selectedItemField;
            }
            set
            {
                this.selectedItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemOut")]
        public ItemOut[] ItemOut
        {
            get
            {
                return this.itemOutField;
            }
            set
            {
                this.itemOutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PunchOutSetupRequestOperation operation
        {
            get
            {
                return this.operationField;
            }
            set
            {
                this.operationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class BuyerCookie
    {

        private System.Xml.XmlNode[] anyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class SupplierSetup
    {

        private URL uRLField;

        /// <remarks/>
        public URL URL
        {
            get
            {
                return this.uRLField;
            }
            set
            {
                this.uRLField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class SelectedItem
    {

        private ItemID itemIDField;

        /// <remarks/>
        public ItemID ItemID
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum PunchOutSetupRequestOperation
    {

        /// <remarks/>
        create,

        /// <remarks/>
        inspect,

        /// <remarks/>
        edit,

        /// <remarks/>
        source,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class PunchOutSetupResponse
    {

        private StartPage startPageField;

        /// <remarks/>
        public StartPage StartPage
        {
            get
            {
                return this.startPageField;
            }
            set
            {
                this.startPageField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class PunchOutOrderMessage
    {

        private BuyerCookie buyerCookieField;

        private PunchOutOrderMessageHeader punchOutOrderMessageHeaderField;

        private ItemIn[] itemInField;

        /// <remarks/>
        public BuyerCookie BuyerCookie
        {
            get
            {
                return this.buyerCookieField;
            }
            set
            {
                this.buyerCookieField = value;
            }
        }

        /// <remarks/>
        public PunchOutOrderMessageHeader PunchOutOrderMessageHeader
        {
            get
            {
                return this.punchOutOrderMessageHeaderField;
            }
            set
            {
                this.punchOutOrderMessageHeaderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemIn")]
        public ItemIn[] ItemIn
        {
            get
            {
                return this.itemInField;
            }
            set
            {
                this.itemInField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class PunchOutOrderMessageHeader
    {

        private SourcingStatus sourcingStatusField;

        private Total totalField;

        private ShipTo shipToField;

        private Shipping shippingField;

        private Tax taxField;

        private SupplierOrderInfo supplierOrderInfoField;

        private PunchOutOrderMessageHeaderOperationAllowed operationAllowedField;

        private PunchOutOrderMessageHeaderQuoteStatus quoteStatusField;

        public PunchOutOrderMessageHeader()
        {
            this.quoteStatusField = PunchOutOrderMessageHeaderQuoteStatus.final;
        }

        /// <remarks/>
        public SourcingStatus SourcingStatus
        {
            get
            {
                return this.sourcingStatusField;
            }
            set
            {
                this.sourcingStatusField = value;
            }
        }

        /// <remarks/>
        public Total Total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        public ShipTo ShipTo
        {
            get
            {
                return this.shipToField;
            }
            set
            {
                this.shipToField = value;
            }
        }

        /// <remarks/>
        public Shipping Shipping
        {
            get
            {
                return this.shippingField;
            }
            set
            {
                this.shippingField = value;
            }
        }

        /// <remarks/>
        public Tax Tax
        {
            get
            {
                return this.taxField;
            }
            set
            {
                this.taxField = value;
            }
        }

        /// <remarks/>
        public SupplierOrderInfo SupplierOrderInfo
        {
            get
            {
                return this.supplierOrderInfoField;
            }
            set
            {
                this.supplierOrderInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public PunchOutOrderMessageHeaderOperationAllowed operationAllowed
        {
            get
            {
                return this.operationAllowedField;
            }
            set
            {
                this.operationAllowedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(PunchOutOrderMessageHeaderQuoteStatus.final)]
        public PunchOutOrderMessageHeaderQuoteStatus quoteStatus
        {
            get
            {
                return this.quoteStatusField;
            }
            set
            {
                this.quoteStatusField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class SourcingStatus
    {

        private SourcingStatusAction actionField;

        private bool actionFieldSpecified;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public SourcingStatusAction action
        {
            get
            {
                return this.actionField;
            }
            set
            {
                this.actionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool actionSpecified
        {
            get
            {
                return this.actionFieldSpecified;
            }
            set
            {
                this.actionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum SourcingStatusAction
    {

        /// <remarks/>
        approve,

        /// <remarks/>
        cancel,

        /// <remarks/>
        deny,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum PunchOutOrderMessageHeaderOperationAllowed
    {

        /// <remarks/>
        create,

        /// <remarks/>
        inspect,

        /// <remarks/>
        edit,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum PunchOutOrderMessageHeaderQuoteStatus
    {

        /// <remarks/>
        pending,

        /// <remarks/>
        final,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class StatusUpdateRequest
    {

        private DocumentReference documentReferenceField;

        private Status statusField;

        private object itemField;

        private Extrinsic[] extrinsicField;

        /// <remarks/>
        public DocumentReference DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
            }
        }

        /// <remarks/>
        public Status Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentStatus", typeof(DocumentStatus))]
        [System.Xml.Serialization.XmlElementAttribute("IntegrationStatus", typeof(IntegrationStatus))]
        [System.Xml.Serialization.XmlElementAttribute("InvoiceStatus", typeof(InvoiceStatus))]
        [System.Xml.Serialization.XmlElementAttribute("PaymentStatus", typeof(PaymentStatus))]
        [System.Xml.Serialization.XmlElementAttribute("SourcingStatus", typeof(SourcingStatus))]
        public object Item
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
        [System.Xml.Serialization.XmlElementAttribute("Extrinsic")]
        public Extrinsic[] Extrinsic
        {
            get
            {
                return this.extrinsicField;
            }
            set
            {
                this.extrinsicField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Status
    {

        private string codeField;

        private string textField;

        private string langField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string text
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
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class DocumentStatus
    {

        private DocumentInfo documentInfoField;

        private ItemStatus[] itemStatusField;

        private Comments[] commentsField;

        private string typeField;

        /// <remarks/>
        public DocumentInfo DocumentInfo
        {
            get
            {
                return this.documentInfoField;
            }
            set
            {
                this.documentInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemStatus")]
        public ItemStatus[] ItemStatus
        {
            get
            {
                return this.itemStatusField;
            }
            set
            {
                this.itemStatusField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Comments")]
        public Comments[] Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ItemStatus
    {

        private ReferenceDocumentInfo referenceDocumentInfoField;

        private Comments[] commentsField;

        private string typeField;

        private string codeField;

        private string parentLineNumberField;

        /// <remarks/>
        public ReferenceDocumentInfo ReferenceDocumentInfo
        {
            get
            {
                return this.referenceDocumentInfoField;
            }
            set
            {
                this.referenceDocumentInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Comments")]
        public Comments[] Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string code
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string parentLineNumber
        {
            get
            {
                return this.parentLineNumberField;
            }
            set
            {
                this.parentLineNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class IntegrationStatus
    {

        private IntegrationMessage integrationMessageField;

        private IntegrationStatusDocumentStatus documentStatusField;

        /// <remarks/>
        public IntegrationMessage IntegrationMessage
        {
            get
            {
                return this.integrationMessageField;
            }
            set
            {
                this.integrationMessageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public IntegrationStatusDocumentStatus documentStatus
        {
            get
            {
                return this.documentStatusField;
            }
            set
            {
                this.documentStatusField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class IntegrationMessage
    {

        private IntegrationMessageIsSuccessful isSuccessfulField;

        private string typeField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public IntegrationMessageIsSuccessful isSuccessful
        {
            get
            {
                return this.isSuccessfulField;
            }
            set
            {
                this.isSuccessfulField = value;
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

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum IntegrationMessageIsSuccessful
    {

        /// <remarks/>
        yes,

        /// <remarks/>
        no,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum IntegrationStatusDocumentStatus
    {

        /// <remarks/>
        deliverySuccessful,

        /// <remarks/>
        deliveryDelayed,

        /// <remarks/>
        deliveryFailed,

        /// <remarks/>
        deliveryReady,

        /// <remarks/>
        customerConfirmed,

        /// <remarks/>
        customerReceived,

        /// <remarks/>
        customerFailed,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class cXMLAttachment
    {

        private Attachment attachmentField;

        /// <remarks/>
        public Attachment Attachment
        {
            get
            {
                return this.attachmentField;
            }
            set
            {
                this.attachmentField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class CopyRequest
    {

        private object itemField;

        private CopyRequestProcessingMode processingModeField;

        private bool processingModeFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("cXML", typeof(cXML))]
        [System.Xml.Serialization.XmlElementAttribute("cXMLAttachment", typeof(cXMLAttachment))]
        public object Item
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public CopyRequestProcessingMode processingMode
        {
            get
            {
                return this.processingModeField;
            }
            set
            {
                this.processingModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool processingModeSpecified
        {
            get
            {
                return this.processingModeFieldSpecified;
            }
            set
            {
                this.processingModeFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class cXML
    {

        private object[] itemsField;

        private Signature[] signatureField;

        private string versionField;

        private string payloadIDField;

        private string timestampField;

        private cXMLSignatureVersion signatureVersionField;

        private bool signatureVersionFieldSpecified;

        private string langField;

        public cXML()
        {
            this.versionField = "1.2.035";
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Header", typeof(Header))]
        [System.Xml.Serialization.XmlElementAttribute("Message", typeof(Message))]
        [System.Xml.Serialization.XmlElementAttribute("Request", typeof(Request))]
        [System.Xml.Serialization.XmlElementAttribute("Response", typeof(Response))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Signature", Namespace = "uri:ds")]
        public Signature[] Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("1.2.035")]
        public string version
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string payloadID
        {
            get
            {
                return this.payloadIDField;
            }
            set
            {
                this.payloadIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string timestamp
        {
            get
            {
                return this.timestampField;
            }
            set
            {
                this.timestampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public cXMLSignatureVersion signatureVersion
        {
            get
            {
                return this.signatureVersionField;
            }
            set
            {
                this.signatureVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool signatureVersionSpecified
        {
            get
            {
                return this.signatureVersionFieldSpecified;
            }
            set
            {
                this.signatureVersionFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this.langField;
            }
            set
            {
                this.langField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Header
    {

        private From fromField;

        private To toField;

        private Sender senderField;

        private Node[] pathField;

        private OriginalDocument originalDocumentField;

        /// <remarks/>
        public From From
        {
            get
            {
                return this.fromField;
            }
            set
            {
                this.fromField = value;
            }
        }

        /// <remarks/>
        public To To
        {
            get
            {
                return this.toField;
            }
            set
            {
                this.toField = value;
            }
        }

        /// <remarks/>
        public Sender Sender
        {
            get
            {
                return this.senderField;
            }
            set
            {
                this.senderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Node", IsNullable = false)]
        public Node[] Path
        {
            get
            {
                return this.pathField;
            }
            set
            {
                this.pathField = value;
            }
        }

        /// <remarks/>
        public OriginalDocument OriginalDocument
        {
            get
            {
                return this.originalDocumentField;
            }
            set
            {
                this.originalDocumentField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class From
    {

        private Credential[] credentialField;

        private Correspondent correspondentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Credential")]
        public Credential[] Credential
        {
            get
            {
                return this.credentialField;
            }
            set
            {
                this.credentialField = value;
            }
        }

        /// <remarks/>
        public Correspondent Correspondent
        {
            get
            {
                return this.correspondentField;
            }
            set
            {
                this.correspondentField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Correspondent
    {

        private Contact[] contactField;

        private Extrinsic[] extrinsicField;

        private string preferredLanguageField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Contact")]
        public Contact[] Contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Extrinsic")]
        public Extrinsic[] Extrinsic
        {
            get
            {
                return this.extrinsicField;
            }
            set
            {
                this.extrinsicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string preferredLanguage
        {
            get
            {
                return this.preferredLanguageField;
            }
            set
            {
                this.preferredLanguageField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class To
    {

        private Credential[] credentialField;

        private Correspondent correspondentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Credential")]
        public Credential[] Credential
        {
            get
            {
                return this.credentialField;
            }
            set
            {
                this.credentialField = value;
            }
        }

        /// <remarks/>
        public Correspondent Correspondent
        {
            get
            {
                return this.correspondentField;
            }
            set
            {
                this.correspondentField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Sender
    {

        private Credential[] credentialField;

        private string userAgentField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Credential")]
        public Credential[] Credential
        {
            get
            {
                return this.credentialField;
            }
            set
            {
                this.credentialField = value;
            }
        }

        /// <remarks/>
        public string UserAgent
        {
            get
            {
                return this.userAgentField;
            }
            set
            {
                this.userAgentField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class OriginalDocument
    {

        private string payloadIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string payloadID
        {
            get
            {
                return this.payloadIDField;
            }
            set
            {
                this.payloadIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Message
    {

        private Status statusField;

        private ProviderDoneMessage providerDoneMessageField;

        private MessageDeploymentMode deploymentModeField;

        private string inReplyToField;

        private string idField;

        public Message()
        {
            this.deploymentModeField = MessageDeploymentMode.production;
        }

        /// <remarks/>
        public Status Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public ProviderDoneMessage ProviderDoneMessage
        {
            get
            {
                return this.providerDoneMessageField;
            }
            set
            {
                this.providerDoneMessageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(MessageDeploymentMode.production)]
        public MessageDeploymentMode deploymentMode
        {
            get
            {
                return this.deploymentModeField;
            }
            set
            {
                this.deploymentModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inReplyTo
        {
            get
            {
                return this.inReplyToField;
            }
            set
            {
                this.inReplyToField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ProviderDoneMessage
    {

        private string originatorCookieField;

        private ReturnData[] returnDataField;

        /// <remarks/>
        public string OriginatorCookie
        {
            get
            {
                return this.originatorCookieField;
            }
            set
            {
                this.originatorCookieField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReturnData")]
        public ReturnData[] ReturnData
        {
            get
            {
                return this.returnDataField;
            }
            set
            {
                this.returnDataField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum MessageDeploymentMode
    {

        /// <remarks/>
        production,

        /// <remarks/>
        test,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Request
    {

        private object itemField;

        private RequestDeploymentMode deploymentModeField;

        private string idField;

        public Request()
        {
            this.deploymentModeField = RequestDeploymentMode.production;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InvoiceDetailRequest", typeof(InvoiceDetailRequest))]
        [System.Xml.Serialization.XmlElementAttribute("ProviderSetupRequest", typeof(ProviderSetupRequest))]
        public object Item
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(RequestDeploymentMode.production)]
        public RequestDeploymentMode deploymentMode
        {
            get
            {
                return this.deploymentModeField;
            }
            set
            {
                this.deploymentModeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceDetailRequest
    {

        private InvoiceDetailRequestHeader invoiceDetailRequestHeaderField;

        private object[] itemsField;

        private InvoiceDetailSummary invoiceDetailSummaryField;

        /// <remarks/>
        public InvoiceDetailRequestHeader InvoiceDetailRequestHeader
        {
            get
            {
                return this.invoiceDetailRequestHeaderField;
            }
            set
            {
                this.invoiceDetailRequestHeaderField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InvoiceDetailHeaderOrder", typeof(InvoiceDetailHeaderOrder))]
        [System.Xml.Serialization.XmlElementAttribute("InvoiceDetailOrder", typeof(InvoiceDetailOrder))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        public InvoiceDetailSummary InvoiceDetailSummary
        {
            get
            {
                return this.invoiceDetailSummaryField;
            }
            set
            {
                this.invoiceDetailSummaryField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceDetailRequestHeader
    {

        private InvoiceDetailHeaderIndicator invoiceDetailHeaderIndicatorField;

        private InvoiceDetailLineIndicator invoiceDetailLineIndicatorField;

        private InvoicePartner[] invoicePartnerField;

        private DocumentReference documentReferenceField;

        private InvoiceIDInfo invoiceIDInfoField;

        private PaymentProposalIDInfo paymentProposalIDInfoField;

        private InvoiceDetailShipping invoiceDetailShippingField;

        private ShipNoticeIDInfo shipNoticeIDInfoField;

        private object[] itemsField;

        private Period periodField;

        private Comments commentsField;

        private IdReference[] idReferenceField;

        private Extrinsic[] extrinsicField;

        private string invoiceIDField;

        private InvoiceDetailRequestHeaderIsInformationOnly isInformationOnlyField;

        private bool isInformationOnlyFieldSpecified;

        private InvoiceDetailRequestHeaderPurpose purposeField;

        private InvoiceDetailRequestHeaderOperation operationField;

        private string invoiceDateField;

        private InvoiceDetailRequestHeaderInvoiceOrigin invoiceOriginField;

        private bool invoiceOriginFieldSpecified;

        private InvoiceDetailRequestHeaderIsERS isERSField;

        private bool isERSFieldSpecified;

        public InvoiceDetailRequestHeader()
        {
            this.purposeField = InvoiceDetailRequestHeaderPurpose.standard;
            this.operationField = InvoiceDetailRequestHeaderOperation.@new;
        }

        /// <remarks/>
        public InvoiceDetailHeaderIndicator InvoiceDetailHeaderIndicator
        {
            get
            {
                return this.invoiceDetailHeaderIndicatorField;
            }
            set
            {
                this.invoiceDetailHeaderIndicatorField = value;
            }
        }

        /// <remarks/>
        public InvoiceDetailLineIndicator InvoiceDetailLineIndicator
        {
            get
            {
                return this.invoiceDetailLineIndicatorField;
            }
            set
            {
                this.invoiceDetailLineIndicatorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InvoicePartner")]
        public InvoicePartner[] InvoicePartner
        {
            get
            {
                return this.invoicePartnerField;
            }
            set
            {
                this.invoicePartnerField = value;
            }
        }

        /// <remarks/>
        public DocumentReference DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
            }
        }

        /// <remarks/>
        public InvoiceIDInfo InvoiceIDInfo
        {
            get
            {
                return this.invoiceIDInfoField;
            }
            set
            {
                this.invoiceIDInfoField = value;
            }
        }

        /// <remarks/>
        public PaymentProposalIDInfo PaymentProposalIDInfo
        {
            get
            {
                return this.paymentProposalIDInfoField;
            }
            set
            {
                this.paymentProposalIDInfoField = value;
            }
        }

        /// <remarks/>
        public InvoiceDetailShipping InvoiceDetailShipping
        {
            get
            {
                return this.invoiceDetailShippingField;
            }
            set
            {
                this.invoiceDetailShippingField = value;
            }
        }

        /// <remarks/>
        public ShipNoticeIDInfo ShipNoticeIDInfo
        {
            get
            {
                return this.shipNoticeIDInfoField;
            }
            set
            {
                this.shipNoticeIDInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InvoiceDetailPaymentTerm", typeof(InvoiceDetailPaymentTerm))]
        [System.Xml.Serialization.XmlElementAttribute("PaymentTerm", typeof(PaymentTerm))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        public Period Period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }

        /// <remarks/>
        public Comments Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IdReference")]
        public IdReference[] IdReference
        {
            get
            {
                return this.idReferenceField;
            }
            set
            {
                this.idReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Extrinsic")]
        public Extrinsic[] Extrinsic
        {
            get
            {
                return this.extrinsicField;
            }
            set
            {
                this.extrinsicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string invoiceID
        {
            get
            {
                return this.invoiceIDField;
            }
            set
            {
                this.invoiceIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public InvoiceDetailRequestHeaderIsInformationOnly isInformationOnly
        {
            get
            {
                return this.isInformationOnlyField;
            }
            set
            {
                this.isInformationOnlyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isInformationOnlySpecified
        {
            get
            {
                return this.isInformationOnlyFieldSpecified;
            }
            set
            {
                this.isInformationOnlyFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(InvoiceDetailRequestHeaderPurpose.standard)]
        public InvoiceDetailRequestHeaderPurpose purpose
        {
            get
            {
                return this.purposeField;
            }
            set
            {
                this.purposeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(InvoiceDetailRequestHeaderOperation.@new)]
        public InvoiceDetailRequestHeaderOperation operation
        {
            get
            {
                return this.operationField;
            }
            set
            {
                this.operationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string invoiceDate
        {
            get
            {
                return this.invoiceDateField;
            }
            set
            {
                this.invoiceDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public InvoiceDetailRequestHeaderInvoiceOrigin invoiceOrigin
        {
            get
            {
                return this.invoiceOriginField;
            }
            set
            {
                this.invoiceOriginField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool invoiceOriginSpecified
        {
            get
            {
                return this.invoiceOriginFieldSpecified;
            }
            set
            {
                this.invoiceOriginFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public InvoiceDetailRequestHeaderIsERS isERS
        {
            get
            {
                return this.isERSField;
            }
            set
            {
                this.isERSField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isERSSpecified
        {
            get
            {
                return this.isERSFieldSpecified;
            }
            set
            {
                this.isERSFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceDetailHeaderIndicator
    {

        private InvoiceDetailHeaderIndicatorIsHeaderInvoice isHeaderInvoiceField;

        private bool isHeaderInvoiceFieldSpecified;

        private InvoiceDetailHeaderIndicatorIsVatRecoverable isVatRecoverableField;

        private bool isVatRecoverableFieldSpecified;

        private InvoiceDetailHeaderIndicatorIsPriceBasedLineLevelCreditMemo isPriceBasedLineLevelCreditMemoField;

        private bool isPriceBasedLineLevelCreditMemoFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public InvoiceDetailHeaderIndicatorIsHeaderInvoice isHeaderInvoice
        {
            get
            {
                return this.isHeaderInvoiceField;
            }
            set
            {
                this.isHeaderInvoiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isHeaderInvoiceSpecified
        {
            get
            {
                return this.isHeaderInvoiceFieldSpecified;
            }
            set
            {
                this.isHeaderInvoiceFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public InvoiceDetailHeaderIndicatorIsVatRecoverable isVatRecoverable
        {
            get
            {
                return this.isVatRecoverableField;
            }
            set
            {
                this.isVatRecoverableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isVatRecoverableSpecified
        {
            get
            {
                return this.isVatRecoverableFieldSpecified;
            }
            set
            {
                this.isVatRecoverableFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public InvoiceDetailHeaderIndicatorIsPriceBasedLineLevelCreditMemo isPriceBasedLineLevelCreditMemo
        {
            get
            {
                return this.isPriceBasedLineLevelCreditMemoField;
            }
            set
            {
                this.isPriceBasedLineLevelCreditMemoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPriceBasedLineLevelCreditMemoSpecified
        {
            get
            {
                return this.isPriceBasedLineLevelCreditMemoFieldSpecified;
            }
            set
            {
                this.isPriceBasedLineLevelCreditMemoFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum InvoiceDetailHeaderIndicatorIsHeaderInvoice
    {

        /// <remarks/>
        yes,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum InvoiceDetailHeaderIndicatorIsVatRecoverable
    {

        /// <remarks/>
        yes,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum InvoiceDetailHeaderIndicatorIsPriceBasedLineLevelCreditMemo
    {

        /// <remarks/>
        yes,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceDetailLineIndicator
    {

        private InvoiceDetailLineIndicatorIsTaxInLine isTaxInLineField;

        private bool isTaxInLineFieldSpecified;

        private InvoiceDetailLineIndicatorIsSpecialHandlingInLine isSpecialHandlingInLineField;

        private bool isSpecialHandlingInLineFieldSpecified;

        private InvoiceDetailLineIndicatorIsShippingInLine isShippingInLineField;

        private bool isShippingInLineFieldSpecified;

        private InvoiceDetailLineIndicatorIsDiscountInLine isDiscountInLineField;

        private bool isDiscountInLineFieldSpecified;

        private InvoiceDetailLineIndicatorIsAccountingInLine isAccountingInLineField;

        private bool isAccountingInLineFieldSpecified;

        private InvoiceDetailLineIndicatorIsPriceAdjustmentInLine isPriceAdjustmentInLineField;

        private bool isPriceAdjustmentInLineFieldSpecified;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public InvoiceDetailLineIndicatorIsTaxInLine isTaxInLine
        {
            get
            {
                return this.isTaxInLineField;
            }
            set
            {
                this.isTaxInLineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isTaxInLineSpecified
        {
            get
            {
                return this.isTaxInLineFieldSpecified;
            }
            set
            {
                this.isTaxInLineFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public InvoiceDetailLineIndicatorIsSpecialHandlingInLine isSpecialHandlingInLine
        {
            get
            {
                return this.isSpecialHandlingInLineField;
            }
            set
            {
                this.isSpecialHandlingInLineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isSpecialHandlingInLineSpecified
        {
            get
            {
                return this.isSpecialHandlingInLineFieldSpecified;
            }
            set
            {
                this.isSpecialHandlingInLineFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public InvoiceDetailLineIndicatorIsShippingInLine isShippingInLine
        {
            get
            {
                return this.isShippingInLineField;
            }
            set
            {
                this.isShippingInLineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isShippingInLineSpecified
        {
            get
            {
                return this.isShippingInLineFieldSpecified;
            }
            set
            {
                this.isShippingInLineFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public InvoiceDetailLineIndicatorIsDiscountInLine isDiscountInLine
        {
            get
            {
                return this.isDiscountInLineField;
            }
            set
            {
                this.isDiscountInLineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isDiscountInLineSpecified
        {
            get
            {
                return this.isDiscountInLineFieldSpecified;
            }
            set
            {
                this.isDiscountInLineFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public InvoiceDetailLineIndicatorIsAccountingInLine isAccountingInLine
        {
            get
            {
                return this.isAccountingInLineField;
            }
            set
            {
                this.isAccountingInLineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAccountingInLineSpecified
        {
            get
            {
                return this.isAccountingInLineFieldSpecified;
            }
            set
            {
                this.isAccountingInLineFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public InvoiceDetailLineIndicatorIsPriceAdjustmentInLine isPriceAdjustmentInLine
        {
            get
            {
                return this.isPriceAdjustmentInLineField;
            }
            set
            {
                this.isPriceAdjustmentInLineField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isPriceAdjustmentInLineSpecified
        {
            get
            {
                return this.isPriceAdjustmentInLineFieldSpecified;
            }
            set
            {
                this.isPriceAdjustmentInLineFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum InvoiceDetailLineIndicatorIsTaxInLine
    {

        /// <remarks/>
        yes,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum InvoiceDetailLineIndicatorIsSpecialHandlingInLine
    {

        /// <remarks/>
        yes,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum InvoiceDetailLineIndicatorIsShippingInLine
    {

        /// <remarks/>
        yes,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum InvoiceDetailLineIndicatorIsDiscountInLine
    {

        /// <remarks/>
        yes,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum InvoiceDetailLineIndicatorIsAccountingInLine
    {

        /// <remarks/>
        yes,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum InvoiceDetailLineIndicatorIsPriceAdjustmentInLine
    {

        /// <remarks/>
        yes,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoicePartner
    {

        private Contact contactField;

        private IdReference[] idReferenceField;

        /// <remarks/>
        public Contact Contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IdReference")]
        public IdReference[] IdReference
        {
            get
            {
                return this.idReferenceField;
            }
            set
            {
                this.idReferenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class PaymentProposalIDInfo
    {

        private string paymentProposalIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string paymentProposalID
        {
            get
            {
                return this.paymentProposalIDField;
            }
            set
            {
                this.paymentProposalIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceDetailShipping
    {

        private Contact contactField;

        private Contact[] contact1Field;

        private CarrierIdentifier[] carrierIdentifierField;

        private ShipmentIdentifier[] shipmentIdentifierField;

        private DocumentReference documentReferenceField;

        private string shippingDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 0)]
        public Contact Contact
        {
            get
            {
                return this.contactField;
            }
            set
            {
                this.contactField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Contact", Order = 1)]
        public Contact[] Contact1
        {
            get
            {
                return this.contact1Field;
            }
            set
            {
                this.contact1Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CarrierIdentifier", Order = 2)]
        public CarrierIdentifier[] CarrierIdentifier
        {
            get
            {
                return this.carrierIdentifierField;
            }
            set
            {
                this.carrierIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShipmentIdentifier", Order = 3)]
        public ShipmentIdentifier[] ShipmentIdentifier
        {
            get
            {
                return this.shipmentIdentifierField;
            }
            set
            {
                this.shipmentIdentifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order = 4)]
        public DocumentReference DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string shippingDate
        {
            get
            {
                return this.shippingDateField;
            }
            set
            {
                this.shippingDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ShipmentIdentifier
    {

        private string domainField;

        private string trackingNumberDateField;

        private string trackingURLField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string domain
        {
            get
            {
                return this.domainField;
            }
            set
            {
                this.domainField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string trackingNumberDate
        {
            get
            {
                return this.trackingNumberDateField;
            }
            set
            {
                this.trackingNumberDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string trackingURL
        {
            get
            {
                return this.trackingURLField;
            }
            set
            {
                this.trackingURLField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceDetailPaymentTerm
    {

        private string payInNumberOfDaysField;

        private string percentageRateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string payInNumberOfDays
        {
            get
            {
                return this.payInNumberOfDaysField;
            }
            set
            {
                this.payInNumberOfDaysField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string percentageRate
        {
            get
            {
                return this.percentageRateField;
            }
            set
            {
                this.percentageRateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum InvoiceDetailRequestHeaderIsInformationOnly
    {

        /// <remarks/>
        yes,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum InvoiceDetailRequestHeaderPurpose
    {

        /// <remarks/>
        standard,

        /// <remarks/>
        creditMemo,

        /// <remarks/>
        debitMemo,

        /// <remarks/>
        lineLevelCreditMemo,

        /// <remarks/>
        lineLevelDebitMemo,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum InvoiceDetailRequestHeaderOperation
    {

        /// <remarks/>
        @new,

        /// <remarks/>
        delete,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum InvoiceDetailRequestHeaderInvoiceOrigin
    {

        /// <remarks/>
        supplier,

        /// <remarks/>
        buyer,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum InvoiceDetailRequestHeaderIsERS
    {

        /// <remarks/>
        yes,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceDetailHeaderOrder
    {

        private InvoiceDetailOrderInfo invoiceDetailOrderInfoField;

        private InvoiceDetailOrderSummary invoiceDetailOrderSummaryField;

        /// <remarks/>
        public InvoiceDetailOrderInfo InvoiceDetailOrderInfo
        {
            get
            {
                return this.invoiceDetailOrderInfoField;
            }
            set
            {
                this.invoiceDetailOrderInfoField = value;
            }
        }

        /// <remarks/>
        public InvoiceDetailOrderSummary InvoiceDetailOrderSummary
        {
            get
            {
                return this.invoiceDetailOrderSummaryField;
            }
            set
            {
                this.invoiceDetailOrderSummaryField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceDetailOrderInfo
    {

        private object[] itemsField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MasterAgreementIDInfo", typeof(MasterAgreementIDInfo))]
        [System.Xml.Serialization.XmlElementAttribute("MasterAgreementReference", typeof(MasterAgreementReference))]
        [System.Xml.Serialization.XmlElementAttribute("OrderIDInfo", typeof(OrderIDInfo))]
        [System.Xml.Serialization.XmlElementAttribute("OrderReference", typeof(OrderReference))]
        [System.Xml.Serialization.XmlElementAttribute("SupplierOrderInfo", typeof(SupplierOrderInfo))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class OrderIDInfo
    {

        private IdReference[] idReferenceField;

        private string orderIDField;

        private string orderDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IdReference")]
        public IdReference[] IdReference
        {
            get
            {
                return this.idReferenceField;
            }
            set
            {
                this.idReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderID
        {
            get
            {
                return this.orderIDField;
            }
            set
            {
                this.orderIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderDate
        {
            get
            {
                return this.orderDateField;
            }
            set
            {
                this.orderDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class OrderReference
    {

        private DocumentReference documentReferenceField;

        private string orderIDField;

        private string orderDateField;

        /// <remarks/>
        public DocumentReference DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderID
        {
            get
            {
                return this.orderIDField;
            }
            set
            {
                this.orderIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderDate
        {
            get
            {
                return this.orderDateField;
            }
            set
            {
                this.orderDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceDetailOrderSummary
    {

        private SubtotalAmount subtotalAmountField;

        private Period periodField;

        private Tax taxField;

        private InvoiceDetailLineSpecialHandling invoiceDetailLineSpecialHandlingField;

        private InvoiceDetailLineShipping invoiceDetailLineShippingField;

        private GrossAmount grossAmountField;

        private InvoiceDetailDiscount invoiceDetailDiscountField;

        private NetAmount netAmountField;

        private Comments commentsField;

        private Extrinsic[] extrinsicField;

        private string invoiceLineNumberField;

        private string inspectionDateField;

        /// <remarks/>
        public SubtotalAmount SubtotalAmount
        {
            get
            {
                return this.subtotalAmountField;
            }
            set
            {
                this.subtotalAmountField = value;
            }
        }

        /// <remarks/>
        public Period Period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }

        /// <remarks/>
        public Tax Tax
        {
            get
            {
                return this.taxField;
            }
            set
            {
                this.taxField = value;
            }
        }

        /// <remarks/>
        public InvoiceDetailLineSpecialHandling InvoiceDetailLineSpecialHandling
        {
            get
            {
                return this.invoiceDetailLineSpecialHandlingField;
            }
            set
            {
                this.invoiceDetailLineSpecialHandlingField = value;
            }
        }

        /// <remarks/>
        public InvoiceDetailLineShipping InvoiceDetailLineShipping
        {
            get
            {
                return this.invoiceDetailLineShippingField;
            }
            set
            {
                this.invoiceDetailLineShippingField = value;
            }
        }

        /// <remarks/>
        public GrossAmount GrossAmount
        {
            get
            {
                return this.grossAmountField;
            }
            set
            {
                this.grossAmountField = value;
            }
        }

        /// <remarks/>
        public InvoiceDetailDiscount InvoiceDetailDiscount
        {
            get
            {
                return this.invoiceDetailDiscountField;
            }
            set
            {
                this.invoiceDetailDiscountField = value;
            }
        }

        /// <remarks/>
        public NetAmount NetAmount
        {
            get
            {
                return this.netAmountField;
            }
            set
            {
                this.netAmountField = value;
            }
        }

        /// <remarks/>
        public Comments Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Extrinsic")]
        public Extrinsic[] Extrinsic
        {
            get
            {
                return this.extrinsicField;
            }
            set
            {
                this.extrinsicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string invoiceLineNumber
        {
            get
            {
                return this.invoiceLineNumberField;
            }
            set
            {
                this.invoiceLineNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inspectionDate
        {
            get
            {
                return this.inspectionDateField;
            }
            set
            {
                this.inspectionDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class SubtotalAmount
    {

        private Money moneyField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceDetailLineSpecialHandling
    {

        private Description descriptionField;

        private Money moneyField;

        private Distribution[] distributionField;

        /// <remarks/>
        public Description Description
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
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Distribution")]
        public Distribution[] Distribution
        {
            get
            {
                return this.distributionField;
            }
            set
            {
                this.distributionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceDetailLineShipping
    {

        private InvoiceDetailShipping invoiceDetailShippingField;

        private Money moneyField;

        private Distribution[] distributionField;

        /// <remarks/>
        public InvoiceDetailShipping InvoiceDetailShipping
        {
            get
            {
                return this.invoiceDetailShippingField;
            }
            set
            {
                this.invoiceDetailShippingField = value;
            }
        }

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Distribution")]
        public Distribution[] Distribution
        {
            get
            {
                return this.distributionField;
            }
            set
            {
                this.distributionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class GrossAmount
    {

        private Money moneyField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceDetailDiscount
    {

        private Money moneyField;

        private Distribution[] distributionField;

        private string percentageRateField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Distribution")]
        public Distribution[] Distribution
        {
            get
            {
                return this.distributionField;
            }
            set
            {
                this.distributionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string percentageRate
        {
            get
            {
                return this.percentageRateField;
            }
            set
            {
                this.percentageRateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class NetAmount
    {

        private Money moneyField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceDetailOrder
    {

        private InvoiceDetailOrderInfo invoiceDetailOrderInfoField;

        private InvoiceDetailReceiptInfo invoiceDetailReceiptInfoField;

        private InvoiceDetailShipNoticeInfo invoiceDetailShipNoticeInfoField;

        private object[] itemsField;

        /// <remarks/>
        public InvoiceDetailOrderInfo InvoiceDetailOrderInfo
        {
            get
            {
                return this.invoiceDetailOrderInfoField;
            }
            set
            {
                this.invoiceDetailOrderInfoField = value;
            }
        }

        /// <remarks/>
        public InvoiceDetailReceiptInfo InvoiceDetailReceiptInfo
        {
            get
            {
                return this.invoiceDetailReceiptInfoField;
            }
            set
            {
                this.invoiceDetailReceiptInfoField = value;
            }
        }

        /// <remarks/>
        public InvoiceDetailShipNoticeInfo InvoiceDetailShipNoticeInfo
        {
            get
            {
                return this.invoiceDetailShipNoticeInfoField;
            }
            set
            {
                this.invoiceDetailShipNoticeInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("InvoiceDetailItem", typeof(InvoiceDetailItem))]
        [System.Xml.Serialization.XmlElementAttribute("InvoiceDetailServiceItem", typeof(InvoiceDetailServiceItem))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceDetailReceiptInfo
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReceiptIDInfo", typeof(ReceiptIDInfo))]
        [System.Xml.Serialization.XmlElementAttribute("ReceiptReference", typeof(ReceiptReference))]
        public object Item
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ReceiptIDInfo
    {

        private IdReference[] idReferenceField;

        private string receiptIDField;

        private string receiptDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IdReference")]
        public IdReference[] IdReference
        {
            get
            {
                return this.idReferenceField;
            }
            set
            {
                this.idReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string receiptID
        {
            get
            {
                return this.receiptIDField;
            }
            set
            {
                this.receiptIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string receiptDate
        {
            get
            {
                return this.receiptDateField;
            }
            set
            {
                this.receiptDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ReceiptReference
    {

        private DocumentReference documentReferenceField;

        private string receiptIDField;

        private string receiptDateField;

        /// <remarks/>
        public DocumentReference DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string receiptID
        {
            get
            {
                return this.receiptIDField;
            }
            set
            {
                this.receiptIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string receiptDate
        {
            get
            {
                return this.receiptDateField;
            }
            set
            {
                this.receiptDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceDetailShipNoticeInfo
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ShipNoticeIDInfo", typeof(ShipNoticeIDInfo))]
        [System.Xml.Serialization.XmlElementAttribute("ShipNoticeReference", typeof(ShipNoticeReference))]
        public object Item
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceDetailItem
    {

        private string unitOfMeasureField;

        private UnitPrice unitPriceField;

        private PriceBasisQuantity priceBasisQuantityField;

        private InvoiceDetailItemReference invoiceDetailItemReferenceField;

        private ReceiptLineItemReference receiptLineItemReferenceField;

        private ShipNoticeLineItemReference shipNoticeLineItemReferenceField;

        private object itemField;

        private ProductMovementItemIDInfo productMovementItemIDInfoField;

        private SubtotalAmount subtotalAmountField;

        private Tax taxField;

        private InvoiceDetailLineSpecialHandling invoiceDetailLineSpecialHandlingField;

        private InvoiceDetailLineShipping invoiceDetailLineShippingField;

        private ShipNoticeIDInfo shipNoticeIDInfoField;

        private GrossAmount grossAmountField;

        private InvoiceDetailDiscount invoiceDetailDiscountField;

        private Modification[] invoiceItemModificationsField;

        private TotalCharges totalChargesField;

        private TotalAllowances totalAllowancesField;

        private TotalAmountWithoutTax totalAmountWithoutTaxField;

        private NetAmount netAmountField;

        private Distribution[] distributionField;

        private Packaging[] packagingField;

        private InvoiceDetailItemIndustry invoiceDetailItemIndustryField;

        private Comments commentsField;

        private CustomsInfo customsInfoField;

        private Extrinsic[] extrinsicField;

        private string invoiceLineNumberField;

        private string quantityField;

        private string referenceDateField;

        private string inspectionDateField;

        private string parentInvoiceLineNumberField;

        private InvoiceDetailItemItemType itemTypeField;

        private bool itemTypeFieldSpecified;

        private InvoiceDetailItemCompositeItemType compositeItemTypeField;

        private bool compositeItemTypeFieldSpecified;

        private InvoiceDetailItemReason reasonField;

        private bool reasonFieldSpecified;

        private InvoiceDetailItemIsAdHoc isAdHocField;

        private bool isAdHocFieldSpecified;

        /// <remarks/>
        public string UnitOfMeasure
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
        public UnitPrice UnitPrice
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

        /// <remarks/>
        public PriceBasisQuantity PriceBasisQuantity
        {
            get
            {
                return this.priceBasisQuantityField;
            }
            set
            {
                this.priceBasisQuantityField = value;
            }
        }

        /// <remarks/>
        public InvoiceDetailItemReference InvoiceDetailItemReference
        {
            get
            {
                return this.invoiceDetailItemReferenceField;
            }
            set
            {
                this.invoiceDetailItemReferenceField = value;
            }
        }

        /// <remarks/>
        public ReceiptLineItemReference ReceiptLineItemReference
        {
            get
            {
                return this.receiptLineItemReferenceField;
            }
            set
            {
                this.receiptLineItemReferenceField = value;
            }
        }

        /// <remarks/>
        public ShipNoticeLineItemReference ShipNoticeLineItemReference
        {
            get
            {
                return this.shipNoticeLineItemReferenceField;
            }
            set
            {
                this.shipNoticeLineItemReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ServiceEntryItemIDInfo", typeof(ServiceEntryItemIDInfo))]
        [System.Xml.Serialization.XmlElementAttribute("ServiceEntryItemReference", typeof(ServiceEntryItemReference))]
        public object Item
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
        public ProductMovementItemIDInfo ProductMovementItemIDInfo
        {
            get
            {
                return this.productMovementItemIDInfoField;
            }
            set
            {
                this.productMovementItemIDInfoField = value;
            }
        }

        /// <remarks/>
        public SubtotalAmount SubtotalAmount
        {
            get
            {
                return this.subtotalAmountField;
            }
            set
            {
                this.subtotalAmountField = value;
            }
        }

        /// <remarks/>
        public Tax Tax
        {
            get
            {
                return this.taxField;
            }
            set
            {
                this.taxField = value;
            }
        }

        /// <remarks/>
        public InvoiceDetailLineSpecialHandling InvoiceDetailLineSpecialHandling
        {
            get
            {
                return this.invoiceDetailLineSpecialHandlingField;
            }
            set
            {
                this.invoiceDetailLineSpecialHandlingField = value;
            }
        }

        /// <remarks/>
        public InvoiceDetailLineShipping InvoiceDetailLineShipping
        {
            get
            {
                return this.invoiceDetailLineShippingField;
            }
            set
            {
                this.invoiceDetailLineShippingField = value;
            }
        }

        /// <remarks/>
        public ShipNoticeIDInfo ShipNoticeIDInfo
        {
            get
            {
                return this.shipNoticeIDInfoField;
            }
            set
            {
                this.shipNoticeIDInfoField = value;
            }
        }

        /// <remarks/>
        public GrossAmount GrossAmount
        {
            get
            {
                return this.grossAmountField;
            }
            set
            {
                this.grossAmountField = value;
            }
        }

        /// <remarks/>
        public InvoiceDetailDiscount InvoiceDetailDiscount
        {
            get
            {
                return this.invoiceDetailDiscountField;
            }
            set
            {
                this.invoiceDetailDiscountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Modification", IsNullable = false)]
        public Modification[] InvoiceItemModifications
        {
            get
            {
                return this.invoiceItemModificationsField;
            }
            set
            {
                this.invoiceItemModificationsField = value;
            }
        }

        /// <remarks/>
        public TotalCharges TotalCharges
        {
            get
            {
                return this.totalChargesField;
            }
            set
            {
                this.totalChargesField = value;
            }
        }

        /// <remarks/>
        public TotalAllowances TotalAllowances
        {
            get
            {
                return this.totalAllowancesField;
            }
            set
            {
                this.totalAllowancesField = value;
            }
        }

        /// <remarks/>
        public TotalAmountWithoutTax TotalAmountWithoutTax
        {
            get
            {
                return this.totalAmountWithoutTaxField;
            }
            set
            {
                this.totalAmountWithoutTaxField = value;
            }
        }

        /// <remarks/>
        public NetAmount NetAmount
        {
            get
            {
                return this.netAmountField;
            }
            set
            {
                this.netAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Distribution")]
        public Distribution[] Distribution
        {
            get
            {
                return this.distributionField;
            }
            set
            {
                this.distributionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Packaging")]
        public Packaging[] Packaging
        {
            get
            {
                return this.packagingField;
            }
            set
            {
                this.packagingField = value;
            }
        }

        /// <remarks/>
        public InvoiceDetailItemIndustry InvoiceDetailItemIndustry
        {
            get
            {
                return this.invoiceDetailItemIndustryField;
            }
            set
            {
                this.invoiceDetailItemIndustryField = value;
            }
        }

        /// <remarks/>
        public Comments Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        public CustomsInfo CustomsInfo
        {
            get
            {
                return this.customsInfoField;
            }
            set
            {
                this.customsInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Extrinsic")]
        public Extrinsic[] Extrinsic
        {
            get
            {
                return this.extrinsicField;
            }
            set
            {
                this.extrinsicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string invoiceLineNumber
        {
            get
            {
                return this.invoiceLineNumberField;
            }
            set
            {
                this.invoiceLineNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string quantity
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string referenceDate
        {
            get
            {
                return this.referenceDateField;
            }
            set
            {
                this.referenceDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inspectionDate
        {
            get
            {
                return this.inspectionDateField;
            }
            set
            {
                this.inspectionDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string parentInvoiceLineNumber
        {
            get
            {
                return this.parentInvoiceLineNumberField;
            }
            set
            {
                this.parentInvoiceLineNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public InvoiceDetailItemItemType itemType
        {
            get
            {
                return this.itemTypeField;
            }
            set
            {
                this.itemTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itemTypeSpecified
        {
            get
            {
                return this.itemTypeFieldSpecified;
            }
            set
            {
                this.itemTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public InvoiceDetailItemCompositeItemType compositeItemType
        {
            get
            {
                return this.compositeItemTypeField;
            }
            set
            {
                this.compositeItemTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool compositeItemTypeSpecified
        {
            get
            {
                return this.compositeItemTypeFieldSpecified;
            }
            set
            {
                this.compositeItemTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public InvoiceDetailItemReason reason
        {
            get
            {
                return this.reasonField;
            }
            set
            {
                this.reasonField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool reasonSpecified
        {
            get
            {
                return this.reasonFieldSpecified;
            }
            set
            {
                this.reasonFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public InvoiceDetailItemIsAdHoc isAdHoc
        {
            get
            {
                return this.isAdHocField;
            }
            set
            {
                this.isAdHocField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAdHocSpecified
        {
            get
            {
                return this.isAdHocFieldSpecified;
            }
            set
            {
                this.isAdHocFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceDetailItemReference
    {

        private ItemID itemIDField;

        private Description descriptionField;

        private Classification[] classificationField;

        private string manufacturerPartIDField;

        private ManufacturerName manufacturerNameField;

        private Country countryField;

        private string[] serialNumberField;

        private string supplierBatchIDField;

        private InvoiceDetailItemReferenceIndustry invoiceDetailItemReferenceIndustryField;

        private string lineNumberField;

        private string serialNumberField1;

        /// <remarks/>
        public ItemID ItemID
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

        /// <remarks/>
        public Description Description
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
        [System.Xml.Serialization.XmlElementAttribute("Classification")]
        public Classification[] Classification
        {
            get
            {
                return this.classificationField;
            }
            set
            {
                this.classificationField = value;
            }
        }

        /// <remarks/>
        public string ManufacturerPartID
        {
            get
            {
                return this.manufacturerPartIDField;
            }
            set
            {
                this.manufacturerPartIDField = value;
            }
        }

        /// <remarks/>
        public ManufacturerName ManufacturerName
        {
            get
            {
                return this.manufacturerNameField;
            }
            set
            {
                this.manufacturerNameField = value;
            }
        }

        /// <remarks/>
        public Country Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SerialNumber")]
        public string[] SerialNumber
        {
            get
            {
                return this.serialNumberField;
            }
            set
            {
                this.serialNumberField = value;
            }
        }

        /// <remarks/>
        public string SupplierBatchID
        {
            get
            {
                return this.supplierBatchIDField;
            }
            set
            {
                this.supplierBatchIDField = value;
            }
        }

        /// <remarks/>
        public InvoiceDetailItemReferenceIndustry InvoiceDetailItemReferenceIndustry
        {
            get
            {
                return this.invoiceDetailItemReferenceIndustryField;
            }
            set
            {
                this.invoiceDetailItemReferenceIndustryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lineNumber
        {
            get
            {
                return this.lineNumberField;
            }
            set
            {
                this.lineNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string serialNumber
        {
            get
            {
                return this.serialNumberField1;
            }
            set
            {
                this.serialNumberField1 = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceDetailItemReferenceIndustry
    {

        private InvoiceDetailItemReferenceRetail invoiceDetailItemReferenceRetailField;

        /// <remarks/>
        public InvoiceDetailItemReferenceRetail InvoiceDetailItemReferenceRetail
        {
            get
            {
                return this.invoiceDetailItemReferenceRetailField;
            }
            set
            {
                this.invoiceDetailItemReferenceRetailField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceDetailItemReferenceRetail
    {

        private string eANIDField;

        private string europeanWasteCatalogIDField;

        private Characteristic[] characteristicField;

        /// <remarks/>
        public string EANID
        {
            get
            {
                return this.eANIDField;
            }
            set
            {
                this.eANIDField = value;
            }
        }

        /// <remarks/>
        public string EuropeanWasteCatalogID
        {
            get
            {
                return this.europeanWasteCatalogIDField;
            }
            set
            {
                this.europeanWasteCatalogIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Characteristic")]
        public Characteristic[] Characteristic
        {
            get
            {
                return this.characteristicField;
            }
            set
            {
                this.characteristicField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ReceiptLineItemReference
    {

        private string receiptLineNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string receiptLineNumber
        {
            get
            {
                return this.receiptLineNumberField;
            }
            set
            {
                this.receiptLineNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ShipNoticeLineItemReference
    {

        private string shipNoticeLineNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string shipNoticeLineNumber
        {
            get
            {
                return this.shipNoticeLineNumberField;
            }
            set
            {
                this.shipNoticeLineNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ServiceEntryItemIDInfo
    {

        private IdReference[] idReferenceField;

        private string serviceLineNumberField;

        private string serviceEntryIDField;

        private string serviceEntryDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IdReference")]
        public IdReference[] IdReference
        {
            get
            {
                return this.idReferenceField;
            }
            set
            {
                this.idReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string serviceLineNumber
        {
            get
            {
                return this.serviceLineNumberField;
            }
            set
            {
                this.serviceLineNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string serviceEntryID
        {
            get
            {
                return this.serviceEntryIDField;
            }
            set
            {
                this.serviceEntryIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string serviceEntryDate
        {
            get
            {
                return this.serviceEntryDateField;
            }
            set
            {
                this.serviceEntryDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ServiceEntryItemReference
    {

        private DocumentReference documentReferenceField;

        private string serviceLineNumberField;

        private string serviceEntryIDField;

        private string serviceEntryDateField;

        /// <remarks/>
        public DocumentReference DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string serviceLineNumber
        {
            get
            {
                return this.serviceLineNumberField;
            }
            set
            {
                this.serviceLineNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string serviceEntryID
        {
            get
            {
                return this.serviceEntryIDField;
            }
            set
            {
                this.serviceEntryIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string serviceEntryDate
        {
            get
            {
                return this.serviceEntryDateField;
            }
            set
            {
                this.serviceEntryDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class TotalCharges
    {

        private Money moneyField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class TotalAllowances
    {

        private Money moneyField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class TotalAmountWithoutTax
    {

        private Money moneyField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceDetailItemIndustry
    {

        private InvoiceDetailItemRetail invoiceDetailItemRetailField;

        /// <remarks/>
        public InvoiceDetailItemRetail InvoiceDetailItemRetail
        {
            get
            {
                return this.invoiceDetailItemRetailField;
            }
            set
            {
                this.invoiceDetailItemRetailField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceDetailItemRetail
    {

        private AdditionalPrices additionalPricesField;

        private TotalRetailAmount totalRetailAmountField;

        private ItemIndicator[] itemIndicatorField;

        private string promotionDealIDField;

        private string promotionVariantIDField;

        /// <remarks/>
        public AdditionalPrices AdditionalPrices
        {
            get
            {
                return this.additionalPricesField;
            }
            set
            {
                this.additionalPricesField = value;
            }
        }

        /// <remarks/>
        public TotalRetailAmount TotalRetailAmount
        {
            get
            {
                return this.totalRetailAmountField;
            }
            set
            {
                this.totalRetailAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemIndicator")]
        public ItemIndicator[] ItemIndicator
        {
            get
            {
                return this.itemIndicatorField;
            }
            set
            {
                this.itemIndicatorField = value;
            }
        }

        /// <remarks/>
        public string PromotionDealID
        {
            get
            {
                return this.promotionDealIDField;
            }
            set
            {
                this.promotionDealIDField = value;
            }
        }

        /// <remarks/>
        public string PromotionVariantID
        {
            get
            {
                return this.promotionVariantIDField;
            }
            set
            {
                this.promotionVariantIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class CustomsInfo
    {

        private Issuer issuerField;

        private DocumentInfo documentInfoField;

        /// <remarks/>
        public Issuer Issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }

        /// <remarks/>
        public DocumentInfo DocumentInfo
        {
            get
            {
                return this.documentInfoField;
            }
            set
            {
                this.documentInfoField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum InvoiceDetailItemItemType
    {

        /// <remarks/>
        composite,

        /// <remarks/>
        item,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum InvoiceDetailItemCompositeItemType
    {

        /// <remarks/>
        groupLevel,

        /// <remarks/>
        itemLevel,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum InvoiceDetailItemReason
    {

        /// <remarks/>
        @return,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum InvoiceDetailItemIsAdHoc
    {

        /// <remarks/>
        yes,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceDetailServiceItem
    {

        private InvoiceDetailServiceItemReference invoiceDetailServiceItemReferenceField;

        private object itemField;

        private SubtotalAmount subtotalAmountField;

        private Period periodField;

        private object[] itemsField;

        private Tax taxField;

        private GrossAmount grossAmountField;

        private InvoiceDetailDiscount invoiceDetailDiscountField;

        private Modification[] invoiceItemModificationsField;

        private TotalCharges totalChargesField;

        private TotalAllowances totalAllowancesField;

        private TotalAmountWithoutTax totalAmountWithoutTaxField;

        private NetAmount netAmountField;

        private Distribution[] distributionField;

        private Comments commentsField;

        private InvoiceLaborDetail invoiceLaborDetailField;

        private Extrinsic[] extrinsicField;

        private string invoiceLineNumberField;

        private string quantityField;

        private string referenceDateField;

        private string inspectionDateField;

        private string parentInvoiceLineNumberField;

        private InvoiceDetailServiceItemItemType itemTypeField;

        private bool itemTypeFieldSpecified;

        private InvoiceDetailServiceItemIsAdHoc isAdHocField;

        private bool isAdHocFieldSpecified;

        /// <remarks/>
        public InvoiceDetailServiceItemReference InvoiceDetailServiceItemReference
        {
            get
            {
                return this.invoiceDetailServiceItemReferenceField;
            }
            set
            {
                this.invoiceDetailServiceItemReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ServiceEntryItemIDInfo", typeof(ServiceEntryItemIDInfo))]
        [System.Xml.Serialization.XmlElementAttribute("ServiceEntryItemReference", typeof(ServiceEntryItemReference))]
        public object Item
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
        public SubtotalAmount SubtotalAmount
        {
            get
            {
                return this.subtotalAmountField;
            }
            set
            {
                this.subtotalAmountField = value;
            }
        }

        /// <remarks/>
        public Period Period
        {
            get
            {
                return this.periodField;
            }
            set
            {
                this.periodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PriceBasisQuantity", typeof(PriceBasisQuantity))]
        [System.Xml.Serialization.XmlElementAttribute("UnitOfMeasure", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("UnitPrice", typeof(UnitPrice))]
        [System.Xml.Serialization.XmlElementAttribute("UnitRate", typeof(UnitRate))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        public Tax Tax
        {
            get
            {
                return this.taxField;
            }
            set
            {
                this.taxField = value;
            }
        }

        /// <remarks/>
        public GrossAmount GrossAmount
        {
            get
            {
                return this.grossAmountField;
            }
            set
            {
                this.grossAmountField = value;
            }
        }

        /// <remarks/>
        public InvoiceDetailDiscount InvoiceDetailDiscount
        {
            get
            {
                return this.invoiceDetailDiscountField;
            }
            set
            {
                this.invoiceDetailDiscountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Modification", IsNullable = false)]
        public Modification[] InvoiceItemModifications
        {
            get
            {
                return this.invoiceItemModificationsField;
            }
            set
            {
                this.invoiceItemModificationsField = value;
            }
        }

        /// <remarks/>
        public TotalCharges TotalCharges
        {
            get
            {
                return this.totalChargesField;
            }
            set
            {
                this.totalChargesField = value;
            }
        }

        /// <remarks/>
        public TotalAllowances TotalAllowances
        {
            get
            {
                return this.totalAllowancesField;
            }
            set
            {
                this.totalAllowancesField = value;
            }
        }

        /// <remarks/>
        public TotalAmountWithoutTax TotalAmountWithoutTax
        {
            get
            {
                return this.totalAmountWithoutTaxField;
            }
            set
            {
                this.totalAmountWithoutTaxField = value;
            }
        }

        /// <remarks/>
        public NetAmount NetAmount
        {
            get
            {
                return this.netAmountField;
            }
            set
            {
                this.netAmountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Distribution")]
        public Distribution[] Distribution
        {
            get
            {
                return this.distributionField;
            }
            set
            {
                this.distributionField = value;
            }
        }

        /// <remarks/>
        public Comments Comments
        {
            get
            {
                return this.commentsField;
            }
            set
            {
                this.commentsField = value;
            }
        }

        /// <remarks/>
        public InvoiceLaborDetail InvoiceLaborDetail
        {
            get
            {
                return this.invoiceLaborDetailField;
            }
            set
            {
                this.invoiceLaborDetailField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Extrinsic")]
        public Extrinsic[] Extrinsic
        {
            get
            {
                return this.extrinsicField;
            }
            set
            {
                this.extrinsicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string invoiceLineNumber
        {
            get
            {
                return this.invoiceLineNumberField;
            }
            set
            {
                this.invoiceLineNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string quantity
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string referenceDate
        {
            get
            {
                return this.referenceDateField;
            }
            set
            {
                this.referenceDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inspectionDate
        {
            get
            {
                return this.inspectionDateField;
            }
            set
            {
                this.inspectionDateField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string parentInvoiceLineNumber
        {
            get
            {
                return this.parentInvoiceLineNumberField;
            }
            set
            {
                this.parentInvoiceLineNumberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public InvoiceDetailServiceItemItemType itemType
        {
            get
            {
                return this.itemTypeField;
            }
            set
            {
                this.itemTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool itemTypeSpecified
        {
            get
            {
                return this.itemTypeFieldSpecified;
            }
            set
            {
                this.itemTypeFieldSpecified = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public InvoiceDetailServiceItemIsAdHoc isAdHoc
        {
            get
            {
                return this.isAdHocField;
            }
            set
            {
                this.isAdHocField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isAdHocSpecified
        {
            get
            {
                return this.isAdHocFieldSpecified;
            }
            set
            {
                this.isAdHocFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceDetailServiceItemReference
    {

        private Classification[] classificationField;

        private ItemID itemIDField;

        private Description descriptionField;

        private string lineNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Classification")]
        public Classification[] Classification
        {
            get
            {
                return this.classificationField;
            }
            set
            {
                this.classificationField = value;
            }
        }

        /// <remarks/>
        public ItemID ItemID
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

        /// <remarks/>
        public Description Description
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
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string lineNumber
        {
            get
            {
                return this.lineNumberField;
            }
            set
            {
                this.lineNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceLaborDetail
    {

        private Contractor contractorField;

        private JobDescription jobDescriptionField;

        private Supervisor supervisorField;

        private WorkLocation workLocationField;

        private InvoiceTimeCardDetail invoiceTimeCardDetailField;

        /// <remarks/>
        public Contractor Contractor
        {
            get
            {
                return this.contractorField;
            }
            set
            {
                this.contractorField = value;
            }
        }

        /// <remarks/>
        public JobDescription JobDescription
        {
            get
            {
                return this.jobDescriptionField;
            }
            set
            {
                this.jobDescriptionField = value;
            }
        }

        /// <remarks/>
        public Supervisor Supervisor
        {
            get
            {
                return this.supervisorField;
            }
            set
            {
                this.supervisorField = value;
            }
        }

        /// <remarks/>
        public WorkLocation WorkLocation
        {
            get
            {
                return this.workLocationField;
            }
            set
            {
                this.workLocationField = value;
            }
        }

        /// <remarks/>
        public InvoiceTimeCardDetail InvoiceTimeCardDetail
        {
            get
            {
                return this.invoiceTimeCardDetailField;
            }
            set
            {
                this.invoiceTimeCardDetailField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceTimeCardDetail
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TimeCardIDInfo", typeof(TimeCardIDInfo))]
        [System.Xml.Serialization.XmlElementAttribute("TimeCardReference", typeof(TimeCardReference))]
        public object Item
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class TimeCardIDInfo
    {

        private string timeCardIDField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string timeCardID
        {
            get
            {
                return this.timeCardIDField;
            }
            set
            {
                this.timeCardIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class TimeCardReference
    {

        private DocumentReference documentReferenceField;

        private string timeCardIDField;

        /// <remarks/>
        public DocumentReference DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string timeCardID
        {
            get
            {
                return this.timeCardIDField;
            }
            set
            {
                this.timeCardIDField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum InvoiceDetailServiceItemItemType
    {

        /// <remarks/>
        composite,

        /// <remarks/>
        item,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum InvoiceDetailServiceItemIsAdHoc
    {

        /// <remarks/>
        yes,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceDetailSummary
    {

        private SubtotalAmount subtotalAmountField;

        private Tax taxField;

        private SpecialHandlingAmount specialHandlingAmountField;

        private ShippingAmount shippingAmountField;

        private GrossAmount grossAmountField;

        private InvoiceDetailDiscount invoiceDetailDiscountField;

        private Modification[] invoiceHeaderModificationsField;

        private Modification[] invoiceDetailSummaryLineItemModificationsField;

        private TotalCharges totalChargesField;

        private TotalAllowances totalAllowancesField;

        private TotalAmountWithoutTax totalAmountWithoutTaxField;

        private NetAmount netAmountField;

        private DepositAmount depositAmountField;

        private DueAmount dueAmountField;

        private InvoiceDetailSummaryIndustry invoiceDetailSummaryIndustryField;

        /// <remarks/>
        public SubtotalAmount SubtotalAmount
        {
            get
            {
                return this.subtotalAmountField;
            }
            set
            {
                this.subtotalAmountField = value;
            }
        }

        /// <remarks/>
        public Tax Tax
        {
            get
            {
                return this.taxField;
            }
            set
            {
                this.taxField = value;
            }
        }

        /// <remarks/>
        public SpecialHandlingAmount SpecialHandlingAmount
        {
            get
            {
                return this.specialHandlingAmountField;
            }
            set
            {
                this.specialHandlingAmountField = value;
            }
        }

        /// <remarks/>
        public ShippingAmount ShippingAmount
        {
            get
            {
                return this.shippingAmountField;
            }
            set
            {
                this.shippingAmountField = value;
            }
        }

        /// <remarks/>
        public GrossAmount GrossAmount
        {
            get
            {
                return this.grossAmountField;
            }
            set
            {
                this.grossAmountField = value;
            }
        }

        /// <remarks/>
        public InvoiceDetailDiscount InvoiceDetailDiscount
        {
            get
            {
                return this.invoiceDetailDiscountField;
            }
            set
            {
                this.invoiceDetailDiscountField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Modification", IsNullable = false)]
        public Modification[] InvoiceHeaderModifications
        {
            get
            {
                return this.invoiceHeaderModificationsField;
            }
            set
            {
                this.invoiceHeaderModificationsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Modification", IsNullable = false)]
        public Modification[] InvoiceDetailSummaryLineItemModifications
        {
            get
            {
                return this.invoiceDetailSummaryLineItemModificationsField;
            }
            set
            {
                this.invoiceDetailSummaryLineItemModificationsField = value;
            }
        }

        /// <remarks/>
        public TotalCharges TotalCharges
        {
            get
            {
                return this.totalChargesField;
            }
            set
            {
                this.totalChargesField = value;
            }
        }

        /// <remarks/>
        public TotalAllowances TotalAllowances
        {
            get
            {
                return this.totalAllowancesField;
            }
            set
            {
                this.totalAllowancesField = value;
            }
        }

        /// <remarks/>
        public TotalAmountWithoutTax TotalAmountWithoutTax
        {
            get
            {
                return this.totalAmountWithoutTaxField;
            }
            set
            {
                this.totalAmountWithoutTaxField = value;
            }
        }

        /// <remarks/>
        public NetAmount NetAmount
        {
            get
            {
                return this.netAmountField;
            }
            set
            {
                this.netAmountField = value;
            }
        }

        /// <remarks/>
        public DepositAmount DepositAmount
        {
            get
            {
                return this.depositAmountField;
            }
            set
            {
                this.depositAmountField = value;
            }
        }

        /// <remarks/>
        public DueAmount DueAmount
        {
            get
            {
                return this.dueAmountField;
            }
            set
            {
                this.dueAmountField = value;
            }
        }

        /// <remarks/>
        public InvoiceDetailSummaryIndustry InvoiceDetailSummaryIndustry
        {
            get
            {
                return this.invoiceDetailSummaryIndustryField;
            }
            set
            {
                this.invoiceDetailSummaryIndustryField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class SpecialHandlingAmount
    {

        private Money moneyField;

        private Description descriptionField;

        private Distribution[] distributionField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }

        /// <remarks/>
        public Description Description
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
        [System.Xml.Serialization.XmlElementAttribute("Distribution")]
        public Distribution[] Distribution
        {
            get
            {
                return this.distributionField;
            }
            set
            {
                this.distributionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ShippingAmount
    {

        private Money moneyField;

        private Distribution[] distributionField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Distribution")]
        public Distribution[] Distribution
        {
            get
            {
                return this.distributionField;
            }
            set
            {
                this.distributionField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class DepositAmount
    {

        private Money moneyField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class DueAmount
    {

        private Money moneyField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceDetailSummaryIndustry
    {

        private InvoiceDetailSummaryRetail invoiceDetailSummaryRetailField;

        /// <remarks/>
        public InvoiceDetailSummaryRetail InvoiceDetailSummaryRetail
        {
            get
            {
                return this.invoiceDetailSummaryRetailField;
            }
            set
            {
                this.invoiceDetailSummaryRetailField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceDetailSummaryRetail
    {

        private AdditionalAmounts additionalAmountsField;

        /// <remarks/>
        public AdditionalAmounts AdditionalAmounts
        {
            get
            {
                return this.additionalAmountsField;
            }
            set
            {
                this.additionalAmountsField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ProviderSetupRequest
    {

        private string originatorCookieField;

        private BrowserFormPost browserFormPostField;

        private Followup followupField;

        private string selectedServiceField;

        private Extrinsic[] extrinsicField;

        /// <remarks/>
        public string OriginatorCookie
        {
            get
            {
                return this.originatorCookieField;
            }
            set
            {
                this.originatorCookieField = value;
            }
        }

        /// <remarks/>
        public BrowserFormPost BrowserFormPost
        {
            get
            {
                return this.browserFormPostField;
            }
            set
            {
                this.browserFormPostField = value;
            }
        }

        /// <remarks/>
        public Followup Followup
        {
            get
            {
                return this.followupField;
            }
            set
            {
                this.followupField = value;
            }
        }

        /// <remarks/>
        public string SelectedService
        {
            get
            {
                return this.selectedServiceField;
            }
            set
            {
                this.selectedServiceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Extrinsic")]
        public Extrinsic[] Extrinsic
        {
            get
            {
                return this.extrinsicField;
            }
            set
            {
                this.extrinsicField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum RequestDeploymentMode
    {

        /// <remarks/>
        production,

        /// <remarks/>
        test,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Response
    {

        private Status statusField;

        private ProviderSetupResponse providerSetupResponseField;

        private string idField;

        /// <remarks/>
        public Status Status
        {
            get
            {
                return this.statusField;
            }
            set
            {
                this.statusField = value;
            }
        }

        /// <remarks/>
        public ProviderSetupResponse ProviderSetupResponse
        {
            get
            {
                return this.providerSetupResponseField;
            }
            set
            {
                this.providerSetupResponseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ProviderSetupResponse
    {

        private StartPage startPageField;

        /// <remarks/>
        public StartPage StartPage
        {
            get
            {
                return this.startPageField;
            }
            set
            {
                this.startPageField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:ds")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:ds", IsNullable = false)]
    public partial class Signature
    {

        private SignedInfo signedInfoField;

        private SignatureValue signatureValueField;

        private KeyInfo keyInfoField;

        private Object[] objectField;

        private string idField;

        /// <remarks/>
        public SignedInfo SignedInfo
        {
            get
            {
                return this.signedInfoField;
            }
            set
            {
                this.signedInfoField = value;
            }
        }

        /// <remarks/>
        public SignatureValue SignatureValue
        {
            get
            {
                return this.signatureValueField;
            }
            set
            {
                this.signatureValueField = value;
            }
        }

        /// <remarks/>
        public KeyInfo KeyInfo
        {
            get
            {
                return this.keyInfoField;
            }
            set
            {
                this.keyInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Object")]
        public Object[] Object
        {
            get
            {
                return this.objectField;
            }
            set
            {
                this.objectField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:ds")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:ds", IsNullable = false)]
    public partial class SignedInfo
    {

        private CanonicalizationMethod canonicalizationMethodField;

        private SignatureMethod signatureMethodField;

        private Reference[] referenceField;

        private string idField;

        /// <remarks/>
        public CanonicalizationMethod CanonicalizationMethod
        {
            get
            {
                return this.canonicalizationMethodField;
            }
            set
            {
                this.canonicalizationMethodField = value;
            }
        }

        /// <remarks/>
        public SignatureMethod SignatureMethod
        {
            get
            {
                return this.signatureMethodField;
            }
            set
            {
                this.signatureMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Reference")]
        public Reference[] Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:ds")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:ds", IsNullable = false)]
    public partial class CanonicalizationMethod
    {

        private string algorithmField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:ds")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:ds", IsNullable = false)]
    public partial class SignatureMethod
    {

        private string[] itemsField;

        private string[] textField;

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HMACOutputLength")]
        public string[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:ds")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:ds", IsNullable = false)]
    public partial class Reference
    {

        private Transform[] transformsField;

        private DigestMethod digestMethodField;

        private string digestValueField;

        private string idField;

        private string uRIField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable = false)]
        public Transform[] Transforms
        {
            get
            {
                return this.transformsField;
            }
            set
            {
                this.transformsField = value;
            }
        }

        /// <remarks/>
        public DigestMethod DigestMethod
        {
            get
            {
                return this.digestMethodField;
            }
            set
            {
                this.digestMethodField = value;
            }
        }

        /// <remarks/>
        public string DigestValue
        {
            get
            {
                return this.digestValueField;
            }
            set
            {
                this.digestValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail")]
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail")]
        public string Type
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:ds")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:ds", IsNullable = false)]
    public partial class Transform
    {

        private string[] itemsField;

        private string[] textField;

        private string algorithmField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("XPath")]
        public string[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:ds")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:ds", IsNullable = false)]
    public partial class DigestMethod
    {

        private string algorithmField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail")]
        public string Algorithm
        {
            get
            {
                return this.algorithmField;
            }
            set
            {
                this.algorithmField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:ds")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:ds", IsNullable = false)]
    public partial class SignatureValue
    {

        private string idField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:ds")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:ds", IsNullable = false)]
    public partial class KeyInfo
    {

        private object[] itemsField;

        private ItemsChoiceType2[] itemsElementNameField;

        private string[] textField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("KeyName", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("KeyValue", typeof(KeyValue))]
        [System.Xml.Serialization.XmlElementAttribute("MgmtData", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("PGPData", typeof(PGPData))]
        [System.Xml.Serialization.XmlElementAttribute("RetrievalMethod", typeof(RetrievalMethod))]
        [System.Xml.Serialization.XmlElementAttribute("SPKIData", typeof(SPKIData))]
        [System.Xml.Serialization.XmlElementAttribute("X509Data", typeof(X509Data))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType2[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:ds")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:ds", IsNullable = false)]
    public partial class KeyValue
    {

        private object[] itemsField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DSAKeyValue", typeof(DSAKeyValue))]
        [System.Xml.Serialization.XmlElementAttribute("RSAKeyValue", typeof(RSAKeyValue))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:ds")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:ds", IsNullable = false)]
    public partial class DSAKeyValue
    {

        private string pField;

        private string qField;

        private string gField;

        private string yField;

        private string jField;

        private string seedField;

        private string pgenCounterField;

        /// <remarks/>
        public string P
        {
            get
            {
                return this.pField;
            }
            set
            {
                this.pField = value;
            }
        }

        /// <remarks/>
        public string Q
        {
            get
            {
                return this.qField;
            }
            set
            {
                this.qField = value;
            }
        }

        /// <remarks/>
        public string G
        {
            get
            {
                return this.gField;
            }
            set
            {
                this.gField = value;
            }
        }

        /// <remarks/>
        public string Y
        {
            get
            {
                return this.yField;
            }
            set
            {
                this.yField = value;
            }
        }

        /// <remarks/>
        public string J
        {
            get
            {
                return this.jField;
            }
            set
            {
                this.jField = value;
            }
        }

        /// <remarks/>
        public string Seed
        {
            get
            {
                return this.seedField;
            }
            set
            {
                this.seedField = value;
            }
        }

        /// <remarks/>
        public string PgenCounter
        {
            get
            {
                return this.pgenCounterField;
            }
            set
            {
                this.pgenCounterField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:ds")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:ds", IsNullable = false)]
    public partial class RSAKeyValue
    {

        private string modulusField;

        private string exponentField;

        /// <remarks/>
        public string Modulus
        {
            get
            {
                return this.modulusField;
            }
            set
            {
                this.modulusField = value;
            }
        }

        /// <remarks/>
        public string Exponent
        {
            get
            {
                return this.exponentField;
            }
            set
            {
                this.exponentField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:ds")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:ds", IsNullable = false)]
    public partial class PGPData
    {

        private string[] itemsField;

        private ItemsChoiceType1[] itemsElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PGPKeyID", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("PGPKeyPacket", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public string[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType1[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "uri:ds", IncludeInSchema = false)]
    public enum ItemsChoiceType1
    {

        /// <remarks/>
        PGPKeyID,

        /// <remarks/>
        PGPKeyPacket,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:ds")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:ds", IsNullable = false)]
    public partial class RetrievalMethod
    {

        private Transform[] transformsField;

        private string uRIField;

        private string typeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable = false)]
        public Transform[] Transforms
        {
            get
            {
                return this.transformsField;
            }
            set
            {
                this.transformsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail")]
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail")]
        public string Type
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:ds")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:ds", IsNullable = false)]
    public partial class SPKIData
    {

        private string sPKISexpField;

        /// <remarks/>
        public string SPKISexp
        {
            get
            {
                return this.sPKISexpField;
            }
            set
            {
                this.sPKISexpField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:ds")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:ds", IsNullable = false)]
    public partial class X509Data
    {

        private object[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("X509CRL", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("X509Certificate", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("X509IssuerSerial", typeof(X509IssuerSerial))]
        [System.Xml.Serialization.XmlElementAttribute("X509SKI", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("X509SubjectName", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:ds")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:ds", IsNullable = false)]
    public partial class X509IssuerSerial
    {

        private string x509IssuerNameField;

        private string x509SerialNumberField;

        /// <remarks/>
        public string X509IssuerName
        {
            get
            {
                return this.x509IssuerNameField;
            }
            set
            {
                this.x509IssuerNameField = value;
            }
        }

        /// <remarks/>
        public string X509SerialNumber
        {
            get
            {
                return this.x509SerialNumberField;
            }
            set
            {
                this.x509SerialNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "uri:ds", IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        /// <remarks/>
        X509CRL,

        /// <remarks/>
        X509Certificate,

        /// <remarks/>
        X509IssuerSerial,

        /// <remarks/>
        X509SKI,

        /// <remarks/>
        X509SubjectName,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "uri:ds", IncludeInSchema = false)]
    public enum ItemsChoiceType2
    {

        /// <remarks/>
        KeyName,

        /// <remarks/>
        KeyValue,

        /// <remarks/>
        MgmtData,

        /// <remarks/>
        PGPData,

        /// <remarks/>
        RetrievalMethod,

        /// <remarks/>
        SPKIData,

        /// <remarks/>
        X509Data,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:ds")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:ds", IsNullable = false)]
    public partial class Object
    {

        private object[] itemsField;

        private string[] textField;

        private string idField;

        private string mimeTypeField;

        private string encodingField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Extrinsic", typeof(Extrinsic), Namespace = "http://tempuri.org/InvoiceDetail")]
        [System.Xml.Serialization.XmlElementAttribute("cXMLSignedInfo", typeof(cXMLSignedInfo), Namespace = "http://tempuri.org/InvoiceDetail")]
        [System.Xml.Serialization.XmlElementAttribute("Manifest", typeof(Manifest))]
        [System.Xml.Serialization.XmlElementAttribute("Signature", typeof(Signature))]
        [System.Xml.Serialization.XmlElementAttribute("SignatureProperties", typeof(SignatureProperties))]
        [System.Xml.Serialization.XmlElementAttribute("QualifyingProperties", typeof(QualifyingProperties), Namespace = "uri:xades")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
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
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail")]
        public string MimeType
        {
            get
            {
                return this.mimeTypeField;
            }
            set
            {
                this.mimeTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail")]
        public string Encoding
        {
            get
            {
                return this.encodingField;
            }
            set
            {
                this.encodingField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class cXMLSignedInfo
    {

        private cXMLSignedInfoSignatureVersion signatureVersionField;

        private string payloadIDField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public cXMLSignedInfoSignatureVersion signatureVersion
        {
            get
            {
                return this.signatureVersionField;
            }
            set
            {
                this.signatureVersionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string payloadID
        {
            get
            {
                return this.payloadIDField;
            }
            set
            {
                this.payloadIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum cXMLSignedInfoSignatureVersion
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1.0")]
        Item10,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:ds")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:ds", IsNullable = false)]
    public partial class Manifest
    {

        private Reference[] referenceField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Reference")]
        public Reference[] Reference
        {
            get
            {
                return this.referenceField;
            }
            set
            {
                this.referenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:ds")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:ds", IsNullable = false)]
    public partial class SignatureProperties
    {

        private SignatureProperty[] signaturePropertyField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SignatureProperty")]
        public SignatureProperty[] SignatureProperty
        {
            get
            {
                return this.signaturePropertyField;
            }
            set
            {
                this.signaturePropertyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:ds")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:ds", IsNullable = false)]
    public partial class SignatureProperty
    {

        private string targetField;

        private string idField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail")]
        public string Target
        {
            get
            {
                return this.targetField;
            }
            set
            {
                this.targetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class QualifyingProperties
    {

        private SignedProperties signedPropertiesField;

        private UnsignedProperties unsignedPropertiesField;

        private string targetField;

        private string idField;

        /// <remarks/>
        public SignedProperties SignedProperties
        {
            get
            {
                return this.signedPropertiesField;
            }
            set
            {
                this.signedPropertiesField = value;
            }
        }

        /// <remarks/>
        public UnsignedProperties UnsignedProperties
        {
            get
            {
                return this.unsignedPropertiesField;
            }
            set
            {
                this.unsignedPropertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail")]
        public string Target
        {
            get
            {
                return this.targetField;
            }
            set
            {
                this.targetField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class SignedProperties
    {

        private SignedSignatureProperties signedSignaturePropertiesField;

        private SignedDataObjectProperties signedDataObjectPropertiesField;

        private string idField;

        /// <remarks/>
        public SignedSignatureProperties SignedSignatureProperties
        {
            get
            {
                return this.signedSignaturePropertiesField;
            }
            set
            {
                this.signedSignaturePropertiesField = value;
            }
        }

        /// <remarks/>
        public SignedDataObjectProperties SignedDataObjectProperties
        {
            get
            {
                return this.signedDataObjectPropertiesField;
            }
            set
            {
                this.signedDataObjectPropertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class SignedSignatureProperties
    {

        private string signingTimeField;

        private Cert[] signingCertificateField;

        private SignaturePolicyIdentifier signaturePolicyIdentifierField;

        private SignatureProductionPlace signatureProductionPlaceField;

        private SignerRole signerRoleField;

        private string idField;

        /// <remarks/>
        public string SigningTime
        {
            get
            {
                return this.signingTimeField;
            }
            set
            {
                this.signingTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Cert", IsNullable = false)]
        public Cert[] SigningCertificate
        {
            get
            {
                return this.signingCertificateField;
            }
            set
            {
                this.signingCertificateField = value;
            }
        }

        /// <remarks/>
        public SignaturePolicyIdentifier SignaturePolicyIdentifier
        {
            get
            {
                return this.signaturePolicyIdentifierField;
            }
            set
            {
                this.signaturePolicyIdentifierField = value;
            }
        }

        /// <remarks/>
        public SignatureProductionPlace SignatureProductionPlace
        {
            get
            {
                return this.signatureProductionPlaceField;
            }
            set
            {
                this.signatureProductionPlaceField = value;
            }
        }

        /// <remarks/>
        public SignerRole SignerRole
        {
            get
            {
                return this.signerRoleField;
            }
            set
            {
                this.signerRoleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class Cert
    {

        private CertDigest certDigestField;

        private IssuerSerial issuerSerialField;

        private string uRIField;

        /// <remarks/>
        public CertDigest CertDigest
        {
            get
            {
                return this.certDigestField;
            }
            set
            {
                this.certDigestField = value;
            }
        }

        /// <remarks/>
        public IssuerSerial IssuerSerial
        {
            get
            {
                return this.issuerSerialField;
            }
            set
            {
                this.issuerSerialField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail")]
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class CertDigest
    {

        private DigestMethod digestMethodField;

        private string digestValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "uri:ds")]
        public DigestMethod DigestMethod
        {
            get
            {
                return this.digestMethodField;
            }
            set
            {
                this.digestMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "uri:ds")]
        public string DigestValue
        {
            get
            {
                return this.digestValueField;
            }
            set
            {
                this.digestValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class IssuerSerial
    {

        private string x509IssuerNameField;

        private string x509SerialNumberField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "uri:ds")]
        public string X509IssuerName
        {
            get
            {
                return this.x509IssuerNameField;
            }
            set
            {
                this.x509IssuerNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "uri:ds")]
        public string X509SerialNumber
        {
            get
            {
                return this.x509SerialNumberField;
            }
            set
            {
                this.x509SerialNumberField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class SignaturePolicyIdentifier
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SignaturePolicyId", typeof(SignaturePolicyId))]
        [System.Xml.Serialization.XmlElementAttribute("SignaturePolicyImplied", typeof(SignaturePolicyImplied))]
        public object Item
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class SignaturePolicyId
    {

        private SigPolicyId sigPolicyIdField;

        private Transform[] transformsField;

        private SigPolicyHash sigPolicyHashField;

        private SigPolicyQualifier[] sigPolicyQualifiersField;

        /// <remarks/>
        public SigPolicyId SigPolicyId
        {
            get
            {
                return this.sigPolicyIdField;
            }
            set
            {
                this.sigPolicyIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(Namespace = "uri:ds")]
        [System.Xml.Serialization.XmlArrayItemAttribute("Transform", IsNullable = false)]
        public Transform[] Transforms
        {
            get
            {
                return this.transformsField;
            }
            set
            {
                this.transformsField = value;
            }
        }

        /// <remarks/>
        public SigPolicyHash SigPolicyHash
        {
            get
            {
                return this.sigPolicyHashField;
            }
            set
            {
                this.sigPolicyHashField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("SigPolicyQualifier", IsNullable = false)]
        public SigPolicyQualifier[] SigPolicyQualifiers
        {
            get
            {
                return this.sigPolicyQualifiersField;
            }
            set
            {
                this.sigPolicyQualifiersField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class SigPolicyId
    {

        private Identifier identifierField;

        private string descriptionField;

        private DocumentationReferences documentationReferencesField;

        /// <remarks/>
        public Identifier Identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }

        /// <remarks/>
        public string Description
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
        public DocumentationReferences DocumentationReferences
        {
            get
            {
                return this.documentationReferencesField;
            }
            set
            {
                this.documentationReferencesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class Identifier
    {

        private IdentifierQualifier qualifierField;

        private bool qualifierFieldSpecified;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail")]
        public IdentifierQualifier Qualifier
        {
            get
            {
                return this.qualifierField;
            }
            set
            {
                this.qualifierField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool QualifierSpecified
        {
            get
            {
                return this.qualifierFieldSpecified;
            }
            set
            {
                this.qualifierFieldSpecified = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum IdentifierQualifier
    {

        /// <remarks/>
        OIDAsURI,

        /// <remarks/>
        OIDAsURN,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class DocumentationReferences
    {

        private string[] documentationReferenceField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DocumentationReference")]
        public string[] DocumentationReference
        {
            get
            {
                return this.documentationReferenceField;
            }
            set
            {
                this.documentationReferenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class SigPolicyHash
    {

        private DigestMethod digestMethodField;

        private string digestValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "uri:ds")]
        public DigestMethod DigestMethod
        {
            get
            {
                return this.digestMethodField;
            }
            set
            {
                this.digestMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "uri:ds")]
        public string DigestValue
        {
            get
            {
                return this.digestValueField;
            }
            set
            {
                this.digestValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class SigPolicyQualifier
    {

        private string[] itemsField;

        private string[] textField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SPURI")]
        public string[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class SignaturePolicyImplied
    {

        private System.Xml.XmlNode[] anyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class SignatureProductionPlace
    {

        private string cityField;

        private string stateOrProvinceField;

        private string postalCodeField;

        private string countryNameField;

        /// <remarks/>
        public string City
        {
            get
            {
                return this.cityField;
            }
            set
            {
                this.cityField = value;
            }
        }

        /// <remarks/>
        public string StateOrProvince
        {
            get
            {
                return this.stateOrProvinceField;
            }
            set
            {
                this.stateOrProvinceField = value;
            }
        }

        /// <remarks/>
        public string PostalCode
        {
            get
            {
                return this.postalCodeField;
            }
            set
            {
                this.postalCodeField = value;
            }
        }

        /// <remarks/>
        public string CountryName
        {
            get
            {
                return this.countryNameField;
            }
            set
            {
                this.countryNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class SignerRole
    {

        private string[] claimedRolesField;

        private CertifiedRole[] certifiedRolesField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ClaimedRole", IsNullable = false)]
        public string[] ClaimedRoles
        {
            get
            {
                return this.claimedRolesField;
            }
            set
            {
                this.claimedRolesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CertifiedRole", IsNullable = false)]
        public CertifiedRole[] CertifiedRoles
        {
            get
            {
                return this.certifiedRolesField;
            }
            set
            {
                this.certifiedRolesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class CertifiedRole
    {

        private string idField;

        private string encodingField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail")]
        public string Encoding
        {
            get
            {
                return this.encodingField;
            }
            set
            {
                this.encodingField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class SignedDataObjectProperties
    {

        private DataObjectFormat[] dataObjectFormatField;

        private CommitmentTypeIndication[] commitmentTypeIndicationField;

        private AllDataObjectsTimeStamp[] allDataObjectsTimeStampField;

        private IndividualDataObjectsTimeStamp[] individualDataObjectsTimeStampField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataObjectFormat")]
        public DataObjectFormat[] DataObjectFormat
        {
            get
            {
                return this.dataObjectFormatField;
            }
            set
            {
                this.dataObjectFormatField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommitmentTypeIndication")]
        public CommitmentTypeIndication[] CommitmentTypeIndication
        {
            get
            {
                return this.commitmentTypeIndicationField;
            }
            set
            {
                this.commitmentTypeIndicationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllDataObjectsTimeStamp")]
        public AllDataObjectsTimeStamp[] AllDataObjectsTimeStamp
        {
            get
            {
                return this.allDataObjectsTimeStampField;
            }
            set
            {
                this.allDataObjectsTimeStampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IndividualDataObjectsTimeStamp")]
        public IndividualDataObjectsTimeStamp[] IndividualDataObjectsTimeStamp
        {
            get
            {
                return this.individualDataObjectsTimeStampField;
            }
            set
            {
                this.individualDataObjectsTimeStampField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class DataObjectFormat
    {

        private string descriptionField;

        private ObjectIdentifier objectIdentifierField;

        private string mimeTypeField;

        private string encodingField;

        private string objectReferenceField;

        /// <remarks/>
        public string Description
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
        public ObjectIdentifier ObjectIdentifier
        {
            get
            {
                return this.objectIdentifierField;
            }
            set
            {
                this.objectIdentifierField = value;
            }
        }

        /// <remarks/>
        public string MimeType
        {
            get
            {
                return this.mimeTypeField;
            }
            set
            {
                this.mimeTypeField = value;
            }
        }

        /// <remarks/>
        public string Encoding
        {
            get
            {
                return this.encodingField;
            }
            set
            {
                this.encodingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail")]
        public string ObjectReference
        {
            get
            {
                return this.objectReferenceField;
            }
            set
            {
                this.objectReferenceField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class ObjectIdentifier
    {

        private Identifier identifierField;

        private string descriptionField;

        private DocumentationReferences documentationReferencesField;

        /// <remarks/>
        public Identifier Identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }

        /// <remarks/>
        public string Description
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
        public DocumentationReferences DocumentationReferences
        {
            get
            {
                return this.documentationReferencesField;
            }
            set
            {
                this.documentationReferencesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class CommitmentTypeIndication
    {

        private CommitmentTypeId commitmentTypeIdField;

        private object[] itemsField;

        private string[] commitmentTypeQualifiersField;

        /// <remarks/>
        public CommitmentTypeId CommitmentTypeId
        {
            get
            {
                return this.commitmentTypeIdField;
            }
            set
            {
                this.commitmentTypeIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AllSignedDataObjects", typeof(AllSignedDataObjects))]
        [System.Xml.Serialization.XmlElementAttribute("ObjectReference", typeof(string))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CommitmentTypeQualifier", IsNullable = false)]
        public string[] CommitmentTypeQualifiers
        {
            get
            {
                return this.commitmentTypeQualifiersField;
            }
            set
            {
                this.commitmentTypeQualifiersField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class CommitmentTypeId
    {

        private Identifier identifierField;

        private string descriptionField;

        private DocumentationReferences documentationReferencesField;

        /// <remarks/>
        public Identifier Identifier
        {
            get
            {
                return this.identifierField;
            }
            set
            {
                this.identifierField = value;
            }
        }

        /// <remarks/>
        public string Description
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
        public DocumentationReferences DocumentationReferences
        {
            get
            {
                return this.documentationReferencesField;
            }
            set
            {
                this.documentationReferencesField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class AllSignedDataObjects
    {

        private System.Xml.XmlNode[] anyField;

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlNode[] Any
        {
            get
            {
                return this.anyField;
            }
            set
            {
                this.anyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class AllDataObjectsTimeStamp
    {

        private CanonicalizationMethod canonicalizationMethodField;

        private object[] itemsField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "uri:ds")]
        public CanonicalizationMethod CanonicalizationMethod
        {
            get
            {
                return this.canonicalizationMethodField;
            }
            set
            {
                this.canonicalizationMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EncapsulatedTimeStamp", typeof(EncapsulatedTimeStamp))]
        [System.Xml.Serialization.XmlElementAttribute("XMLTimeStamp", typeof(string))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class EncapsulatedTimeStamp
    {

        private string idField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class IndividualDataObjectsTimeStamp
    {

        private Include[] includeField;

        private CanonicalizationMethod canonicalizationMethodField;

        private object[] itemsField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Include")]
        public Include[] Include
        {
            get
            {
                return this.includeField;
            }
            set
            {
                this.includeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "uri:ds")]
        public CanonicalizationMethod CanonicalizationMethod
        {
            get
            {
                return this.canonicalizationMethodField;
            }
            set
            {
                this.canonicalizationMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EncapsulatedTimeStamp", typeof(EncapsulatedTimeStamp))]
        [System.Xml.Serialization.XmlElementAttribute("XMLTimeStamp", typeof(string))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class Include
    {

        private string uRIField;

        private string referencedDataField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail")]
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail")]
        public string referencedData
        {
            get
            {
                return this.referencedDataField;
            }
            set
            {
                this.referencedDataField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class UnsignedProperties
    {

        private UnsignedSignatureProperties unsignedSignaturePropertiesField;

        private UnsignedDataObjectProperties unsignedDataObjectPropertiesField;

        private string idField;

        /// <remarks/>
        public UnsignedSignatureProperties UnsignedSignatureProperties
        {
            get
            {
                return this.unsignedSignaturePropertiesField;
            }
            set
            {
                this.unsignedSignaturePropertiesField = value;
            }
        }

        /// <remarks/>
        public UnsignedDataObjectProperties UnsignedDataObjectProperties
        {
            get
            {
                return this.unsignedDataObjectPropertiesField;
            }
            set
            {
                this.unsignedDataObjectPropertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class UnsignedSignatureProperties
    {

        private object[] itemsField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ArchiveTimeStamp", typeof(ArchiveTimeStamp))]
        [System.Xml.Serialization.XmlElementAttribute("AttrAuthoritiesCertValues", typeof(AttrAuthoritiesCertValues))]
        [System.Xml.Serialization.XmlElementAttribute("AttributeCertificateRefs", typeof(AttributeCertificateRefs))]
        [System.Xml.Serialization.XmlElementAttribute("AttributeRevocationRefs", typeof(AttributeRevocationRefs))]
        [System.Xml.Serialization.XmlElementAttribute("AttributeRevocationValues", typeof(AttributeRevocationValues))]
        [System.Xml.Serialization.XmlElementAttribute("CertificateValues", typeof(CertificateValues))]
        [System.Xml.Serialization.XmlElementAttribute("CompleteCertificateRefs", typeof(CompleteCertificateRefs))]
        [System.Xml.Serialization.XmlElementAttribute("CompleteRevocationRefs", typeof(CompleteRevocationRefs))]
        [System.Xml.Serialization.XmlElementAttribute("CounterSignature", typeof(CounterSignature))]
        [System.Xml.Serialization.XmlElementAttribute("RefsOnlyTimeStamp", typeof(RefsOnlyTimeStamp))]
        [System.Xml.Serialization.XmlElementAttribute("RevocationValues", typeof(RevocationValues))]
        [System.Xml.Serialization.XmlElementAttribute("SigAndRefsTimeStamp", typeof(SigAndRefsTimeStamp))]
        [System.Xml.Serialization.XmlElementAttribute("SignatureTimeStamp", typeof(SignatureTimeStamp))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class ArchiveTimeStamp
    {

        private Include[] includeField;

        private CanonicalizationMethod canonicalizationMethodField;

        private object[] itemsField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Include")]
        public Include[] Include
        {
            get
            {
                return this.includeField;
            }
            set
            {
                this.includeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "uri:ds")]
        public CanonicalizationMethod CanonicalizationMethod
        {
            get
            {
                return this.canonicalizationMethodField;
            }
            set
            {
                this.canonicalizationMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EncapsulatedTimeStamp", typeof(EncapsulatedTimeStamp))]
        [System.Xml.Serialization.XmlElementAttribute("XMLTimeStamp", typeof(string))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class AttrAuthoritiesCertValues
    {

        private object[] itemsField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EncapsulatedX509Certificate", typeof(EncapsulatedX509Certificate))]
        [System.Xml.Serialization.XmlElementAttribute("OtherCertificate", typeof(string))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class EncapsulatedX509Certificate
    {

        private string idField;

        private string encodingField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail")]
        public string Encoding
        {
            get
            {
                return this.encodingField;
            }
            set
            {
                this.encodingField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class AttributeCertificateRefs
    {

        private Cert[] certRefsField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Cert", IsNullable = false)]
        public Cert[] CertRefs
        {
            get
            {
                return this.certRefsField;
            }
            set
            {
                this.certRefsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class AttributeRevocationRefs
    {

        private CRLRef[] cRLRefsField;

        private OCSPRef[] oCSPRefsField;

        private string[] otherRefsField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CRLRef", IsNullable = false)]
        public CRLRef[] CRLRefs
        {
            get
            {
                return this.cRLRefsField;
            }
            set
            {
                this.cRLRefsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OCSPRef", IsNullable = false)]
        public OCSPRef[] OCSPRefs
        {
            get
            {
                return this.oCSPRefsField;
            }
            set
            {
                this.oCSPRefsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OtherRef", IsNullable = false)]
        public string[] OtherRefs
        {
            get
            {
                return this.otherRefsField;
            }
            set
            {
                this.otherRefsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class CRLRef
    {

        private DigestAlgAndValue digestAlgAndValueField;

        private CRLIdentifier cRLIdentifierField;

        /// <remarks/>
        public DigestAlgAndValue DigestAlgAndValue
        {
            get
            {
                return this.digestAlgAndValueField;
            }
            set
            {
                this.digestAlgAndValueField = value;
            }
        }

        /// <remarks/>
        public CRLIdentifier CRLIdentifier
        {
            get
            {
                return this.cRLIdentifierField;
            }
            set
            {
                this.cRLIdentifierField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class DigestAlgAndValue
    {

        private DigestMethod digestMethodField;

        private string digestValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "uri:ds")]
        public DigestMethod DigestMethod
        {
            get
            {
                return this.digestMethodField;
            }
            set
            {
                this.digestMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "uri:ds")]
        public string DigestValue
        {
            get
            {
                return this.digestValueField;
            }
            set
            {
                this.digestValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class CRLIdentifier
    {

        private string issuerField;

        private string issueTimeField;

        private string numberField;

        private string uRIField;

        /// <remarks/>
        public string Issuer
        {
            get
            {
                return this.issuerField;
            }
            set
            {
                this.issuerField = value;
            }
        }

        /// <remarks/>
        public string IssueTime
        {
            get
            {
                return this.issueTimeField;
            }
            set
            {
                this.issueTimeField = value;
            }
        }

        /// <remarks/>
        public string Number
        {
            get
            {
                return this.numberField;
            }
            set
            {
                this.numberField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail")]
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class OCSPRef
    {

        private OCSPIdentifier oCSPIdentifierField;

        private DigestAlgAndValue digestAlgAndValueField;

        /// <remarks/>
        public OCSPIdentifier OCSPIdentifier
        {
            get
            {
                return this.oCSPIdentifierField;
            }
            set
            {
                this.oCSPIdentifierField = value;
            }
        }

        /// <remarks/>
        public DigestAlgAndValue DigestAlgAndValue
        {
            get
            {
                return this.digestAlgAndValueField;
            }
            set
            {
                this.digestAlgAndValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class OCSPIdentifier
    {

        private ResponderID responderIDField;

        private string producedAtField;

        private string uRIField;

        /// <remarks/>
        public ResponderID ResponderID
        {
            get
            {
                return this.responderIDField;
            }
            set
            {
                this.responderIDField = value;
            }
        }

        /// <remarks/>
        public string ProducedAt
        {
            get
            {
                return this.producedAtField;
            }
            set
            {
                this.producedAtField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail")]
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class ResponderID
    {

        private string itemField;

        private ItemChoiceType itemElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ByKey", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ByName", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public string Item
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
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName
        {
            get
            {
                return this.itemElementNameField;
            }
            set
            {
                this.itemElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "uri:xades", IncludeInSchema = false)]
    public enum ItemChoiceType
    {

        /// <remarks/>
        ByKey,

        /// <remarks/>
        ByName,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class AttributeRevocationValues
    {

        private EncapsulatedCRLValue[] cRLValuesField;

        private EncapsulatedOCSPValue[] oCSPValuesField;

        private string[] otherValuesField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("EncapsulatedCRLValue", IsNullable = false)]
        public EncapsulatedCRLValue[] CRLValues
        {
            get
            {
                return this.cRLValuesField;
            }
            set
            {
                this.cRLValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("EncapsulatedOCSPValue", IsNullable = false)]
        public EncapsulatedOCSPValue[] OCSPValues
        {
            get
            {
                return this.oCSPValuesField;
            }
            set
            {
                this.oCSPValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OtherValue", IsNullable = false)]
        public string[] OtherValues
        {
            get
            {
                return this.otherValuesField;
            }
            set
            {
                this.otherValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class EncapsulatedCRLValue
    {

        private string idField;

        private string encodingField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail")]
        public string Encoding
        {
            get
            {
                return this.encodingField;
            }
            set
            {
                this.encodingField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class EncapsulatedOCSPValue
    {

        private string idField;

        private string encodingField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail")]
        public string Encoding
        {
            get
            {
                return this.encodingField;
            }
            set
            {
                this.encodingField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class CertificateValues
    {

        private object[] itemsField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EncapsulatedX509Certificate", typeof(EncapsulatedX509Certificate))]
        [System.Xml.Serialization.XmlElementAttribute("OtherCertificate", typeof(string))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class CompleteCertificateRefs
    {

        private Cert[] certRefsField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Cert", IsNullable = false)]
        public Cert[] CertRefs
        {
            get
            {
                return this.certRefsField;
            }
            set
            {
                this.certRefsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class CompleteRevocationRefs
    {

        private CRLRef[] cRLRefsField;

        private OCSPRef[] oCSPRefsField;

        private string[] otherRefsField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("CRLRef", IsNullable = false)]
        public CRLRef[] CRLRefs
        {
            get
            {
                return this.cRLRefsField;
            }
            set
            {
                this.cRLRefsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OCSPRef", IsNullable = false)]
        public OCSPRef[] OCSPRefs
        {
            get
            {
                return this.oCSPRefsField;
            }
            set
            {
                this.oCSPRefsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OtherRef", IsNullable = false)]
        public string[] OtherRefs
        {
            get
            {
                return this.otherRefsField;
            }
            set
            {
                this.otherRefsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class CounterSignature
    {

        private Signature signatureField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "uri:ds")]
        public Signature Signature
        {
            get
            {
                return this.signatureField;
            }
            set
            {
                this.signatureField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class RefsOnlyTimeStamp
    {

        private Include[] includeField;

        private CanonicalizationMethod canonicalizationMethodField;

        private object[] itemsField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Include")]
        public Include[] Include
        {
            get
            {
                return this.includeField;
            }
            set
            {
                this.includeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "uri:ds")]
        public CanonicalizationMethod CanonicalizationMethod
        {
            get
            {
                return this.canonicalizationMethodField;
            }
            set
            {
                this.canonicalizationMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EncapsulatedTimeStamp", typeof(EncapsulatedTimeStamp))]
        [System.Xml.Serialization.XmlElementAttribute("XMLTimeStamp", typeof(string))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class RevocationValues
    {

        private EncapsulatedCRLValue[] cRLValuesField;

        private EncapsulatedOCSPValue[] oCSPValuesField;

        private string[] otherValuesField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("EncapsulatedCRLValue", IsNullable = false)]
        public EncapsulatedCRLValue[] CRLValues
        {
            get
            {
                return this.cRLValuesField;
            }
            set
            {
                this.cRLValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("EncapsulatedOCSPValue", IsNullable = false)]
        public EncapsulatedOCSPValue[] OCSPValues
        {
            get
            {
                return this.oCSPValuesField;
            }
            set
            {
                this.oCSPValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OtherValue", IsNullable = false)]
        public string[] OtherValues
        {
            get
            {
                return this.otherValuesField;
            }
            set
            {
                this.otherValuesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class SigAndRefsTimeStamp
    {

        private Include[] includeField;

        private CanonicalizationMethod canonicalizationMethodField;

        private object[] itemsField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Include")]
        public Include[] Include
        {
            get
            {
                return this.includeField;
            }
            set
            {
                this.includeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "uri:ds")]
        public CanonicalizationMethod CanonicalizationMethod
        {
            get
            {
                return this.canonicalizationMethodField;
            }
            set
            {
                this.canonicalizationMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EncapsulatedTimeStamp", typeof(EncapsulatedTimeStamp))]
        [System.Xml.Serialization.XmlElementAttribute("XMLTimeStamp", typeof(string))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class SignatureTimeStamp
    {

        private CanonicalizationMethod canonicalizationMethodField;

        private object[] itemsField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "uri:ds")]
        public CanonicalizationMethod CanonicalizationMethod
        {
            get
            {
                return this.canonicalizationMethodField;
            }
            set
            {
                this.canonicalizationMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EncapsulatedTimeStamp", typeof(EncapsulatedTimeStamp))]
        [System.Xml.Serialization.XmlElementAttribute("XMLTimeStamp", typeof(string))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class UnsignedDataObjectProperties
    {

        private string[] unsignedDataObjectPropertyField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UnsignedDataObjectProperty")]
        public string[] UnsignedDataObjectProperty
        {
            get
            {
                return this.unsignedDataObjectPropertyField;
            }
            set
            {
                this.unsignedDataObjectPropertyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum cXMLSignatureVersion
    {

        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("1.0")]
        Item10,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    public enum CopyRequestProcessingMode
    {

        /// <remarks/>
        info,

        /// <remarks/>
        process,

        /// <remarks/>
        copy,
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class TermsOfTransport
    {

        private string sealIDField;

        private string sealingPartyCodeField;

        private string equipmentIdentificationCodeField;

        private TransportTerms transportTermsField;

        private Dimension[] dimensionField;

        private Extrinsic[] extrinsicField;

        /// <remarks/>
        public string SealID
        {
            get
            {
                return this.sealIDField;
            }
            set
            {
                this.sealIDField = value;
            }
        }

        /// <remarks/>
        public string SealingPartyCode
        {
            get
            {
                return this.sealingPartyCodeField;
            }
            set
            {
                this.sealingPartyCodeField = value;
            }
        }

        /// <remarks/>
        public string EquipmentIdentificationCode
        {
            get
            {
                return this.equipmentIdentificationCodeField;
            }
            set
            {
                this.equipmentIdentificationCodeField = value;
            }
        }

        /// <remarks/>
        public TransportTerms TransportTerms
        {
            get
            {
                return this.transportTermsField;
            }
            set
            {
                this.transportTermsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Dimension")]
        public Dimension[] Dimension
        {
            get
            {
                return this.dimensionField;
            }
            set
            {
                this.dimensionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Extrinsic")]
        public Extrinsic[] Extrinsic
        {
            get
            {
                return this.extrinsicField;
            }
            set
            {
                this.extrinsicField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ExpiryDate
    {

        private string dateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string date
        {
            get
            {
                return this.dateField;
            }
            set
            {
                this.dateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class ItemInfo
    {

        private ItemID itemIDField;

        private Description descriptionField;

        private Classification[] classificationField;

        private string manufacturerPartIDField;

        private ManufacturerName manufacturerNameField;

        private Country countryField;

        private string supplierBatchIDField;

        private ReferenceDocumentInfo[] referenceDocumentInfoField;

        private string unitOfMeasureField;

        private Extrinsic[] extrinsicField;

        private string quantityField;

        /// <remarks/>
        public ItemID ItemID
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

        /// <remarks/>
        public Description Description
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
        [System.Xml.Serialization.XmlElementAttribute("Classification")]
        public Classification[] Classification
        {
            get
            {
                return this.classificationField;
            }
            set
            {
                this.classificationField = value;
            }
        }

        /// <remarks/>
        public string ManufacturerPartID
        {
            get
            {
                return this.manufacturerPartIDField;
            }
            set
            {
                this.manufacturerPartIDField = value;
            }
        }

        /// <remarks/>
        public ManufacturerName ManufacturerName
        {
            get
            {
                return this.manufacturerNameField;
            }
            set
            {
                this.manufacturerNameField = value;
            }
        }

        /// <remarks/>
        public Country Country
        {
            get
            {
                return this.countryField;
            }
            set
            {
                this.countryField = value;
            }
        }

        /// <remarks/>
        public string SupplierBatchID
        {
            get
            {
                return this.supplierBatchIDField;
            }
            set
            {
                this.supplierBatchIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReferenceDocumentInfo")]
        public ReferenceDocumentInfo[] ReferenceDocumentInfo
        {
            get
            {
                return this.referenceDocumentInfoField;
            }
            set
            {
                this.referenceDocumentInfoField = value;
            }
        }

        /// <remarks/>
        public string UnitOfMeasure
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
        [System.Xml.Serialization.XmlElementAttribute("Extrinsic")]
        public Extrinsic[] Extrinsic
        {
            get
            {
                return this.extrinsicField;
            }
            set
            {
                this.extrinsicField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string quantity
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class FixedAmount
    {

        private Money moneyField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class FeeAmount
    {

        private Money moneyField;

        private Fee[] feeField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Fee")]
        public Fee[] Fee
        {
            get
            {
                return this.feeField;
            }
            set
            {
                this.feeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Fee
    {

        private Money moneyField;

        private string typeField;

        /// <remarks/>
        public Money Money
        {
            get
            {
                return this.moneyField;
            }
            set
            {
                this.moneyField = value;
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class OrderInfo
    {

        private object itemField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OrderIDInfo", typeof(OrderIDInfo))]
        [System.Xml.Serialization.XmlElementAttribute("OrderReference", typeof(OrderReference))]
        public object Item
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
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceReference
    {

        private DocumentReference documentReferenceField;

        private string invoiceIDField;

        private string invoiceDateField;

        /// <remarks/>
        public DocumentReference DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string invoiceID
        {
            get
            {
                return this.invoiceIDField;
            }
            set
            {
                this.invoiceIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string invoiceDate
        {
            get
            {
                return this.invoiceDateField;
            }
            set
            {
                this.invoiceDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class TransportReference
    {

        private DocumentReference documentReferenceField;

        private string requestIDField;

        private string requestDateField;

        /// <remarks/>
        public DocumentReference DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string requestID
        {
            get
            {
                return this.requestIDField;
            }
            set
            {
                this.requestIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string requestDate
        {
            get
            {
                return this.requestDateField;
            }
            set
            {
                this.requestDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class TransportIDInfo
    {

        private IdReference[] idReferenceField;

        private string requestIDField;

        private string requestDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IdReference")]
        public IdReference[] IdReference
        {
            get
            {
                return this.idReferenceField;
            }
            set
            {
                this.idReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string requestID
        {
            get
            {
                return this.requestIDField;
            }
            set
            {
                this.requestIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string requestDate
        {
            get
            {
                return this.requestDateField;
            }
            set
            {
                this.requestDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class OrderStatusRequestReference
    {

        private DocumentReference documentReferenceField;

        private string orderStatusRequestIDField;

        private string orderStatusRequestDateField;

        /// <remarks/>
        public DocumentReference DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderStatusRequestID
        {
            get
            {
                return this.orderStatusRequestIDField;
            }
            set
            {
                this.orderStatusRequestIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderStatusRequestDate
        {
            get
            {
                return this.orderStatusRequestDateField;
            }
            set
            {
                this.orderStatusRequestDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class OrderStatusRequestIDInfo
    {

        private string orderStatusRequestIDField;

        private string orderStatusRequestDateField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderStatusRequestID
        {
            get
            {
                return this.orderStatusRequestIDField;
            }
            set
            {
                this.orderStatusRequestIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string orderStatusRequestDate
        {
            get
            {
                return this.orderStatusRequestDateField;
            }
            set
            {
                this.orderStatusRequestDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class QualityInspectionRequestReference
    {

        private DocumentReference documentReferenceField;

        private string inspectionIDField;

        private string inspectionDateField;

        /// <remarks/>
        public DocumentReference DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inspectionID
        {
            get
            {
                return this.inspectionIDField;
            }
            set
            {
                this.inspectionIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inspectionDate
        {
            get
            {
                return this.inspectionDateField;
            }
            set
            {
                this.inspectionDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class QualityInspectionResultReference
    {

        private DocumentReference documentReferenceField;

        private string inspectionIDField;

        private string inspectionDateField;

        /// <remarks/>
        public DocumentReference DocumentReference
        {
            get
            {
                return this.documentReferenceField;
            }
            set
            {
                this.documentReferenceField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inspectionID
        {
            get
            {
                return this.inspectionIDField;
            }
            set
            {
                this.inspectionIDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string inspectionDate
        {
            get
            {
                return this.inspectionDateField;
            }
            set
            {
                this.inspectionDateField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceItemModifications
    {

        private Modification[] modificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Modification")]
        public Modification[] Modification
        {
            get
            {
                return this.modificationField;
            }
            set
            {
                this.modificationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceHeaderModifications
    {

        private Modification[] modificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Modification")]
        public Modification[] Modification
        {
            get
            {
                return this.modificationField;
            }
            set
            {
                this.modificationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class InvoiceDetailSummaryLineItemModifications
    {

        private Modification[] modificationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Modification")]
        public Modification[] Modification
        {
            get
            {
                return this.modificationField;
            }
            set
            {
                this.modificationField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://tempuri.org/InvoiceDetail")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://tempuri.org/InvoiceDetail", IsNullable = false)]
    public partial class Path
    {

        private Node[] nodeField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Node")]
        public Node[] Node
        {
            get
            {
                return this.nodeField;
            }
            set
            {
                this.nodeField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class EncapsulatedPKIData
    {

        private string idField;

        private string encodingField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail")]
        public string Encoding
        {
            get
            {
                return this.encodingField;
            }
            set
            {
                this.encodingField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class ReferenceInfo
    {

        private DigestMethod digestMethodField;

        private string digestValueField;

        private string idField;

        private string uRIField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "uri:ds")]
        public DigestMethod DigestMethod
        {
            get
            {
                return this.digestMethodField;
            }
            set
            {
                this.digestMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "uri:ds")]
        public string DigestValue
        {
            get
            {
                return this.digestValueField;
            }
            set
            {
                this.digestValueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail")]
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class XAdESTimeStamp
    {

        private Include[] includeField;

        private CanonicalizationMethod canonicalizationMethodField;

        private object[] itemsField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Include")]
        public Include[] Include
        {
            get
            {
                return this.includeField;
            }
            set
            {
                this.includeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "uri:ds")]
        public CanonicalizationMethod CanonicalizationMethod
        {
            get
            {
                return this.canonicalizationMethodField;
            }
            set
            {
                this.canonicalizationMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EncapsulatedTimeStamp", typeof(EncapsulatedTimeStamp))]
        [System.Xml.Serialization.XmlElementAttribute("XMLTimeStamp", typeof(string))]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class OtherTimeStamp
    {

        private ReferenceInfo[] referenceInfoField;

        private CanonicalizationMethod canonicalizationMethodField;

        private object itemField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ReferenceInfo")]
        public ReferenceInfo[] ReferenceInfo
        {
            get
            {
                return this.referenceInfoField;
            }
            set
            {
                this.referenceInfoField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Namespace = "uri:ds")]
        public CanonicalizationMethod CanonicalizationMethod
        {
            get
            {
                return this.canonicalizationMethodField;
            }
            set
            {
                this.canonicalizationMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EncapsulatedTimeStamp", typeof(EncapsulatedTimeStamp))]
        [System.Xml.Serialization.XmlElementAttribute("XMLTimeStamp", typeof(string))]
        public object Item
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
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class QualifyingPropertiesReference
    {

        private string uRIField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail")]
        public string URI
        {
            get
            {
                return this.uRIField;
            }
            set
            {
                this.uRIField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://tempuri.org/InvoiceDetail", DataType = "ID")]
        public string Id
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class SigningCertificate
    {

        private Cert[] certField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cert")]
        public Cert[] Cert
        {
            get
            {
                return this.certField;
            }
            set
            {
                this.certField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class SigPolicyQualifiers
    {

        private SigPolicyQualifier[] sigPolicyQualifierField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SigPolicyQualifier")]
        public SigPolicyQualifier[] SigPolicyQualifier
        {
            get
            {
                return this.sigPolicyQualifierField;
            }
            set
            {
                this.sigPolicyQualifierField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class SPUserNotice
    {

        private NoticeRef noticeRefField;

        private string explicitTextField;

        /// <remarks/>
        public NoticeRef NoticeRef
        {
            get
            {
                return this.noticeRefField;
            }
            set
            {
                this.noticeRefField = value;
            }
        }

        /// <remarks/>
        public string ExplicitText
        {
            get
            {
                return this.explicitTextField;
            }
            set
            {
                this.explicitTextField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class NoticeRef
    {

        private string organizationField;

        private string[] noticeNumbersField;

        /// <remarks/>
        public string Organization
        {
            get
            {
                return this.organizationField;
            }
            set
            {
                this.organizationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("int", IsNullable = false)]
        public string[] NoticeNumbers
        {
            get
            {
                return this.noticeNumbersField;
            }
            set
            {
                this.noticeNumbersField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class NoticeNumbers
    {

        private string[] intField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("int")]
        public string[] @int
        {
            get
            {
                return this.intField;
            }
            set
            {
                this.intField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class CommitmentTypeQualifiers
    {

        private string[] commitmentTypeQualifierField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CommitmentTypeQualifier")]
        public string[] CommitmentTypeQualifier
        {
            get
            {
                return this.commitmentTypeQualifierField;
            }
            set
            {
                this.commitmentTypeQualifierField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class ClaimedRoles
    {

        private string[] claimedRoleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ClaimedRole")]
        public string[] ClaimedRole
        {
            get
            {
                return this.claimedRoleField;
            }
            set
            {
                this.claimedRoleField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class CertifiedRoles
    {

        private CertifiedRole[] certifiedRoleField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CertifiedRole")]
        public CertifiedRole[] CertifiedRole
        {
            get
            {
                return this.certifiedRoleField;
            }
            set
            {
                this.certifiedRoleField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class CertRefs
    {

        private Cert[] certField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Cert")]
        public Cert[] Cert
        {
            get
            {
                return this.certField;
            }
            set
            {
                this.certField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class CRLRefs
    {

        private CRLRef[] cRLRefField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CRLRef")]
        public CRLRef[] CRLRef
        {
            get
            {
                return this.cRLRefField;
            }
            set
            {
                this.cRLRefField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class OCSPRefs
    {

        private OCSPRef[] oCSPRefField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OCSPRef")]
        public OCSPRef[] OCSPRef
        {
            get
            {
                return this.oCSPRefField;
            }
            set
            {
                this.oCSPRefField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class OtherRefs
    {

        private string[] otherRefField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherRef")]
        public string[] OtherRef
        {
            get
            {
                return this.otherRefField;
            }
            set
            {
                this.otherRefField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class CRLValues
    {

        private EncapsulatedCRLValue[] encapsulatedCRLValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EncapsulatedCRLValue")]
        public EncapsulatedCRLValue[] EncapsulatedCRLValue
        {
            get
            {
                return this.encapsulatedCRLValueField;
            }
            set
            {
                this.encapsulatedCRLValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class OCSPValues
    {

        private EncapsulatedOCSPValue[] encapsulatedOCSPValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EncapsulatedOCSPValue")]
        public EncapsulatedOCSPValue[] EncapsulatedOCSPValue
        {
            get
            {
                return this.encapsulatedOCSPValueField;
            }
            set
            {
                this.encapsulatedOCSPValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:xades")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:xades", IsNullable = false)]
    public partial class OtherValues
    {

        private string[] otherValueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherValue")]
        public string[] OtherValue
        {
            get
            {
                return this.otherValueField;
            }
            set
            {
                this.otherValueField = value;
            }
        }
    }

    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "uri:ds")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "uri:ds", IsNullable = false)]
    public partial class Transforms
    {

        private Transform[] transformField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Transform")]
        public Transform[] Transform
        {
            get
            {
                return this.transformField;
            }
            set
            {
                this.transformField = value;
            }
        }
    }
    */
}