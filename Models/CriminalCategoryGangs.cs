using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalCategoryGangs")]
public class CriminalCategoryGangs
{
    [XmlElement("GangRelatedCrime")]
    public CriminalChargetypes GangRelatedCrime { get; set; }

    [XmlElement("SolicitGangMembers")]
    public CriminalChargetypes SolicitGangMembers { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
