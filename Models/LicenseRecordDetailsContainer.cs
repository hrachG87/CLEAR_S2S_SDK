using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("LicenseRecordDetailsContainer")]
public class LicenseRecordDetailsContainer
{
    [XmlElement("licenseResponseDetail")]
    public LicenseResponseDetail licenseResponseDetail { get; set; }

}
}