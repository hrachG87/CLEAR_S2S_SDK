using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonNames")]
public class PersonNames
{
    [XmlElement("PersonName")]
    public List<PersonName> PersonName { get; set; }
}
