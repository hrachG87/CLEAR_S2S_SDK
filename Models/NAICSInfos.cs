using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("NAICSInfos")]
public class NAICSInfos
{
    [XmlElement("NAICSInfo")]
    public List<SICInfo> NAICSInfo { get; set; }

}