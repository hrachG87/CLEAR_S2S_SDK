using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CaseLawInfo")]
public class CaseLawInfo
{
    [XmlElement("CaseTitle")]
    public string CaseTitle { get; set; }

    [XmlElement("WestLawCaseNumber")]
    public string WestLawCaseNumber { get; set; }

    [XmlElement("FilingDate")]
    public string FilingDate { get; set; }

    [XmlElement("Court")]
    public string Court { get; set; }

    [XmlElement("CompanyInterest")]
    public string CompanyInterest { get; set; }
}
