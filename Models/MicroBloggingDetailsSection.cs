using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("MicroBloggingDetailsSection")]
public class MicroBloggingDetailsSection
{
    [XmlElement("MicroBloggingDetailsRecord")]
    public List<WebAndSocialMediaRecord> MicroBloggingDetailsRecord { get; set; }
}
