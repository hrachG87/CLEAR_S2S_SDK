using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("WatercraftDatasets")]
public class WatercraftDatasets
{
    [XmlElement("StateWatercraft")]
    public string StateWatercraft { get; set; }

    [XmlElement("USCoastGuard")]
    public string USCoastGuard { get; set; }
}
