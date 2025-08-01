using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalSubcategoryAssaultOther")]
public class CriminalSubcategoryAssaultOther
{
    [XmlElement("AssaultByInmate")]
    public CriminalChargetypes AssaultByInmate { get; set; }

    [XmlElement("BiasMotivatedAssault")]
    public CriminalChargetypes BiasMotivatedAssault { get; set; }

    [XmlElement("AssaultWithMotorVehicle")]
    public CriminalChargetypes AssaultWithMotorVehicle { get; set; }

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