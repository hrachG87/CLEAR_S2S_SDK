using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BusinessExecutives")]
public class BusinessExecutives
{
    [XmlElement("Name")]
    public string Name { get; set; }

    [XmlElement("Title")]
    public string Title { get; set; }

}