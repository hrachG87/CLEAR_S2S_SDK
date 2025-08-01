using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalSubcategoryManufactureSellDistribute")]
public class CriminalSubcategoryManufactureSellDistribute
{
    [XmlElement("HallucinogenManufacture")]
    public CriminalChargetypes HallucinogenManufacture { get; set; }

    [XmlElement("HallucinogenDistribute")]
    public CriminalChargetypes HallucinogenDistribute { get; set; }

    [XmlElement("HallucinogenSell")]
    public CriminalChargetypes HallucinogenSell { get; set; }

    [XmlElement("HeroinSell")]
    public CriminalChargetypes HeroinSell { get; set; }

    [XmlElement("HeroinSmuggle")]
    public CriminalChargetypes HeroinSmuggle { get; set; }

    [XmlElement("OpiumSell")]
    public CriminalChargetypes OpiumSell { get; set; }

    [XmlElement("OpiumSmuggle")]
    public CriminalChargetypes OpiumSmuggle { get; set; }

    [XmlElement("CocaineSell")]
    public CriminalChargetypes CocaineSell { get; set; }

    [XmlElement("CocaineSmuggle")]
    public CriminalChargetypes CocaineSmuggle { get; set; }

    [XmlElement("SyntheticNarcoticSell")]
    public CriminalChargetypes SyntheticNarcoticSell { get; set; }

    [XmlElement("SyntheticNarcoticsSmuggle")]
    public CriminalChargetypes SyntheticNarcoticsSmuggle { get; set; }

    [XmlElement("AmphetamineManufacture")]
    public CriminalChargetypes AmphetamineManufacture { get; set; }

    [XmlElement("AmphetamineSell")]
    public CriminalChargetypes AmphetamineSell { get; set; }

    [XmlElement("BarbiturateManufacture")]
    public CriminalChargetypes BarbiturateManufacture { get; set; }

    [XmlElement("BarbiturateSell")]
    public CriminalChargetypes BarbiturateSell { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}