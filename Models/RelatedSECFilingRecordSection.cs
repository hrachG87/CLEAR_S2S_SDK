using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RelatedSECFilingRecordSection")]
public class RelatedSECFilingRecordSection
{
    [XmlElement("RelatedSECFilingRecord")]
    public List<RelatedSECFilingRecord> RelatedSECFilingRecord { get; set; }

}
}