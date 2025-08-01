using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalCategorySovereignty")]
public class CriminalCategorySovereignty
{
    [XmlElement("Treason")]
    public CriminalChargetypes Treason { get; set; }

    [XmlElement("TreasonMisprison")]
    public CriminalChargetypes TreasonMisprison { get; set; }

    [XmlElement("Espionage")]
    public CriminalChargetypes Espionage { get; set; }

    [XmlElement("Sabotage")]
    public CriminalChargetypes Sabotage { get; set; }

    [XmlElement("Sedition")]
    public CriminalChargetypes Sedition { get; set; }

    [XmlElement("SelectiveService")]
    public CriminalChargetypes SelectiveService { get; set; }

    [XmlElement("DiscloseClassifiedInfo")]
    public CriminalChargetypes DiscloseClassifiedInfo { get; set; }

    [XmlElement("Sovereignty")]
    public CriminalChargetypes Sovereignty { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}