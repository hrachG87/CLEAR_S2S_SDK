using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("IndustryCodes")]
public class IndustryCodes
{
    [XmlElement("SICCode")]
    public List<string> SICCode { get; set; }

    [XmlElement("NAICSCode")]
    public List<string> NAICSCode { get; set; }
}
