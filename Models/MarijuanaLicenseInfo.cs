using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("MarijuanaLicenseInfo")]
public class MarijuanaLicenseInfo
{
    [XmlElement("LicenseNumber")]
    public string LicenseNumber { get; set; }

    [XmlElement("LicenseClassification")]
    public string LicenseClassification { get; set; }

    [XmlElement("LicensingAuthorityName")]
    public string LicensingAuthorityName { get; set; }

    [XmlElement("LicensingAuthorityTier")]
    public string LicensingAuthorityTier { get; set; }

    [XmlElement("LicensingAuthorityAddress")]
    public List<CommonDataAddress> LicensingAuthorityAddress { get; set; }

    [XmlElement("UniformLicenseType")]
    public string UniformLicenseType { get; set; }

    [XmlElement("UniformLicenseStatus")]
    public string UniformLicenseStatus { get; set; }

    [XmlElement("UniformLicenseStatusAsOfDate")]
    public string UniformLicenseStatusAsOfDate { get; set; }

}
}