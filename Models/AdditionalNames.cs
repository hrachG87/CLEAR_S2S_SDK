using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AdditionalNames")]
public class AdditionalNames
{
    [XmlElement("Name")]
    public List<string> Name { get; set; }
}
