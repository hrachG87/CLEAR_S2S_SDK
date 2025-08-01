using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("OfficeForeignAssetsControl")]
public class OfficeForeignAssetsControl
{
    [XmlElement("MiscellaneousInfo")]
    public string MiscellaneousInfo { get; set; }

    [XmlElement("SanctionProgram")]
    public string SanctionProgram { get; set; }

    [XmlElement("VesselInfo")]
    public CriminalVesselInfo VesselInfo { get; set; }

}
}