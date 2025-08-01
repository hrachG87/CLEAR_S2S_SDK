using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalCategorySexOffenses")]
public class CriminalCategorySexOffenses
{
    [XmlElement("SexOffenseChild")]
    public CriminalChargetypes SexOffenseChild { get; set; }

    [XmlElement("HomosexualActWithGirl")]
    public CriminalChargetypes HomosexualActWithGirl { get; set; }

    [XmlElement("HomosexualActWithBoy")]
    public CriminalChargetypes HomosexualActWithBoy { get; set; }

    [XmlElement("IncestWithMinor")]
    public CriminalChargetypes IncestWithMinor { get; set; }

    [XmlElement("IndecentExposure")]
    public CriminalChargetypes IndecentExposure { get; set; }

    [XmlElement("Bestiality")]
    public CriminalChargetypes Bestiality { get; set; }

    [XmlElement("IncestWithAdult")]
    public CriminalChargetypes IncestWithAdult { get; set; }

    [XmlElement("SeductionOfAdult")]
    public CriminalChargetypes SeductionOfAdult { get; set; }

    [XmlElement("SexOffenseWoman")]
    public CriminalChargetypes SexOffenseWoman { get; set; }

    [XmlElement("SexOffenseMan")]
    public CriminalChargetypes SexOffenseMan { get; set; }

    [XmlElement("PeepingTom")]
    public CriminalChargetypes PeepingTom { get; set; }

    [XmlElement("FailureToRegisterAsSOR")]
    public CriminalChargetypes FailureToRegisterAsSOR { get; set; }

    [XmlElement("IndecentExposureToMinor")]
    public CriminalChargetypes IndecentExposureToMinor { get; set; }

    [XmlElement("IndecentExposureToAdult")]
    public CriminalChargetypes IndecentExposureToAdult { get; set; }

    [XmlElement("LewdActsWithMinor")]
    public CriminalChargetypes LewdActsWithMinor { get; set; }

    [XmlElement("SexuallyViolateHumanRemains")]
    public CriminalChargetypes SexuallyViolateHumanRemains { get; set; }

    [XmlElement("MolestationOfMinor")]
    public CriminalChargetypes MolestationOfMinor { get; set; }

    [XmlElement("Voyeurism")]
    public CriminalChargetypes Voyeurism { get; set; }

    [XmlElement("SexOffenseElderly")]
    public CriminalChargetypes SexOffenseElderly { get; set; }

    [XmlElement("SexOffenseDisabled")]
    public CriminalChargetypes SexOffenseDisabled { get; set; }

    [XmlElement("TransportInterstateForSex")]
    public CriminalChargetypes TransportInterstateForSex { get; set; }

    [XmlElement("IndecentLiberties")]
    public CriminalChargetypes IndecentLiberties { get; set; }

    [XmlElement("GrossIndecency")]
    public CriminalChargetypes GrossIndecency { get; set; }

    [XmlElement("PublicLewdness")]
    public CriminalChargetypes PublicLewdness { get; set; }

    [XmlElement("SexOffenseRemarks")]
    public CriminalChargetypes SexOffenseRemarks { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

    [XmlElement("SORViolation")]
    public CriminalChargetypes SORViolation { get; set; }

}