using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AdditionalBusinessFactsRecord")]
public class AdditionalBusinessFactsRecord
{
    [XmlElement("StateOfOriginComment")]
    public string StateOfOriginComment { get; set; }

    [XmlElement("StateOfOrigin")]
    public string StateOfOrigin { get; set; }

    [XmlElement("DateOfIncorporation")]
    public string DateOfIncorporation { get; set; }

    [XmlElement("CurrentStatus")]
    public string CurrentStatus { get; set; }

    [XmlElement("BusinessType")]
    public string BusinessType { get; set; }

    [XmlElement("CharterNumber")]
    public string CharterNumber { get; set; }

    [XmlElement("Agent")]
    public string Agent { get; set; }

    [XmlElement("AgentAddress")]
    public Address AgentAddress { get; set; }

    [XmlElement("Competitors")]
    public Competitors Competitors { get; set; }
}
