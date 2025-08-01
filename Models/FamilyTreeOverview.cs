using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("FamilyTreeOverview")]
public class FamilyTreeOverview
{
    [XmlElement("AffiliateHistory")]
    public List<string> AffiliateHistory { get; set; }

    [XmlElement("FamilyTreeSummary")]
    public FamilyTreeSummary FamilyTreeSummary { get; set; }

}
}