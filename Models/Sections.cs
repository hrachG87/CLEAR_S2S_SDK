using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("Sections")]
public class Sections
{
    [XmlElement("Section")]
    public List<Section> Section { get; set; }
}
