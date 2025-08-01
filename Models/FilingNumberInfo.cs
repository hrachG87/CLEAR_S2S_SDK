using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("FilingNumberInfo")]
public class FilingNumberInfo
{
    [XmlElement("FilingNumber")]
    public List<string> FilingNumber { get; set; }

    [XmlElement("PageNumber")]
    public List<string> PageNumber { get; set; }

    [XmlElement("VolumeNumber")]
    public List<string> VolumeNumber { get; set; }
}
