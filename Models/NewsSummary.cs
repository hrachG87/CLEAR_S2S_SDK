using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("NewsSummary")]
public class NewsSummary
{
    [XmlElement("Headline")]
    public string Headline { get; set; }

    [XmlElement("PublicationInfo")]
    public NewsPublicationInfo PublicationInfo { get; set; }

    [XmlElement("CitationInfo")]
    public CitationInfo CitationInfo { get; set; }

    [XmlElement("ArticleSnippet")]
    public ArticleSnippet ArticleSnippet { get; set; }

}
}