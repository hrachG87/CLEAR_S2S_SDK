using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("DeathDetails")]
public class DeathDetails
{
    [XmlElement("PersonName")]
    public string PersonName { get; set; }

    [XmlElement("BirthDate")]
    public string BirthDate { get; set; }

    [XmlElement("DeathDate")]
    public string DeathDate { get; set; }

    [XmlElement("Source")]
    public List<string> Source { get; set; }

    [XmlElement("DocumentIdentifierInfo")]
    public List<EidvPersonSearchDocumentIdentifierInfo> DocumentIdentifierInfo { get; set; }
}
