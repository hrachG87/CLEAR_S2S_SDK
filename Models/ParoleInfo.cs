using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ParoleInfo")]
public class ParoleInfo
{
    [XmlElement("NextParoleHearingDate")]
    public string NextParoleHearingDate { get; set; }

    [XmlElement("ParoleAmendedDate")]
    public string ParoleAmendedDate { get; set; }

    [XmlElement("ParoleBeginDate")]
    public string ParoleBeginDate { get; set; }

    [XmlElement("ParoleEligibilityDate")]
    public string ParoleEligibilityDate { get; set; }

    [XmlElement("ParoleHearing")]
    public List<ParoleHearing> ParoleHearing { get; set; }

    [XmlElement("ParoleTerm")]
    public CriminalDataDurationOfTime ParoleTerm { get; set; }

    [XmlElement("ParoleLocation")]
    public string ParoleLocation { get; set; }

    [XmlElement("ParoleOfficer")]
    public string ParoleOfficer { get; set; }

    [XmlElement("ParoleProjectedDate")]
    public string ParoleProjectedDate { get; set; }

    [XmlElement("ParoleReleaseDate")]
    public string ParoleReleaseDate { get; set; }

    [XmlElement("ParoleTerminationReason")]
    public string ParoleTerminationReason { get; set; }

    [XmlElement("ProbationStatus")]
    public string ProbationStatus { get; set; }

    [XmlElement("SupervisionCounty")]
    public string SupervisionCounty { get; set; }

    [XmlElement("ParoleStatus")]
    public string ParoleStatus { get; set; }

    [XmlElement("ParoleOfficerPhone")]
    public string ParoleOfficerPhone { get; set; }

}
}