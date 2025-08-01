using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CourtDataJudgmentInfo")]
public class CourtDataJudgmentInfo
{
    [XmlElement("AwardAmount")]
    public string AwardAmount { get; set; }

    [XmlElement("JudgementPrincipalAmount")]
    public string JudgementPrincipalAmount { get; set; }

    [XmlElement("PaidOnCreditAmount")]
    public string PaidOnCreditAmount { get; set; }

    [XmlElement("JudgmentTotalAmount")]
    public string JudgmentTotalAmount { get; set; }

    [XmlElement("ObligationInfo")]
    public List<ObligationInfo> ObligationInfo { get; set; }

    [XmlElement("StatusInfo")]
    public StatusInfo StatusInfo { get; set; }

    [XmlElement("SubjudgmentInfo")]
    public SubjudgmentInfo SubjudgmentInfo { get; set; }

}
}