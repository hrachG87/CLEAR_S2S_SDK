using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("ImageInfo")]
public class ImageInfo
{
    [XmlElement("URL")]
    public string URL { get; set; }

    [XmlElement("Provider")]
    public string Provider { get; set; }

    [XmlElement("ValidSince")]
    public string ValidSince { get; set; }

    [XmlElement("LastSeen")]
    public string LastSeen { get; set; }
}
