using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("InvasionOfPrivacy")]
public class InvasionOfPrivacy
{
    [XmlElement("DivulgeEavesdropInfo")]
    public RiskFlagInfo DivulgeEavesdropInfo { get; set; }

    [XmlElement("DivulgeEavesdropOrder")]
    public RiskFlagInfo DivulgeEavesdropOrder { get; set; }

    [XmlElement("DivulgeMessage")]
    public RiskFlagInfo DivulgeMessage { get; set; }

    [XmlElement("Eavesdropping")]
    public RiskFlagInfo Eavesdropping { get; set; }

    [XmlElement("EavesdropEquipment")]
    public RiskFlagInfo EavesdropEquipment { get; set; }

    [XmlElement("OpenSealedCommun")]
    public RiskFlagInfo OpenSealedCommun { get; set; }

    [XmlElement("TrespassRemarks")]
    public RiskFlagInfo TrespassRemarks { get; set; }

    [XmlElement("FailReportWiretap")]
    public RiskFlagInfo FailReportWiretap { get; set; }

    [XmlElement("InvadePrivacy")]
    public RiskFlagInfo InvadePrivacy { get; set; }
}
