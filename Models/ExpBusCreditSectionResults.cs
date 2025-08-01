using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ExpBusCreditSectionResults")]
public class ExpBusCreditSectionResults
{
    [XmlElement("SectionName")]
    public string SectionName { get; set; }

    [XmlElement("SectionStatus")]
    public string SectionStatus { get; set; }

    [XmlElement("SectionRecordCount")]
    public int SectionRecordCount { get; set; }

    [XmlElement("SectionDetails")]
    public ExpBusCreditReportSections SectionDetails { get; set; }

    [XmlElement("CLEARReportDescription")]
    public string CLEARReportDescription { get; set; }

}
}