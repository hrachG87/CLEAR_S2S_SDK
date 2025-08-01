using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PeopleSameAddressRecord")]
public class PeopleSameAddressRecord
{
    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("PersonNames")]
    public List<PersonNames> PersonNames { get; set; }

    [XmlElement("SourcePeopleAddress")]
    public SourcePeopleAddressInfo SourcePeopleAddress { get; set; }
}
