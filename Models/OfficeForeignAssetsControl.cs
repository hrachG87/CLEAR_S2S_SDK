using System;
using System.Collections.Generic;
using System.Xml.Serialization;


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