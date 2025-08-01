using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("WebAndSocialMediaRecord")]
public class WebAndSocialMediaRecord
{
    [XmlElement("RecordType")]
    public string RecordType { get; set; }

    [XmlElement("URL")]
    public string URL { get; set; }

    [XmlElement("Content")]
    public List<Content> Content { get; set; }

    [XmlElement("MatchedBy")]
    public string MatchedBy { get; set; }

    [XmlElement("MatchRating")]
    public string MatchRating { get; set; }

}
}