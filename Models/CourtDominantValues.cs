using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CourtDominantValues")]
public class CourtDominantValues
{
    [XmlElement("Name")]
    public string Name { get; set; }

    [XmlElement("SSN")]
    public string SSN { get; set; }

    [XmlElement("PersonBirthDate")]
    public string PersonBirthDate { get; set; }

    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("CaseState")]
    public string CaseState { get; set; }

    [XmlElement("CaseDate")]
    public string CaseDate { get; set; }

    [XmlElement("MatchToUserSuppliedSSN")]
    public string MatchToUserSuppliedSSN { get; set; }

    [XmlElement("MatchToUserSuppliedDOB")]
    public string MatchToUserSuppliedDOB { get; set; }

    [XmlElement("MatchToSubjectsSSN")]
    public string MatchToSubjectsSSN { get; set; }

    [XmlElement("MatchToSubjectsDOB")]
    public string MatchToSubjectsDOB { get; set; }

}