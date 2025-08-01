using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonReportExcludedPartySection")]
public class PersonReportExcludedPartySection
{
    [XmlElement("ExcludedPartyRecord")]
    public List<HealthcareSanctionRecord> ExcludedPartyRecord { get; set; }

}
}