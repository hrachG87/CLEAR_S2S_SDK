using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalSubcategoryForgery")]
public class CriminalSubcategoryForgery
{
    [XmlElement("ForgeryOfChecks")]
    public CriminalChargetypes ForgeryOfChecks { get; set; }

    [XmlElement("Forgery")]
    public CriminalChargetypes Forgery { get; set; }

    [XmlElement("PassingForgedDocs")]
    public CriminalChargetypes PassingForgedDocs { get; set; }

    [XmlElement("PossessionForged")]
    public CriminalChargetypes PossessionForged { get; set; }

    [XmlElement("TransportForged")]
    public CriminalChargetypes TransportForged { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
