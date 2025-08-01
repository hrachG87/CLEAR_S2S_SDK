using System;
using System.Collections.Generic;
using System.Xml.Serialization;

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
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
