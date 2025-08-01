using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("DisorderlyConduct")]
public class DisorderlyConduct
{
    [XmlElement("Curfew")]
    public RiskFlagInfo Curfew { get; set; }

    [XmlElement("Loitering")]
    public RiskFlagInfo Loitering { get; set; }

    [XmlElement("Vagrancy")]
    public RiskFlagInfo Vagrancy { get; set; }

    [XmlElement("RoughCrowd")]
    public RiskFlagInfo RoughCrowd { get; set; }

    [XmlElement("VulgarLanguage")]
    public RiskFlagInfo VulgarLanguage { get; set; }

    [XmlElement("PublicIntoxication")]
    public RiskFlagInfo PublicIntoxication { get; set; }

    [XmlElement("DisorderlyConductRemarks")]
    public RiskFlagInfo DisorderlyConductRemarks { get; set; }
}
