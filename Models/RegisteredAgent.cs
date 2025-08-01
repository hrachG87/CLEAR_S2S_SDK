using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RegisteredAgent")]
public class RegisteredAgent
{
    [XmlElement("AgentName")]
    public string AgentName { get; set; }

    [XmlElement("AgentAddress")]
    public CommonDataAddress AgentAddress { get; set; }
}
