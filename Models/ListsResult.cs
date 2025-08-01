using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("ListsResult")]
public class ListsResult
{
    [XmlElement("ListNames")]
    public ListNames ListNames { get; set; }

}