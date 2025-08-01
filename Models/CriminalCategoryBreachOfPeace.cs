using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalCategoryBreachOfPeace")]
public class CriminalCategoryBreachOfPeace
{
    [XmlElement("Anarchism")]
    public CriminalChargetypes Anarchism { get; set; }

    [XmlElement("IncitingRiot")]
    public CriminalChargetypes IncitingRiot { get; set; }

    [XmlElement("EngagingRiot")]
    public CriminalChargetypes EngagingRiot { get; set; }

    [XmlElement("InterfereWithFirearmDuringRiot")]
    public CriminalChargetypes InterfereWithFirearmDuringRiot { get; set; }

    [XmlElement("InterfereWithOfficerDuringRiot")]
    public CriminalChargetypes InterfereWithOfficerDuringRiot { get; set; }

    [XmlElement("Riot")]
    public CriminalChargetypes Riot { get; set; }

    [XmlElement("UnlawfulAssembly")]
    public CriminalChargetypes UnlawfulAssembly { get; set; }

    [XmlElement("Desecrating")]
    public CriminalChargetypes Desecrating { get; set; }

    [XmlElement("ObsceneTelecall")]
    public CriminalChargetypes ObsceneTelecall { get; set; }

    [XmlElement("PublicPeace")]
    public CriminalChargetypes PublicPeace { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
