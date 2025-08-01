using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("ProfLicenseRecord")]
public class ProfLicenseRecord
{
    [XmlElement("Alias")]
    public string Alias { get; set; }

    [XmlElement("AttorneyProfInfo")]
    public AttorneyProfInfo AttorneyProfInfo { get; set; }

    [XmlElement("AttorneyTitle")]
    public string AttorneyTitle { get; set; }

    [XmlElement("ContactInfo")]
    public LicenseDataContactInfo ContactInfo { get; set; }

    [XmlElement("EducationInfo")]
    public List<LicenseDataEducationInfo> EducationInfo { get; set; }

    [XmlElement("EmployeeInfo")]
    public EmployeeInfo EmployeeInfo { get; set; }

    [XmlElement("FurtherInfo")]
    public FurtherInfo FurtherInfo { get; set; }

    [XmlElement("InsuranceProfInfo")]
    public InsuranceProfInfo InsuranceProfInfo { get; set; }

    [XmlElement("ProLicenseInfo")]
    public ProLicenseInfo ProLicenseInfo { get; set; }

    [XmlElement("MedicalProfile")]
    public MedicalProfile MedicalProfile { get; set; }

    [XmlElement("PersonInfo")]
    public LicensePersonInfo PersonInfo { get; set; }

    [XmlElement("PersonalAddresses")]
    public PersonalAddresses PersonalAddresses { get; set; }

    [XmlElement("PracticeLocation")]
    public string PracticeLocation { get; set; }

    [XmlElement("PreviousEmployer")]
    public PreviousEmployer PreviousEmployer { get; set; }

    [XmlElement("RealEstateInfo")]
    public LicenseRealEstateInfo RealEstateInfo { get; set; }

    [XmlElement("TradeName")]
    public string TradeName { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }
}
