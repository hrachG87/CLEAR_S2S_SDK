using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("MultipleSSNs")]
public class MultipleSSNs
{
    [XmlElement("MultipleSSNsIndicator")]
    public string MultipleSSNsIndicator { get; set; }

    [XmlElement("TotalScoreLowered")]
    public string TotalScoreLowered { get; set; }

    [XmlElement("CustomMessage")]
    public string CustomMessage { get; set; }

    [XmlElement("MultipleSSNdetails")]
    public List<MultipleSSNsDetails> MultipleSSNdetails { get; set; }

}