using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalCharges")]
public class CriminalCharges
{
    [XmlElement("AmendedCriminalOffense")]
    public string AmendedCriminalOffense { get; set; }

    [XmlElement("AmendedStatuteViolated")]
    public string AmendedStatuteViolated { get; set; }

    [XmlElement("ChargesTypeOfDocument")]
    public string ChargesTypeOfDocument { get; set; }

    [XmlElement("ClassOfCrime")]
    public string ClassOfCrime { get; set; }

    [XmlElement("ConvictionLocation")]
    public string ConvictionLocation { get; set; }

    [XmlElement("CountyOfCrime")]
    public string CountyOfCrime { get; set; }

    [XmlElement("CrimeDate")]
    public string CrimeDate { get; set; }

    [XmlElement("CrimeIndicators")]
    public CrimeIndicators CrimeIndicators { get; set; }

    [XmlElement("CriminalCourt")]
    public string CriminalCourt { get; set; }

    [XmlElement("CriminalOffense")]
    public string CriminalOffense { get; set; }

    [XmlElement("DispositionOfCrime")]
    public string DispositionOfCrime { get; set; }

    [XmlElement("HighestFelonyClass")]
    public string HighestFelonyClass { get; set; }

    [XmlElement("NumberOfCounts")]
    public string NumberOfCounts { get; set; }

    [XmlElement("OffenderStatus")]
    public string OffenderStatus { get; set; }

    [XmlElement("StatuteViolated")]
    public string StatuteViolated { get; set; }

    [XmlElement("TotalConvictedUniqueOffenses")]
    public string TotalConvictedUniqueOffenses { get; set; }

    [XmlElement("TownOfCrime")]
    public string TownOfCrime { get; set; }

    [XmlElement("BailAmount")]
    public string BailAmount { get; set; }

    [XmlElement("CaseInfo")]
    public CriminalDataCaseInfo CaseInfo { get; set; }

    [XmlElement("CourtDateInfo")]
    public CourtDateInfo CourtDateInfo { get; set; }

    [XmlElement("InmateReleaseInfo")]
    public InmateReleaseInfo InmateReleaseInfo { get; set; }

    [XmlElement("MiscellaneousInfo")]
    public List<string> MiscellaneousInfo { get; set; }

    [XmlElement("WarrantNumber")]
    public string WarrantNumber { get; set; }

}
}