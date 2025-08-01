using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("Drugs")]
public class Drugs
{
    [XmlElement("HallucinogenManufacture")]
    public RiskFlagInfo HallucinogenManufacture { get; set; }

    [XmlElement("HallucinogenDistribute")]
    public RiskFlagInfo HallucinogenDistribute { get; set; }

    [XmlElement("HallucinogenSell")]
    public RiskFlagInfo HallucinogenSell { get; set; }

    [XmlElement("HeroinSell")]
    public RiskFlagInfo HeroinSell { get; set; }

    [XmlElement("HeroinSmuggle")]
    public RiskFlagInfo HeroinSmuggle { get; set; }

    [XmlElement("OpiumSell")]
    public RiskFlagInfo OpiumSell { get; set; }

    [XmlElement("OpiumSmuggle")]
    public RiskFlagInfo OpiumSmuggle { get; set; }

    [XmlElement("CocaineSell")]
    public RiskFlagInfo CocaineSell { get; set; }

    [XmlElement("CocaineSmuggle")]
    public RiskFlagInfo CocaineSmuggle { get; set; }

    [XmlElement("SyntheticNarcoticSell")]
    public RiskFlagInfo SyntheticNarcoticSell { get; set; }

    [XmlElement("SyntheticNarcoticsSmuggle")]
    public RiskFlagInfo SyntheticNarcoticsSmuggle { get; set; }

    [XmlElement("AmphetamineManufacture")]
    public RiskFlagInfo AmphetamineManufacture { get; set; }

    [XmlElement("AmphetamineSell")]
    public RiskFlagInfo AmphetamineSell { get; set; }

    [XmlElement("BarbiturateManufacture")]
    public RiskFlagInfo BarbiturateManufacture { get; set; }

    [XmlElement("BarbiturateSell")]
    public RiskFlagInfo BarbiturateSell { get; set; }

    [XmlElement("Barbiturate")]
    public RiskFlagInfo Barbiturate { get; set; }

    [XmlElement("Amphetamine")]
    public RiskFlagInfo Amphetamine { get; set; }

    [XmlElement("DangerousDrugs")]
    public RiskFlagInfo DangerousDrugs { get; set; }

    [XmlElement("Hallucinogen")]
    public RiskFlagInfo Hallucinogen { get; set; }

    [XmlElement("Heroin")]
    public RiskFlagInfo Heroin { get; set; }

    [XmlElement("Opium")]
    public RiskFlagInfo Opium { get; set; }

    [XmlElement("Cocaine")]
    public RiskFlagInfo Cocaine { get; set; }

    [XmlElement("SyntheticNarcotic")]
    public RiskFlagInfo SyntheticNarcotic { get; set; }

    [XmlElement("HallucinogenPossession")]
    public RiskFlagInfo HallucinogenPossession { get; set; }

    [XmlElement("HeroinPossession")]
    public RiskFlagInfo HeroinPossession { get; set; }

    [XmlElement("OpiumPossession")]
    public RiskFlagInfo OpiumPossession { get; set; }

    [XmlElement("CocainePossession")]
    public RiskFlagInfo CocainePossession { get; set; }

    [XmlElement("SyntheticNarcoticPossession")]
    public RiskFlagInfo SyntheticNarcoticPossession { get; set; }

    [XmlElement("AmphetaminePossession")]
    public RiskFlagInfo AmphetaminePossession { get; set; }

    [XmlElement("BarbituratePossession")]
    public RiskFlagInfo BarbituratePossession { get; set; }

    [XmlElement("NarcoticEquipmentPossession")]
    public RiskFlagInfo NarcoticEquipmentPossession { get; set; }
}
