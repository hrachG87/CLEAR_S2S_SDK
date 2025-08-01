using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("EidvPersonSearchMatchTypeField")]
public class EidvPersonSearchMatchTypeField
{
    [XmlElement("value")]
    public string value { get; set; }

    [XmlElement("matchtype")]
    public string matchtype { get; set; }

    [XmlElement("matchscore")]
    public string matchscore { get; set; }

}