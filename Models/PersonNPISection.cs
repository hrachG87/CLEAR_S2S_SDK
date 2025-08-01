using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonNPISection")]
public class PersonNPISection
{
    [XmlElement("NPIRecord")]
    public List<NPIRecord> NPIRecord { get; set; }

}
}