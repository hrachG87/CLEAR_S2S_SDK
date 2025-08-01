using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("DriverLicenseInfo")]
public class DriverLicenseInfo
{
    [XmlElement("DriverLicenseNumber")]
    public List<string> DriverLicenseNumber { get; set; }

    [XmlElement("DriverLicenseState")]
    public List<string> DriverLicenseState { get; set; }

    [XmlElement("DriverLicenseCounty")]
    public List<string> DriverLicenseCounty { get; set; }

    [XmlElement("MatchToUserSuppliedDLNumber")]
    public List<string> MatchToUserSuppliedDLNumber { get; set; }

    [XmlElement("MatchToSubjectsDLNumber")]
    public List<string> MatchToSubjectsDLNumber { get; set; }

}
}