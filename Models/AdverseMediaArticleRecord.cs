using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("AdverseMediaArticleRecord")]
public class AdverseMediaArticleRecord
{
    [XmlElement("Number")]
    public int Number { get; set; }

    [XmlElement("Title")]
    public string Title { get; set; }

    [XmlElement("TitleOriginalLanguage")]
    public string TitleOriginalLanguage { get; set; }

    [XmlElement("Snippet")]
    public string Snippet { get; set; }

    [XmlElement("SnippetOriginalLanguage")]
    public string SnippetOriginalLanguage { get; set; }

    [XmlElement("SnippetAdverseTerms")]
    public AdverseTermsContainer SnippetAdverseTerms { get; set; }

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

    [XmlElement("FullTextAdverseTerms")]
    public AdverseTermsContainer FullTextAdverseTerms { get; set; }

}