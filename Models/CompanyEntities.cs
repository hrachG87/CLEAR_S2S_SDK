using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyEntities")]
public class CompanyEntities
{
    [XmlElement("CompanyEntity")]
    public List<CompanyEntity> CompanyEntity { get; set; }

}
}