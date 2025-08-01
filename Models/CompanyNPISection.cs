using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyNPISection")]
public class CompanyNPISection
{
    [XmlElement("NPIRecord")]
    public List<NPIRecord> NPIRecord { get; set; }

}
}