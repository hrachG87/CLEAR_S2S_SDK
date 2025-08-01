using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("MilitarySection")]
public class MilitarySection
{
    [XmlElement("MilitaryRecord")]
    public List<MilitaryRecord> MilitaryRecord { get; set; }
}
