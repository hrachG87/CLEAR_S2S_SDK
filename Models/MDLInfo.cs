using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("MDLInfo")]
public class MDLInfo
{
    [XmlElement("Number")]
    public List<string> Number { get; set; }

    [XmlElement("Jurisdiction")]
    public string Jurisdiction { get; set; }

    [XmlElement("JurisdictionNumber")]
    public string JurisdictionNumber { get; set; }

    [XmlElement("CaseNumber")]
    public string CaseNumber { get; set; }

    [XmlElement("CaseName")]
    public string CaseName { get; set; }

    [XmlElement("StartDate")]
    public string StartDate { get; set; }

    [XmlElement("EndDate")]
    public string EndDate { get; set; }

    [XmlElement("OriginalDistrict")]
    public string OriginalDistrict { get; set; }

    [XmlElement("OriginalJurisdictionNumber")]
    public string OriginalJurisdictionNumber { get; set; }

    [XmlElement("OriginalDocketNumber")]
    public List<string> OriginalDocketNumber { get; set; }

}