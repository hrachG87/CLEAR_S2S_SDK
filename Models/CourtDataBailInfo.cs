using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CourtDataBailInfo")]
public class CourtDataBailInfo
{
    [XmlElement("BailPosted")]
    public string BailPosted { get; set; }

    [XmlElement("BailerName")]
    public string BailerName { get; set; }

    [XmlElement("BondNumber")]
    public string BondNumber { get; set; }

    [XmlElement("CountNumber")]
    public string CountNumber { get; set; }

    [XmlElement("DateBailPosted")]
    public string DateBailPosted { get; set; }

    [XmlElement("PartyNumber")]
    public string PartyNumber { get; set; }

    [XmlElement("Status")]
    public CourtStatus Status { get; set; }
}
