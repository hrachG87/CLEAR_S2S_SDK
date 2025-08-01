using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("DocumentRetrievalResponseDetail")]
public class DocumentRetrievalResponseDetail
{
    [XmlElement("AddressCompilationRecord")]
    public List<AddressCompilationRecord> AddressCompilationRecord { get; set; }

    [XmlElement("ExperianRecord")]
    public List<ExperianRecord> ExperianRecord { get; set; }

    [XmlElement("HistoricCreditBureauRecord")]
    public List<HistoricCreditBureauRecord> HistoricCreditBureauRecord { get; set; }

    [XmlElement("HouseholdListingRecord")]
    public List<HouseholdListingRecord> HouseholdListingRecord { get; set; }

    [XmlElement("MilitaryRecord")]
    public List<MilitaryRecord> MilitaryRecord { get; set; }

    [XmlElement("NewMoverRecord")]
    public List<NewMoverRecord> NewMoverRecord { get; set; }

    [XmlElement("PhoneRecord")]
    public List<PhoneRecord> PhoneRecord { get; set; }

    [XmlElement("TransUnionRecord")]
    public List<TransUnionRecord> TransUnionRecord { get; set; }

    [XmlElement("CanadianPhoneRecord")]
    public List<CanadianPhoneRecord> CanadianPhoneRecord { get; set; }

    [XmlElement("ObituaryRecord")]
    public List<ObituaryRecord> ObituaryRecord { get; set; }

    [XmlElement("DeathRecord")]
    public List<DeathRecord> DeathRecord { get; set; }

    [XmlElement("DeceasedRecord")]
    public List<DeceasedRecord> DeceasedRecord { get; set; }

    [XmlElement("UtilityRecord")]
    public List<UtilityRecord> UtilityRecord { get; set; }

    [XmlElement("DriverLicenseRecord")]
    public List<DriverLicenseRecord> DriverLicenseRecord { get; set; }

    [XmlElement("WorldCheckRecord")]
    public List<WorldCheckRecord> WorldCheckRecord { get; set; }

    [XmlElement("WorkAffiliationRecord")]
    public List<WorkAffiliationRecord> WorkAffiliationRecord { get; set; }

    [XmlElement("HuntFishLicenseRecord")]
    public List<HuntFishLicenseRecord> HuntFishLicenseRecord { get; set; }

    [XmlElement("VoterRecord")]
    public List<VoterRecord> VoterRecord { get; set; }

    [XmlElement("BusinessPhoneRecord")]
    public List<BusinessPhoneRecord> BusinessPhoneRecord { get; set; }

    [XmlElement("CorporateRecord")]
    public List<CorporateRecord> CorporateRecord { get; set; }

    [XmlElement("DunBradStreetRecord")]
    public List<DunBradstreetRecord> DunBradStreetRecord { get; set; }

    [XmlElement("FederalEmployeeIDRecord")]
    public List<FederalEmployerIDRecord> FederalEmployeeIDRecord { get; set; }

    [XmlElement("FictitiousBusinessRecord")]
    public List<FictitiousBusinessRecord> FictitiousBusinessRecord { get; set; }

    [XmlElement("InfractionRecord")]
    public List<CriminalRecord> InfractionRecord { get; set; }

    [XmlElement("GlobalSanctionRecord")]
    public List<GlobalSanctionRecord> GlobalSanctionRecord { get; set; }

    [XmlElement("WorldbaseRecord")]
    public List<WorldbaseRecord> WorldbaseRecord { get; set; }

    [XmlElement("CanadianBusinessPhoneRecord")]
    public List<BusinessPhoneRecord> CanadianBusinessPhoneRecord { get; set; }

    [XmlElement("ExecutiveAffiliationRecord")]
    public List<ExecutiveAffiliationRecord> ExecutiveAffiliationRecord { get; set; }

    [XmlElement("ExecutiveBioRecord")]
    public List<ExecutiveBioRecord> ExecutiveBioRecord { get; set; }

    [XmlElement("ExecutiveProfileRecord")]
    public List<ExecutiveProfileRecord> ExecutiveProfileRecord { get; set; }

    [XmlElement("BusinessProfileRecord")]
    public List<BusinessProfileRecord> BusinessProfileRecord { get; set; }

    [XmlElement("ArrestRecord")]
    public List<ArrestRecord> ArrestRecord { get; set; }

    [XmlElement("CriminalRecord")]
    public List<CriminalRecord> CriminalRecord { get; set; }

    [XmlElement("CriminalExpansionRecord")]
    public List<CriminalExpansionRecord> CriminalExpansionRecord { get; set; }

    [XmlElement("ProfLicenseRecord")]
    public List<ProfLicenseRecord> ProfLicenseRecord { get; set; }

    [XmlElement("FedDocketBankruptcyRecord")]
    public List<FedDocketBankruptcyRecord> FedDocketBankruptcyRecord { get; set; }

    [XmlElement("SuperiorBankruptcyRecord")]
    public List<SuperiorBankruptcyRecord> SuperiorBankruptcyRecord { get; set; }

    [XmlElement("PublicBankruptcyRecord")]
    public List<PublicBankruptcyRecord> PublicBankruptcyRecord { get; set; }

    [XmlElement("HealthcareSanctionRecord")]
    public List<HealthcareSanctionRecord> HealthcareSanctionRecord { get; set; }

    [XmlElement("MoneyServiceRecord")]
    public List<MoneyServiceRecord> MoneyServiceRecord { get; set; }

    [XmlElement("RealTimeArrestRecord")]
    public List<RealTimeArrestRecord> RealTimeArrestRecord { get; set; }

    [XmlElement("VehicleRecord")]
    public List<VehicleRecord> VehicleRecord { get; set; }

    [XmlElement("EmailRecord")]
    public List<EmailRecord> EmailRecord { get; set; }

    [XmlElement("EquifaxCreditHeaderRecord")]
    public List<EquifaxCreditHeaderRecord> EquifaxCreditHeaderRecord { get; set; }

    [XmlElement("MotorVehicleServiceAndWarrantyRecord")]
    public List<MotorVehicleServiceAndWarrantyRecord> MotorVehicleServiceAndWarrantyRecord { get; set; }

    [XmlElement("DivorceRecord")]
    public List<DivorceRecord> DivorceRecord { get; set; }

    [XmlElement("MarriageRecord")]
    public List<MarriageRecord> MarriageRecord { get; set; }

    [XmlElement("HealthcareLicenseRecord")]
    public List<HealthcareLicenseRecord> HealthcareLicenseRecord { get; set; }

    [XmlElement("CircuitCourtDocketRecord")]
    public List<CircuitCourtDocketRecord> CircuitCourtDocketRecord { get; set; }

    [XmlElement("DistrictCourtDocketRecord")]
    public List<DistrictCourtDocketRecord> DistrictCourtDocketRecord { get; set; }

    [XmlElement("LawsuitRecord")]
    public List<LawsuitRecord> LawsuitRecord { get; set; }

    [XmlElement("LienJudgeMultipleRecord")]
    public List<LienJudgeMultipleRecord> LienJudgeMultipleRecord { get; set; }

    [XmlElement("LienJudgeNYRecord")]
    public List<LienJudgeNYRecord> LienJudgeNYRecord { get; set; }

    [XmlElement("LienJudgeRecord")]
    public List<LienJudgeRecord> LienJudgeRecord { get; set; }

    [XmlElement("LowerCourtLawsuitRecord")]
    public List<LowerCourtLawsuitRecord> LowerCourtLawsuitRecord { get; set; }

    [XmlElement("StateDocketRecord")]
    public List<StateDocketRecord> StateDocketRecord { get; set; }

    [XmlElement("ForeclosureRecord")]
    public List<ForeclosureRecord> ForeclosureRecord { get; set; }

    [XmlElement("PropertyDeedRecord")]
    public List<PropertyDeedRecord> PropertyDeedRecord { get; set; }

    [XmlElement("PropertyTaxRecord")]
    public List<PropertyTaxRecord> PropertyTaxRecord { get; set; }

    [XmlElement("AircraftRecord")]
    public List<AircraftRecord> AircraftRecord { get; set; }

    [XmlElement("StateBoatRecord")]
    public List<StateBoatRecord> StateBoatRecord { get; set; }

    [XmlElement("MarijuanaRelatedBusinessRecord")]
    public List<MarijuanaRelatedBusinessRecord> MarijuanaRelatedBusinessRecord { get; set; }

    [XmlElement("CompanyFundamentalsRecord")]
    public List<CompanyFundamentalsRecord> CompanyFundamentalsRecord { get; set; }

    [XmlElement("BankAccountHeaderRecord")]
    public List<BankAccountHeaderRecord> BankAccountHeaderRecord { get; set; }

    [XmlElement("BusinessContactRecord")]
    public List<BusinessContactRecord> BusinessContactRecord { get; set; }

    [XmlElement("UCCRecord")]
    public List<UCCRecord> UCCRecord { get; set; }

    [XmlElement("USCoastGuardRecord")]
    public List<USCoastGuardRecord> USCoastGuardRecord { get; set; }

    [XmlElement("UCCNYRecord")]
    public List<UCCNYRecord> UCCNYRecord { get; set; }

    [XmlElement("NPIRecord")]
    public List<NPIRecord> NPIRecord { get; set; }

    [XmlElement("CCWLicenseRecord")]
    public List<CCWLicenseRecord> CCWLicenseRecord { get; set; }

}