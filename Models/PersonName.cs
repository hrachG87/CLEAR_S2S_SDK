using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonName")]
public class PersonName
{
    [XmlElement("EntityId")]
    public string EntityId { get; set; }

    [XmlElement("Prefix")]
    public string Prefix { get; set; }

    [XmlElement("FirstName")]
    public string FirstName { get; set; }

    [XmlElement("MiddleName")]
    public string MiddleName { get; set; }

    [XmlElement("MaidenName")]
    public string MaidenName { get; set; }

    [XmlElement("LastName")]
    public string LastName { get; set; }

    [XmlElement("Suffix")]
    public string Suffix { get; set; }

    [XmlElement("SecondaryLastName")]
    public string SecondaryLastName { get; set; }

    [XmlElement("FullName")]
    public List<string> FullName { get; set; }

    [XmlElement("SourceInfo")]
    public List<SearchSources> SourceInfo { get; set; }

    [XmlElement("TREntityId")]
    public string TREntityId { get; set; }

}