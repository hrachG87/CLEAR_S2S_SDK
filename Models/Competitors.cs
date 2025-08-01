using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("Competitors")]
public class Competitors
{
    [XmlElement("Competitor")]
    public List<string> Competitor { get; set; }

}
}