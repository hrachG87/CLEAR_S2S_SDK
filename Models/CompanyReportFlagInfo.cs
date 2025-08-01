using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyReportFlagInfo")]
public class CompanyReportFlagInfo
{
    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("PhoneNumber")]
    public string PhoneNumber { get; set; }

    [XmlElement("FEIN")]
    public string FEIN { get; set; }

    [XmlElement("OfficerName")]
    public string OfficerName { get; set; }

    [XmlElement("OfficerTitle")]
    public string OfficerTitle { get; set; }

}
}