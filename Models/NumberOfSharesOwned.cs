using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("NumberOfSharesOwned")]
public class NumberOfSharesOwned
{
    [XmlElement("ShareCount")]
    public string ShareCount { get; set; }

    [XmlElement("ShareClass")]
    public string ShareClass { get; set; }

}