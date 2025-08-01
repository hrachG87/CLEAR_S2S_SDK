using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("AdverseMediaDeleteMonitorCriteria")]
public class AdverseMediaDeleteMonitorCriteria
{
    [XmlElement("ListName")]
    public string ListName { get; set; }

}