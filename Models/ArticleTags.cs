using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ArticleTags")]
public class ArticleTags
{
    [XmlElement("ArticleTag")]
    public List<string> ArticleTag { get; set; }

}
}