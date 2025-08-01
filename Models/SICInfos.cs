using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("SICInfos")]
public class SICInfos
{
    [XmlElement("SICInfo")]
    public List<SICInfo> SICInfo { get; set; }
}
