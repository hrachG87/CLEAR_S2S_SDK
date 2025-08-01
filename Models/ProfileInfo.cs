using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("ProfileInfo")]
public class ProfileInfo
{
    [XmlElement("PersonName")]
    public PersonNameInfo PersonName { get; set; }

    [XmlElement("PersonProfile")]
    public PersonProfile PersonProfile { get; set; }

    [XmlElement("PersonSSN")]
    public List<SSNInfo> PersonSSN { get; set; }

    [XmlElement("CountryName")]
    public string CountryName { get; set; }

    [XmlElement("IDInfo")]
    public List<IDDetails> IDInfo { get; set; }
}
