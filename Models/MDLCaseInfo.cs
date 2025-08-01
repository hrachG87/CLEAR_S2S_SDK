using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("MDLCaseInfo")]
public class MDLCaseInfo
{
    [XmlElement("CaseEntry")]
    public List<MDLInfo> CaseEntry { get; set; }

    [XmlElement("RelatedCase")]
    public List<MDLInfo> RelatedCase { get; set; }

}
}