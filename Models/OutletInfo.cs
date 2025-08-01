using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("OutletInfo")]
public class OutletInfo
{
    [XmlElement("OutletAddress")]
    public CommonDataAddress OutletAddress { get; set; }

    [XmlElement("OutletCityLimits")]
    public string OutletCityLimits { get; set; }

    [XmlElement("OutletFirstSalesDate")]
    public string OutletFirstSalesDate { get; set; }

    [XmlElement("OutletName")]
    public string OutletName { get; set; }

    [XmlElement("OutletNumber")]
    public string OutletNumber { get; set; }

    [XmlElement("OutletOwner")]
    public string OutletOwner { get; set; }

    [XmlElement("OutletPhone")]
    public string OutletPhone { get; set; }

    [XmlElement("OutletSicCode")]
    public string OutletSicCode { get; set; }

}
}