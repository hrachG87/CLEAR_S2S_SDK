using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CompanyReportHealthcareSanctionSection")]
public class CompanyReportHealthcareSanctionSection
{
    [XmlElement("HealthcareSanctionRecord")]
    public List<HealthcareSanctionRecord> HealthcareSanctionRecord { get; set; }

}