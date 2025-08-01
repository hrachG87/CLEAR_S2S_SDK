using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("TagInfo")]
public class TagInfo
{
    [XmlElement("Classification")]
    public string Classification { get; set; }

    [XmlElement("Content")]
    public string Content { get; set; }

    [XmlElement("ValidSinceDate")]
    public string ValidSinceDate { get; set; }

    [XmlElement("LastSeenDate")]
    public string LastSeenDate { get; set; }

}