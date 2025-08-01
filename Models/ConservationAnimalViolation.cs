using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("ConservationAnimalViolation")]
public class ConservationAnimalViolation
{
    [XmlElement("ConserveAnimalRemarks")]
    public RiskFlagInfo ConserveAnimalRemarks { get; set; }

    [XmlElement("ConserveAnimal")]
    public RiskFlagInfo ConserveAnimal { get; set; }

    [XmlElement("ConserveFish")]
    public RiskFlagInfo ConserveFish { get; set; }

    [XmlElement("ConserveBirds")]
    public RiskFlagInfo ConserveBirds { get; set; }

    [XmlElement("ConserveLicenseStamp")]
    public RiskFlagInfo ConserveLicenseStamp { get; set; }

    [XmlElement("ConserveEnvironment")]
    public RiskFlagInfo ConserveEnvironment { get; set; }

}