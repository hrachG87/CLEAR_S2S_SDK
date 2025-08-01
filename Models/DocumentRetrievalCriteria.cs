using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("DocumentRetrievalCriteria")]
public class DocumentRetrievalCriteria
{
    [XmlElement("GroupId")]
    public string GroupId { get; set; }

    [XmlElement("ReportId")]
    public string ReportId { get; set; }

    [XmlElement("DocumentGuids")]
    public DocumentRetrievalSources DocumentGuids { get; set; }

    [XmlElement("IncludeIncarcerationRecords")]
    public bool IncludeIncarcerationRecords { get; set; }
}
