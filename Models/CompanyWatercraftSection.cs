using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CompanyWatercraftSection")]
public class CompanyWatercraftSection
{
    [XmlElement("StateBoatRecord")]
    public List<StateBoatRecord> StateBoatRecord { get; set; }

    [XmlElement("USCoastGuardRecord")]
    public List<USCoastGuardRecord> USCoastGuardRecord { get; set; }

}