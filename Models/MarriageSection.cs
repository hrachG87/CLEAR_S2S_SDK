using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("MarriageSection")]
public class MarriageSection
{
    [XmlElement("marriageRecord")]
    public List<MarriageRecord> marriageRecord { get; set; }

}
}