using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonDocumentRecordDetailsContainer")]
public class PersonDocumentRecordDetailsContainer
{
    [XmlElement("PersonDocumentResponseDetail")]
    public PersonDocumentResponseDetail PersonDocumentResponseDetail { get; set; }

}