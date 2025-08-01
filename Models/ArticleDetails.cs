using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ArticleDetails")]
public class ArticleDetails
{
    [XmlElement("RecordId")]
    public string RecordId { get; set; }

    [XmlElement("Title")]
    public string Title { get; set; }

    [XmlElement("TitleOriginalLanguage")]
    public string TitleOriginalLanguage { get; set; }

    [XmlElement("Snippet")]
    public string Snippet { get; set; }

    [XmlElement("SnippetOriginalLanguage")]
    public string SnippetOriginalLanguage { get; set; }

    [XmlElement("Date")]
    public string Date { get; set; }

    [XmlElement("URL")]
    public string URL { get; set; }

    [XmlElement("Language")]
    public string Language { get; set; }

    [XmlElement("Relevance")]
    public string Relevance { get; set; }

    [XmlElement("FullText")]
    public string FullText { get; set; }

    [XmlElement("FullTextOriginalLanguage")]
    public string FullTextOriginalLanguage { get; set; }

}
}