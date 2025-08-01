using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("DocumentRetrievalSources")]
public class DocumentRetrievalSources
{
    [XmlElement("SourceDocumentGuid")]
    public List<string> SourceDocumentGuid { get; set; }

}
}