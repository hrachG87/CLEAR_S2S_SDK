using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("Content")]
public class Content
{
    [XmlElement("value")]
    public string value { get; set; }

    [XmlElement("name")]
    public string name { get; set; }
}
