using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("WatercraftUserCriteria")]
public class WatercraftUserCriteria
{
    [XmlElement("WatercraftCriteria")]
    public WatercraftCriteria WatercraftCriteria { get; set; }
}
