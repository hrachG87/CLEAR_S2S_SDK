using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RiskInformScoreRecord")]
public class RiskInformScoreRecord
{
    [XmlElement("TotalScore")]
    public string TotalScore { get; set; }

    [XmlElement("MinThresholdScore")]
    public string MinThresholdScore { get; set; }

    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("FEIN")]
    public string FEIN { get; set; }

    [XmlElement("PhoneNumber")]
    public string PhoneNumber { get; set; }

    [XmlElement("CurrentAddress")]
    public CommonDataAddress CurrentAddress { get; set; }

    [XmlElement("Header")]
    public Header Header { get; set; }

    [XmlElement("Sections")]
    public RIBusinessSearchSections Sections { get; set; }

}