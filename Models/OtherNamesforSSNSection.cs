using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("OtherNamesforSSNSection")]
public class OtherNamesforSSNSection
{
    [XmlElement("OtherNameRecord")]
    public List<OtherNameRecord> OtherNameRecord { get; set; }

}
}