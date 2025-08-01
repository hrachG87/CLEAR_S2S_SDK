using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("DunBradstreetPCISection")]
public class DunBradstreetPCISection
{
    [XmlElement("DunBradstreetPCIRecord")]
    public List<DunBradstreetPCIRecord> DunBradstreetPCIRecord { get; set; }

}