using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("NeighborSection")]
public class NeighborSection
{
    [XmlElement("NeighborRecord")]
    public List<NeighborRecord> NeighborRecord { get; set; }

}
}