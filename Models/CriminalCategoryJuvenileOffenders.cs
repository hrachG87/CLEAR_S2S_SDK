using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalCategoryJuvenileOffenders")]
public class CriminalCategoryJuvenileOffenders
{
    [XmlElement("JuvenileEscape")]
    public CriminalChargetypes JuvenileEscape { get; set; }

    [XmlElement("JuvenileParoleAbscond")]
    public CriminalChargetypes JuvenileParoleAbscond { get; set; }

    [XmlElement("JuvenileProbationAbscond")]
    public CriminalChargetypes JuvenileProbationAbscond { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
