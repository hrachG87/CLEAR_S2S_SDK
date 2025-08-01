using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CategoryTag")]
public class CategoryTag
{
    [XmlElement("TagName")]
    public string TagName { get; set; }

    [XmlElement("ResultCount")]
    public int ResultCount { get; set; }
}
