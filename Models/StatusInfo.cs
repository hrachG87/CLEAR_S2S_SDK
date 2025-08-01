using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("StatusInfo")]
public class StatusInfo
{
    [XmlElement("Status")]
    public string Status { get; set; }

    [XmlElement("StatusDate")]
    public string StatusDate { get; set; }
}
