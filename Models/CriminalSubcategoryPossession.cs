using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalSubcategoryPossession")]
public class CriminalSubcategoryPossession
{
    [XmlElement("HallucinogenPossession")]
    public CriminalChargetypes HallucinogenPossession { get; set; }

    [XmlElement("HeroinPossession")]
    public CriminalChargetypes HeroinPossession { get; set; }

    [XmlElement("OpiumPossession")]
    public CriminalChargetypes OpiumPossession { get; set; }

    [XmlElement("CocainePossession")]
    public CriminalChargetypes CocainePossession { get; set; }

    [XmlElement("SynthethicNarcoticPossession")]
    public CriminalChargetypes SynthethicNarcoticPossession { get; set; }

    [XmlElement("AmphetaminePossession")]
    public CriminalChargetypes AmphetaminePossession { get; set; }

    [XmlElement("BarbituratePossession")]
    public CriminalChargetypes BarbituratePossession { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
