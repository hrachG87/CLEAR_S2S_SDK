using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("LegalFilingsSection")]
public class LegalFilingsSection
{
    [XmlElement("LegalFilingsRecord")]
    public List<LegalFilingsRecord> LegalFilingsRecord { get; set; }

}
}