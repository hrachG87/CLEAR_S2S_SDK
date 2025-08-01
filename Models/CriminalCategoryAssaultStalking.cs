using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalCategoryAssaultStalking")]
public class CriminalCategoryAssaultStalking
{
    [XmlElement("SimpleAssault")]
    public CriminalSubcategorySimpleAssault SimpleAssault { get; set; }

    [XmlElement("AggravatedAssault")]
    public CriminalSubcategoryAggravatedAssault AggravatedAssault { get; set; }

    [XmlElement("AssaultOther")]
    public CriminalSubcategoryAssaultOther AssaultOther { get; set; }

    [XmlElement("StalkingIntimidation")]
    public CriminalSubcategoryStalkingIntimidation StalkingIntimidation { get; set; }

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