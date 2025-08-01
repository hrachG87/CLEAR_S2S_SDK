using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PoliticalDonorSection")]
public class PoliticalDonorSection
{
    [XmlElement("PoliticalDonorRecord")]
    public List<PoliticalDonorRecord> PoliticalDonorRecord { get; set; }
}
