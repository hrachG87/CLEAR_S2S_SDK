using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RIBusinessSearchSection")]
public class RIBusinessSearchSection
{
    [XmlElement("SectionName")]
    public string SectionName { get; set; }

    [XmlElement("SectionScore")]
    public string SectionScore { get; set; }

    [XmlElement("SectionDetails")]
    public RIBusinessSearchSectionDetails SectionDetails { get; set; }

    [XmlElement("CustomMessage")]
    public string CustomMessage { get; set; }

}
}