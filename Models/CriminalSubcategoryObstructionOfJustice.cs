using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalSubcategoryObstructionOfJustice")]
public class CriminalSubcategoryObstructionOfJustice
{
    [XmlElement("Perjury")]
    public CriminalChargetypes Perjury { get; set; }

    [XmlElement("SubornPerjury")]
    public CriminalChargetypes SubornPerjury { get; set; }

    [XmlElement("ObstructJustice")]
    public CriminalChargetypes ObstructJustice { get; set; }

    [XmlElement("ObstructCourtOrder")]
    public CriminalChargetypes ObstructCourtOrder { get; set; }

    [XmlElement("JudicialOfficerMiscond")]
    public CriminalChargetypes JudicialOfficerMiscond { get; set; }

    [XmlElement("ContemptCongress")]
    public CriminalChargetypes ContemptCongress { get; set; }

    [XmlElement("ContemptLegislature")]
    public CriminalChargetypes ContemptLegislature { get; set; }

    [XmlElement("BriberyOfJuror")]
    public CriminalChargetypes BriberyOfJuror { get; set; }

    [XmlElement("TamperWithJuror")]
    public CriminalChargetypes TamperWithJuror { get; set; }

    [XmlElement("JurorAcceptBribe")]
    public CriminalChargetypes JurorAcceptBribe { get; set; }

    [XmlElement("BriberyOfJudicialOfficer")]
    public CriminalChargetypes BriberyOfJudicialOfficer { get; set; }

    [XmlElement("WitnessAcceptBribe")]
    public CriminalChargetypes WitnessAcceptBribe { get; set; }

    [XmlElement("FalselyAccuseOfCrime")]
    public CriminalChargetypes FalselyAccuseOfCrime { get; set; }

    [XmlElement("Obstruction")]
    public CriminalChargetypes Obstruction { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}