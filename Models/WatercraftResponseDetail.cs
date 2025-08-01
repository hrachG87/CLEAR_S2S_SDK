using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("WatercraftResponseDetail")]
public class WatercraftResponseDetail
{
    [XmlElement("StateBoatRecord")]
    public List<StateBoatRecord> StateBoatRecord { get; set; }

    [XmlElement("DocumentGuids")]
    public List<Sources> DocumentGuids { get; set; }

    [XmlElement("USCoastGuardRecord")]
    public List<USCoastGuardRecord> USCoastGuardRecord { get; set; }
}
