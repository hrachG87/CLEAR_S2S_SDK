using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("BusinessAKA")]
public class BusinessAKA
{
    [XmlElement("BusinessAKAName")]
    public string BusinessAKAName { get; set; }

    [XmlElement("TypeOfAKA")]
    public string TypeOfAKA { get; set; }
}
