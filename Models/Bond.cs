using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("Bond")]
public class Bond
{
    [XmlElement("BondActiveDate")]
    public string BondActiveDate { get; set; }

    [XmlElement("BondEffectiveDate")]
    public string BondEffectiveDate { get; set; }

    [XmlElement("BondNumber")]
    public string BondNumber { get; set; }

    [XmlElement("InsuranceID")]
    public string InsuranceID { get; set; }
}
