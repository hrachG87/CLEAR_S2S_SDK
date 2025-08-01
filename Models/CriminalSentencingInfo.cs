using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalSentencingInfo")]
public class CriminalSentencingInfo
{
    [XmlElement("CommunityService")]
    public CommunityService CommunityService { get; set; }

    [XmlElement("ConsecutiveConcurrent")]
    public string ConsecutiveConcurrent { get; set; }

    [XmlElement("LicenseSuspension")]
    public CriminalDataDurationOfTime LicenseSuspension { get; set; }

    [XmlElement("MaximumSentencing")]
    public CriminalDataDurationOfTime MaximumSentencing { get; set; }

    [XmlElement("MinimumSentencing")]
    public CriminalDataDurationOfTime MinimumSentencing { get; set; }

    [XmlElement("Sentence")]
    public Sentence Sentence { get; set; }

    [XmlElement("SentenceBeginDate")]
    public string SentenceBeginDate { get; set; }

    [XmlElement("SentenceCompleted")]
    public string SentenceCompleted { get; set; }

    [XmlElement("SentenceCounty")]
    public string SentenceCounty { get; set; }

    [XmlElement("SentenceDescription")]
    public string SentenceDescription { get; set; }

    [XmlElement("SentenceEffectiveDate")]
    public string SentenceEffectiveDate { get; set; }

    [XmlElement("SentenceExpirationDate")]
    public string SentenceExpirationDate { get; set; }

    [XmlElement("SentenceImposedDate")]
    public string SentenceImposedDate { get; set; }

    [XmlElement("SentenceModifiedDate")]
    public string SentenceModifiedDate { get; set; }

    [XmlElement("SentencePardoned")]
    public string SentencePardoned { get; set; }

    [XmlElement("SentenceStatus")]
    public string SentenceStatus { get; set; }

    [XmlElement("SentenceSuspension")]
    public CriminalDataDurationOfTime SentenceSuspension { get; set; }

    [XmlElement("SentenceVerified")]
    public string SentenceVerified { get; set; }

}