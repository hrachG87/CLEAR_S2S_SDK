using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("NAICSDetail")]
public class NAICSDetail
{
    [XmlElement("NAICSCode")]
    public string NAICSCode { get; set; }

    [XmlElement("NAICSDesc")]
    public string NAICSDesc { get; set; }
}
