using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("SOESummaryRecord")]
public class SOESummaryRecord
{
    [XmlElement("Number")]
    public int Number { get; set; }

    [XmlElement("SanctionType")]
    public string SanctionType { get; set; }

    [XmlElement("Title")]
    public string Title { get; set; }

    [XmlElement("URL")]
    public string URL { get; set; }

    [XmlElement("Relevance")]
    public string Relevance { get; set; }
}
