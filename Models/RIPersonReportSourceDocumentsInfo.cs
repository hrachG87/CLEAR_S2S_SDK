using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RIPersonReportSourceDocumentsInfo")]
public class RIPersonReportSourceDocumentsInfo
{
    [XmlElement("SourceName")]
    public string SourceName { get; set; }

    [XmlElement("DocumentCount")]
    public string DocumentCount { get; set; }

    [XmlElement("DocumentGuids")]
    public string DocumentGuids { get; set; }

    [XmlElement("HistoricCreditBureauRecord")]
    public List<HistoricCreditBureauRecord> HistoricCreditBureauRecord { get; set; }

    [XmlElement("HealthcareSanctionRecord")]
    public List<HealthcareSanctionRecord> HealthcareSanctionRecord { get; set; }

    [XmlElement("ArrestRecord")]
    public List<ArrestRecord> ArrestRecord { get; set; }

    [XmlElement("CriminalExpansionRecord")]
    public List<CriminalExpansionRecord> CriminalExpansionRecord { get; set; }

    [XmlElement("CriminalRecord")]
    public List<CriminalRecord> CriminalRecord { get; set; }

    [XmlElement("DriverLicenseRecord")]
    public List<DriverLicenseRecord> DriverLicenseRecord { get; set; }

    [XmlElement("ProfLicenseRecord")]
    public List<ProfLicenseRecord> ProfLicenseRecord { get; set; }

    [XmlElement("MarijuanaRelatedBusinessRecord")]
    public List<MarijuanaRelatedBusinessRecord> MarijuanaRelatedBusinessRecord { get; set; }

    [XmlElement("WorldCheckRecord")]
    public List<WorldCheckRecord> WorldCheckRecord { get; set; }

    [XmlElement("BankAccountHeaderRecord")]
    public List<BankAccountHeaderRecord> BankAccountHeaderRecord { get; set; }

    [XmlElement("TransUnionRecord")]
    public List<TransUnionRecord> TransUnionRecord { get; set; }

    [XmlElement("VehicleRecord")]
    public List<VehicleRecord> VehicleRecord { get; set; }

    [XmlElement("DeathRecord")]
    public List<DeathRecord> DeathRecord { get; set; }

    [XmlElement("EquifaxCreditHeaderRecord")]
    public List<EquifaxCreditHeaderRecord> EquifaxCreditHeaderRecord { get; set; }

    [XmlElement("ExperianRecord")]
    public List<ExperianRecord> ExperianRecord { get; set; }

    [XmlElement("GlobalSanctionRecord")]
    public List<GlobalSanctionRecord> GlobalSanctionRecord { get; set; }

    [XmlElement("AddressCompilationRecord")]
    public List<AddressCompilationRecord> AddressCompilationRecord { get; set; }

    [XmlElement("FedDocketBankruptcyRecord")]
    public List<FedDocketBankruptcyRecord> FedDocketBankruptcyRecord { get; set; }

    [XmlElement("PublicBankruptcyRecord")]
    public List<PublicBankruptcyRecord> PublicBankruptcyRecord { get; set; }

    [XmlElement("SuperiorBankruptcyRecord")]
    public List<SuperiorBankruptcyRecord> SuperiorBankruptcyRecord { get; set; }

    [XmlElement("UtilityRecord")]
    public List<UtilityRecord> UtilityRecord { get; set; }

    [XmlElement("LienJudgeRecord")]
    public List<LienJudgeRecord> LienJudgeRecord { get; set; }

    [XmlElement("LienJudgeNYRecord")]
    public List<LienJudgeNYRecord> LienJudgeNYRecord { get; set; }

    [XmlElement("LienJudgeMultipleRecord")]
    public List<LienJudgeMultipleRecord> LienJudgeMultipleRecord { get; set; }

    [XmlElement("LowerCourtLawsuitRecord")]
    public List<LowerCourtLawsuitRecord> LowerCourtLawsuitRecord { get; set; }

    [XmlElement("LawsuitRecord")]
    public List<LawsuitRecord> LawsuitRecord { get; set; }

    [XmlElement("PropertyTaxRecord")]
    public List<PropertyTaxRecord> PropertyTaxRecord { get; set; }

    [XmlElement("PropertyDeedRecord")]
    public List<PropertyDeedRecord> PropertyDeedRecord { get; set; }

    [XmlElement("StateBoatRecord")]
    public List<StateBoatRecord> StateBoatRecord { get; set; }

    [XmlElement("MotorVehicleServiceAndWarrantyRecord")]
    public List<MotorVehicleServiceAndWarrantyRecord> MotorVehicleServiceAndWarrantyRecord { get; set; }

    [XmlElement("ForeclosureRecord")]
    public List<ForeclosureRecord> ForeclosureRecord { get; set; }

    [XmlElement("AircraftRecord")]
    public List<AircraftRecord> AircraftRecord { get; set; }

    [XmlElement("FederalEmployerIDRecord")]
    public List<FederalEmployerIDRecord> FederalEmployerIDRecord { get; set; }

    [XmlElement("PhoneRecord")]
    public List<PhoneRecord> PhoneRecord { get; set; }

    [XmlElement("CorporateRecord")]
    public List<CorporateRecord> CorporateRecord { get; set; }

    [XmlElement("DunBradstreetRecord")]
    public List<DunBradstreetRecord> DunBradstreetRecord { get; set; }

    [XmlElement("WorldbaseRecord")]
    public List<WorldbaseRecord> WorldbaseRecord { get; set; }

    [XmlElement("ExecutiveProfileRecord")]
    public List<ExecutiveProfileRecord> ExecutiveProfileRecord { get; set; }

    [XmlElement("BusinessPhoneRecord")]
    public List<BusinessPhoneRecord> BusinessPhoneRecord { get; set; }

    [XmlElement("BusinessProfileRecord")]
    public List<BusinessProfileRecord> BusinessProfileRecord { get; set; }

    [XmlElement("BusinessContactRecord")]
    public List<BusinessContactRecord> BusinessContactRecord { get; set; }

    [XmlElement("HealthcareLicenseRecord")]
    public List<HealthcareLicenseRecord> HealthcareLicenseRecord { get; set; }

    [XmlElement("StateDocketRecord")]
    public List<StateDocketRecord> StateDocketRecord { get; set; }

    [XmlElement("DistrictCourtDocketRecord")]
    public List<DistrictCourtDocketRecord> DistrictCourtDocketRecord { get; set; }

    [XmlElement("CircuitCourtDocketRecord")]
    public List<CircuitCourtDocketRecord> CircuitCourtDocketRecord { get; set; }

    [XmlElement("USCoastGuardRecord")]
    public List<USCoastGuardRecord> USCoastGuardRecord { get; set; }

    [XmlElement("NPIRecord")]
    public List<NPIRecord> NPIRecord { get; set; }

    [XmlElement("ccwlicenseRecord")]
    public List<CCWLicenseRecord> ccwlicenseRecord { get; set; }

}
}