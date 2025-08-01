using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("QuarterlyScoreTrends")]
public class QuarterlyScoreTrends
{
    [XmlElement("QuarterlyScoreTrend")]
    public List<QuarterlyScoreTrend> QuarterlyScoreTrend { get; set; }

}
}