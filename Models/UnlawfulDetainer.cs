using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("UnlawfulDetainer")]
public class UnlawfulDetainer
{
    [XmlElement("UnlawfulCivil")]
    public RiskFlagInfo UnlawfulCivil { get; set; }

    [XmlElement("UnlawfulJudge")]
    public RiskFlagInfo UnlawfulJudge { get; set; }
}
