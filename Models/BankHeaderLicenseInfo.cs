using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("BankHeaderLicenseInfo")]
public class BankHeaderLicenseInfo
{
    [XmlElement("LicenseNumber")]
    public string LicenseNumber { get; set; }

    [XmlElement("IssueState")]
    public string IssueState { get; set; }

}
}