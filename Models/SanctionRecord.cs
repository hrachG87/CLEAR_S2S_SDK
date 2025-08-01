using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("SanctionRecord")]
public class SanctionRecord
{
    [XmlElement("ParentEntryType")]
    public string ParentEntryType { get; set; }

    [XmlElement("Score")]
    public double Score { get; set; }

    [XmlElement("Term")]
    public string Term { get; set; }

    [XmlElement("MatchedEntry")]
    public string MatchedEntry { get; set; }

    [XmlElement("MatchedEntryType")]
    public string MatchedEntryType { get; set; }

    [XmlElement("ParentEntry")]
    public string ParentEntry { get; set; }

    [XmlElement("Relevance")]
    public double Relevance { get; set; }

    [XmlElement("UserReference")]
    public string UserReference { get; set; }

    [XmlElement("ListName")]
    public string ListName { get; set; }

    [XmlElement("Type")]
    public string Type { get; set; }

    [XmlElement("MasterEntry")]
    public string MasterEntry { get; set; }

    [XmlElement("AdditionalInfo")]
    public List<AdditionalInfo> AdditionalInfo { get; set; }

    [XmlElement("RawAdditionalInfoList")]
    public RawAdditionalInfoList RawAdditionalInfoList { get; set; }

}
}