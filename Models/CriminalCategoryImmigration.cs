using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalCategoryImmigration")]
public class CriminalCategoryImmigration
{
    [XmlElement("IllegalEntry")]
    public CriminalChargetypes IllegalEntry { get; set; }

    [XmlElement("FalseCitizenship")]
    public CriminalChargetypes FalseCitizenship { get; set; }

    [XmlElement("SmugglingAliens")]
    public CriminalChargetypes SmugglingAliens { get; set; }

    [XmlElement("Immigration")]
    public CriminalChargetypes Immigration { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
