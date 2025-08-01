using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RelatedPartiesInfo")]
public class RelatedPartiesInfo
{
    [XmlElement("Superior")]
    public List<RelatedParty> Superior { get; set; }

    [XmlElement("Subordinate")]
    public List<RelatedParty> Subordinate { get; set; }

    [XmlElement("RelatedParty")]
    public List<RelatedParty> RelatedParty { get; set; }
}
