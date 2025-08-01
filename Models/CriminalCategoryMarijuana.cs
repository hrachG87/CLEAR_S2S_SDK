using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalCategoryMarijuana")]
public class CriminalCategoryMarijuana
{
    [XmlElement("GrowSellDistribute")]
    public CriminalSubcategoryGrowSellDistribute GrowSellDistribute { get; set; }

    [XmlElement("Possession")]
    public CriminalSubcategoryMarijuanaPossession Possession { get; set; }

    [XmlElement("OtherOffense")]
    public CriminalSubcategoryOtherOffense OtherOffense { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
