using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CorporateFilings")]
public class CorporateFilings
{
    [XmlElement("CorporateFilingsFlag")]
    public RiskFlagInfo CorporateFilingsFlag { get; set; }
}
