using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CitationInfo")]
public class CitationInfo
{
    [XmlElement("Citation")]
    public string Citation { get; set; }

    [XmlElement("Edition")]
    public string Edition { get; set; }

    [XmlElement("WestlawCitation")]
    public string WestlawCitation { get; set; }

}
}