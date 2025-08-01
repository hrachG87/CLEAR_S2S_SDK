using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("DocumentCriteria")]
public class DocumentCriteria
{
    [XmlElement("DocumentRetrievalCriteria")]
    public DocumentRetrievalCriteria DocumentRetrievalCriteria { get; set; }

}
}