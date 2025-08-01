using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("Smuggling")]
public class Smuggling
{
    [XmlElement("SmuggleContraband")]
    public RiskFlagInfo SmuggleContraband { get; set; }

    [XmlElement("SmuggleContraPrisoner")]
    public RiskFlagInfo SmuggleContraPrisoner { get; set; }

    [XmlElement("SmuggleAvoidDuty")]
    public RiskFlagInfo SmuggleAvoidDuty { get; set; }

    [XmlElement("SmugglingFlag")]
    public RiskFlagInfo SmugglingFlag { get; set; }

    [XmlElement("InmatePossessesContraband")]
    public RiskFlagInfo InmatePossessesContraband { get; set; }

}
}