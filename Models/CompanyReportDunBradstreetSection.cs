using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyReportDunBradstreetSection")]
public class CompanyReportDunBradstreetSection
{
    [XmlElement("DunBradstreetRecord")]
    public List<DunBradstreetRecord> DunBradstreetRecord { get; set; }

}
}