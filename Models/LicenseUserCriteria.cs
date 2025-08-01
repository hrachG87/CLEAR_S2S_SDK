using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("LicenseUserCriteria")]
public class LicenseUserCriteria
{
    [XmlElement("LicenseCriteria")]
    public LicenseCriteria LicenseCriteria { get; set; }

}
}