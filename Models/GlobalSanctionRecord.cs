using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("GlobalSanctionRecord")]
public class GlobalSanctionRecord
{
    [XmlElement("NameInfo")]
    public CriminalNameInfo NameInfo { get; set; }

    [XmlElement("Nationality")]
    public List<string> Nationality { get; set; }

    [XmlElement("AdditionalDescription")]
    public string AdditionalDescription { get; set; }

    [XmlElement("PositionRole")]
    public string PositionRole { get; set; }

    [XmlElement("VesselInfo")]
    public CriminalVesselInfo VesselInfo { get; set; }

    [XmlElement("Location")]
    public List<CommonDataAddress> Location { get; set; }

    [XmlElement("SanctionInfo")]
    public List<SanctionInfo> SanctionInfo { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

    [XmlElement("IDInfo")]
    public List<IDInfo> IDInfo { get; set; }
}
