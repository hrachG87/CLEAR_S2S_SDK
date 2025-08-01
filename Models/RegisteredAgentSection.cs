using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RegisteredAgentSection")]
public class RegisteredAgentSection
{
    [XmlElement("AgentInfoRecord")]
    public List<AgentInfoRecord> AgentInfoRecord { get; set; }

}