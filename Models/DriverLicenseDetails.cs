using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("DriverLicenseDetails")]
public class DriverLicenseDetails
{
    [XmlElement("CommericalIndicator")]
    public string CommericalIndicator { get; set; }

    [XmlElement("LicenseType")]
    public string LicenseType { get; set; }

    [XmlElement("OrigDriverLicenseIssueDate")]
    public string OrigDriverLicenseIssueDate { get; set; }

    [XmlElement("DriverLicenseCommercialStatus")]
    public string DriverLicenseCommercialStatus { get; set; }

    [XmlElement("DriverLicenseEndorsement")]
    public List<string> DriverLicenseEndorsement { get; set; }

    [XmlElement("DriverLicenseExpirationDate")]
    public string DriverLicenseExpirationDate { get; set; }

    [XmlElement("DriverLicenseIssueDate")]
    public string DriverLicenseIssueDate { get; set; }

    [XmlElement("DriverLicenseNonCommercialStatus")]
    public string DriverLicenseNonCommercialStatus { get; set; }

    [XmlElement("DrivingRestrictionDescription")]
    public List<string> DrivingRestrictionDescription { get; set; }

    [XmlElement("ReportedDate")]
    public string ReportedDate { get; set; }

}