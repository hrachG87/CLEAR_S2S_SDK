using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("Sentence")]
public class Sentence
{
    [XmlElement("AdditionalSentenceInformation")]
    public string AdditionalSentenceInformation { get; set; }

    [XmlElement("DurationOfTime")]
    public CriminalDataDurationOfTime DurationOfTime { get; set; }

}
}