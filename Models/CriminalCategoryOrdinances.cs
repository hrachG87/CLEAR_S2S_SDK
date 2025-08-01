using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalCategoryOrdinances")]
public class CriminalCategoryOrdinances
{
    [XmlElement("MunicipalOrdinance")]
    public CriminalChargetypes MunicipalOrdinance { get; set; }

    [XmlElement("CountyOrdinance")]
    public CriminalChargetypes CountyOrdinance { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
