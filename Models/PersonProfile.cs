using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonProfile")]
public class PersonProfile
{
    [XmlElement("PersonBirthDate")]
    public List<string> PersonBirthDate { get; set; }

    [XmlElement("YearOfBirth")]
    public List<string> YearOfBirth { get; set; }

    [XmlElement("MonthOfBirth")]
    public List<string> MonthOfBirth { get; set; }

    [XmlElement("DayOfBirth")]
    public List<string> DayOfBirth { get; set; }

    [XmlElement("PersonAgeTo")]
    public List<string> PersonAgeTo { get; set; }

    [XmlElement("PersonAgeFrom")]
    public List<string> PersonAgeFrom { get; set; }

    [XmlElement("PersonDeathIndicator")]
    public List<string> PersonDeathIndicator { get; set; }

    [XmlElement("PersonDeathDate")]
    public List<string> PersonDeathDate { get; set; }

    [XmlElement("PersonDeathPlace")]
    public List<string> PersonDeathPlace { get; set; }

    [XmlElement("PersonBirthPlace")]
    public List<string> PersonBirthPlace { get; set; }

    [XmlElement("PersonBirthState")]
    public List<string> PersonBirthState { get; set; }

    [XmlElement("NumberofDependents")]
    public List<string> NumberofDependents { get; set; }

    [XmlElement("EmployeeOccupation")]
    public List<string> EmployeeOccupation { get; set; }

    [XmlElement("ProfessionalTitle")]
    public List<string> ProfessionalTitle { get; set; }

    [XmlElement("PersonAge")]
    public List<string> PersonAge { get; set; }

    [XmlElement("PersonBuild")]
    public List<string> PersonBuild { get; set; }

    [XmlElement("PersonCitizenship")]
    public List<string> PersonCitizenship { get; set; }

    [XmlElement("PersonEducationLevel")]
    public List<string> PersonEducationLevel { get; set; }

    [XmlElement("PersonEthnicity")]
    public List<string> PersonEthnicity { get; set; }

    [XmlElement("PersonEyeColor")]
    public List<string> PersonEyeColor { get; set; }

    [XmlElement("PersonHairColor")]
    public List<string> PersonHairColor { get; set; }

    [XmlElement("PersonHeight")]
    public List<string> PersonHeight { get; set; }

    [XmlElement("PersonRace")]
    public List<string> PersonRace { get; set; }

    [XmlElement("PersonSex")]
    public List<string> PersonSex { get; set; }

    [XmlElement("PersonSkinTone")]
    public List<string> PersonSkinTone { get; set; }

    [XmlElement("PersonMaritalStatus")]
    public List<string> PersonMaritalStatus { get; set; }

    [XmlElement("PersonSpouseName")]
    public List<string> PersonSpouseName { get; set; }

    [XmlElement("PersonWeight")]
    public List<string> PersonWeight { get; set; }

    [XmlElement("PersonMarkings")]
    public List<string> PersonMarkings { get; set; }

    [XmlElement("PersonMarkingsLocation")]
    public List<string> PersonMarkingsLocation { get; set; }

    [XmlElement("PersonMarkingsType")]
    public List<string> PersonMarkingsType { get; set; }

    [XmlElement("PersonContactEmail")]
    public List<string> PersonContactEmail { get; set; }

    [XmlElement("MatchToUserSuppliedDOB")]
    public List<string> MatchToUserSuppliedDOB { get; set; }

    [XmlElement("MatchToSubjectsDOB")]
    public List<string> MatchToSubjectsDOB { get; set; }

    [XmlElement("PersonBirthDates")]
    public List<PersonBirthDate> PersonBirthDates { get; set; }

}
}