using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalDataCaseInfo")]
public class CriminalDataCaseInfo
{
    [XmlElement("DistrictCourtDocketNumber")]
    public string DistrictCourtDocketNumber { get; set; }

    [XmlElement("DocketNumber")]
    public string DocketNumber { get; set; }

    [XmlElement("OtherCaseNumber")]
    public string OtherCaseNumber { get; set; }

    [XmlElement("CaseNumber")]
    public List<string> CaseNumber { get; set; }

    [XmlElement("CaseFiling")]
    public CriminalDataCaseFiling CaseFiling { get; set; }

    [XmlElement("CaseGeneralCategory")]
    public string CaseGeneralCategory { get; set; }

    [XmlElement("CaseTitle")]
    public string CaseTitle { get; set; }

    [XmlElement("CaseCategory")]
    public string CaseCategory { get; set; }

    [XmlElement("CaseInformation")]
    public string CaseInformation { get; set; }

    [XmlElement("CaseStatus")]
    public string CaseStatus { get; set; }

    [XmlElement("CaseStatusDate")]
    public string CaseStatusDate { get; set; }

    [XmlElement("CaseComments")]
    public List<string> CaseComments { get; set; }
}
