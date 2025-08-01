using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("TitleHistory")]
public class TitleHistory
{
    [XmlElement("OriginalTitleDate")]
    public string OriginalTitleDate { get; set; }

    [XmlElement("TitleInfo")]
    public List<LienTitleInfo> TitleInfo { get; set; }

    [XmlElement("TitleNumber")]
    public string TitleNumber { get; set; }

}