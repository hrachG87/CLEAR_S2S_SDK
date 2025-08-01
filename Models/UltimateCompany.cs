using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("UltimateCompany")]
public class UltimateCompany
{
    [XmlElement("UltimateDUNSNumber")]
    public string UltimateDUNSNumber { get; set; }

    [XmlElement("UltimateCompanyName")]
    public string UltimateCompanyName { get; set; }

    [XmlElement("UltimateCompanyAddress")]
    public CommonDataAddress UltimateCompanyAddress { get; set; }

}