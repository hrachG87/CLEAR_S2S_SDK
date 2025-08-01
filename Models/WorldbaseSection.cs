using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("WorldbaseSection")]
public class WorldbaseSection
{
    [XmlElement("WorldbaseRecord")]
    public List<WorldbaseRecord> WorldbaseRecord { get; set; }

}
}