using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AdverseMediaCreateMonitorUserCriteria")]
public class AdverseMediaCreateMonitorUserCriteria
{
    [XmlElement("Criteria")]
    public AdverseMediaMonitorCriteria Criteria { get; set; }
}
