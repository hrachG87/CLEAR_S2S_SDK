using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalCategoryDisorderlyConduct")]
public class CriminalCategoryDisorderlyConduct
{
    [XmlElement("DisorderlyConductRemarks")]
    public CriminalChargetypes DisorderlyConductRemarks { get; set; }

    [XmlElement("Curfew")]
    public CriminalChargetypes Curfew { get; set; }

    [XmlElement("Loitering")]
    public CriminalChargetypes Loitering { get; set; }

    [XmlElement("Vagrancy")]
    public CriminalChargetypes Vagrancy { get; set; }

    [XmlElement("PublicIntoxication")]
    public CriminalChargetypes PublicIntoxication { get; set; }

    [XmlElement("RoughCrowd")]
    public CriminalChargetypes RoughCrowd { get; set; }

    [XmlElement("VulgarLanguage")]
    public CriminalChargetypes VulgarLanguage { get; set; }

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