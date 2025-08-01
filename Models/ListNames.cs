using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("ListNames")]
public class ListNames
{
    [XmlElement("ListName")]
    public List<string> ListName { get; set; }

}