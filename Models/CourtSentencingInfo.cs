using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CourtSentencingInfo")]
public class CourtSentencingInfo
{
    [XmlElement("ConsecutiveConcurrent")]
    public string ConsecutiveConcurrent { get; set; }

    [XmlElement("CourtCharge")]
    public string CourtCharge { get; set; }

    [XmlElement("FullfillmentMethod")]
    public string FullfillmentMethod { get; set; }

    [XmlElement("MaximumSentence")]
    public CourtDataDurationOfTime MaximumSentence { get; set; }

    [XmlElement("MinimumSentence")]
    public CourtDataDurationOfTime MinimumSentence { get; set; }

    [XmlElement("PartyNumber")]
    public List<string> PartyNumber { get; set; }

    [XmlElement("SentenceDate")]
    public string SentenceDate { get; set; }

    [XmlElement("SentenceDescription")]
    public string SentenceDescription { get; set; }

    [XmlElement("SentenceNumber")]
    public string SentenceNumber { get; set; }

    [XmlElement("TotalSentence")]
    public string TotalSentence { get; set; }
}
