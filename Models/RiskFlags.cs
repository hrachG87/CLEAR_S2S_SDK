using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RiskFlags")]
public class RiskFlags
{
    [XmlElement("RealTimeIncarcerationAndArrest")]
    public string RealTimeIncarcerationAndArrest { get; set; }
}
