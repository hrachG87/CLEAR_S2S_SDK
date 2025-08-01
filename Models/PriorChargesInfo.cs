using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PriorChargesInfo")]
public class PriorChargesInfo
{
    [XmlElement("PriorIncarcerationCount")]
    public string PriorIncarcerationCount { get; set; }

    [XmlElement("PriorIncarcerationDate")]
    public string PriorIncarcerationDate { get; set; }

    [XmlElement("PriorLocation")]
    public string PriorLocation { get; set; }

    [XmlElement("PriorStatus")]
    public string PriorStatus { get; set; }

    [XmlElement("PriorOffense")]
    public string PriorOffense { get; set; }

}
}