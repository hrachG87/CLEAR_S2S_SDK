using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("SanctionSection")]
public class SanctionSection
{
    [XmlElement("SanctionRecord")]
    public List<SanctionRecord> SanctionRecord { get; set; }

}
}