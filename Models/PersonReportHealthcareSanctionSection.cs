using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonReportHealthcareSanctionSection")]
public class PersonReportHealthcareSanctionSection
{
    [XmlElement("HealthcareSanctionRecord")]
    public List<HealthcareSanctionRecord> HealthcareSanctionRecord { get; set; }

}