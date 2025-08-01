using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("DateAndCount")]
public class DateAndCount
{
    [XmlElement("Date")]
    public string Date { get; set; }

    [XmlElement("Count")]
    public int Count { get; set; }

}