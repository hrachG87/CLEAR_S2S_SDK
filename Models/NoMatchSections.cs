using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("NoMatchSections")]
public class NoMatchSections
{
    [XmlElement("noMatchSection")]
    public List<string> noMatchSection { get; set; }

}