using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("Assets")]
public class Assets
{
    [XmlElement("AssetEntry")]
    public List<Entries> AssetEntry { get; set; }

    [XmlElement("TotalAmount")]
    public string TotalAmount { get; set; }
}
