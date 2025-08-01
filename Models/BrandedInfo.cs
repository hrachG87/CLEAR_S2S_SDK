using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("BrandedInfo")]
public class BrandedInfo
{
    [XmlElement("BrandedTitle")]
    public string BrandedTitle { get; set; }

    [XmlElement("BrandedDate")]
    public string BrandedDate { get; set; }

    [XmlElement("BrandedState")]
    public string BrandedState { get; set; }
}
