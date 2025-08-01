using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("Sentence")]
public class Sentence
{
    [XmlElement("AdditionalSentenceInformation")]
    public string AdditionalSentenceInformation { get; set; }

    [XmlElement("DurationOfTime")]
    public CriminalDataDurationOfTime DurationOfTime { get; set; }

}