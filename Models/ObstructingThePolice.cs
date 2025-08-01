using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ObstructingThePolice")]
public class ObstructingThePolice
{
    [XmlElement("ResistOfficer")]
    public RiskFlagInfo ResistOfficer { get; set; }

    [XmlElement("ObstructCrimInvestigation")]
    public RiskFlagInfo ObstructCrimInvestigation { get; set; }

    [XmlElement("FalseReport")]
    public RiskFlagInfo FalseReport { get; set; }

    [XmlElement("DestroyEvidence")]
    public RiskFlagInfo DestroyEvidence { get; set; }

    [XmlElement("DissuadeWitness")]
    public RiskFlagInfo DissuadeWitness { get; set; }

    [XmlElement("DeceiveWitness")]
    public RiskFlagInfo DeceiveWitness { get; set; }

    [XmlElement("RefuseAidOfficer")]
    public RiskFlagInfo RefuseAidOfficer { get; set; }

    [XmlElement("CompoundCrime")]
    public RiskFlagInfo CompoundCrime { get; set; }

    [XmlElement("UnauthCommunPrisoner")]
    public RiskFlagInfo UnauthCommunPrisoner { get; set; }

    [XmlElement("IllegalArrest")]
    public RiskFlagInfo IllegalArrest { get; set; }

    [XmlElement("CrossPoliceLines")]
    public RiskFlagInfo CrossPoliceLines { get; set; }

    [XmlElement("FailReportCrime")]
    public RiskFlagInfo FailReportCrime { get; set; }

    [XmlElement("FailMoveOn")]
    public RiskFlagInfo FailMoveOn { get; set; }

    [XmlElement("FalseImpersonatePolice")]
    public RiskFlagInfo FalseImpersonatePolice { get; set; }

    [XmlElement("PoliceRadio")]
    public RiskFlagInfo PoliceRadio { get; set; }

    [XmlElement("FleePolice")]
    public RiskFlagInfo FleePolice { get; set; }

    [XmlElement("ObstructEmergencyWorker")]
    public RiskFlagInfo ObstructEmergencyWorker { get; set; }

    [XmlElement("ObstructPolice")]
    public RiskFlagInfo ObstructPolice { get; set; }

    [XmlElement("InterceptPoliceRadio")]
    public RiskFlagInfo InterceptPoliceRadio { get; set; }

}
}