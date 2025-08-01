using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("NameInfo")]
public class NameInfo
{
    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }

    [XmlElement("AdditionalNames")]
    public List<PersonName> AdditionalNames { get; set; }
}
