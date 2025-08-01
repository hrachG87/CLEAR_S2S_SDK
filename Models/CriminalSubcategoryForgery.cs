using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
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
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}
}