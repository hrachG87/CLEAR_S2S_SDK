using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("Liabilities")]
public class Liabilities
{
    [XmlElement("LiabilityEntry")]
    public List<Entries> LiabilityEntry { get; set; }

    [XmlElement("TotalAmount")]
    public string TotalAmount { get; set; }
}
