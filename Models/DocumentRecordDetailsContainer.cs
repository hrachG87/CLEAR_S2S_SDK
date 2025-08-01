using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("DocumentRecordDetailsContainer")]
public class DocumentRecordDetailsContainer
{
    [XmlElement("DocumentRetrievalResponseDetail")]
    public DocumentRetrievalResponseDetail DocumentRetrievalResponseDetail { get; set; }

}