using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("ControlledSubstances")]
public class ControlledSubstances
{
    [XmlElement("ControlledSubstanceObtainByFraud")]
    public RiskFlagInfo ControlledSubstanceObtainByFraud { get; set; }

    [XmlElement("ControlledSubstanceManufacture")]
    public RiskFlagInfo ControlledSubstanceManufacture { get; set; }

    [XmlElement("ControlledSubstanceSell")]
    public RiskFlagInfo ControlledSubstanceSell { get; set; }

    [XmlElement("ControlledSubstancePossession")]
    public RiskFlagInfo ControlledSubstancePossession { get; set; }

    [XmlElement("ControlledSubstanceRemarks")]
    public RiskFlagInfo ControlledSubstanceRemarks { get; set; }

    [XmlElement("ControlledSubstanceCounterfeitSell")]
    public RiskFlagInfo ControlledSubstanceCounterfeitSell { get; set; }

    [XmlElement("ControlledSubstanceCounterfeitPossession")]
    public RiskFlagInfo ControlledSubstanceCounterfeitPossession { get; set; }

    [XmlElement("ControlledSubstanceDeliverToMinor")]
    public RiskFlagInfo ControlledSubstanceDeliverToMinor { get; set; }
}
