using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PhoneInfo")]
public class PhoneInfo
{
    [XmlElement("PhoneNumber")]
    public string PhoneNumber { get; set; }

    [XmlElement("PhoneNumberSuffix")]
    public string PhoneNumberSuffix { get; set; }

    [XmlElement("WorkPhoneNumber")]
    public string WorkPhoneNumber { get; set; }

    [XmlElement("TollFreePhoneNumber")]
    public string TollFreePhoneNumber { get; set; }

    [XmlElement("OtherPhoneNumber")]
    public string OtherPhoneNumber { get; set; }

    [XmlElement("FaxNumber")]
    public string FaxNumber { get; set; }

    [XmlElement("PhoneNumberType")]
    public string PhoneNumberType { get; set; }

    [XmlElement("OtherPhoneNumberType")]
    public string OtherPhoneNumberType { get; set; }

    [XmlElement("PhoneCarrier")]
    public string PhoneCarrier { get; set; }

    [XmlElement("OtherPhoneCarrier")]
    public string OtherPhoneCarrier { get; set; }

    [XmlElement("AdditionalPhoneList")]
    public List<AdditionalPhoneNumbers> AdditionalPhoneList { get; set; }

    [XmlElement("MatchToSubjectsPhoneNumber")]
    public bool MatchToSubjectsPhoneNumber { get; set; }
}
