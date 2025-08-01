using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BondInfo")]
public class BondInfo
{
    [XmlElement("Bond")]
    public Bond Bond { get; set; }

    [XmlElement("BondAmount")]
    public string BondAmount { get; set; }

    [XmlElement("BondTypeCode")]
    public string BondTypeCode { get; set; }

}