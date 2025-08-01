using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("QuarterlyScoreTrend")]
public class QuarterlyScoreTrend
{
    [XmlElement("Quarter")]
    public string Quarter { get; set; }

    [XmlElement("Score")]
    public int Score { get; set; }

}
}