using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalCategoryExtortion")]
public class CriminalCategoryExtortion
{
    [XmlElement("ExtortionThreatInjurePerson")]
    public CriminalChargetypes ExtortionThreatInjurePerson { get; set; }

    [XmlElement("ExtortionThreatDamageProperty")]
    public CriminalChargetypes ExtortionThreatDamageProperty { get; set; }

    [XmlElement("ExtortionThreatInjureReputation")]
    public CriminalChargetypes ExtortionThreatInjureReputation { get; set; }

    [XmlElement("ExtortionThreatAccusingOfCrime")]
    public CriminalChargetypes ExtortionThreatAccusingOfCrime { get; set; }

    [XmlElement("ExtortionThreatInformOfViolence")]
    public CriminalChargetypes ExtortionThreatInformOfViolence { get; set; }

    [XmlElement("Extortion")]
    public CriminalChargetypes Extortion { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
