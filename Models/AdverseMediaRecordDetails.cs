using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AdverseMediaRecordDetails")]
public class AdverseMediaRecordDetails
{
    [XmlElement("RecordId")]
    public string RecordId { get; set; }

    [XmlElement("AdverseMediaResults")]
    public AdverseMediaResults AdverseMediaResults { get; set; }

    [XmlElement("AdverseMediaSanctionsResults")]
    public AdverseMediaSanctionsResults AdverseMediaSanctionsResults { get; set; }

    [XmlElement("AdverseMediaPepResults")]
    public AdverseMediaPepResults AdverseMediaPepResults { get; set; }

    [XmlElement("AdverseMediaSoeResults")]
    public AdverseMediaSoeResults AdverseMediaSoeResults { get; set; }
}
