using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("LiquorLawViolations")]
public class LiquorLawViolations
{
    [XmlElement("ManufactureLiquor")]
    public RiskFlagInfo ManufactureLiquor { get; set; }

    [XmlElement("SaleLiquor")]
    public RiskFlagInfo SaleLiquor { get; set; }

    [XmlElement("TransportLiquor")]
    public RiskFlagInfo TransportLiquor { get; set; }

    [XmlElement("PossessLiquor")]
    public RiskFlagInfo PossessLiquor { get; set; }

    [XmlElement("Liquor")]
    public RiskFlagInfo Liquor { get; set; }

    [XmlElement("MinorPossessLiquor")]
    public RiskFlagInfo MinorPossessLiquor { get; set; }

    [XmlElement("FurnishMinorLiquor")]
    public RiskFlagInfo FurnishMinorLiquor { get; set; }

}