using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("LicenseResultsInfo")]
public class LicenseResultsInfo
{
    [XmlElement("LicenseType")]
    public string LicenseType { get; set; }

    [XmlElement("LicenseNumber")]
    public string LicenseNumber { get; set; }

    [XmlElement("LicenseState")]
    public string LicenseState { get; set; }

}
}