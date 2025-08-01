using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RiskInformScore")]
public class RiskInformScore
{
    [XmlElement("RiskInformScoreRecord")]
    public RiskInformScoreRecord RiskInformScoreRecord { get; set; }
}
