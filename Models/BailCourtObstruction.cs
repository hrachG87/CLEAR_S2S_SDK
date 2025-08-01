using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("BailCourtObstruction")]
public class BailCourtObstruction
{
    [XmlElement("ContemptCourt")]
    public RiskFlagInfo ContemptCourt { get; set; }

    [XmlElement("SecuredBondBail")]
    public RiskFlagInfo SecuredBondBail { get; set; }

    [XmlElement("PersonalRecogBail")]
    public RiskFlagInfo PersonalRecogBail { get; set; }

    [XmlElement("Perjury")]
    public RiskFlagInfo Perjury { get; set; }

    [XmlElement("SubornPerjury")]
    public RiskFlagInfo SubornPerjury { get; set; }

    [XmlElement("ObstructJustice")]
    public RiskFlagInfo ObstructJustice { get; set; }

    [XmlElement("ObstructCourtOrder")]
    public RiskFlagInfo ObstructCourtOrder { get; set; }

    [XmlElement("JudicialOfficerMiscond")]
    public RiskFlagInfo JudicialOfficerMiscond { get; set; }

    [XmlElement("ContemptCongress")]
    public RiskFlagInfo ContemptCongress { get; set; }

    [XmlElement("ContemptLegislature")]
    public RiskFlagInfo ContemptLegislature { get; set; }

    [XmlElement("Obstruction")]
    public RiskFlagInfo Obstruction { get; set; }

    [XmlElement("ParoleViolation")]
    public RiskFlagInfo ParoleViolation { get; set; }

    [XmlElement("ProbationViolation")]
    public RiskFlagInfo ProbationViolation { get; set; }

    [XmlElement("ConditionalReleaseViolation")]
    public RiskFlagInfo ConditionalReleaseViolation { get; set; }

    [XmlElement("MandatoryReleaseViolation")]
    public RiskFlagInfo MandatoryReleaseViolation { get; set; }

    [XmlElement("FailToAppear")]
    public RiskFlagInfo FailToAppear { get; set; }

    [XmlElement("ViolateCourtOrder")]
    public RiskFlagInfo ViolateCourtOrder { get; set; }

    [XmlElement("BriberyOfJuror")]
    public RiskFlagInfo BriberyOfJuror { get; set; }

    [XmlElement("TamperWithJuror")]
    public RiskFlagInfo TamperWithJuror { get; set; }

    [XmlElement("JurorAcceptBribe")]
    public RiskFlagInfo JurorAcceptBribe { get; set; }

    [XmlElement("BriberyOfJudicialOfficer")]
    public RiskFlagInfo BriberyOfJudicialOfficer { get; set; }

    [XmlElement("WitnessAcceptBribe")]
    public RiskFlagInfo WitnessAcceptBribe { get; set; }

    [XmlElement("FalselyAccusedOfCrime")]
    public RiskFlagInfo FalselyAccusedOfCrime { get; set; }

}
}