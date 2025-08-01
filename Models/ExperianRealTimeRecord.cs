using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("ExperianRealTimeRecord")]
public class ExperianRealTimeRecord
{
    [XmlElement("Names")]
    public List<PersonName> Names { get; set; }

    [XmlElement("SpouseInfo")]
    public List<SpouseInfo> SpouseInfo { get; set; }

    [XmlElement("AddressesPhoneInfo")]
    public List<AddressesPhones> AddressesPhoneInfo { get; set; }

    [XmlElement("SSN")]
    public List<SSNInfo> SSN { get; set; }

    [XmlElement("Phones")]
    public List<PhoneInfo> Phones { get; set; }

    [XmlElement("DateOfBirth")]
    public List<DateOfBirth> DateOfBirth { get; set; }

    [XmlElement("MatchesPersonEntity")]
    public string MatchesPersonEntity { get; set; }

    [XmlElement("FraudServicesInfo")]
    public FraudServicesInfo FraudServicesInfo { get; set; }

    [XmlElement("ReportDate")]
    public string ReportDate { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }
}
