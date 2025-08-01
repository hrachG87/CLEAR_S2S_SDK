using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalCategoryCounterfeitingForgery")]
public class CriminalCategoryCounterfeitingForgery
{
    [XmlElement("Counterfeiting")]
    public CriminalSubcategoryCounterfeiting Counterfeiting { get; set; }

    [XmlElement("Forgery")]
    public CriminalSubcategoryForgery Forgery { get; set; }

    [XmlElement("CounterfeitingForgery")]
    public CriminalSubcategoryCounterfeitingForgery CounterfeitingForgery { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}