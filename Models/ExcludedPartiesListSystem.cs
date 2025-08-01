using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("ExcludedPartiesListSystem")]
public class ExcludedPartiesListSystem
{
    [XmlElement("EPLS")]
    public RiskFlagInfo EPLS { get; set; }
}
