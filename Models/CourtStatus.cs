using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CourtStatus")]
public class CourtStatus
{
    [XmlElement("Status")]
    public string Status { get; set; }

    [XmlElement("StatusDate")]
    public string StatusDate { get; set; }

    [XmlElement("StatusDescription")]
    public string StatusDescription { get; set; }
}
