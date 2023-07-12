
// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.demandware.com/xml/impex/catalog/2006-10-31")]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "http://www.demandware.com/xml/impex/catalog/2006-10-31", IsNullable = false)]
public partial class catalog
{

    private catalogHeader headerField;

    private catalogProduct[] productField;

    private string catalogidField;

    /// <remarks/>
    public catalogHeader header
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
    [System.Xml.Serialization.XmlElementAttribute("product")]
    public catalogProduct[] product
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
    [System.Xml.Serialization.XmlAttributeAttribute("catalog-id")]
    public string catalogid
    {
        get
        {
            return this.catalogidField;
        }
        set
        {
            this.catalogidField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.demandware.com/xml/impex/catalog/2006-10-31")]
public partial class catalogHeader
{

    private catalogHeaderImagesettings imagesettingsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("image-settings")]
    public catalogHeaderImagesettings imagesettings
    {
        get
        {
            return this.imagesettingsField;
        }
        set
        {
            this.imagesettingsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.demandware.com/xml/impex/catalog/2006-10-31")]
public partial class catalogHeaderImagesettings
{

    private catalogHeaderImagesettingsInternallocation internallocationField;

    private string[] viewtypesField;

    private string variationattributeidField;

    private string altpatternField;

    private string titlepatternField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("internal-location")]
    public catalogHeaderImagesettingsInternallocation internallocation
    {
        get
        {
            return this.internallocationField;
        }
        set
        {
            this.internallocationField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute("view-types")]
    [System.Xml.Serialization.XmlArrayItemAttribute("view-type", IsNullable = false)]
    public string[] viewtypes
    {
        get
        {
            return this.viewtypesField;
        }
        set
        {
            this.viewtypesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("variation-attribute-id")]
    public string variationattributeid
    {
        get
        {
            return this.variationattributeidField;
        }
        set
        {
            this.variationattributeidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("alt-pattern")]
    public string altpattern
    {
        get
        {
            return this.altpatternField;
        }
        set
        {
            this.altpatternField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("title-pattern")]
    public string titlepattern
    {
        get
        {
            return this.titlepatternField;
        }
        set
        {
            this.titlepatternField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.demandware.com/xml/impex/catalog/2006-10-31")]
public partial class catalogHeaderImagesettingsInternallocation
{

    private string basepathField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("base-path")]
    public string basepath
    {
        get
        {
            return this.basepathField;
        }
        set
        {
            this.basepathField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.demandware.com/xml/impex/catalog/2006-10-31")]
public partial class catalogProduct
{

    private object eanField;

    private object upcField;

    private object unitField;

    private byte minorderquantityField;

    private byte stepquantityField;

    private catalogProductDisplayname displaynameField;

    private string shortdescriptionField;

    private string longdescriptionField;

    private bool onlineflagField;

    private System.DateTime onlinefromField;

    private System.DateTime onlinetoField;

    private bool searchableflagField;

    private bool searchableifunavailableflagField;

    private catalogProductImagegroup[] imagesField;

    private string taxclassidField;

    private string brandField;

    private object pageattributesField;

    private catalogProductCustomattribute[] customattributesField;

    private catalogProductVariations variationsField;

    private string productidField;

    /// <remarks/>
    public object ean
    {
        get
        {
            return this.eanField;
        }
        set
        {
            this.eanField = value;
        }
    }

    /// <remarks/>
    public object upc
    {
        get
        {
            return this.upcField;
        }
        set
        {
            this.upcField = value;
        }
    }

    /// <remarks/>
    public object unit
    {
        get
        {
            return this.unitField;
        }
        set
        {
            this.unitField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("min-order-quantity")]
    public byte minorderquantity
    {
        get
        {
            return this.minorderquantityField;
        }
        set
        {
            this.minorderquantityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("step-quantity")]
    public byte stepquantity
    {
        get
        {
            return this.stepquantityField;
        }
        set
        {
            this.stepquantityField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("display-name")]
    public catalogProductDisplayname displayname
    {
        get
        {
            return this.displaynameField;
        }
        set
        {
            this.displaynameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("short-description")]
    public string shortdescription
    {
        get
        {
            return this.shortdescriptionField;
        }
        set
        {
            this.shortdescriptionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("long-description")]
    public string longdescription
    {
        get
        {
            return this.longdescriptionField;
        }
        set
        {
            this.longdescriptionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("online-flag")]
    public bool onlineflag
    {
        get
        {
            return this.onlineflagField;
        }
        set
        {
            this.onlineflagField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("online-from")]
    public System.DateTime onlinefrom
    {
        get
        {
            return this.onlinefromField;
        }
        set
        {
            this.onlinefromField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("online-to")]
    public System.DateTime onlineto
    {
        get
        {
            return this.onlinetoField;
        }
        set
        {
            this.onlinetoField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("searchable-flag")]
    public bool searchableflag
    {
        get
        {
            return this.searchableflagField;
        }
        set
        {
            this.searchableflagField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("searchable-if-unavailable-flag")]
    public bool searchableifunavailableflag
    {
        get
        {
            return this.searchableifunavailableflagField;
        }
        set
        {
            this.searchableifunavailableflagField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("image-group", IsNullable = false)]
    public catalogProductImagegroup[] images
    {
        get
        {
            return this.imagesField;
        }
        set
        {
            this.imagesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("tax-class-id")]
    public string taxclassid
    {
        get
        {
            return this.taxclassidField;
        }
        set
        {
            this.taxclassidField = value;
        }
    }

    /// <remarks/>
    public string brand
    {
        get
        {
            return this.brandField;
        }
        set
        {
            this.brandField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("page-attributes")]
    public object pageattributes
    {
        get
        {
            return this.pageattributesField;
        }
        set
        {
            this.pageattributesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute("custom-attributes")]
    [System.Xml.Serialization.XmlArrayItemAttribute("custom-attribute", IsNullable = false)]
    public catalogProductCustomattribute[] customattributes
    {
        get
        {
            return this.customattributesField;
        }
        set
        {
            this.customattributesField = value;
        }
    }

    /// <remarks/>
    public catalogProductVariations variations
    {
        get
        {
            return this.variationsField;
        }
        set
        {
            this.variationsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("product-id")]
    public string productid
    {
        get
        {
            return this.productidField;
        }
        set
        {
            this.productidField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.demandware.com/xml/impex/catalog/2006-10-31")]
public partial class catalogProductDisplayname
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
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.demandware.com/xml/impex/catalog/2006-10-31")]
public partial class catalogProductImagegroup
{

    private string viewtypeField;

    private string variationvalueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("view-type")]
    public string viewtype
    {
        get
        {
            return this.viewtypeField;
        }
        set
        {
            this.viewtypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("variation-value")]
    public string variationvalue
    {
        get
        {
            return this.variationvalueField;
        }
        set
        {
            this.variationvalueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.demandware.com/xml/impex/catalog/2006-10-31")]
public partial class catalogProductCustomattribute
{

    private string[] valueField;

    private string[] textField;

    private string attributeidField;

    private string langField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("value")]
    public string[] value
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
    [System.Xml.Serialization.XmlAttributeAttribute("attribute-id")]
    public string attributeid
    {
        get
        {
            return this.attributeidField;
        }
        set
        {
            this.attributeidField = value;
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
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.demandware.com/xml/impex/catalog/2006-10-31")]
public partial class catalogProductVariations
{

    private catalogProductVariationsVariationattribute[] attributesField;

    private catalogProductVariationsVariant[] variantsField;

    private catalogProductVariationsVariationgroups variationgroupsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("variation-attribute", IsNullable = false)]
    public catalogProductVariationsVariationattribute[] attributes
    {
        get
        {
            return this.attributesField;
        }
        set
        {
            this.attributesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("variant", IsNullable = false)]
    public catalogProductVariationsVariant[] variants
    {
        get
        {
            return this.variantsField;
        }
        set
        {
            this.variantsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("variation-groups")]
    public catalogProductVariationsVariationgroups variationgroups
    {
        get
        {
            return this.variationgroupsField;
        }
        set
        {
            this.variationgroupsField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.demandware.com/xml/impex/catalog/2006-10-31")]
public partial class catalogProductVariationsVariationattribute
{

    private string displaynameField;

    private catalogProductVariationsVariationattributeVariationattributevalue[] variationattributevaluesField;

    private string attributeidField;

    private string variationattributeidField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("display-name")]
    public string displayname
    {
        get
        {
            return this.displaynameField;
        }
        set
        {
            this.displaynameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayAttribute("variation-attribute-values")]
    [System.Xml.Serialization.XmlArrayItemAttribute("variation-attribute-value", IsNullable = false)]
    public catalogProductVariationsVariationattributeVariationattributevalue[] variationattributevalues
    {
        get
        {
            return this.variationattributevaluesField;
        }
        set
        {
            this.variationattributevaluesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("attribute-id")]
    public string attributeid
    {
        get
        {
            return this.attributeidField;
        }
        set
        {
            this.attributeidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("variation-attribute-id")]
    public string variationattributeid
    {
        get
        {
            return this.variationattributeidField;
        }
        set
        {
            this.variationattributeidField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.demandware.com/xml/impex/catalog/2006-10-31")]
public partial class catalogProductVariationsVariationattributeVariationattributevalue
{

    private string displayvalueField;

    private string descriptionField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("display-value")]
    public string displayvalue
    {
        get
        {
            return this.displayvalueField;
        }
        set
        {
            this.displayvalueField = value;
        }
    }

    /// <remarks/>
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
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.demandware.com/xml/impex/catalog/2006-10-31")]
public partial class catalogProductVariationsVariant
{

    private string productidField;

    private bool defaultField;

    private bool defaultFieldSpecified;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("product-id")]
    public string productid
    {
        get
        {
            return this.productidField;
        }
        set
        {
            this.productidField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public bool @default
    {
        get
        {
            return this.defaultField;
        }
        set
        {
            this.defaultField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool defaultSpecified
    {
        get
        {
            return this.defaultFieldSpecified;
        }
        set
        {
            this.defaultFieldSpecified = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.demandware.com/xml/impex/catalog/2006-10-31")]
public partial class catalogProductVariationsVariationgroups
{

    private catalogProductVariationsVariationgroupsVariationgroup variationgroupField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("variation-group")]
    public catalogProductVariationsVariationgroupsVariationgroup variationgroup
    {
        get
        {
            return this.variationgroupField;
        }
        set
        {
            this.variationgroupField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.demandware.com/xml/impex/catalog/2006-10-31")]
public partial class catalogProductVariationsVariationgroupsVariationgroup
{

    private uint productidField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute("product-id")]
    public uint productid
    {
        get
        {
            return this.productidField;
        }
        set
        {
            this.productidField = value;
        }
    }
}

