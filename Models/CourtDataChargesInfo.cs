using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CourtDataChargesInfo")]
public class CourtDataChargesInfo
{
    [XmlElement("NumberOfCounts")]
    public List<string> NumberOfCounts { get; set; }

    [XmlElement("OffenseLevel")]
    public string OffenseLevel { get; set; }

    [XmlElement("Disposition")]
    public List<CaseDisposition> Disposition { get; set; }

    [XmlElement("AmendedCriminalOffense")]
    public string AmendedCriminalOffense { get; set; }

    [XmlElement("AmendedStatute")]
    public ValueAndLabelSet AmendedStatute { get; set; }

    [XmlElement("CourtCharge")]
    public string CourtCharge { get; set; }

    [XmlElement("ClassOfOffense")]
    public string ClassOfOffense { get; set; }

    [XmlElement("OffenseCode")]
    public ValueAndLabelSet OffenseCode { get; set; }

    [XmlElement("OffenseCommitted")]
    public string OffenseCommitted { get; set; }

    [XmlElement("OffenseDate")]
    public string OffenseDate { get; set; }

    [XmlElement("OffenseNotes")]
    public string OffenseNotes { get; set; }

    [XmlElement("PartyTypeAndName")]
    public PartyTypeAndName PartyTypeAndName { get; set; }

    [XmlElement("StatuteViolated")]
    public string StatuteViolated { get; set; }

    [XmlElement("TotalNumberOfCounts")]
    public string TotalNumberOfCounts { get; set; }

    [XmlElement("PendingCounts")]
    public List<CountInfo> PendingCounts { get; set; }

    [XmlElement("TerminatedCounts")]
    public List<CountInfo> TerminatedCounts { get; set; }

}
}