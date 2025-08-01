using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("DeathSection")]
public class DeathSection
{
    [XmlElement("DeathRecord")]
    public List<DeathRecord> DeathRecord { get; set; }

    [XmlElement("DeceasedRecord")]
    public List<DeceasedRecord> DeceasedRecord { get; set; }

    [XmlElement("ObituaryRecord")]
    public List<ObituaryRecord> ObituaryRecord { get; set; }

    [XmlElement("DeathSummaryRecord")]
    public List<DeathSummaryRecord> DeathSummaryRecord { get; set; }
}
