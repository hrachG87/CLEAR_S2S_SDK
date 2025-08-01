using System;
using System.Collections.Generic;
using System.Xml.Serialization;

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
    public bool Misdemeanor Charge { get; set; }

    [XmlElement("Misdemeanor Conviction")]
    public bool Misdemeanor Conviction { get; set; }

    [XmlElement("Felony Charge")]
    public bool Felony Charge { get; set; }

    [XmlElement("Felony Conviction")]
    public bool Felony Conviction { get; set; }
}
