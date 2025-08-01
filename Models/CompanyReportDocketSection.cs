using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyReportDocketSection")]
public class CompanyReportDocketSection
{
    [XmlElement("CompanyDocketRecord")]
    public List<CompanyDocketRecord> CompanyDocketRecord { get; set; }

}
}