using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("SICDetail")]
public class SICDetail
{
    [XmlElement("SICCode")]
    public string SICCode { get; set; }

    [XmlElement("SICDesc")]
    public string SICDesc { get; set; }
}
