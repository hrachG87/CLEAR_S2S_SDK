using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonUCCFilings")]
public class PersonUCCFilings
{
    [XmlElement("UCCFilingsFlag")]
    public RiskFlagInfo UCCFilingsFlag { get; set; }
}
