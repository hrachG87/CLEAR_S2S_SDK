using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("Liens")]
public class Liens
{
    [XmlElement("LiensOverAmount")]
    public RiskFlagInfo LiensOverAmount { get; set; }

    [XmlElement("FederalTaxLien")]
    public RiskFlagInfo FederalTaxLien { get; set; }

    [XmlElement("StateTaxLien")]
    public RiskFlagInfo StateTaxLien { get; set; }

    [XmlElement("FederalTaxLienRelease")]
    public RiskFlagInfo FederalTaxLienRelease { get; set; }

    [XmlElement("StateTaxLienRelease")]
    public RiskFlagInfo StateTaxLienRelease { get; set; }

    [XmlElement("MiscLiens")]
    public RiskFlagInfo MiscLiens { get; set; }

    [XmlElement("MiscLiensRelease")]
    public RiskFlagInfo MiscLiensRelease { get; set; }

    [XmlElement("MultipleTaxLiens")]
    public RiskFlagInfo MultipleTaxLiens { get; set; }

    [XmlElement("LiensTotalAmount")]
    public RiskFlagInfo LiensTotalAmount { get; set; }

}
}