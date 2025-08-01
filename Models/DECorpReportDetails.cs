using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("DECorpReportDetails")]
public class DECorpReportDetails
{
    [XmlElement("Status")]
    public ClearReportApiStatus Status { get; set; }

    [XmlElement("SectionResults")]
    public List<DECorpSectionResults> SectionResults { get; set; }
}
