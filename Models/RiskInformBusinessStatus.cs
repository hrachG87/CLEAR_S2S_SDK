using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RiskInformBusinessStatus")]
public class RiskInformBusinessStatus
{
    [XmlElement("StatusCode")]
    public int StatusCode { get; set; }

    [XmlElement("SubStatusCode")]
    public int SubStatusCode { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("Message")]
    public string Message { get; set; }
}
