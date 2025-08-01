using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyPhoneRecord")]
public class CompanyPhoneRecord
{
    [XmlElement("CompanyPhoneInfo")]
    public List<CompanyPhoneInfo> CompanyPhoneInfo { get; set; }

    [XmlElement("SourcePhoneInfo")]
    public SourcePhoneInfo SourcePhoneInfo { get; set; }

}
}