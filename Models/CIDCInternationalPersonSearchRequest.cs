using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CIDCInternationalPersonSearchRequest")]
public class CIDCInternationalPersonSearchRequest
{
    [XmlElement("MultiSourceVerification")]
    public bool MultiSourceVerification { get; set; }

    [XmlElement("InternalID")]
    public string InternalID { get; set; }

    [XmlElement("UserReference")]
    public List<string> UserReference { get; set; }

    [XmlElement("TotalScoreType")]
    public string TotalScoreType { get; set; }

    [XmlElement("MatchType")]
    public string MatchType { get; set; }

    [XmlElement("Criteria")]
    public CIDCInternationalPersonSearchCriteria Criteria { get; set; }

    [XmlElement("CIDCName")]
    public string CIDCName { get; set; }

    [XmlElement("CIDCVersion")]
    public string CIDCVersion { get; set; }
}
