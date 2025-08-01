using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalCategoryCodeViolationCategory")]
public class CriminalCategoryCodeViolationCategory
{
    [XmlElement("HousingCodeViolation")]
    public CriminalChargetypes HousingCodeViolation { get; set; }

    [XmlElement("ZoningCodeViolation")]
    public CriminalChargetypes ZoningCodeViolation { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
