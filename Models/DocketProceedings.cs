using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("DocketProceedings")]
public class DocketProceedings
{
    [XmlElement("DocketDate")]
    public string DocketDate { get; set; }

    [XmlElement("DocketEntryNumber")]
    public string DocketEntryNumber { get; set; }

    [XmlElement("DocketDescription")]
    public List<DocketDescription> DocketDescription { get; set; }

    [XmlElement("DocketedDate")]
    public string DocketedDate { get; set; }

    [XmlElement("DocketPartyInfo")]
    public List<DocketPartyInfo> DocketPartyInfo { get; set; }
}
