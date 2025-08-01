using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyWatercraftSection")]
public class CompanyWatercraftSection
{
    [XmlElement("StateBoatRecord")]
    public List<StateBoatRecord> StateBoatRecord { get; set; }

    [XmlElement("USCoastGuardRecord")]
    public List<USCoastGuardRecord> USCoastGuardRecord { get; set; }

}
}