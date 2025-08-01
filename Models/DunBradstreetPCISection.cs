using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("DunBradstreetPCISection")]
public class DunBradstreetPCISection
{
    [XmlElement("DunBradstreetPCIRecord")]
    public List<DunBradstreetPCIRecord> DunBradstreetPCIRecord { get; set; }

}
}