using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("Comments")]
public class Comments
{
    [XmlElement("CommentDate")]
    public string CommentDate { get; set; }

    [XmlElement("CommentSource")]
    public string CommentSource { get; set; }

    [XmlElement("CommentText")]
    public string CommentText { get; set; }

    [XmlElement("CommentText2")]
    public string CommentText2 { get; set; }

    [XmlElement("SourceBusiness")]
    public string SourceBusiness { get; set; }

    [XmlElement("SourceTitle")]
    public string SourceTitle { get; set; }

    [XmlElement("SourceTitle2")]
    public string SourceTitle2 { get; set; }

    [XmlElement("SourceTitle3")]
    public string SourceTitle3 { get; set; }

    [XmlElement("SourceTitleDesc")]
    public string SourceTitleDesc { get; set; }

}
}