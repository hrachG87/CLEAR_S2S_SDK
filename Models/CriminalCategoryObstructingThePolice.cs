using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalCategoryObstructingThePolice")]
public class CriminalCategoryObstructingThePolice
{
    [XmlElement("ResistOfficer")]
    public CriminalChargetypes ResistOfficer { get; set; }

    [XmlElement("ObstructCrimInvestigation")]
    public CriminalChargetypes ObstructCrimInvestigation { get; set; }

    [XmlElement("FalseReport")]
    public CriminalChargetypes FalseReport { get; set; }

    [XmlElement("DestroyEvidence")]
    public CriminalChargetypes DestroyEvidence { get; set; }

    [XmlElement("DissuadeWitness")]
    public CriminalChargetypes DissuadeWitness { get; set; }

    [XmlElement("DeceiveWitness")]
    public CriminalChargetypes DeceiveWitness { get; set; }

    [XmlElement("RefuseAidOfficer")]
    public CriminalChargetypes RefuseAidOfficer { get; set; }

    [XmlElement("CompoundCrime")]
    public CriminalChargetypes CompoundCrime { get; set; }

    [XmlElement("UnauthCommunPrisoner")]
    public CriminalChargetypes UnauthCommunPrisoner { get; set; }

    [XmlElement("IllegalArrest")]
    public CriminalChargetypes IllegalArrest { get; set; }

    [XmlElement("CrossPoliceLines")]
    public CriminalChargetypes CrossPoliceLines { get; set; }

    [XmlElement("FailReportCrime")]
    public CriminalChargetypes FailReportCrime { get; set; }

    [XmlElement("FailMoveOn")]
    public CriminalChargetypes FailMoveOn { get; set; }

    [XmlElement("InterceptPoliceRadio")]
    public CriminalChargetypes InterceptPoliceRadio { get; set; }

    [XmlElement("FalseImpersonatePolice")]
    public CriminalChargetypes FalseImpersonatePolice { get; set; }

    [XmlElement("PoliceRadio")]
    public CriminalChargetypes PoliceRadio { get; set; }

    [XmlElement("FleePolice")]
    public CriminalChargetypes FleePolice { get; set; }

    [XmlElement("ObstructEmergencyWorker")]
    public CriminalChargetypes ObstructEmergencyWorker { get; set; }

    [XmlElement("ObstructPolice")]
    public CriminalChargetypes ObstructPolice { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
