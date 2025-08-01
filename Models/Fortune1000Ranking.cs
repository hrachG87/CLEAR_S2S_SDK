using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("Fortune1000Ranking")]
public class Fortune1000Ranking
{
    [XmlElement("Year")]
    public int Year { get; set; }

    [XmlElement("Rank")]
    public int Rank { get; set; }

}
}