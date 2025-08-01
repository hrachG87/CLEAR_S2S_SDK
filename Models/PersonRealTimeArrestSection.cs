using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonRealTimeArrestSection")]
public class PersonRealTimeArrestSection
{
    [XmlElement("RealTimeArrestRecord")]
    public List<RealTimeArrestRecord> RealTimeArrestRecord { get; set; }
}
