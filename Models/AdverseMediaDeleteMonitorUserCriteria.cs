using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("AdverseMediaDeleteMonitorUserCriteria")]
public class AdverseMediaDeleteMonitorUserCriteria
{
    [XmlElement("Criteria")]
    public AdverseMediaDeleteMonitorCriteria Criteria { get; set; }
}
