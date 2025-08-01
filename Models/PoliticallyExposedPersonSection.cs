using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PoliticallyExposedPersonSection")]
public class PoliticallyExposedPersonSection
{
    [XmlElement("PepRecord")]
    public List<PepRecord> PepRecord { get; set; }
}
