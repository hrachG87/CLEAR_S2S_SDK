using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("LicensesDatasets")]
public class LicensesDatasets
{
    [XmlElement("ProfessionalLicenses")]
    public string ProfessionalLicenses { get; set; }

    [XmlElement("HealthcareLicenses")]
    public string HealthcareLicenses { get; set; }

}
}