using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("MedicalProfile")]
public class MedicalProfile
{
    [XmlElement("AdvancedPracticeStatus")]
    public string AdvancedPracticeStatus { get; set; }

    [XmlElement("ApprovalNumber")]
    public string ApprovalNumber { get; set; }

    [XmlElement("CertNurseMidwife")]
    public string CertNurseMidwife { get; set; }

    [XmlElement("Deceased")]
    public string Deceased { get; set; }

    [XmlElement("Derogatory")]
    public string Derogatory { get; set; }

    [XmlElement("DisciplinaryAction")]
    public List<string> DisciplinaryAction { get; set; }

    [XmlElement("DisplincaryDate")]
    public List<string> DisplincaryDate { get; set; }

    [XmlElement("DispenseMedication")]
    public string DispenseMedication { get; set; }

    [XmlElement("DispensingNumIssueDate")]
    public string DispensingNumIssueDate { get; set; }

    [XmlElement("DispensingNumber")]
    public string DispensingNumber { get; set; }

    [XmlElement("DrugSchedules")]
    public string DrugSchedules { get; set; }

    [XmlElement("EndorsedBy")]
    public string EndorsedBy { get; set; }

    [XmlElement("HospitalName")]
    public List<string> HospitalName { get; set; }

    [XmlElement("IsDispensingPhysician")]
    public string IsDispensingPhysician { get; set; }

    [XmlElement("IsPublicInfo")]
    public string IsPublicInfo { get; set; }

    [XmlElement("LimitEndDate")]
    public string LimitEndDate { get; set; }

    [XmlElement("LimitStartDate")]
    public string LimitStartDate { get; set; }

    [XmlElement("MedSubcategory")]
    public string MedSubcategory { get; set; }

    [XmlElement("OpenInvestigation")]
    public string OpenInvestigation { get; set; }

    [XmlElement("PhysicianInfoChanged")]
    public string PhysicianInfoChanged { get; set; }

    [XmlElement("PracticeSetting")]
    public string PracticeSetting { get; set; }

    [XmlElement("PracticeTime")]
    public string PracticeTime { get; set; }

    [XmlElement("PrescribingAuthority")]
    public string PrescribingAuthority { get; set; }

    [XmlElement("ProbationEndDate")]
    public string ProbationEndDate { get; set; }

    [XmlElement("ProbationStartDate")]
    public string ProbationStartDate { get; set; }

    [XmlElement("PublicHealthNurse")]
    public string PublicHealthNurse { get; set; }

    [XmlElement("ReciprocityNotes")]
    public string ReciprocityNotes { get; set; }

    [XmlElement("RegisteredAgent")]
    public string RegisteredAgent { get; set; }

    [XmlElement("ReciprocityLocation")]
    public string ReciprocityLocation { get; set; }

    [XmlElement("RegistrationStatusDate")]
    public string RegistrationStatusDate { get; set; }

    [XmlElement("ResidentStatus")]
    public string ResidentStatus { get; set; }

    [XmlElement("StateOfReciprocity")]
    public string StateOfReciprocity { get; set; }

    [XmlElement("SupervisingMDName")]
    public List<string> SupervisingMDName { get; set; }

    [XmlElement("TypeOfPractice")]
    public string TypeOfPractice { get; set; }

    [XmlElement("UnprofessionalConduct")]
    public string UnprofessionalConduct { get; set; }

    [XmlElement("ARNPExpireDate")]
    public string ARNPExpireDate { get; set; }

    [XmlElement("ARNPRegNumber")]
    public string ARNPRegNumber { get; set; }

    [XmlElement("ARNPRegistrationDate")]
    public string ARNPRegistrationDate { get; set; }

    [XmlElement("CNACertificateNum")]
    public string CNACertificateNum { get; set; }

    [XmlElement("PAAgent")]
    public string PAAgent { get; set; }

    [XmlElement("PASupervisor")]
    public string PASupervisor { get; set; }

    [XmlElement("SANECredentialDate")]
    public string SANECredentialDate { get; set; }

    [XmlElement("SANEExpireDate")]
    public string SANEExpireDate { get; set; }

    [XmlElement("SANENumber")]
    public string SANENumber { get; set; }

}
}