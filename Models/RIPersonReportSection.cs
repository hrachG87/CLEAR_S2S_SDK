using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RIPersonReportSection")]
public class RIPersonReportSection
{
    [XmlElement("SectionName")]
    public string SectionName { get; set; }

    [XmlElement("subSection")]
    public List<SubSection> subSection { get; set; }

    [XmlElement("flagInfo")]
    public List<RIPersonReportFlagInfo> flagInfo { get; set; }

}
}