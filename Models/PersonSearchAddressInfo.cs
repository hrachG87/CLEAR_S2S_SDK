using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonSearchAddressInfo")]
public class PersonSearchAddressInfo
{
    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("Phones")]
    public PhoneInfo Phones { get; set; }

    [XmlElement("SourceInfo")]
    public List<PersonSearchSources> SourceInfo { get; set; }
}
