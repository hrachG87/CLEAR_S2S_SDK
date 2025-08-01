using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BirthDate")]
public class BirthDate
{
    [XmlElement("Day")]
    public string Day { get; set; }

    [XmlElement("Month")]
    public string Month { get; set; }

    [XmlElement("Year")]
    public string Year { get; set; }

}