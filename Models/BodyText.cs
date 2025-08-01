using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BodyText")]
public class BodyText
{
    [XmlElement("SectionTitle")]
    public string SectionTitle { get; set; }

    [XmlElement("SectionText")]
    public string SectionText { get; set; }

}