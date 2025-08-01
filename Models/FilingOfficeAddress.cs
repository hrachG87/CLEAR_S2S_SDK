using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("FilingOfficeAddress")]
public class FilingOfficeAddress
{
    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("FilingOfficeName")]
    public string FilingOfficeName { get; set; }

    [XmlElement("FilingState")]
    public string FilingState { get; set; }

    [XmlElement("FilingOfficeLocation")]
    public string FilingOfficeLocation { get; set; }
}
