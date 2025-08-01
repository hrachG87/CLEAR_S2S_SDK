using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("Subjudgments")]
public class Subjudgments
{
    [XmlElement("LienInfo")]
    public List<LienInfo> LienInfo { get; set; }

    [XmlElement("JudgmentInfo")]
    public List<CourtDataJudgmentInfo> JudgmentInfo { get; set; }

    [XmlElement("CommentInfo")]
    public List<CommentInfo> CommentInfo { get; set; }

    [XmlElement("Debtor")]
    public List<Debtor> Debtor { get; set; }

    [XmlElement("Creditor")]
    public List<Creditor> Creditor { get; set; }

}
}