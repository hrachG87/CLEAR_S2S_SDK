using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalSubcategoryDrugsOtherOffense")]
public class CriminalSubcategoryDrugsOtherOffense
{
    [XmlElement("Hallucinogen")]
    public CriminalChargetypes Hallucinogen { get; set; }

    [XmlElement("Heroin")]
    public CriminalChargetypes Heroin { get; set; }

    [XmlElement("Opium")]
    public CriminalChargetypes Opium { get; set; }

    [XmlElement("Cocaine")]
    public CriminalChargetypes Cocaine { get; set; }

    [XmlElement("SyntheticNarcotic")]
    public CriminalChargetypes SyntheticNarcotic { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}