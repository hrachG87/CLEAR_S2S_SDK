using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonDocumentResponseDetail")]
public class PersonDocumentResponseDetail
{
    [XmlElement("AddressCompilationRecord")]
    public List<AddressCompilationRecord> AddressCompilationRecord { get; set; }

    [XmlElement("ExperianRecord")]
    public List<ExperianRecord> ExperianRecord { get; set; }

    [XmlElement("HistoricCreditBureauRecord")]
    public List<HistoricCreditBureauRecord> HistoricCreditBureauRecord { get; set; }

    [XmlElement("HouseholdListingRecord")]
    public List<HouseholdListingRecord> HouseholdListingRecord { get; set; }

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

    [XmlElement("DocumentGuids")]
    public List<Sources> DocumentGuids { get; set; }

    [XmlElement("EquifaxCreditHeaderRecord")]
    public List<EquifaxCreditHeaderRecord> EquifaxCreditHeaderRecord { get; set; }

    [XmlElement("BankAccountHeaderRecord")]
    public List<BankAccountHeaderRecord> BankAccountHeaderRecord { get; set; }

    [XmlElement("BusinessContactRecord")]
    public List<BusinessContactRecord> BusinessContactRecord { get; set; }

    [XmlElement("NPIRecord")]
    public List<NPIRecord> NPIRecord { get; set; }

}