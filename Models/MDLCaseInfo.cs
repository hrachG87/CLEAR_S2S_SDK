using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("MDLCaseInfo")]
public class MDLCaseInfo
{
    [XmlElement("CaseEntry")]
    public List<MDLInfo> CaseEntry { get; set; }

    [XmlElement("RelatedCase")]
    public List<MDLInfo> RelatedCase { get; set; }
}
