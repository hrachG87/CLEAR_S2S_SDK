using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("DocumentHeader")]
public class DocumentHeader
{
    [XmlElement("FirstCite")]
    public string FirstCite { get; set; }

    [XmlElement("SecondCite")]
    public string SecondCite { get; set; }

    [XmlElement("WestlawCite")]
    public string WestlawCite { get; set; }

    [XmlElement("Publication")]
    public string Publication { get; set; }

    [XmlElement("CopyRight")]
    public string CopyRight { get; set; }

    [XmlElement("FullPublishDate")]
    public string FullPublishDate { get; set; }

    [XmlElement("Section")]
    public string Section { get; set; }

    [XmlElement("Volume")]
    public string Volume { get; set; }

    [XmlElement("VolumeIssue")]
    public string VolumeIssue { get; set; }

}
}