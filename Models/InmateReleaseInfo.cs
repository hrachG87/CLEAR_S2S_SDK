using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("InmateReleaseInfo")]
public class InmateReleaseInfo
{
    [XmlElement("ActualReleaseDate")]
    public string ActualReleaseDate { get; set; }

    [XmlElement("FirearmRestriction")]
    public string FirearmRestriction { get; set; }

    [XmlElement("MaximumReleaseDate")]
    public string MaximumReleaseDate { get; set; }

    [XmlElement("ProjectedReleaseDate")]
    public string ProjectedReleaseDate { get; set; }

    [XmlElement("InmateReleaseReason")]
    public string InmateReleaseReason { get; set; }

    [XmlElement("InmateReleaseTime")]
    public string InmateReleaseTime { get; set; }

    [XmlElement("TentativeReleaseDate")]
    public string TentativeReleaseDate { get; set; }

}
}