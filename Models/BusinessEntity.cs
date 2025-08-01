using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("BusinessEntity")]
public class BusinessEntity
{
    [XmlElement("GroupId")]
    public string GroupId { get; set; }

    [XmlElement("TotalScore")]
    public string TotalScore { get; set; }

    [XmlElement("MinThresholdScore")]
    public string MinThresholdScore { get; set; }

    [XmlElement("EntityId")]
    public string EntityId { get; set; }

    [XmlElement("Header")]
    public Header Header { get; set; }

    [XmlElement("Sections")]
    public RIBusinessSearchSections Sections { get; set; }

}
}