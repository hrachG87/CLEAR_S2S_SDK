using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalSubcategoryDrivingWhileIntoxicated")]
public class CriminalSubcategoryDrivingWhileIntoxicated
{
    [XmlElement("DrivingUnderInfluenceOfDrugs")]
    public CriminalChargetypes DrivingUnderInfluenceOfDrugs { get; set; }

    [XmlElement("DrivingUnderInfluenceOfLiquor")]
    public CriminalChargetypes DrivingUnderInfluenceOfLiquor { get; set; }

    [XmlElement("RefuseBloodAlcoholTest")]
    public CriminalChargetypes RefuseBloodAlcoholTest { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
