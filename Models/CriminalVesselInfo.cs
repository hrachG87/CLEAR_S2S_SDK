using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalVesselInfo")]
public class CriminalVesselInfo
{
    [XmlElement("TypeOfVessel")]
    public string TypeOfVessel { get; set; }

    [XmlElement("CallSign")]
    public string CallSign { get; set; }

    [XmlElement("Country")]
    public string Country { get; set; }

    [XmlElement("GrossTonnage")]
    public string GrossTonnage { get; set; }

    [XmlElement("Owner")]
    public List<string> Owner { get; set; }

    [XmlElement("Tonnage")]
    public string Tonnage { get; set; }

}