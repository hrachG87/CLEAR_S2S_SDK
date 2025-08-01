using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RIBusinessSearchSections")]
public class RIBusinessSearchSections
{
    [XmlElement("Section")]
    public List<RIBusinessSearchSection> Section { get; set; }

}