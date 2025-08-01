using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CommentSource")]
public class CommentSource
{
    [XmlElement("SourceBusinessName")]
    public string SourceBusinessName { get; set; }

    [XmlElement("SourceName")]
    public string SourceName { get; set; }

    [XmlElement("SourceTitle")]
    public string SourceTitle { get; set; }

    [XmlElement("SourceTitle2")]
    public string SourceTitle2 { get; set; }

    [XmlElement("SourceTitle3")]
    public string SourceTitle3 { get; set; }

    [XmlElement("StatusInfo")]
    public string StatusInfo { get; set; }

    [XmlElement("SourceTitleDescription")]
    public string SourceTitleDescription { get; set; }
}
