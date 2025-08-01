using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("DocumentRecordDetailsContainer")]
public class DocumentRecordDetailsContainer
{
    [XmlElement("DocumentRetrievalResponseDetail")]
    public DocumentRetrievalResponseDetail DocumentRetrievalResponseDetail { get; set; }

}
}