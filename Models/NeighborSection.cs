using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("NeighborSection")]
public class NeighborSection
{
    [XmlElement("NeighborRecord")]
    public List<NeighborRecord> NeighborRecord { get; set; }

}