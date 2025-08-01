using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CourtPartyInfo")]
public class CourtPartyInfo
{
    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }

    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("TypeOfParty")]
    public List<string> TypeOfParty { get; set; }

    [XmlElement("Address")]
    public List<CommonDataAddress> Address { get; set; }

    [XmlElement("PhoneInfo")]
    public PhoneInfo PhoneInfo { get; set; }

    [XmlElement("AttorneyInfo")]
    public List<AttorneyInfo> AttorneyInfo { get; set; }

    [XmlElement("Comment")]
    public List<string> Comment { get; set; }

    [XmlElement("HeadquarterDUNSNumber")]
    public List<string> HeadquarterDUNSNumber { get; set; }

    [XmlElement("ForeignReg")]
    public string ForeignReg { get; set; }

    [XmlElement("DriverLicenseInfo")]
    public List<DriverLicenseInfo> DriverLicenseInfo { get; set; }

    [XmlElement("PersonProfile")]
    public List<PersonProfile> PersonProfile { get; set; }

    [XmlElement("FEIN")]
    public List<string> FEIN { get; set; }

    [XmlElement("ReportedDate")]
    public string ReportedDate { get; set; }

    [XmlElement("WebAddress")]
    public string WebAddress { get; set; }

    [XmlElement("DUNSNumber")]
    public List<string> DUNSNumber { get; set; }

    [XmlElement("SSNInfo")]
    public List<SSNInfo> SSNInfo { get; set; }

    [XmlElement("AKAName")]
    public List<PersonName> AKAName { get; set; }

}
}