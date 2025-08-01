using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalSubcategoryParoleProbationViolation")]
public class CriminalSubcategoryParoleProbationViolation
{
    [XmlElement("ParoleViolation")]
    public CriminalChargetypes ParoleViolation { get; set; }

    [XmlElement("ProbationViolation")]
    public CriminalChargetypes ProbationViolation { get; set; }

    [XmlElement("ConditionalReleaseViolation")]
    public CriminalChargetypes ConditionalReleaseViolation { get; set; }

    [XmlElement("MandatoryReleaseViolation")]
    public CriminalChargetypes MandatoryReleaseViolation { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}