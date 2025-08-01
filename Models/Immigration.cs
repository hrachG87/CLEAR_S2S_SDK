using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("Immigration")]
public class Immigration
{
    [XmlElement("SmugglingAliens")]
    public RiskFlagInfo SmugglingAliens { get; set; }

    [XmlElement("IllegalEntry")]
    public RiskFlagInfo IllegalEntry { get; set; }

    [XmlElement("FalseCitizenship")]
    public RiskFlagInfo FalseCitizenship { get; set; }

    [XmlElement("ImmigrationFlag")]
    public RiskFlagInfo ImmigrationFlag { get; set; }

}