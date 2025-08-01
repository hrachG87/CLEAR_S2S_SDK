using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalCategoryInvasionOfPrivacy")]
public class CriminalCategoryInvasionOfPrivacy
{
    [XmlElement("DivulgeEavesdropInfo")]
    public CriminalChargetypes DivulgeEavesdropInfo { get; set; }

    [XmlElement("DivulgeEavesdropOrder")]
    public CriminalChargetypes DivulgeEavesdropOrder { get; set; }

    [XmlElement("DivulgeMessage")]
    public CriminalChargetypes DivulgeMessage { get; set; }

    [XmlElement("Eavesdropping")]
    public CriminalChargetypes Eavesdropping { get; set; }

    [XmlElement("EavesdropEquipment")]
    public CriminalChargetypes EavesdropEquipment { get; set; }

    [XmlElement("OpenSealedCommun")]
    public CriminalChargetypes OpenSealedCommun { get; set; }

    [XmlElement("TresspassRemarks")]
    public CriminalChargetypes TresspassRemarks { get; set; }

    [XmlElement("FailReportWiretap")]
    public CriminalChargetypes FailReportWiretap { get; set; }

    [XmlElement("InvadePrivacy")]
    public CriminalChargetypes InvadePrivacy { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
