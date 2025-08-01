using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("SortOptions")]
public class SortOptions
{
    [XmlElement("NameSearched")]
    public string NameSearched { get; set; }

    [XmlElement("Score")]
    public string Score { get; set; }

    [XmlElement("Date")]
    public string Date { get; set; }

    [XmlElement("CategoryTags")]
    public string CategoryTags { get; set; }

    [XmlElement("FirstWordArticle")]
    public string FirstWordArticle { get; set; }

    [XmlElement("ListName")]
    public string ListName { get; set; }

}