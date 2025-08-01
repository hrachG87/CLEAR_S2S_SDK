using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformBusinessReportSectionResults")]
public class RiskInformBusinessReportSectionResults
{
    [XmlElement("SectionName")]
    public string SectionName { get; set; }

    [XmlElement("CustomMessage")]
    public string CustomMessage { get; set; }

    [XmlElement("SectionStatus")]
    public string SectionStatus { get; set; }

    [XmlElement("SectionRecordCount")]
    public int SectionRecordCount { get; set; }

    [XmlElement("SectionDetails")]
    public RiskInformBusinessSectionDetails SectionDetails { get; set; }

    [XmlElement("CLEARReportDescription")]
    public string CLEARReportDescription { get; set; }

}
}