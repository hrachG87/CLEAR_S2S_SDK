using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonDocumentDominantValues")]
public class PersonDocumentDominantValues
{
    [XmlElement("Name")]
    public PersonName Name { get; set; }

    [XmlElement("SSN")]
    public string SSN { get; set; }

    [XmlElement("AgeInfo")]
    public PersonProfile AgeInfo { get; set; }

    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("ReportedDate")]
    public string ReportedDate { get; set; }
}
