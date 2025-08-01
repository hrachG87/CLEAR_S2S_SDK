using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ParoleHearing")]
public class ParoleHearing
{
    [XmlElement("HearingDate")]
    public string HearingDate { get; set; }

    [XmlElement("HearingLocation")]
    public string HearingLocation { get; set; }

    [XmlElement("TypeOfHearing")]
    public string TypeOfHearing { get; set; }

    [XmlElement("NumMonthsDeferred")]
    public string NumMonthsDeferred { get; set; }

    [XmlElement("ParoleBoardAction")]
    public string ParoleBoardAction { get; set; }

}
}