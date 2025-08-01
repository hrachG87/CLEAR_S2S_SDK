using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RealPropertyRecordDetailsContainer")]
public class RealPropertyRecordDetailsContainer
{
    [XmlElement("RealPropertyResponseDetail")]
    public RealPropertyResponseDetail RealPropertyResponseDetail { get; set; }
}
