using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AdverseMediaPepResults")]
public class AdverseMediaPepResults
{
    [XmlElement("ParentEntryType")]
    public string ParentEntryType { get; set; }

    [XmlElement("Relevance")]
    public string Relevance { get; set; }

    [XmlElement("Score")]
    public double Score { get; set; }

    [XmlElement("MatchedEntry")]
    public string MatchedEntry { get; set; }

    [XmlElement("MatchedEntryType")]
    public string MatchedEntryType { get; set; }

    [XmlElement("ParentEntry")]
    public string ParentEntry { get; set; }

    [XmlElement("ListName")]
    public string ListName { get; set; }

    [XmlElement("RelevanceStyle")]
    public string RelevanceStyle { get; set; }

    [XmlElement("MasterEntry")]
    public string MasterEntry { get; set; }

    [XmlElement("Type")]
    public string Type { get; set; }

    [XmlElement("AdditionalInfo")]
    public List<PepAdditionalInfo> AdditionalInfo { get; set; }

    [XmlElement("RawAdditionalInfoList")]
    public RawAdditionalInfoList RawAdditionalInfoList { get; set; }

}
}