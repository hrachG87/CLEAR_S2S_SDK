using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CompanyReportCriminalSection")]
public class CompanyReportCriminalSection
{
    [XmlElement("CriminalRecord")]
    public List<CriminalRecord> CriminalRecord { get; set; }

    [XmlElement("CriminalExpansionRecord")]
    public List<CriminalExpansionRecord> CriminalExpansionRecord { get; set; }
}
