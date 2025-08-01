using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("WebsiteInfo")]
public class WebsiteInfo
{
    [XmlElement("TypeOfWebsite")]
    public string TypeOfWebsite { get; set; }

    [XmlElement("URL")]
    public string URL { get; set; }
}
