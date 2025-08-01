using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("NewsPublicationInfo")]
public class NewsPublicationInfo
{
    [XmlElement("Publication")]
    public string Publication { get; set; }

    [XmlElement("Author")]
    public string Author { get; set; }

    [XmlElement("AuthorType")]
    public string AuthorType { get; set; }

    [XmlElement("WordCount")]
    public string WordCount { get; set; }

}