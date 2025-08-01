using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("Synopsis")]
public class Synopsis
{
    [XmlElement("Damage")]
    public List<string> Damage { get; set; }

    [XmlElement("Facts")]
    public List<string> Facts { get; set; }

}