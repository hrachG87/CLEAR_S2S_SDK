using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("ArticleSnippet")]
public class ArticleSnippet
{
    [XmlElement("Edition")]
    public string Edition { get; set; }

    [XmlElement("PublicationDate")]
    public string PublicationDate { get; set; }

    [XmlElement("WordCount")]
    public string WordCount { get; set; }

    [XmlElement("LeadParagraph")]
    public string LeadParagraph { get; set; }

}