using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("UCCRecord")]
public class UCCRecord
{
    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

    [XmlElement("UCCFilingInfo")]
    public UCCFilingInfo UCCFilingInfo { get; set; }

    [XmlElement("UCCFilingHistory")]
    public List<UCCFilingHistory> UCCFilingHistory { get; set; }

}
}