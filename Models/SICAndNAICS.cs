using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("SICAndNAICS")]
public class SICAndNAICS
{
    [XmlElement("PrimarySIC")]
    public SICInfo PrimarySIC { get; set; }

    [XmlElement("SecondarySIC")]
    public List<SICInfo> SecondarySIC { get; set; }

    [XmlElement("PrimaryNAICS")]
    public SICInfo PrimaryNAICS { get; set; }

    [XmlElement("SecondaryNAICS")]
    public List<SICInfo> SecondaryNAICS { get; set; }

}