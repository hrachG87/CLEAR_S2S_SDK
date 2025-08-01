using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("HealthcareLicenseSection")]
public class HealthcareLicenseSection
{
    [XmlElement("HealthcareLicenseRecord")]
    public List<HealthcareLicenseRecord> HealthcareLicenseRecord { get; set; }

}
}