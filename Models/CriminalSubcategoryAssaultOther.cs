using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalSubcategoryAssaultOther")]
public class CriminalSubcategoryAssaultOther
{
    [XmlElement("AssaultByInmate")]
    public CriminalChargetypes AssaultByInmate { get; set; }

    [XmlElement("BiasMotivatedAssault")]
    public CriminalChargetypes BiasMotivatedAssault { get; set; }

    [XmlElement("AssaultWithMotorVehicle")]
    public CriminalChargetypes AssaultWithMotorVehicle { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
