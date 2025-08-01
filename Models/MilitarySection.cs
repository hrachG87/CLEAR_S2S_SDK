using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("MilitarySection")]
public class MilitarySection
{
    [XmlElement("MilitaryRecord")]
    public List<MilitaryRecord> MilitaryRecord { get; set; }

}
}