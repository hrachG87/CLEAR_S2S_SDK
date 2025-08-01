using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalCategoryLicenseViolationCategory")]
public class CriminalCategoryLicenseViolationCategory
{
    [XmlElement("ProfLicViolation")]
    public CriminalChargetypes ProfLicViolation { get; set; }

    [XmlElement("BizLicViolation")]
    public CriminalChargetypes BizLicViolation { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}
}