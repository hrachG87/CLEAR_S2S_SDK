using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("LowerCourtInfo")]
public class LowerCourtInfo
{
    [XmlElement("DispositionInfo")]
    public CaseDisposition DispositionInfo { get; set; }

    [XmlElement("CaseStatus")]
    public string CaseStatus { get; set; }

    [XmlElement("DebtDescription")]
    public string DebtDescription { get; set; }

    [XmlElement("JudgmentAmount")]
    public string JudgmentAmount { get; set; }

    [XmlElement("Defendant")]
    public List<Debtor> Defendant { get; set; }

    [XmlElement("Plaintiff")]
    public List<Plaintiff> Plaintiff { get; set; }

    [XmlElement("OtherParty")]
    public List<OtherParty> OtherParty { get; set; }

}
}