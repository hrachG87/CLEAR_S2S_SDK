using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("AdverseMediaUpdateMonitorUserCriteria")]
public class AdverseMediaUpdateMonitorUserCriteria
{
    [XmlElement("Criteria")]
    public AdverseMediaMonitorCriteria Criteria { get; set; }

}