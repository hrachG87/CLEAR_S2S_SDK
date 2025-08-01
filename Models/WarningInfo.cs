using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("WarningInfo")]
public class WarningInfo
{
    [XmlElement("GangAffiliation")]
    public string GangAffiliation { get; set; }

    [XmlElement("EscapeRisk")]
    public string EscapeRisk { get; set; }

    [XmlElement("HearingProblems")]
    public string HearingProblems { get; set; }

    [XmlElement("HistoryOfViolence")]
    public string HistoryOfViolence { get; set; }

    [XmlElement("MedicalAlert")]
    public string MedicalAlert { get; set; }

    [XmlElement("MentalIllness")]
    public string MentalIllness { get; set; }

    [XmlElement("SexOffender")]
    public string SexOffender { get; set; }

    [XmlElement("SuicideRisk")]
    public string SuicideRisk { get; set; }

    [XmlElement("Warning")]
    public List<string> Warning { get; set; }
}
