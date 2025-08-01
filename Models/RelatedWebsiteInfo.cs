using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RelatedWebsiteInfo")]
public class RelatedWebsiteInfo
{
    [XmlElement("URL")]
    public string URL { get; set; }

    [XmlElement("Domain")]
    public string Domain { get; set; }

    [XmlElement("Category")]
    public string Category { get; set; }

    [XmlElement("ValidSinceDate")]
    public string ValidSinceDate { get; set; }

    [XmlElement("Titles")]
    public List<string> Titles { get; set; }

    [XmlElement("Previews")]
    public List<string> Previews { get; set; }

    [XmlElement("Tags")]
    public List<TagInfo> Tags { get; set; }

}