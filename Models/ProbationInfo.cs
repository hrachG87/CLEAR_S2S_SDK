using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("ProbationInfo")]
public class ProbationInfo
{
    [XmlElement("PlacementAfterViolation")]
    public string PlacementAfterViolation { get; set; }

    [XmlElement("ProbationActualEndDate")]
    public string ProbationActualEndDate { get; set; }

    [XmlElement("ProbationAfterPrison")]
    public string ProbationAfterPrison { get; set; }

    [XmlElement("ProbationAgency")]
    public string ProbationAgency { get; set; }

    [XmlElement("ProbationBeginDate")]
    public string ProbationBeginDate { get; set; }

    [XmlElement("ProbationScheduledEndDate")]
    public string ProbationScheduledEndDate { get; set; }

    [XmlElement("ProbationTime")]
    public List<CriminalDataDurationOfTime> ProbationTime { get; set; }

    [XmlElement("ProbationMinimumTime")]
    public CriminalDataDurationOfTime ProbationMinimumTime { get; set; }

    [XmlElement("ProbationViolation")]
    public string ProbationViolation { get; set; }

    [XmlElement("ProbationViolationDate")]
    public string ProbationViolationDate { get; set; }

    [XmlElement("ProbConsecutiveConcurrent")]
    public string ProbConsecutiveConcurrent { get; set; }

    [XmlElement("ReturnedToCustodyDate")]
    public string ReturnedToCustodyDate { get; set; }

    [XmlElement("TypeOfProbation")]
    public string TypeOfProbation { get; set; }
}
