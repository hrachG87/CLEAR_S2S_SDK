using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("BusinessPersonInfo")]
public class BusinessPersonInfo
{
    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("NameType")]
    public string NameType { get; set; }

    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }

    [XmlElement("PhoneNumber")]
    public PhoneInfo PhoneNumber { get; set; }

    [XmlElement("PersonProfile")]
    public PersonProfile PersonProfile { get; set; }
}
