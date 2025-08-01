using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RatioHeaders")]
public class RatioHeaders
{
    [XmlElement("Firm")]
    public RatioTable Firm { get; set; }

    [XmlElement("IndustryMedian")]
    public RatioTable IndustryMedian { get; set; }

    [XmlElement("IndustryQuartile")]
    public RatioTable IndustryQuartile { get; set; }

}
}