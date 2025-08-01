using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AdverseMdiaReportIncludeArticles")]
public class AdverseMdiaReportIncludeArticles
{
    [XmlElement("RecordId")]
    public List<string> RecordId { get; set; }
}
