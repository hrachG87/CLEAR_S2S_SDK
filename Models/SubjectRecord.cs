using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("SubjectRecord")]
public class SubjectRecord
{
    [XmlElement("PersonInfo")]
    public PersonReportPersonInfo PersonInfo { get; set; }

    [XmlElement("EntityId")]
    public List<string> EntityId { get; set; }

    [XmlElement("PersonAKAInfo")]
    public List<PersonReportPersonInfo> PersonAKAInfo { get; set; }

    [XmlElement("DeathSummary")]
    public DeathSummary DeathSummary { get; set; }

    [XmlElement("DriverLicenseInfo")]
    public List<DriverLicenseInfo> DriverLicenseInfo { get; set; }

    [XmlElement("MarriageDivorceSummary")]
    public MarriageDivorceSummary MarriageDivorceSummary { get; set; }

    [XmlElement("LicenseSummary")]
    public LicenseSummary LicenseSummary { get; set; }

    [XmlElement("WorkAffiliations")]
    public List<WorkAffiliations> WorkAffiliations { get; set; }

    [XmlElement("PhotoImages")]
    public PersonPhotoImages PhotoImages { get; set; }

    [XmlElement("TREntityId")]
    public List<string> TREntityId { get; set; }

}
}