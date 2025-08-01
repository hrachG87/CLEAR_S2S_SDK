using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalSubcategorySimpleAssault")]
public class CriminalSubcategorySimpleAssault
{
    [XmlElement("SimpleAssault")]
    public CriminalChargetypes SimpleAssault { get; set; }

    [XmlElement("Assault")]
    public CriminalChargetypes Assault { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
