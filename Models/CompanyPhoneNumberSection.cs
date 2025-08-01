using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyPhoneNumberSection")]
public class CompanyPhoneNumberSection
{
    [XmlElement("CompanyPhoneRecord")]
    public List<CompanyPhoneRecord> CompanyPhoneRecord { get; set; }

}
}