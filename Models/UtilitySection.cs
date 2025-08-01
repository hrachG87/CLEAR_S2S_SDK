using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("UtilitySection")]
public class UtilitySection
{
    [XmlElement("UtilityRecord")]
    public List<UtilityRecord> UtilityRecord { get; set; }

}
}