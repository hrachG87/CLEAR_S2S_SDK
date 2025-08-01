using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalCategoryConservationAnimalViolation")]
public class CriminalCategoryConservationAnimalViolation
{
    [XmlElement("ConserveAnimalRemarks")]
    public CriminalChargetypes ConserveAnimalRemarks { get; set; }

    [XmlElement("ConserveAnimal")]
    public CriminalChargetypes ConserveAnimal { get; set; }

    [XmlElement("ConserveFish")]
    public CriminalChargetypes ConserveFish { get; set; }

    [XmlElement("ConserveBirds")]
    public CriminalChargetypes ConserveBirds { get; set; }

    [XmlElement("ConserveLicenseStamp")]
    public CriminalChargetypes ConserveLicenseStamp { get; set; }

    [XmlElement("ConserveEnvironment")]
    public CriminalChargetypes ConserveEnvironment { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}