using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("AdverseMediaMonitorListDetail")]
public class AdverseMediaMonitorListDetail
{
    [XmlElement("Status")]
    public Status Status { get; set; }

    [XmlElement("DetailResult")]
    public DetailResult DetailResult { get; set; }

}