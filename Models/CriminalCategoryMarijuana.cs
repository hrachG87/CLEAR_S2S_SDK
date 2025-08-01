using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalCategoryMarijuana")]
public class CriminalCategoryMarijuana
{
    [XmlElement("GrowSellDistribute")]
    public CriminalSubcategoryGrowSellDistribute GrowSellDistribute { get; set; }

    [XmlElement("Possession")]
    public CriminalSubcategoryMarijuanaPossession Possession { get; set; }

    [XmlElement("OtherOffense")]
    public CriminalSubcategoryOtherOffense OtherOffense { get; set; }

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