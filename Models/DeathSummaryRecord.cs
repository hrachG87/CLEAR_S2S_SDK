using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("DeathSummaryRecord")]
public class DeathSummaryRecord
{
    [XmlElement("DeathDetails")]
    public List<DeathSummary> DeathDetails { get; set; }
}
