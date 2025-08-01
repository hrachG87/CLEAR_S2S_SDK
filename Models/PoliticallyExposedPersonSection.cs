using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PoliticallyExposedPersonSection")]
public class PoliticallyExposedPersonSection
{
    [XmlElement("PepRecord")]
    public List<PepRecord> PepRecord { get; set; }

}
}