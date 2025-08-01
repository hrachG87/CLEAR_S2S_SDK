using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalSubcategoryGrowSellDistribute")]
public class CriminalSubcategoryGrowSellDistribute
{
    [XmlElement("MarijuanaSell")]
    public CriminalChargetypes MarijuanaSell { get; set; }

    [XmlElement("MarijuanaSmuggle")]
    public CriminalChargetypes MarijuanaSmuggle { get; set; }

    [XmlElement("MarijuanaProduce")]
    public CriminalChargetypes MarijuanaProduce { get; set; }

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