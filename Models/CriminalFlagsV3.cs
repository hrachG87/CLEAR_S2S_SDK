using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalFlagsV3")]
public class CriminalFlagsV3
{
    [XmlElement("AnimalCrueltyV3")]
    public AnimalCruelty AnimalCrueltyV3 { get; set; }

    [XmlElement("Arson")]
    public Arson Arson { get; set; }

    [XmlElement("AssaultStalking")]
    public AssaultStalking AssaultStalking { get; set; }

    [XmlElement("BailCourtObstruction")]
    public BailCourtObstruction BailCourtObstruction { get; set; }

    [XmlElement("BreachOfPeace")]
    public BreachOfPeace BreachOfPeace { get; set; }

    [XmlElement("BriberyConflictOfInterest")]
    public BriberyConflictOfInterest BriberyConflictOfInterest { get; set; }

    [XmlElement("Burglary")]
    public Burglary Burglary { get; set; }

    [XmlElement("CivilRightsViolation")]
    public CivilRightsViolation CivilRightsViolation { get; set; }

    [XmlElement("CommercialSexOffenses")]
    public CommercialSexOffensesV3 CommercialSexOffenses { get; set; }

    [XmlElement("ConservationAnimalViolation")]
    public ConservationAnimalViolation ConservationAnimalViolation { get; set; }

    [XmlElement("Conspiracy")]
    public Conspiracy Conspiracy { get; set; }

    [XmlElement("CounterfeitingForgery")]
    public CounterfeitingForgery CounterfeitingForgery { get; set; }

    [XmlElement("CriminalTrafficOrTrafficInfraction")]
    public CriminalTrafficOrTrafficInfraction CriminalTrafficOrTrafficInfraction { get; set; }

    [XmlElement("CrimesAgainstPerson")]
    public CrimesAgainstPerson CrimesAgainstPerson { get; set; }

    [XmlElement("DamageProperty")]
    public DamageProperty DamageProperty { get; set; }

    [XmlElement("DisorderlyConduct")]
    public DisorderlyConduct DisorderlyConduct { get; set; }

    [XmlElement("DisturbingThePeace")]
    public DisturbingThePeace DisturbingThePeace { get; set; }

    [XmlElement("Drugs")]
    public Drugs Drugs { get; set; }

    [XmlElement("ElderAbuse")]
    public ElderAbuse ElderAbuse { get; set; }

    [XmlElement("Embezzlement")]
    public Embezzlement Embezzlement { get; set; }

    [XmlElement("Extortion")]
    public Extortion Extortion { get; set; }

    [XmlElement("FamilyOffenses")]
    public FamilyOffenses FamilyOffenses { get; set; }

    [XmlElement("FireworksOffenses")]
    public FireworksOffenses FireworksOffenses { get; set; }

    [XmlElement("FlightEscape")]
    public FlightEscape FlightEscape { get; set; }

    [XmlElement("FraudulentActivities")]
    public FraudulentActivities FraudulentActivities { get; set; }

    [XmlElement("Gambling")]
    public Gambling Gambling { get; set; }

    [XmlElement("HarassingCommunications")]
    public HarassingCommunication HarassingCommunications { get; set; }

    [XmlElement("HealthSafetyViolations")]
    public HealthSafetyViolations HealthSafetyViolations { get; set; }

    [XmlElement("Hijacking")]
    public Hijacking Hijacking { get; set; }

    [XmlElement("HomicideMurderManslaughter")]
    public HomicideMurderManslaughter HomicideMurderManslaughter { get; set; }

    [XmlElement("HumanTrafficking")]
    public HumanTrafficking HumanTrafficking { get; set; }

    [XmlElement("Immigration")]
    public Immigration Immigration { get; set; }

    [XmlElement("InvasionOfPrivacy")]
    public InvasionOfPrivacy InvasionOfPrivacy { get; set; }

    [XmlElement("JuvenileOffenders")]
    public JuvenileOffenders JuvenileOffenders { get; set; }

    [XmlElement("Kidnapping")]
    public Kidnapping Kidnapping { get; set; }

    [XmlElement("LiquorLawViolations")]
    public LiquorLawViolations LiquorLawViolations { get; set; }

    [XmlElement("Marijuana")]
    public Marijuana Marijuana { get; set; }

    [XmlElement("MaterialWitness")]
    public MaterialWitness MaterialWitness { get; set; }

    [XmlElement("Military")]
    public Military Military { get; set; }

    [XmlElement("MoneyLaundering")]
    public MoneyLaundering MoneyLaundering { get; set; }

    [XmlElement("MoralsDecencyCrimes")]
    public MoralsDecencyCrimes MoralsDecencyCrimes { get; set; }

    [XmlElement("MotorVehicleTheft")]
    public MotorVehicleTheft MotorVehicleTheft { get; set; }

    [XmlElement("ObstructingThePolice")]
    public ObstructingThePolice ObstructingThePolice { get; set; }

    [XmlElement("PornographyObsceneMaterial")]
    public PornographyObsceneMaterial PornographyObsceneMaterial { get; set; }

    [XmlElement("PropertyCrimes")]
    public PropertyCrimes PropertyCrimes { get; set; }

    [XmlElement("PublicOrderCrimes")]
    public PublicOrderCrimes PublicOrderCrimes { get; set; }

    [XmlElement("Racketeering")]
    public Racketeering Racketeering { get; set; }

    [XmlElement("Robbery")]
    public Robbery Robbery { get; set; }

    [XmlElement("SecretService")]
    public SecretService SecretService { get; set; }

    [XmlElement("SeriousCriminalTrafficOffenses")]
    public SeriousCriminalTrafficOffenses SeriousCriminalTrafficOffenses { get; set; }

    [XmlElement("SexualAssault")]
    public SexualAssault SexualAssault { get; set; }

    [XmlElement("SexualExploitationEnticement")]
    public SexualExploitationEnticement SexualExploitationEnticement { get; set; }

    [XmlElement("SexOffenses")]
    public SexOffensesV3 SexOffenses { get; set; }

    [XmlElement("Smuggling")]
    public Smuggling Smuggling { get; set; }

    [XmlElement("Sovereignty")]
    public Sovereignty Sovereignty { get; set; }

    [XmlElement("StolenProperty")]
    public StolenProperty StolenProperty { get; set; }

    [XmlElement("TaxRelatedOffenses")]
    public TaxRelatedOffenses TaxRelatedOffenses { get; set; }

    [XmlElement("TerroristicThreats")]
    public TerroristicThreats TerroristicThreats { get; set; }

    [XmlElement("TheftShoplifting")]
    public TheftShoplifting TheftShoplifting { get; set; }

    [XmlElement("Trespassing")]
    public Trespassing Trespassing { get; set; }

    [XmlElement("WeaponOffenses")]
    public WeaponOffenses WeaponOffenses { get; set; }

    [XmlElement("Antitrust")]
    public Antitrust Antitrust { get; set; }

    [XmlElement("ElectionLaws")]
    public ElectionLaws ElectionLaws { get; set; }

    [XmlElement("CommercialVehicleOffense")]
    public CommercialVehicleOffense CommercialVehicleOffense { get; set; }

    [XmlElement("MotorVehicleRegistrationOffense")]
    public MotorVehicleRegistrationOffense MotorVehicleRegistrationOffense { get; set; }

    [XmlElement("TrafficOffense")]
    public TrafficOffense TrafficOffense { get; set; }

    [XmlElement("AccessoryToOffense")]
    public AccessoryToOffense AccessoryToOffense { get; set; }

    [XmlElement("AidingAbetting")]
    public AidingAbetting AidingAbetting { get; set; }

    [XmlElement("Attempt")]
    public Attempt Attempt { get; set; }

    [XmlElement("BiasMotivatedOffense")]
    public BiasMotivatedOffense BiasMotivatedOffense { get; set; }

    [XmlElement("ChildPornography")]
    public ChildPornography ChildPornography { get; set; }

    [XmlElement("CodeViolation")]
    public CodeViolation CodeViolation { get; set; }

    [XmlElement("ComputerExtortion")]
    public ComputerExtortion ComputerExtortion { get; set; }

    [XmlElement("ControlledSubstances")]
    public ControlledSubstances ControlledSubstances { get; set; }

    [XmlElement("DiscloseConfidentialInfo")]
    public DiscloseConfidentialInfo DiscloseConfidentialInfo { get; set; }

    [XmlElement("FacilitateCrime")]
    public FacilitateCrime FacilitateCrime { get; set; }

    [XmlElement("FalseAlarm")]
    public FalseAlarm FalseAlarm { get; set; }

    [XmlElement("FalseBombReport")]
    public FalseBombReport FalseBombReport { get; set; }

    [XmlElement("Gangs")]
    public Gangs Gangs { get; set; }

    [XmlElement("LicenseViolation")]
    public LicenseViolation LicenseViolation { get; set; }

    [XmlElement("OdometerTampering")]
    public OdometerTampering OdometerTampering { get; set; }

    [XmlElement("Ordinances")]
    public Ordinances Ordinances { get; set; }

    [XmlElement("PrescriptionFraud")]
    public PrescriptionFraud PrescriptionFraud { get; set; }

    [XmlElement("PublicRecordsTampering")]
    public PublicRecordsTampering PublicRecordsTampering { get; set; }

    [XmlElement("SolicitingCrime")]
    public SolicitingCrime SolicitingCrime { get; set; }

    [XmlElement("Truancy")]
    public Truancy Truancy { get; set; }

    [XmlElement("Usury")]
    public Usury Usury { get; set; }

    [XmlElement("UncategorizedCriminalRecords")]
    public UncategorizedCriminalRecords UncategorizedCriminalRecords { get; set; }

}