using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RIPersonReportScoreRecord")]
public class RIPersonReportScoreRecord
{
    [XmlElement("TotalScore")]
    public string TotalScore { get; set; }

    [XmlElement("MinThresholdScore")]
    public string MinThresholdScore { get; set; }

    [XmlElement("personName")]
    public PersonName personName { get; set; }

    [XmlElement("ssn")]
    public SSNInfo ssn { get; set; }

    [XmlElement("dob")]
    public PersonProfile dob { get; set; }

    [XmlElement("currentAddress")]
    public CommonDataAddress currentAddress { get; set; }

    [XmlElement("header")]
    public RiskInformPersonSearchHeader header { get; set; }

    [XmlElement("sections")]
    public RIPersonSearchSections sections { get; set; }
}
