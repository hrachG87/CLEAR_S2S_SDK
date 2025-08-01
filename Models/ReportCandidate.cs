using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("ReportCandidate")]
public class ReportCandidate
{
    [XmlElement("BaseGuid")]
    public string BaseGuid { get; set; }

    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }

    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }
}
