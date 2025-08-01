using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("SourcePeopleAddressInfo")]
public class SourcePeopleAddressInfo
{
    [XmlElement("Name")]
    public string Name { get; set; }

    [XmlElement("SSN")]
    public List<string> SSN { get; set; }

    [XmlElement("PersonProfile")]
    public PersonProfile PersonProfile { get; set; }

    [XmlElement("DriverLicenseInfo")]
    public DriverLicenseInfo DriverLicenseInfo { get; set; }

    [XmlElement("SpouseName")]
    public string SpouseName { get; set; }

    [XmlElement("PeopleAddress")]
    public List<PeopleAddress> PeopleAddress { get; set; }

    [XmlElement("AdditionalPhoneNumbers")]
    public List<string> AdditionalPhoneNumbers { get; set; }

    [XmlElement("AdditionalHouseholdMembers")]
    public List<PersonName> AdditionalHouseholdMembers { get; set; }

    [XmlElement("AKAInfo")]
    public List<CompanyReportAKAInfo> AKAInfo { get; set; }

}
}