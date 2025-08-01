using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonDetails")]
public class PersonDetails
{
    [XmlElement("BodyMarkInfo")]
    public List<BodyMarkInfo> BodyMarkInfo { get; set; }

    [XmlElement("DriverLicenseInfo")]
    public List<DriverLicenseInfo> DriverLicenseInfo { get; set; }

    [XmlElement("StateIDInfo")]
    public List<IDDetails> StateIDInfo { get; set; }

    [XmlElement("CorrectiveLenses")]
    public string CorrectiveLenses { get; set; }

    [XmlElement("FacialHair")]
    public string FacialHair { get; set; }

    [XmlElement("Handedness")]
    public string Handedness { get; set; }

    [XmlElement("LanguageRead")]
    public string LanguageRead { get; set; }

    [XmlElement("LanguageSpoken")]
    public string LanguageSpoken { get; set; }

    [XmlElement("LanguageWritten")]
    public string LanguageWritten { get; set; }

    [XmlElement("LegalResidentStatus")]
    public string LegalResidentStatus { get; set; }

    [XmlElement("MilitaryBranchName")]
    public CriminalPersonMilitarySummary MilitaryBranchName { get; set; }

    [XmlElement("PersonalDescription")]
    public string PersonalDescription { get; set; }

    [XmlElement("PersonCharacteristics")]
    public PersonProfile PersonCharacteristics { get; set; }

    [XmlElement("PrimaryLanguage")]
    public string PrimaryLanguage { get; set; }

    [XmlElement("SpeaksEnglish")]
    public string SpeaksEnglish { get; set; }

    [XmlElement("TypeOfBlood")]
    public string TypeOfBlood { get; set; }

    [XmlElement("IDInfo")]
    public List<IDDetails> IDInfo { get; set; }

    [XmlElement("FBINumber")]
    public List<string> FBINumber { get; set; }

    [XmlElement("USResidentStatus")]
    public string USResidentStatus { get; set; }

}
}