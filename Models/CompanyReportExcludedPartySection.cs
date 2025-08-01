using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CompanyReportExcludedPartySection")]
public class CompanyReportExcludedPartySection
{
    [XmlElement("ExcludedPartyRecord")]
    public List<HealthcareSanctionRecord> ExcludedPartyRecord { get; set; }

}