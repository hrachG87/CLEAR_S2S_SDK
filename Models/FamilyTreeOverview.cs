using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("FamilyTreeOverview")]
public class FamilyTreeOverview
{
    [XmlElement("AffiliateHistory")]
    public List<string> AffiliateHistory { get; set; }

    [XmlElement("FamilyTreeSummary")]
    public FamilyTreeSummary FamilyTreeSummary { get; set; }

}