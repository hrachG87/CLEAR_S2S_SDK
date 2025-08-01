using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("WhereFiled")]
public class WhereFiled
{
    [XmlElement("FilingName")]
    public string FilingName { get; set; }

    [XmlElement("FilingCity")]
    public string FilingCity { get; set; }

    [XmlElement("FilingState")]
    public string FilingState { get; set; }

}