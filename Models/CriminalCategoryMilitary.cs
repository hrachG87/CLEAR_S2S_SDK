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
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}