using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalCategoryHealthSafetyViolation")]
public class CriminalCategoryHealthSafetyViolation
{
    [XmlElement("AdulteratedDrugs")]
    public CriminalChargetypes AdulteratedDrugs { get; set; }

    [XmlElement("MisbrandedDrugs")]
    public CriminalChargetypes MisbrandedDrugs { get; set; }

    [XmlElement("HealthSafetyDrugs")]
    public CriminalChargetypes HealthSafetyDrugs { get; set; }

    [XmlElement("PoisonFoodWater")]
    public CriminalChargetypes PoisonFoodWater { get; set; }

    [XmlElement("AdulteratedFood")]
    public CriminalChargetypes AdulteratedFood { get; set; }

    [XmlElement("MisbrandedFood")]
    public CriminalChargetypes MisbrandedFood { get; set; }

    [XmlElement("HealthSafetyFood")]
    public CriminalChargetypes HealthSafetyFood { get; set; }

    [XmlElement("DischargePollutionIntoWater")]
    public CriminalChargetypes DischargePollutionIntoWater { get; set; }

    [XmlElement("AdulteratedCosmetic")]
    public CriminalChargetypes AdulteratedCosmetic { get; set; }

    [XmlElement("MisbrandedCosmetic")]
    public CriminalChargetypes MisbrandedCosmetic { get; set; }

    [XmlElement("HealthSafetyCosmetic")]
    public CriminalChargetypes HealthSafetyCosmetic { get; set; }

    [XmlElement("LrgCarnivoreLaw")]
    public CriminalChargetypes LrgCarnivoreLaw { get; set; }

    [XmlElement("DogLawViolation")]
    public CriminalChargetypes DogLawViolation { get; set; }

    [XmlElement("AnimalsAtLarge")]
    public CriminalChargetypes AnimalsAtLarge { get; set; }

    [XmlElement("TobaccoToMinor")]
    public CriminalChargetypes TobaccoToMinor { get; set; }

    [XmlElement("TobaccoMinorUse")]
    public CriminalChargetypes TobaccoMinorUse { get; set; }

    [XmlElement("AircraftSafety")]
    public CriminalChargetypes AircraftSafety { get; set; }

    [XmlElement("BoatNavigationLawsViolation")]
    public CriminalChargetypes BoatNavigationLawsViolation { get; set; }

    [XmlElement("HealthSafety")]
    public CriminalChargetypes HealthSafety { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}