using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RIPersonSearchSection")]
public class RIPersonSearchSection
{
    [XmlElement("SectionName")]
    public string SectionName { get; set; }

    [XmlElement("SectionScore")]
    public string SectionScore { get; set; }

    [XmlElement("SectionDetails")]
    public RIPersonSearchSectionDetails SectionDetails { get; set; }

    [XmlElement("CustomMessage")]
    public string CustomMessage { get; set; }
}
