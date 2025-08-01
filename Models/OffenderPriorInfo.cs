using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("OffenderPriorInfo")]
public class OffenderPriorInfo
{
    [XmlElement("InmateReleaseInfo")]
    public InmateReleaseInfo InmateReleaseInfo { get; set; }

    [XmlElement("PriorChargesInfo")]
    public PriorChargesInfo PriorChargesInfo { get; set; }

    [XmlElement("SentencingInfo")]
    public CriminalSentencingInfo SentencingInfo { get; set; }

    [XmlElement("PriorCaseNumber")]
    public string PriorCaseNumber { get; set; }

    [XmlElement("PriorCrimeDate")]
    public string PriorCrimeDate { get; set; }

    [XmlElement("PriorCrimeCategory")]
    public string PriorCrimeCategory { get; set; }

    [XmlElement("PriorCrimeClass")]
    public string PriorCrimeClass { get; set; }

    [XmlElement("PriorDisposition")]
    public string PriorDisposition { get; set; }

    [XmlElement("PriorDispositionDate")]
    public string PriorDispositionDate { get; set; }

}
}