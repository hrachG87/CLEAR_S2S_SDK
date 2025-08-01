using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("FraudServicesInfo")]
public class FraudServicesInfo
{
    [XmlElement("TypeCode")]
    public string TypeCode { get; set; }

    [XmlElement("FraudServicesCode")]
    public FraudServicesCode FraudServicesCode { get; set; }

    [XmlElement("DateOfBirth")]
    public DateOfBirth DateOfBirth { get; set; }

    [XmlElement("DateOfDeath")]
    public string DateOfDeath { get; set; }

    [XmlElement("SICCode")]
    public string SICCode { get; set; }

    [XmlElement("SSNFirstIssueYear")]
    public string SSNFirstIssueYear { get; set; }

    [XmlElement("SSNLastIssueYear")]
    public string SSNLastIssueYear { get; set; }

}