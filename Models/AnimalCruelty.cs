using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("AnimalCruelty")]
public class AnimalCruelty
{
    [XmlElement("AnimalAbuse")]
    public RiskFlagInfo AnimalAbuse { get; set; }

    [XmlElement("NeglectAnimal")]
    public RiskFlagInfo NeglectAnimal { get; set; }

    [XmlElement("OrganizedAnimal")]
    public RiskFlagInfo OrganizedAnimal { get; set; }

}