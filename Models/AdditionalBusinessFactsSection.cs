using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AdditionalBusinessFactsSection")]
public class AdditionalBusinessFactsSection
{
    [XmlElement("AdditionalBusinessFactsRecord")]
    public List<AdditionalBusinessFactsRecord> AdditionalBusinessFactsRecord { get; set; }

}
}