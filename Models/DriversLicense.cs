using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("DriversLicense")]
public class DriversLicense
{
    [XmlElement("DriversLicenseNumber")]
    public string DriversLicenseNumber { get; set; }

    [XmlElement("IssueState")]
    public string IssueState { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }
}
