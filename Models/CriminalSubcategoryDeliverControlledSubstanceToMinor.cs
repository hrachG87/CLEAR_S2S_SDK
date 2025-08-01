using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalSubcategoryDeliverControlledSubstanceToMinor")]
public class CriminalSubcategoryDeliverControlledSubstanceToMinor
{
    [XmlElement("ControlledSubstanceDeliverToMinor")]
    public CriminalChargetypes ControlledSubstanceDeliverToMinor { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
