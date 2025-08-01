using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("MRZ")]
public class MRZ
{
    [XmlElement("UpperLine")]
    public string UpperLine { get; set; }

    [XmlElement("LowerLine")]
    public string LowerLine { get; set; }
}
