using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("AdverseMediaDeleteMonitorResult")]
public class AdverseMediaDeleteMonitorResult
{
    [XmlElement("Status")]
    public Status Status { get; set; }

}