using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("StateOwnedEntitySection")]
public class StateOwnedEntitySection
{
    [XmlElement("SoeRecord")]
    public List<SoeRecord> SoeRecord { get; set; }

}
}