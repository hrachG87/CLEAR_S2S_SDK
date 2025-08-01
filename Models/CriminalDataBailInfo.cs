using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalDataBailInfo")]
public class CriminalDataBailInfo
{
    [XmlElement("BailerName")]
    public string BailerName { get; set; }

    [XmlElement("BailPosted")]
    public string BailPosted { get; set; }

    [XmlElement("BailSet")]
    public string BailSet { get; set; }

    [XmlElement("DateBailPosted")]
    public string DateBailPosted { get; set; }

    [XmlElement("DateBailSet")]
    public string DateBailSet { get; set; }
}
