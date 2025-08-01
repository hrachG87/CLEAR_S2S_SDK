using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("ListSummary")]
public class ListSummary
{
    [XmlElement("SearchSubject")]
    public string SearchSubject { get; set; }

    [XmlElement("ListName")]
    public string ListName { get; set; }

    [XmlElement("SubjectId")]
    public int SubjectId { get; set; }

    [XmlElement("UserReference")]
    public string UserReference { get; set; }

    [XmlElement("ArticleDetails")]
    public ArticleDetails ArticleDetails { get; set; }

    [XmlElement("AdverseMediaSanctionsResults")]
    public AdverseMediaSanctionsResults AdverseMediaSanctionsResults { get; set; }

    [XmlElement("AdverseMediaPepResults")]
    public AdverseMediaPepResults AdverseMediaPepResults { get; set; }

    [XmlElement("AdverseMediaSoeResults")]
    public AdverseMediaSoeResults AdverseMediaSoeResults { get; set; }

    [XmlElement("CategoryTags")]
    public CategoryTags CategoryTags { get; set; }

}