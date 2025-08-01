using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RealPropertyUserCriteria")]
public class RealPropertyUserCriteria
{
    [XmlElement("RealPropertyCriteria")]
    public RealPropertyCriteria RealPropertyCriteria { get; set; }
}
