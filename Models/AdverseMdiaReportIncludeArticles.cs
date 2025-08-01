using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AdverseMdiaReportIncludeArticles")]
public class AdverseMdiaReportIncludeArticles
{
    [XmlElement("RecordId")]
    public List<string> RecordId { get; set; }

}
}