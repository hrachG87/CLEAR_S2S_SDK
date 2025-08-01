using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalCategoryHijacking")]
public class CriminalCategoryHijacking
{
    [XmlElement("HijackPublicTransportation")]
    public CriminalChargetypes HijackPublicTransportation { get; set; }

    [XmlElement("AircraftHijack")]
    public CriminalChargetypes AircraftHijack { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
