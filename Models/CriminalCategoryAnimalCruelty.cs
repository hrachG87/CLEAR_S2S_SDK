using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalCategoryAnimalCruelty")]
public class CriminalCategoryAnimalCruelty
{
    [XmlElement("AnimalAbuse")]
    public CriminalChargetypes AnimalAbuse { get; set; }

    [XmlElement("OrganizedAnimal")]
    public CriminalChargetypes OrganizedAnimal { get; set; }

    [XmlElement("AnimalSexAbuse")]
    public CriminalChargetypes AnimalSexAbuse { get; set; }

    [XmlElement("NeglectAnimal")]
    public CriminalChargetypes NeglectAnimal { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
