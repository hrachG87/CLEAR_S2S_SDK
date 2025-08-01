using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("BusinessReportCandidate")]
public class BusinessReportCandidate
{
    [XmlElement("BaseGuid")]
    public string BaseGuid { get; set; }

    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }
}
