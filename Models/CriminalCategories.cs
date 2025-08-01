using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalCategories")]
public class CriminalCategories
{
    [XmlElement("UncategorizedCriminalRecords")]
    public CriminalCategoryUncategorizedCriminalRecords UncategorizedCriminalRecords { get; set; }

    [XmlElement("Abortion")]
    public CriminalCategoryAbortion Abortion { get; set; }

    [XmlElement("AbuseOfACorpse")]
    public CriminalCategoryAbuseOfACorpse AbuseOfACorpse { get; set; }

    [XmlElement("AccessoryToOffense")]
    public CriminalCategoryAccessoryToOffense AccessoryToOffense { get; set; }

    [XmlElement("AidingAndAbettingCategory")]
    public CriminalCategoryAidingAndAbettingCategory AidingAndAbettingCategory { get; set; }

    [XmlElement("AnimalCruelty")]
    public CriminalCategoryAnimalCruelty AnimalCruelty { get; set; }

    [XmlElement("Antitrust")]
    public CriminalCategoryAntitrust Antitrust { get; set; }

    [XmlElement("Arson")]
    public CriminalCategoryArson Arson { get; set; }

    [XmlElement("AssaultStalking")]
    public CriminalCategoryAssaultStalking AssaultStalking { get; set; }

    [XmlElement("Attempt")]
    public CriminalCategoryAttempt Attempt { get; set; }

    [XmlElement("AttemptedMurder")]
    public CriminalCategoryAttemptedMurder AttemptedMurder { get; set; }

    [XmlElement("BailCourtObstruction")]
    public CriminalCategoryBailCourtObstruction BailCourtObstruction { get; set; }

    [XmlElement("BiasMotivatedOffense")]
    public CriminalCategoryBiasMotivatedOffense BiasMotivatedOffense { get; set; }

    [XmlElement("BreachOfPeace")]
    public CriminalCategoryBreachOfPeace BreachOfPeace { get; set; }

    [XmlElement("BriberyConflictOfInterest")]
    public CriminalCategoryBriberyConflictOfInterest BriberyConflictOfInterest { get; set; }

    [XmlElement("Burglary")]
    public CriminalCategoryBurglary Burglary { get; set; }

    [XmlElement("ChildPornography")]
    public CriminalCategoryChildPornography ChildPornography { get; set; }

    [XmlElement("CivilRightsViolation")]
    public CriminalCategoryCivilRightsViolation CivilRightsViolation { get; set; }

    [XmlElement("CodeViolationCategory")]
    public CriminalCategoryCodeViolationCategory CodeViolationCategory { get; set; }

    [XmlElement("CommercialSexOffense")]
    public CriminalCategoryCommercialSexOffense CommercialSexOffense { get; set; }

    [XmlElement("ComputerExtortion")]
    public CriminalCategoryComputerExtortion ComputerExtortion { get; set; }

    [XmlElement("ConservationAnimalViolation")]
    public CriminalCategoryConservationAnimalViolation ConservationAnimalViolation { get; set; }

    [XmlElement("Conspiracy")]
    public CriminalCategoryConspiracy Conspiracy { get; set; }

    [XmlElement("ControlledSubstances")]
    public CriminalCategoryControlledSubstances ControlledSubstances { get; set; }

    [XmlElement("CounterfeitingForgery")]
    public CriminalCategoryCounterfeitingForgery CounterfeitingForgery { get; set; }

    [XmlElement("CriminalTrafficOrTrafficInfraction")]
    public CriminalCategoryCriminalTrafficOrTrafficInfraction CriminalTrafficOrTrafficInfraction { get; set; }

    [XmlElement("CrimesAgainstPerson")]
    public CriminalCategoryCrimesAgainstPerson CrimesAgainstPerson { get; set; }

    [XmlElement("DamageProperty")]
    public CriminalCategoryDamageProperty DamageProperty { get; set; }

    [XmlElement("DamagePropertyComputer")]
    public CriminalCategoryDamagePropertyComputer DamagePropertyComputer { get; set; }

    [XmlElement("DiscloseConfidentialInformation")]
    public CriminalCategoryDiscloseConfidentialInformation DiscloseConfidentialInformation { get; set; }

    [XmlElement("DisorderlyConduct")]
    public CriminalCategoryDisorderlyConduct DisorderlyConduct { get; set; }

    [XmlElement("DisturbingThePeace")]
    public CriminalCategoryDisturbingThePeace DisturbingThePeace { get; set; }

    [XmlElement("Drugs")]
    public CriminalCategoryDrugs Drugs { get; set; }

    [XmlElement("ElderAbuse")]
    public CriminalCategoryElderAbuse ElderAbuse { get; set; }

    [XmlElement("ElectionLaws")]
    public CriminalCategoryElectionLaws ElectionLaws { get; set; }

    [XmlElement("Embezzlement")]
    public CriminalCategoryEmbezzlement Embezzlement { get; set; }

    [XmlElement("Extortion")]
    public CriminalCategoryExtortion Extortion { get; set; }

    [XmlElement("FacilitatingACrimeCategory")]
    public CriminalCategoryFacilitatingACrimeCategory FacilitatingACrimeCategory { get; set; }

    [XmlElement("FalseAlarm")]
    public CriminalCategoryFalseAlarm FalseAlarm { get; set; }

    [XmlElement("FalseBombReport")]
    public CriminalCategoryFalseBombReport FalseBombReport { get; set; }

    [XmlElement("FamilyOffenses")]
    public CriminalCategoryFamilyOffenses FamilyOffenses { get; set; }

    [XmlElement("FireworksOffense")]
    public CriminalCategoryFireworksOffense FireworksOffense { get; set; }

    [XmlElement("FlightEscape")]
    public CriminalCategoryFlightEscape FlightEscape { get; set; }

    [XmlElement("FraudulentActivitiesBadChecksCreditCardsImpersonation")]
    public CriminalCategoryFraudulentActivitiesBadChecksCreditCardsImpersonation FraudulentActivitiesBadChecksCreditCardsImpersonation { get; set; }

    [XmlElement("Gambling")]
    public CriminalCategoryGambling Gambling { get; set; }

    [XmlElement("Gangs")]
    public CriminalCategoryGangs Gangs { get; set; }

    [XmlElement("HarassingCommunication")]
    public CriminalCategoryHarassingCommunication HarassingCommunication { get; set; }

    [XmlElement("HealthSafetyViolation")]
    public CriminalCategoryHealthSafetyViolation HealthSafetyViolation { get; set; }

    [XmlElement("Hijacking")]
    public CriminalCategoryHijacking Hijacking { get; set; }

    [XmlElement("HomicideMurderManslaughter")]
    public CriminalCategoryHomicideMurderManslaughter HomicideMurderManslaughter { get; set; }

    [XmlElement("HumanTrafficking")]
    public CriminalCategoryHumanTrafficking HumanTrafficking { get; set; }

    [XmlElement("Immigration")]
    public CriminalCategoryImmigration Immigration { get; set; }

    [XmlElement("InvasionOfPrivacy")]
    public CriminalCategoryInvasionOfPrivacy InvasionOfPrivacy { get; set; }

    [XmlElement("JuvenileOffenders")]
    public CriminalCategoryJuvenileOffenders JuvenileOffenders { get; set; }

    [XmlElement("Kidnapping")]
    public CriminalCategoryKidnapping Kidnapping { get; set; }

    [XmlElement("LicenseViolationCategory")]
    public CriminalCategoryLicenseViolationCategory LicenseViolationCategory { get; set; }

    [XmlElement("LiquorLawViolations")]
    public CriminalCategoryLiquorLawViolations LiquorLawViolations { get; set; }

    [XmlElement("Marijuana")]
    public CriminalCategoryMarijuana Marijuana { get; set; }

    [XmlElement("MaterialWitness")]
    public CriminalCategoryMaterialWitness MaterialWitness { get; set; }

    [XmlElement("Military")]
    public CriminalCategoryMilitary Military { get; set; }

    [XmlElement("MoneyLaundering")]
    public CriminalCategoryMoneyLaundering MoneyLaundering { get; set; }

    [XmlElement("MoralsDecencyCrimes")]
    public CriminalCategoryMoralsDecencyCrimes MoralsDecencyCrimes { get; set; }

    [XmlElement("MotorVehicleTheft")]
    public CriminalCategoryMotorVehicleTheft MotorVehicleTheft { get; set; }

    [XmlElement("ObstructingThePolice")]
    public CriminalCategoryObstructingThePolice ObstructingThePolice { get; set; }

    [XmlElement("OdometerTampering")]
    public CriminalCategoryOdometerTampering OdometerTampering { get; set; }

    [XmlElement("Ordinances")]
    public CriminalCategoryOrdinances Ordinances { get; set; }

    [XmlElement("PornographyObsceneMaterial")]
    public CriminalCategoryPornographyObsceneMaterial PornographyObsceneMaterial { get; set; }

    [XmlElement("PrescriptionFraud")]
    public CriminalCategoryPrescriptionFraud PrescriptionFraud { get; set; }

    [XmlElement("PropertyCrimes")]
    public CriminalCategoryPropertyCrimes PropertyCrimes { get; set; }

    [XmlElement("PublicOrderCrimes")]
    public CriminalCategoryPublicOrderCrimes PublicOrderCrimes { get; set; }

    [XmlElement("PublicRecordsTampering")]
    public CriminalCategoryPublicRecordsTampering PublicRecordsTampering { get; set; }

    [XmlElement("Racketeering")]
    public CriminalCategoryRacketeering Racketeering { get; set; }

    [XmlElement("Robbery")]
    public CriminalCategoryRobbery Robbery { get; set; }

    [XmlElement("SecretService")]
    public CriminalCategorySecretService SecretService { get; set; }

    [XmlElement("SeriousCriminalTrafficOffenses")]
    public CriminalCategorySeriousCriminalTrafficOffenses SeriousCriminalTrafficOffenses { get; set; }

    [XmlElement("SexualAssault")]
    public CriminalCategorySexualAssault SexualAssault { get; set; }

    [XmlElement("SexualExploitationEnticement")]
    public CriminalCategorySexualExploitationEnticement SexualExploitationEnticement { get; set; }

    [XmlElement("SexOffenses")]
    public CriminalCategorySexOffenses SexOffenses { get; set; }

    [XmlElement("Smuggling")]
    public CriminalCategorySmuggling Smuggling { get; set; }

    [XmlElement("SolicitingACrime")]
    public CriminalCategorySolicitingACrime SolicitingACrime { get; set; }

    [XmlElement("Sovereignty")]
    public CriminalCategorySovereignty Sovereignty { get; set; }

    [XmlElement("StolenProperty")]
    public CriminalCategoryStolenProperty StolenProperty { get; set; }

    [XmlElement("TaxRelatedOffenses")]
    public CriminalCategoryTaxRelatedOffenses TaxRelatedOffenses { get; set; }

    [XmlElement("TerroristicThreats")]
    public CriminalCategoryTerroristicThreats TerroristicThreats { get; set; }

    [XmlElement("TheftShoplifting")]
    public CriminalCategoryTheftShoplifting TheftShoplifting { get; set; }

    [XmlElement("Trespassing")]
    public CriminalCategoryTrespassing Trespassing { get; set; }

    [XmlElement("Truancy")]
    public CriminalCategoryTruancy Truancy { get; set; }

    [XmlElement("Usury")]
    public CriminalCategoryUsury Usury { get; set; }

    [XmlElement("WeaponOffenses")]
    public CriminalCategoryWeaponOffenses WeaponOffenses { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}
}