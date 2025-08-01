using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalCategoryRacketeering")]
public class CriminalCategoryRacketeering
{
    [XmlElement("Racketeering")]
    public CriminalChargetypes Racketeering { get; set; }

    [XmlElement("ProceedsFromRacketeering")]
    public CriminalChargetypes ProceedsFromRacketeering { get; set; }

    [XmlElement("PropertyFromRacketeering")]
    public CriminalChargetypes PropertyFromRacketeering { get; set; }

    [XmlElement("ConspiracyRacketeering")]
    public CriminalChargetypes ConspiracyRacketeering { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
