using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalCategorySecretService")]
public class CriminalCategorySecretService
{
    [XmlElement("ThreatToProtectee")]
    public CriminalChargetypes ThreatToProtectee { get; set; }

    [XmlElement("DeportedFelon")]
    public CriminalChargetypes DeportedFelon { get; set; }

    [XmlElement("AlienUnlawfullyPresent")]
    public CriminalChargetypes AlienUnlawfullyPresent { get; set; }

    [XmlElement("ViolationOfNSR")]
    public CriminalChargetypes ViolationOfNSR { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
