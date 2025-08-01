using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("LenderInfo")]
public class LenderInfo
{
    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("Phone")]
    public PhoneInfo Phone { get; set; }

    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }
}
