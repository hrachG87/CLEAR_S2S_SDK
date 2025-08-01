using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PeopleSamePhoneRecord")]
public class PeopleSamePhoneRecord
{
    [XmlElement("PhoneNumber")]
    public string PhoneNumber { get; set; }

    [XmlElement("PersonNames")]
    public List<PersonNames> PersonNames { get; set; }
}
