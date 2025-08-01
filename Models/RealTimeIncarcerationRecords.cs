using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RealTimeIncarcerationRecords")]
public class RealTimeIncarcerationRecords
{
    [XmlElement("RealTimeIncarcerationRecord")]
    public List<RealTimeIncarcerationRecord> RealTimeIncarcerationRecord { get; set; }
}
