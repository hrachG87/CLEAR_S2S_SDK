using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalCategoryAbortion")]
public class CriminalCategoryAbortion
{
    [XmlElement("AbortionOnOther")]
    public CriminalChargetypes AbortionOnOther { get; set; }

    [XmlElement("AbortionOnSelf")]
    public CriminalChargetypes AbortionOnSelf { get; set; }

    [XmlElement("SubmissionToAbortion")]
    public CriminalChargetypes SubmissionToAbortion { get; set; }

    [XmlElement("Abortifacient")]
    public CriminalChargetypes Abortifacient { get; set; }

    [XmlElement("Abortion")]
    public CriminalChargetypes Abortion { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}