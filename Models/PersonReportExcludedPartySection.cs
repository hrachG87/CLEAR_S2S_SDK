using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonReportExcludedPartySection")]
public class PersonReportExcludedPartySection
{
    [XmlElement("ExcludedPartyRecord")]
    public List<HealthcareSanctionRecord> ExcludedPartyRecord { get; set; }

}