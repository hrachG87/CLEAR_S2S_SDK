using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("WatercraftDatasets")]
public class WatercraftDatasets
{
    [XmlElement("StateWatercraft")]
    public string StateWatercraft { get; set; }

    [XmlElement("USCoastGuard")]
    public string USCoastGuard { get; set; }

}
}