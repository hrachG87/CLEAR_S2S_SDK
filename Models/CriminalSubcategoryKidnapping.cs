using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalSubcategoryKidnapping")]
public class CriminalSubcategoryKidnapping
{
    [XmlElement("KidnapMinorRansom")]
    public CriminalChargetypes KidnapMinorRansom { get; set; }

    [XmlElement("KidnapAdultRansom")]
    public CriminalChargetypes KidnapAdultRansom { get; set; }

    [XmlElement("KidnapMinorSexAssault")]
    public CriminalChargetypes KidnapMinorSexAssault { get; set; }

    [XmlElement("KidnapAdultSexAssault")]
    public CriminalChargetypes KidnapAdultSexAssault { get; set; }

    [XmlElement("KidnapMinor")]
    public CriminalChargetypes KidnapMinor { get; set; }

    [XmlElement("KidnapAdult")]
    public CriminalChargetypes KidnapAdult { get; set; }

    [XmlElement("KidnapHostageForEscape")]
    public CriminalChargetypes KidnapHostageForEscape { get; set; }

    [XmlElement("AbductionWithoutRansomAssault")]
    public CriminalChargetypes AbductionWithoutRansomAssault { get; set; }

    [XmlElement("KidnapHijackingAircraft")]
    public CriminalChargetypes KidnapHijackingAircraft { get; set; }

    [XmlElement("NonParentKidnapMinor")]
    public CriminalChargetypes NonParentKidnapMinor { get; set; }

    [XmlElement("NonParentFalseImprisonMinor")]
    public CriminalChargetypes NonParentFalseImprisonMinor { get; set; }

    [XmlElement("ParentFalseImprisonMinor")]
    public CriminalChargetypes ParentFalseImprisonMinor { get; set; }

    [XmlElement("InterfereWithCustody")]
    public CriminalChargetypes InterfereWithCustody { get; set; }

    [XmlElement("FalseImprisonNonMinor")]
    public CriminalChargetypes FalseImprisonNonMinor { get; set; }

    [XmlElement("Kidnapping")]
    public CriminalChargetypes Kidnapping { get; set; }

    [XmlElement("Misdemeanor Charge")]
    public bool MisdemeanorCharge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool MisdemeanorConviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool FelonyCharge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool FelonyConviction { get; set; }

}
}