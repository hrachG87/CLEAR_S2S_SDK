using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RIBusinessSearchHeaderDetails")]
public class RIBusinessSearchHeaderDetails
{
    [XmlElement("value")]
    public string value { get; set; }

    [XmlElement("SectionCount")]
    public string SectionCount { get; set; }

    [XmlElement("SectionScore")]
    public string SectionScore { get; set; }

}
}