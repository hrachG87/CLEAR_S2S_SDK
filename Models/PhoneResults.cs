using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PhoneResults")]
public class PhoneResults
{
    [XmlElement("Status")]
    public Status Status { get; set; }

    [XmlElement("Uri")]
    public string Uri { get; set; }

    [XmlElement("GroupCount")]
    public int GroupCount { get; set; }

}