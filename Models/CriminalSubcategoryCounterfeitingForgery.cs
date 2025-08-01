using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalSubcategoryCounterfeitingForgery")]
public class CriminalSubcategoryCounterfeitingForgery
{
    [XmlElement("PossesionToolsCounterfeitForgery")]
    public CriminalChargetypes PossesionToolsCounterfeitForgery { get; set; }

    [XmlElement("TransportToolsCounterfeitForgery")]
    public CriminalChargetypes TransportToolsCounterfeitForgery { get; set; }

    [XmlElement("FalseIdDocuments")]
    public CriminalChargetypes FalseIdDocuments { get; set; }

    [XmlElement("ProvidingIdCounterfeitForgery")]
    public CriminalChargetypes ProvidingIdCounterfeitForgery { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
