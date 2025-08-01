using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalSubcategoryFamilyOffenses")]
public class CriminalSubcategoryFamilyOffenses
{
    [XmlElement("NeglectFamily")]
    public CriminalChargetypes NeglectFamily { get; set; }

    [XmlElement("CrueltyToChild")]
    public CriminalChargetypes CrueltyToChild { get; set; }

    [XmlElement("CrueltyToWife")]
    public CriminalChargetypes CrueltyToWife { get; set; }

    [XmlElement("NeglectChild")]
    public CriminalChargetypes NeglectChild { get; set; }

    [XmlElement("NonPaymentAlimony")]
    public CriminalChargetypes NonPaymentAlimony { get; set; }

    [XmlElement("NonSupportParent")]
    public CriminalChargetypes NonSupportParent { get; set; }

    [XmlElement("CrueltytoElderly")]
    public CriminalChargetypes CrueltytoElderly { get; set; }

    [XmlElement("CrueltytoDisabled")]
    public CriminalChargetypes CrueltytoDisabled { get; set; }

    [XmlElement("NeglectElderly")]
    public CriminalChargetypes NeglectElderly { get; set; }

    [XmlElement("NeglectDisabled")]
    public CriminalChargetypes NeglectDisabled { get; set; }

    [XmlElement("FailReportChildAbuse")]
    public CriminalChargetypes FailReportChildAbuse { get; set; }

    [XmlElement("FailReportAbuseOfVulnerableAdult")]
    public CriminalChargetypes FailReportAbuseOfVulnerableAdult { get; set; }

    [XmlElement("FamilyOffense")]
    public CriminalChargetypes FamilyOffense { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}