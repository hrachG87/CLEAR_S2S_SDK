using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("BusinessFlags")]
public class BusinessFlags
{
    [XmlElement("Aircraft")]
    public Aircraft Aircraft { get; set; }

    [XmlElement("Bankruptcy")]
    public Bankruptcy Bankruptcy { get; set; }

    [XmlElement("FinancialCivilJudgments")]
    public FinancialCivilJudgments FinancialCivilJudgments { get; set; }

    [XmlElement("HealthcareInformation")]
    public HealthcareInformation HealthcareInformation { get; set; }

    [XmlElement("Lawsuits")]
    public Lawsuits Lawsuits { get; set; }

    [XmlElement("Liens")]
    public Liens Liens { get; set; }

    [XmlElement("PartyToRiskBasedLawsuits")]
    public PartyToRiskBasedLawsuits PartyToRiskBasedLawsuits { get; set; }

    [XmlElement("RealProperty")]
    public RealProperty RealProperty { get; set; }

    [XmlElement("Watercraft")]
    public Watercraft Watercraft { get; set; }

    [XmlElement("DMVRecords")]
    public DMVRecords DMVRecords { get; set; }

    [XmlElement("UCCFilings")]
    public UCCFilings UCCFilings { get; set; }

}
}