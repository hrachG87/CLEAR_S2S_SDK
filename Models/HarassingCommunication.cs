using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("HarassingCommunication")]
public class HarassingCommunication
{
    [XmlElement("HarassingCommunicationFlag")]
    public RiskFlagInfo HarassingCommunicationFlag { get; set; }
}
