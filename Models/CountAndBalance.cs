using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CountAndBalance")]
public class CountAndBalance
{
    [XmlElement("Count")]
    public int Count { get; set; }

    [XmlElement("Balance")]
    public int Balance { get; set; }
}
