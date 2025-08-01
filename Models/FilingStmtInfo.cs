using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("FilingStmtInfo")]
public class FilingStmtInfo
{
    [XmlElement("BusinessInfo")]
    public BusinessDataBusinessInfo BusinessInfo { get; set; }

    [XmlElement("Comments")]
    public List<Comments> Comments { get; set; }

    [XmlElement("ContractType")]
    public string ContractType { get; set; }

    [XmlElement("ExpireDate")]
    public string ExpireDate { get; set; }

    [XmlElement("FileNumberFull")]
    public string FileNumberFull { get; set; }

    [XmlElement("FilePages")]
    public string FilePages { get; set; }

    [XmlElement("FileStatus")]
    public string FileStatus { get; set; }

    [XmlElement("FileTime")]
    public string FileTime { get; set; }

    [XmlElement("FilingAction")]
    public string FilingAction { get; set; }

    [XmlElement("FilingMethod")]
    public string FilingMethod { get; set; }

    [XmlElement("FilingTermination")]
    public string FilingTermination { get; set; }

    [XmlElement("FilmNumber")]
    public string FilmNumber { get; set; }

    [XmlElement("OriginalFileNumberFull")]
    public string OriginalFileNumberFull { get; set; }

    [XmlElement("PageCount")]
    public string PageCount { get; set; }

    [XmlElement("PageNumber")]
    public string PageNumber { get; set; }

    [XmlElement("ReferenceFileNumber")]
    public string ReferenceFileNumber { get; set; }

    [XmlElement("ReferenceID")]
    public string ReferenceID { get; set; }

    [XmlElement("RelatedFileDate")]
    public string RelatedFileDate { get; set; }

    [XmlElement("VolumeNumber")]
    public string VolumeNumber { get; set; }

}
}