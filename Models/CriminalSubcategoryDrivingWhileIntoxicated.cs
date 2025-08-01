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
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}