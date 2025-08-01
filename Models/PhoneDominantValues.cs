using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PhoneDominantValues")]
public class PhoneDominantValues
{
    [XmlElement("PhoneNumber")]
    public string PhoneNumber { get; set; }

    [XmlElement("Name")]
    public string Name { get; set; }

    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("ReportedDate")]
    public string ReportedDate { get; set; }
}
