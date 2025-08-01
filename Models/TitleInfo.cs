using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("TitleInfo")]
public class TitleInfo
{
    [XmlElement("Title")]
    public List<string> Title { get; set; }

    [XmlElement("Author")]
    public List<string> Author { get; set; }

}