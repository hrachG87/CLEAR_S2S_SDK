using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("AdverseMediaUpdateMonitorResult")]
public class AdverseMediaUpdateMonitorResult
{
    [XmlElement("Status")]
    public Status Status { get; set; }

}