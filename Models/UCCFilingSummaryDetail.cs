using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("UCCFilingSummaryDetail")]
public class UCCFilingSummaryDetail
{
    [XmlElement("StartDate")]
    public string StartDate { get; set; }

    [XmlElement("CautionaryUCCCount")]
    public int CautionaryUCCCount { get; set; }

    [XmlElement("TotalFiled")]
    public int TotalFiled { get; set; }

    [XmlElement("ReleasedOrTerminated")]
    public int ReleasedOrTerminated { get; set; }

    [XmlElement("Continuous")]
    public int Continuous { get; set; }

    [XmlElement("AmendedOrAssigned")]
    public int AmendedOrAssigned { get; set; }
}
