using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalCategoryAnimalCrueltyV3")]
public class CriminalCategoryAnimalCrueltyV3
{
    [XmlElement("AnimalAbuse")]
    public CriminalChargetypes AnimalAbuse { get; set; }

    [XmlElement("OrganizedAnimal")]
    public CriminalChargetypes OrganizedAnimal { get; set; }

    [XmlElement("NeglectAnimal")]
    public CriminalChargetypes NeglectAnimal { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}
}