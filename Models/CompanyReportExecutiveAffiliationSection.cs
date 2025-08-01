using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyReportExecutiveAffiliationSection")]
public class CompanyReportExecutiveAffiliationSection
{
    [XmlElement("ExecutiveAffiliationRecord")]
    public List<ExecutiveAffiliationRecord> ExecutiveAffiliationRecord { get; set; }

    [XmlElement("ExecutiveBioRecord")]
    public List<ExecutiveBioRecord> ExecutiveBioRecord { get; set; }

}
}