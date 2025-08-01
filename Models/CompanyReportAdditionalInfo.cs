using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyReportAdditionalInfo")]
public class CompanyReportAdditionalInfo
{
    [XmlElement("Age")]
    public string Age { get; set; }

    [XmlElement("Bio")]
    public string Bio { get; set; }

}
}