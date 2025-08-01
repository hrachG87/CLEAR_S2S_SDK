using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("FamilyOffenses")]
public class FamilyOffenses
{
    [XmlElement("NeglectFamily")]
    public RiskFlagInfo NeglectFamily { get; set; }

    [XmlElement("CrueltyToChild")]
    public RiskFlagInfo CrueltyToChild { get; set; }

    [XmlElement("CrueltyToWife")]
    public RiskFlagInfo CrueltyToWife { get; set; }

    [XmlElement("NeglectChild")]
    public RiskFlagInfo NeglectChild { get; set; }

    [XmlElement("NonPaymentAlimony")]
    public RiskFlagInfo NonPaymentAlimony { get; set; }

    [XmlElement("NonSupportParent")]
    public RiskFlagInfo NonSupportParent { get; set; }

    [XmlElement("CrueltyToElderly")]
    public RiskFlagInfo CrueltyToElderly { get; set; }

    [XmlElement("CrueltyToDisabled")]
    public RiskFlagInfo CrueltyToDisabled { get; set; }

    [XmlElement("NeglectElderly")]
    public RiskFlagInfo NeglectElderly { get; set; }

    [XmlElement("NeglectDisabled")]
    public RiskFlagInfo NeglectDisabled { get; set; }

    [XmlElement("FailReportChildAbuse")]
    public RiskFlagInfo FailReportChildAbuse { get; set; }

    [XmlElement("FailReportAbuseOfVulnerableAdult")]
    public RiskFlagInfo FailReportAbuseOfVulnerableAdult { get; set; }

    [XmlElement("FamilyOffense")]
    public RiskFlagInfo FamilyOffense { get; set; }

    [XmlElement("ContribDelinquencyMinor")]
    public RiskFlagInfo ContribDelinquencyMinor { get; set; }

}