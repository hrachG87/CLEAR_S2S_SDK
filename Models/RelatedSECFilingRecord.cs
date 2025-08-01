using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RelatedSECFilingRecord")]
public class RelatedSECFilingRecord
{
    [XmlElement("RelatedSECFinancialFilings")]
    public List<SECInfo> RelatedSECFinancialFilings { get; set; }

}
}