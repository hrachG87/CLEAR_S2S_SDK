using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RelatedDocumentInfo")]
public class RelatedDocumentInfo
{
    [XmlElement("DocumentGuid")]
    public string DocumentGuid { get; set; }

    [XmlElement("EntityId")]
    public List<string> EntityId { get; set; }

}
}