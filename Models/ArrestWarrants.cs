using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("ArrestWarrants")]
public class ArrestWarrants
{
    [XmlElement("ArrestWarrantsFlag")]
    public RiskFlagInfo ArrestWarrantsFlag { get; set; }
}
