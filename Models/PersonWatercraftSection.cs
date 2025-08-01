using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonWatercraftSection")]
public class PersonWatercraftSection
{
    [XmlElement("StateBoatRecord")]
    public List<StateBoatRecord> StateBoatRecord { get; set; }

    [XmlElement("USCoastGuardRecord")]
    public List<USCoastGuardRecord> USCoastGuardRecord { get; set; }
}
