using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("HealthSafetyViolations")]
public class HealthSafetyViolations
{
    [XmlElement("AdulteratedDrugs")]
    public RiskFlagInfo AdulteratedDrugs { get; set; }

    [XmlElement("MisbrandedDrugs")]
    public RiskFlagInfo MisbrandedDrugs { get; set; }

    [XmlElement("HealthSafetyDrugs")]
    public RiskFlagInfo HealthSafetyDrugs { get; set; }

    [XmlElement("DischargePollutionIntoWater")]
    public RiskFlagInfo DischargePollutionIntoWater { get; set; }

    [XmlElement("AdulteratedFood")]
    public RiskFlagInfo AdulteratedFood { get; set; }

    [XmlElement("MisbrandedFood")]
    public RiskFlagInfo MisbrandedFood { get; set; }

    [XmlElement("HealthSafetyFood")]
    public RiskFlagInfo HealthSafetyFood { get; set; }

    [XmlElement("AdulteratedCosmetic")]
    public RiskFlagInfo AdulteratedCosmetic { get; set; }

    [XmlElement("MisbrandedCosmetic")]
    public RiskFlagInfo MisbrandedCosmetic { get; set; }

    [XmlElement("HealthSafetyCosmetic")]
    public RiskFlagInfo HealthSafetyCosmetic { get; set; }

    [XmlElement("LrgCarnivoreLaw")]
    public RiskFlagInfo LrgCarnivoreLaw { get; set; }

    [XmlElement("Dog Law Violation")]
    public RiskFlagInfo Dog Law Violation { get; set; }

    [XmlElement("AnimalsAtLarge")]
    public RiskFlagInfo AnimalsAtLarge { get; set; }

    [XmlElement("TobaccoToMinor")]
    public RiskFlagInfo TobaccoToMinor { get; set; }

    [XmlElement("TobaccoMinorUse")]
    public RiskFlagInfo TobaccoMinorUse { get; set; }

    [XmlElement("AircraftSafety")]
    public RiskFlagInfo AircraftSafety { get; set; }

    [XmlElement("BoatNavigationLawsViolation")]
    public RiskFlagInfo BoatNavigationLawsViolation { get; set; }

    [XmlElement("HealthSafety")]
    public RiskFlagInfo HealthSafety { get; set; }

    [XmlElement("PoisonFoodWater")]
    public RiskFlagInfo PoisonFoodWater { get; set; }
}
