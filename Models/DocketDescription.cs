using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("DocketDescription")]
public class DocketDescription
{
    [XmlElement("DocumentDescription")]
    public string DocumentDescription { get; set; }

    [XmlElement("DocketEntryDescription")]
    public List<string> DocketEntryDescription { get; set; }

    [XmlElement("FileType")]
    public string FileType { get; set; }

    [XmlElement("FilingFee")]
    public string FilingFee { get; set; }

    [XmlElement("DocketJudgeName")]
    public string DocketJudgeName { get; set; }

    [XmlElement("DocketAttorneyName")]
    public string DocketAttorneyName { get; set; }

    [XmlElement("DocketDescriptionDisposition")]
    public string DocketDescriptionDisposition { get; set; }

    [XmlElement("MiscDate")]
    public string MiscDate { get; set; }

    [XmlElement("Time")]
    public string Time { get; set; }

    [XmlElement("Room")]
    public string Room { get; set; }

    [XmlElement("DocketDescriptionLocation")]
    public string DocketDescriptionLocation { get; set; }

    [XmlElement("JudgmentAmount")]
    public string JudgmentAmount { get; set; }

    [XmlElement("Insurance")]
    public string Insurance { get; set; }

    [XmlElement("DocketMisc")]
    public string DocketMisc { get; set; }
}
