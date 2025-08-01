using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("TerroristicThreats")]
public class TerroristicThreats
{
    [XmlElement("ThreatenFedProtectee")]
    public RiskFlagInfo ThreatenFedProtectee { get; set; }

    [XmlElement("ThreatenTerrorist")]
    public RiskFlagInfo ThreatenTerrorist { get; set; }

    [XmlElement("ProvideMaterialSupportTerrorism")]
    public RiskFlagInfo ProvideMaterialSupportTerrorism { get; set; }

    [XmlElement("TerroristAct")]
    public RiskFlagInfo TerroristAct { get; set; }

}