using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("ResponseValue")]
public class ResponseValue
{
    [XmlElement("value")]
    public string value { get; set; }

    [XmlElement("Name")]
    public string Name { get; set; }

    [XmlElement("Column")]
    public string Column { get; set; }
}
