using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("HouseholdListingRecord")]
public class HouseholdListingRecord
{
    [XmlElement("HeadOfHousehold")]
    public HouseholdInfo HeadOfHousehold { get; set; }

    [XmlElement("MemberOfHousehold")]
    public List<HouseholdInfo> MemberOfHousehold { get; set; }

    [XmlElement("AddressInfo")]
    public AddressesPhones AddressInfo { get; set; }

    [XmlElement("OccupationOfMale")]
    public string OccupationOfMale { get; set; }

    [XmlElement("OccupationOfFemale")]
    public string OccupationOfFemale { get; set; }

    [XmlElement("PhoneInfo")]
    public List<PhoneInfo> PhoneInfo { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }
}
