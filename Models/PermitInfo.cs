using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PermitInfo")]
public class PermitInfo
{
    [XmlElement("LifetimePermit")]
    public string LifetimePermit { get; set; }

    [XmlElement("ExpirationDate")]
    public string ExpirationDate { get; set; }

    [XmlElement("PermitClass")]
    public List<string> PermitClass { get; set; }

    [XmlElement("PermitIssueDate")]
    public string PermitIssueDate { get; set; }

    [XmlElement("PermitLicenseNumber")]
    public List<string> PermitLicenseNumber { get; set; }

    [XmlElement("PermitState")]
    public string PermitState { get; set; }

    [XmlElement("TypeOfPermit")]
    public List<string> TypeOfPermit { get; set; }

}
}