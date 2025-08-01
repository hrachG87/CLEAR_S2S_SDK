using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("IDInfo")]
public class IDInfo
{
    [XmlElement("DriverLicenseInfo")]
    public List<DriverLicenseInfo> DriverLicenseInfo { get; set; }

    [XmlElement("UndocumentedImmigrantInfo")]
    public List<UndocumentedImmigrantInfo> UndocumentedImmigrantInfo { get; set; }

    [XmlElement("SexOffenderID")]
    public string SexOffenderID { get; set; }

    [XmlElement("StateIDInfo")]
    public List<IDDetails> StateIDInfo { get; set; }

    [XmlElement("OtherIDInfo")]
    public List<IDDetails> OtherIDInfo { get; set; }

    [XmlElement("NationalID")]
    public List<string> NationalID { get; set; }

    [XmlElement("PassportID")]
    public List<string> PassportID { get; set; }

    [XmlElement("InmateID")]
    public string InmateID { get; set; }

    [XmlElement("PersonSSN")]
    public List<SSNInfo> PersonSSN { get; set; }

    [XmlElement("PersonProfile")]
    public List<PersonProfile> PersonProfile { get; set; }

    [XmlElement("FBICriminalID")]
    public List<string> FBICriminalID { get; set; }

}
}