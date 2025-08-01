using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalCategoryLiquorLawViolations")]
public class CriminalCategoryLiquorLawViolations
{
    [XmlElement("ManufactureLiquor")]
    public CriminalChargetypes ManufactureLiquor { get; set; }

    [XmlElement("SaleLiquor")]
    public CriminalChargetypes SaleLiquor { get; set; }

    [XmlElement("TransportLiquor")]
    public CriminalChargetypes TransportLiquor { get; set; }

    [XmlElement("PossessLiquor")]
    public CriminalChargetypes PossessLiquor { get; set; }

    [XmlElement("MinorPossessLiquor")]
    public CriminalChargetypes MinorPossessLiquor { get; set; }

    [XmlElement("FurnishMinorLiquor")]
    public CriminalChargetypes FurnishMinorLiquor { get; set; }

    [XmlElement("Liquor")]
    public CriminalChargetypes Liquor { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
