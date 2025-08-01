using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyReportInfractionSection")]
public class CompanyReportInfractionSection
{
    [XmlElement("InfractionRecord")]
    public List<CriminalRecord> InfractionRecord { get; set; }

}
}