using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("ProLicenseInfo")]
public class ProLicenseInfo
{
    [XmlElement("ActiveEffectiveDate")]
    public string ActiveEffectiveDate { get; set; }

    [XmlElement("AdditionalLicenseInfo")]
    public string AdditionalLicenseInfo { get; set; }

    [XmlElement("AlternateLicenseNum")]
    public List<string> AlternateLicenseNum { get; set; }

    [XmlElement("BasisOfLicensure")]
    public string BasisOfLicensure { get; set; }

    [XmlElement("BoardAction")]
    public string BoardAction { get; set; }

    [XmlElement("BoardActionCaseNum")]
    public string BoardActionCaseNum { get; set; }

    [XmlElement("BoardActionEffDate")]
    public string BoardActionEffDate { get; set; }

    [XmlElement("BoardActionInd")]
    public string BoardActionInd { get; set; }

    [XmlElement("BoardCertified")]
    public string BoardCertified { get; set; }

    [XmlElement("CertificationInfo")]
    public List<LicenseDataLicenseInfo> CertificationInfo { get; set; }

    [XmlElement("CertifiedSpecialty")]
    public string CertifiedSpecialty { get; set; }

    [XmlElement("ClassOfLicense")]
    public string ClassOfLicense { get; set; }

    [XmlElement("ConditionalLicense")]
    public string ConditionalLicense { get; set; }

    [XmlElement("FirstLicenseDate")]
    public string FirstLicenseDate { get; set; }

    [XmlElement("HowLicensed")]
    public string HowLicensed { get; set; }

    [XmlElement("InactiveReqDate")]
    public string InactiveReqDate { get; set; }

    [XmlElement("InStateLicense")]
    public string InStateLicense { get; set; }

    [XmlElement("LicenseActive")]
    public string LicenseActive { get; set; }

    [XmlElement("LicenseClassDesc")]
    public string LicenseClassDesc { get; set; }

    [XmlElement("LicenseClassStatus")]
    public string LicenseClassStatus { get; set; }

    [XmlElement("LicenseDescription")]
    public string LicenseDescription { get; set; }

    [XmlElement("LicenseDiscipline")]
    public string LicenseDiscipline { get; set; }

    [XmlElement("LicenseId")]
    public string LicenseId { get; set; }

    [XmlElement("LicenseNumberMsg")]
    public string LicenseNumberMsg { get; set; }

    [XmlElement("LicenseReinstateDate")]
    public string LicenseReinstateDate { get; set; }

    [XmlElement("LicenseRenewalDate")]
    public string LicenseRenewalDate { get; set; }

    [XmlElement("LicenseRenewalPeriod")]
    public string LicenseRenewalPeriod { get; set; }

    [XmlElement("LicenseRestriction")]
    public string LicenseRestriction { get; set; }

    [XmlElement("LicenseRevokeDate")]
    public string LicenseRevokeDate { get; set; }

    [XmlElement("LicenseSanctionDate")]
    public string LicenseSanctionDate { get; set; }

    [XmlElement("LicenseState")]
    public string LicenseState { get; set; }

    [XmlElement("LicenseSubjectToProc")]
    public string LicenseSubjectToProc { get; set; }

    [XmlElement("LicenseTransactionDate")]
    public string LicenseTransactionDate { get; set; }

    [XmlElement("LicenseTypeMsg")]
    public string LicenseTypeMsg { get; set; }

    [XmlElement("LicenseUpdateDate")]
    public string LicenseUpdateDate { get; set; }

    [XmlElement("LicensingAgency")]
    public string LicensingAgency { get; set; }

    [XmlElement("MethodOfLicensure")]
    public string MethodOfLicensure { get; set; }

    [XmlElement("OtherLicenseNum")]
    public List<string> OtherLicenseNum { get; set; }

    [XmlElement("OtherStatesLicensed")]
    public List<string> OtherStatesLicensed { get; set; }

    [XmlElement("OutOfStateLicense")]
    public string OutOfStateLicense { get; set; }

    [XmlElement("PracticeArea")]
    public string PracticeArea { get; set; }

    [XmlElement("PrereqLicenseNumber")]
    public string PrereqLicenseNumber { get; set; }

    [XmlElement("PrereqLicenseType")]
    public string PrereqLicenseType { get; set; }

    [XmlElement("PrimaryPracState")]
    public string PrimaryPracState { get; set; }

    [XmlElement("PrimeBoardCertified")]
    public string PrimeBoardCertified { get; set; }

    [XmlElement("SecondBoardCertified")]
    public string SecondBoardCertified { get; set; }

    [XmlElement("SecondaryPracState")]
    public string SecondaryPracState { get; set; }

    [XmlElement("Specialty")]
    public List<string> Specialty { get; set; }

    [XmlElement("SpecialtyPrivilege")]
    public string SpecialtyPrivilege { get; set; }

    [XmlElement("StateOfOriginalLic")]
    public string StateOfOriginalLic { get; set; }

    [XmlElement("TempLicExpDate")]
    public string TempLicExpDate { get; set; }

    [XmlElement("TempLicIssuedDate")]
    public string TempLicIssuedDate { get; set; }

    [XmlElement("TempLicenseNumber")]
    public string TempLicenseNumber { get; set; }

    [XmlElement("ThirdPracState")]
    public string ThirdPracState { get; set; }

    [XmlElement("TypeOfLicenseExam")]
    public string TypeOfLicenseExam { get; set; }

    [XmlElement("TypeOfProvider")]
    public string TypeOfProvider { get; set; }

    [XmlElement("YearLicensed")]
    public string YearLicensed { get; set; }

}