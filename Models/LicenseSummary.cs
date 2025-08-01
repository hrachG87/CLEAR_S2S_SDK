using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("LicenseSummary")]
public class LicenseSummary
{
    [XmlElement("ProfessionalLicense")]
    public List<PersonSummaryInfo> ProfessionalLicense { get; set; }

    [XmlElement("RecreationalLicense")]
    public List<PersonSummaryInfo> RecreationalLicense { get; set; }

    [XmlElement("HealthcareLicense")]
    public List<PersonSummaryInfo> HealthcareLicense { get; set; }

}
}