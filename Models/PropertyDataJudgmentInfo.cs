using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PropertyDataJudgmentInfo")]
public class PropertyDataJudgmentInfo
{
    [XmlElement("AttorneyInfo")]
    public AttorneyInfo AttorneyInfo { get; set; }

    [XmlElement("AuctionInfo")]
    public AuctionInfo AuctionInfo { get; set; }

    [XmlElement("JudgmentAmount")]
    public string JudgmentAmount { get; set; }

    [XmlElement("Plaintiff")]
    public PersonName Plaintiff { get; set; }

    [XmlElement("CaseFiling")]
    public PropertyDataCaseFiling CaseFiling { get; set; }

}
}