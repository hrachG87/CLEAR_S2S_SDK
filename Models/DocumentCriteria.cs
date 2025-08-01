using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("DocumentCriteria")]
public class DocumentCriteria
{
    [XmlElement("DocumentRetrievalCriteria")]
    public DocumentRetrievalCriteria DocumentRetrievalCriteria { get; set; }

}