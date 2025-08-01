using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("JudgementInfo")]
public class JudgementInfo
{
    [XmlElement("AmountDescription")]
    public string AmountDescription { get; set; }

    [XmlElement("CostAmount")]
    public string CostAmount { get; set; }

    [XmlElement("FeeAmount")]
    public string FeeAmount { get; set; }

    [XmlElement("Frequency")]
    public string Frequency { get; set; }

    [XmlElement("JudgementDate")]
    public string JudgementDate { get; set; }

    [XmlElement("JudgmentLocation")]
    public ValueAndLabelSet JudgmentLocation { get; set; }

    [XmlElement("JudgementNote")]
    public string JudgementNote { get; set; }

    [XmlElement("PartyTypeAndName")]
    public PartyTypeAndName PartyTypeAndName { get; set; }

    [XmlElement("MiscOrAmount")]
    public ValueAndLabelSet MiscOrAmount { get; set; }

    [XmlElement("SatisfactionDate")]
    public string SatisfactionDate { get; set; }

    [XmlElement("Signatures")]
    public List<string> Signatures { get; set; }

    [XmlElement("TotalJudgement")]
    public string TotalJudgement { get; set; }

    [XmlElement("Status")]
    public CourtStatus Status { get; set; }

}