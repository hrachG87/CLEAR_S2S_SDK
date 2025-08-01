using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("NewsResults")]
public class NewsResults
{
    [XmlElement("DocumentHeader")]
    public DocumentHeader DocumentHeader { get; set; }

    [XmlElement("TitleInfo")]
    public TitleInfo TitleInfo { get; set; }

    [XmlElement("MainArticle")]
    public MainArticle MainArticle { get; set; }

    [XmlElement("IndexReferences")]
    public IndexReferences IndexReferences { get; set; }

    [XmlElement("WordCount")]
    public string WordCount { get; set; }

    [XmlElement("Abstract")]
    public List<Abstract> Abstract { get; set; }

}