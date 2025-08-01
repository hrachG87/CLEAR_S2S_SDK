using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AgentInfoRecord")]
public class AgentInfoRecord
{
    [XmlElement("AgentAddress")]
    public CommonDataAddress AgentAddress { get; set; }

    [XmlElement("AgentFax")]
    public string AgentFax { get; set; }

    [XmlElement("AgentName")]
    public string AgentName { get; set; }

    [XmlElement("AgentNumber")]
    public string AgentNumber { get; set; }

    [XmlElement("AgentPhone")]
    public string AgentPhone { get; set; }

}
}