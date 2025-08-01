using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("OtherDetailsSection")]
public class OtherDetailsSection
{
    [XmlElement("OtherDetailsRecord")]
    public List<WebAndSocialMediaRecord> OtherDetailsRecord { get; set; }
}
