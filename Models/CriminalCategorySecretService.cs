using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalCategorySecretService")]
public class CriminalCategorySecretService
{
    [XmlElement("ThreatToProtectee")]
    public CriminalChargetypes ThreatToProtectee { get; set; }

    [XmlElement("DeportedFelon")]
    public CriminalChargetypes DeportedFelon { get; set; }

    [XmlElement("AlienUnlawfullyPresent")]
    public CriminalChargetypes AlienUnlawfullyPresent { get; set; }

    [XmlElement("ViolationOfNSR")]
    public CriminalChargetypes ViolationOfNSR { get; set; }

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