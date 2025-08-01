using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("EmailUserActivityFlagAttributes")]
public class EmailUserActivityFlagAttributes
{
    [XmlElement("TotalScoreLowered")]
    public double TotalScoreLowered { get; set; }

    [XmlElement("CustomMessage")]
    public string CustomMessage { get; set; }

    [XmlElement("Value")]
    public string Value { get; set; }

}
}