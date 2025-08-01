using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("VehicleRecord")]
public class VehicleRecord
{
    [XmlElement("DPPA")]
    public List<string> DPPA { get; set; }

    [XmlElement("LienInfo")]
    public List<LienTitleInfo> LienInfo { get; set; }

    [XmlElement("OwnerInfo")]
    public List<OwnerInfo> OwnerInfo { get; set; }

    [XmlElement("TitleHistory")]
    public List<TitleHistory> TitleHistory { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

    [XmlElement("DMVHistory")]
    public List<DMVHistory> DMVHistory { get; set; }
}
