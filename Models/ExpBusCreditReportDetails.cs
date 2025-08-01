using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("ExpBusCreditReportDetails")]
public class ExpBusCreditReportDetails
{
    [XmlElement("Status")]
    public ClearReportApiStatus Status { get; set; }

    [XmlElement("SectionResults")]
    public List<ExpBusCreditSectionResults> SectionResults { get; set; }

}