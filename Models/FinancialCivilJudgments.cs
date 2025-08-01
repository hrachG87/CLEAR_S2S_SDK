using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("FinancialCivilJudgments")]
public class FinancialCivilJudgments
{
    [XmlElement("Judgments")]
    public RiskFlagInfo Judgments { get; set; }

    [XmlElement("JudgmentsOverAmount")]
    public RiskFlagInfo JudgmentsOverAmount { get; set; }

    [XmlElement("JudgmentsTotalAmount")]
    public RiskFlagInfo JudgmentsTotalAmount { get; set; }

    [XmlElement("JudgmentsRelease")]
    public RiskFlagInfo JudgmentsRelease { get; set; }
}
