using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("DocumentRetrievalRequest")]
public class DocumentRetrievalRequest
{
    [XmlElement("PersmissiblePurpose")]
    public PermissiblePurpose PersmissiblePurpose { get; set; }

    [XmlElement("Reference")]
    public string Reference { get; set; }

    [XmlElement("Criteria")]
    public DocumentCriteria Criteria { get; set; }

}