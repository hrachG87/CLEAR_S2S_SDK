using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("Sovereignty")]
public class Sovereignty
{
    [XmlElement("Treason")]
    public RiskFlagInfo Treason { get; set; }

    [XmlElement("TreasonMisprison")]
    public RiskFlagInfo TreasonMisprison { get; set; }

    [XmlElement("Espionage")]
    public RiskFlagInfo Espionage { get; set; }

    [XmlElement("Sabotage")]
    public RiskFlagInfo Sabotage { get; set; }

    [XmlElement("Sedition")]
    public RiskFlagInfo Sedition { get; set; }

    [XmlElement("SelectiveService")]
    public RiskFlagInfo SelectiveService { get; set; }

    [XmlElement("SovereigntyFlag")]
    public RiskFlagInfo SovereigntyFlag { get; set; }

    [XmlElement("DiscloseClassifiedInfo")]
    public RiskFlagInfo DiscloseClassifiedInfo { get; set; }

}