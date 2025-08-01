using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("InmateDisciplineInfo")]
public class InmateDisciplineInfo
{
    [XmlElement("DecisionOnAppeal")]
    public string DecisionOnAppeal { get; set; }

    [XmlElement("InfractionDate")]
    public string InfractionDate { get; set; }

    [XmlElement("InfractionDescription")]
    public string InfractionDescription { get; set; }

    [XmlElement("InfractionHearing")]
    public string InfractionHearing { get; set; }

    [XmlElement("InfractionPlea")]
    public string InfractionPlea { get; set; }

    [XmlElement("InfractionTimeLost")]
    public string InfractionTimeLost { get; set; }

    [XmlElement("InfractionVerdict")]
    public string InfractionVerdict { get; set; }

    [XmlElement("InfractionViolationStatus")]
    public string InfractionViolationStatus { get; set; }

}