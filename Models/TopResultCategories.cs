using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("TopResultCategories")]
public class TopResultCategories
{
    [XmlElement("CategoryTag")]
    public List<CategoryTag> CategoryTag { get; set; }
}
