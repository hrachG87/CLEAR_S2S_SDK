using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CommentInfo")]
public class CommentInfo
{
    [XmlElement("Comment")]
    public List<string> Comment { get; set; }

    [XmlElement("CommentLine2")]
    public string CommentLine2 { get; set; }

    [XmlElement("CommentDate")]
    public List<string> CommentDate { get; set; }

    [XmlElement("CommentDescription")]
    public List<string> CommentDescription { get; set; }

    [XmlElement("CommentSource")]
    public List<CommentSource> CommentSource { get; set; }

    [XmlElement("CommentCode")]
    public string CommentCode { get; set; }

    [XmlElement("CommentTitle")]
    public string CommentTitle { get; set; }

}