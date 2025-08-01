using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalCategoryRacketeering")]
public class CriminalCategoryRacketeering
{
    [XmlElement("Racketeering")]
    public CriminalChargetypes Racketeering { get; set; }

    [XmlElement("ProceedsFromRacketeering")]
    public CriminalChargetypes ProceedsFromRacketeering { get; set; }

    [XmlElement("PropertyFromRacketeering")]
    public CriminalChargetypes PropertyFromRacketeering { get; set; }

    [XmlElement("ConspiracyRacketeering")]
    public CriminalChargetypes ConspiracyRacketeering { get; set; }

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