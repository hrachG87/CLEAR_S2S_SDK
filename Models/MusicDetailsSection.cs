using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("MusicDetailsSection")]
public class MusicDetailsSection
{
    [XmlElement("MusicDetailsRecord")]
    public List<WebAndSocialMediaRecord> MusicDetailsRecord { get; set; }
}
