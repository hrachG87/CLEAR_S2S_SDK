using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyProfileSection")]
public class CompanyProfileSection
{
    [XmlElement("CompanyProfileRecord")]
    public List<CompanyProfileRecord> CompanyProfileRecord { get; set; }

}
}