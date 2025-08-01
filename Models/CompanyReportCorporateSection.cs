using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyReportCorporateSection")]
public class CompanyReportCorporateSection
{
    [XmlElement("CorporateRecord")]
    public List<CorporateRecord> CorporateRecord { get; set; }

}
}