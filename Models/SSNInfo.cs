using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("SSNInfo")]
public class SSNInfo
{
    [XmlElement("SSN")]
    public List<string> SSN { get; set; }

    [XmlElement("PartialSSN")]
    public List<string> PartialSSN { get; set; }

    [XmlElement("MatchToUserSuppliedSSN")]
    public List<string> MatchToUserSuppliedSSN { get; set; }

    [XmlElement("MatchToSubjectsSSN")]
    public List<string> MatchToSubjectsSSN { get; set; }

    [XmlElement("SSNIssuanceText")]
    public string SSNIssuanceText { get; set; }

    [XmlElement("SSNIssueState")]
    public string SSNIssueState { get; set; }

    [XmlElement("SSNIssueDate")]
    public string SSNIssueDate { get; set; }

    [XmlElement("SSNExpirationDate")]
    public string SSNExpirationDate { get; set; }

}