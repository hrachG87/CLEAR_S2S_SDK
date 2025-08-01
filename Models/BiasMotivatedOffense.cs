using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("BiasMotivatedOffense")]
public class BiasMotivatedOffense
{
    [XmlElement("BiasMotivatedOffenseFlag")]
    public RiskFlagInfo BiasMotivatedOffenseFlag { get; set; }
}
