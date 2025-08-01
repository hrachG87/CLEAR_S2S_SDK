using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskFlagsDocumentIdentifierInfo")]
public class RiskFlagsDocumentIdentifierInfo
{
    [XmlElement("SourceName")]
    public string SourceName { get; set; }

    [XmlElement("DocumentGuid")]
    public string DocumentGuid { get; set; }

}
}