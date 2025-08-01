using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("ArticleTags")]
public class ArticleTags
{
    [XmlElement("ArticleTag")]
    public List<string> ArticleTag { get; set; }

}