using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalSubcategoryContributeToDelinquencyOfMinor")]
public class CriminalSubcategoryContributeToDelinquencyOfMinor
{
    [XmlElement("ContribDelinquencyMinor")]
    public CriminalChargetypes ContribDelinquencyMinor { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}