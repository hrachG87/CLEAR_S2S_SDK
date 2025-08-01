using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("DivorceRecord")]
public class DivorceRecord
{
    [XmlElement("AlimonyAwarded")]
    public string AlimonyAwarded { get; set; }

    [XmlElement("AlimonyAmount")]
    public string AlimonyAmount { get; set; }

    [XmlElement("ChildSupportInfo")]
    public ChildSupportInfo ChildSupportInfo { get; set; }

    [XmlElement("DecreeDate")]
    public string DecreeDate { get; set; }

    [XmlElement("DecreeLocation")]
    public CommonDataAddress DecreeLocation { get; set; }

    [XmlElement("DecreeType")]
    public string DecreeType { get; set; }

    [XmlElement("DivorceFilingCounty")]
    public string DivorceFilingCounty { get; set; }

    [XmlElement("DivorceFilingDate")]
    public string DivorceFilingDate { get; set; }

    [XmlElement("DivorceFilingNumber")]
    public string DivorceFilingNumber { get; set; }

    [XmlElement("DivorceLocation")]
    public CommonDataAddress DivorceLocation { get; set; }

    [XmlElement("MarriageDate")]
    public string MarriageDate { get; set; }

    [XmlElement("MarriageLocation")]
    public CommonDataAddress MarriageLocation { get; set; }

    [XmlElement("NumberOfChildren")]
    public string NumberOfChildren { get; set; }

    [XmlElement("PersonHusband")]
    public PersonHusband PersonHusband { get; set; }

    [XmlElement("PersonWife")]
    public PersonWife PersonWife { get; set; }

    [XmlElement("Petitioner")]
    public PersonInfo Petitioner { get; set; }

    [XmlElement("PetitionerType")]
    public string PetitionerType { get; set; }

    [XmlElement("Respondent")]
    public PersonInfo Respondent { get; set; }

    [XmlElement("SeparationDate")]
    public string SeparationDate { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }
}
