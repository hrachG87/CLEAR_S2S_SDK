using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalCategoryTerroristicThreats")]
public class CriminalCategoryTerroristicThreats
{
    [XmlElement("ThreatenFedProtectee")]
    public CriminalChargetypes ThreatenFedProtectee { get; set; }

    [XmlElement("ThreatenTerrorist")]
    public CriminalChargetypes ThreatenTerrorist { get; set; }

    [XmlElement("ProvideMaterialSupportTerrorism")]
    public CriminalChargetypes ProvideMaterialSupportTerrorism { get; set; }

    [XmlElement("TerroristAct")]
    public CriminalChargetypes TerroristAct { get; set; }

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