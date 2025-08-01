using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalSubcategoryDeliverControlledSubstanceToMinor")]
public class CriminalSubcategoryDeliverControlledSubstanceToMinor
{
    [XmlElement("ControlledSubstanceDeliverToMinor")]
    public CriminalChargetypes ControlledSubstanceDeliverToMinor { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}