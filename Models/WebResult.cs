using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("WebResult")]
public class WebResult
{
    [XmlElement("Title")]
    public string Title { get; set; }

    [XmlElement("URL")]
    public string URL { get; set; }

    [XmlElement("Preview")]
    public string Preview { get; set; }

}