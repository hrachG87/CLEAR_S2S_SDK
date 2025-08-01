using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("SexOffenses")]
public class SexOffenses
{
    [XmlElement("SexOffenseChild")]
    public RiskFlagInfo SexOffenseChild { get; set; }

    [XmlElement("HomosexualActWithGirl")]
    public RiskFlagInfo HomosexualActWithGirl { get; set; }

    [XmlElement("HomosexualActWithBoy")]
    public RiskFlagInfo HomosexualActWithBoy { get; set; }

    [XmlElement("IncestWithMinor")]
    public RiskFlagInfo IncestWithMinor { get; set; }

    [XmlElement("IndecentExposure")]
    public RiskFlagInfo IndecentExposure { get; set; }

    [XmlElement("Beastiality")]
    public RiskFlagInfo Beastiality { get; set; }

    [XmlElement("IncestWithAdult")]
    public RiskFlagInfo IncestWithAdult { get; set; }

    [XmlElement("SeductionOfAdult")]
    public RiskFlagInfo SeductionOfAdult { get; set; }

    [XmlElement("SexOffenseWoman")]
    public RiskFlagInfo SexOffenseWoman { get; set; }

    [XmlElement("SexOffenseMan")]
    public RiskFlagInfo SexOffenseMan { get; set; }

    [XmlElement("PeepingTom")]
    public RiskFlagInfo PeepingTom { get; set; }

    [XmlElement("FailureToRegisterAsSOR")]
    public RiskFlagInfo FailureToRegisterAsSOR { get; set; }

    [XmlElement("IndecentExposureToMinor")]
    public RiskFlagInfo IndecentExposureToMinor { get; set; }

    [XmlElement("IndecentExposureToAdult")]
    public RiskFlagInfo IndecentExposureToAdult { get; set; }

    [XmlElement("LewdActsWithMinor")]
    public RiskFlagInfo LewdActsWithMinor { get; set; }

    [XmlElement("SexuallyViolateHumanRemains")]
    public RiskFlagInfo SexuallyViolateHumanRemains { get; set; }

    [XmlElement("MolestationOfMinor")]
    public RiskFlagInfo MolestationOfMinor { get; set; }

    [XmlElement("Voyeurism")]
    public RiskFlagInfo Voyeurism { get; set; }

    [XmlElement("SexOffenseElderly")]
    public RiskFlagInfo SexOffenseElderly { get; set; }

    [XmlElement("SexOffenseDisabled")]
    public RiskFlagInfo SexOffenseDisabled { get; set; }

    [XmlElement("TransportInterstateForSex")]
    public RiskFlagInfo TransportInterstateForSex { get; set; }

    [XmlElement("IndecentLiberties")]
    public RiskFlagInfo IndecentLiberties { get; set; }

    [XmlElement("GrossIndecency")]
    public RiskFlagInfo GrossIndecency { get; set; }

    [XmlElement("SexOffenseRemarks")]
    public RiskFlagInfo SexOffenseRemarks { get; set; }

    [XmlElement("PublicLewdness")]
    public RiskFlagInfo PublicLewdness { get; set; }

    [XmlElement("SORViolation")]
    public RiskFlagInfo SORViolation { get; set; }

}