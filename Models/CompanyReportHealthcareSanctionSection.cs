using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyReportHealthcareSanctionSection")]
public class CompanyReportHealthcareSanctionSection
{
    [XmlElement("HealthcareSanctionRecord")]
    public List<HealthcareSanctionRecord> HealthcareSanctionRecord { get; set; }

}
}