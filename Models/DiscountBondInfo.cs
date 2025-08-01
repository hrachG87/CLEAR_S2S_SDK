using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("DiscountBondInfo")]
public class DiscountBondInfo
{
    [XmlElement("Bond")]
    public Bond Bond { get; set; }

    [XmlElement("BondActivityCode")]
    public string BondActivityCode { get; set; }

    [XmlElement("BondActivityDate")]
    public string BondActivityDate { get; set; }

    [XmlElement("BondCaseNumber")]
    public string BondCaseNumber { get; set; }

    [XmlElement("BondCancelDate")]
    public string BondCancelDate { get; set; }

}