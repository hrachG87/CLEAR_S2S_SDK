using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("SocialMediaInfo")]
public class SocialMediaInfo
{
    [XmlElement("URL")]
    public string URL { get; set; }

    [XmlElement("Username")]
    public string Username { get; set; }

    [XmlElement("Domain")]
    public string Domain { get; set; }

    [XmlElement("Category")]
    public string Category { get; set; }

    [XmlElement("Bio")]
    public string Bio { get; set; }

    [XmlElement("Name")]
    public string Name { get; set; }

    [XmlElement("Description")]
    public string Description { get; set; }

    [XmlElement("Interest")]
    public List<string> Interest { get; set; }

    [XmlElement("Followers")]
    public int Followers { get; set; }

    [XmlElement("Following")]
    public int Following { get; set; }
}
