using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalCategoryMilitary")]
public class CriminalCategoryMilitary
{
    [XmlElement("MilitaryDesertion")]
    public CriminalChargetypes MilitaryDesertion { get; set; }

    [XmlElement("Military")]
    public CriminalChargetypes Military { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
