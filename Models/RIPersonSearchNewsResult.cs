using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RIPersonSearchNewsResult")]
public class RIPersonSearchNewsResult
{
    [XmlElement("RecordId")]
    public string RecordId { get; set; }

    [XmlElement("NewsSummary")]
    public NewsSummary NewsSummary { get; set; }

    [XmlElement("NewsDetails")]
    public RIPersonSearchNewsResults NewsDetails { get; set; }

}
}