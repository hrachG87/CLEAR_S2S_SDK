using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("BriberyConflictOfInterest")]
public class BriberyConflictOfInterest
{
    [XmlElement("GivingBribe")]
    public RiskFlagInfo GivingBribe { get; set; }

    [XmlElement("OfferingBribe")]
    public RiskFlagInfo OfferingBribe { get; set; }

    [XmlElement("ReceivingBribe")]
    public RiskFlagInfo ReceivingBribe { get; set; }

    [XmlElement("Bribe")]
    public RiskFlagInfo Bribe { get; set; }

    [XmlElement("GivingGratuity")]
    public RiskFlagInfo GivingGratuity { get; set; }

    [XmlElement("OfferingGratuity")]
    public RiskFlagInfo OfferingGratuity { get; set; }

    [XmlElement("ReceivingGratuity")]
    public RiskFlagInfo ReceivingGratuity { get; set; }

    [XmlElement("Gratuity")]
    public RiskFlagInfo Gratuity { get; set; }

    [XmlElement("GivingKickback")]
    public RiskFlagInfo GivingKickback { get; set; }

    [XmlElement("OfferingKickback")]
    public RiskFlagInfo OfferingKickback { get; set; }

    [XmlElement("ReceivingKickback")]
    public RiskFlagInfo ReceivingKickback { get; set; }

    [XmlElement("Kickback")]
    public RiskFlagInfo Kickback { get; set; }

    [XmlElement("Bribery")]
    public RiskFlagInfo Bribery { get; set; }

    [XmlElement("ConflictOfInterest")]
    public RiskFlagInfo ConflictOfInterest { get; set; }

}
}