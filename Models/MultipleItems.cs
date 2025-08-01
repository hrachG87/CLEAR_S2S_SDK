using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("MultipleItems")]
public class MultipleItems
{
    [XmlElement("MultiplePersonalProperties")]
    public RiskFlagInfo MultiplePersonalProperties { get; set; }
}
