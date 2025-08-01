using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CompanyReportExecutiveAffiliationSection")]
public class CompanyReportExecutiveAffiliationSection
{
    [XmlElement("ExecutiveAffiliationRecord")]
    public List<ExecutiveAffiliationRecord> ExecutiveAffiliationRecord { get; set; }

    [XmlElement("ExecutiveBioRecord")]
    public List<ExecutiveBioRecord> ExecutiveBioRecord { get; set; }

}