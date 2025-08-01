using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("MarriageRecord")]
public class MarriageRecord
{
    [XmlElement("CeremonyType")]
    public string CeremonyType { get; set; }

    [XmlElement("MarriageDate")]
    public string MarriageDate { get; set; }

    [XmlElement("MarriageLocation")]
    public CommonDataAddress MarriageLocation { get; set; }

    [XmlElement("PersonHusband")]
    public PersonHusband PersonHusband { get; set; }

    [XmlElement("PersonWife")]
    public PersonWife PersonWife { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

}