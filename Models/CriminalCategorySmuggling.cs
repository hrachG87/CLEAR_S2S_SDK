using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalCategorySmuggling")]
public class CriminalCategorySmuggling
{
    [XmlElement("SmuggleContraband")]
    public CriminalChargetypes SmuggleContraband { get; set; }

    [XmlElement("SmuggleContraPrisoner")]
    public CriminalChargetypes SmuggleContraPrisoner { get; set; }

    [XmlElement("SmuggleAvoidDuty")]
    public CriminalChargetypes SmuggleAvoidDuty { get; set; }

    [XmlElement("InmatePossessesContraband")]
    public CriminalChargetypes InmatePossessesContraband { get; set; }

    [XmlElement("Smuggling")]
    public CriminalChargetypes Smuggling { get; set; }

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