using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("BusinessRiskRecord")]
public class BusinessRiskRecord
{
    [XmlElement("BusinessFlags")]
    public BusinessFlags BusinessFlags { get; set; }

    [XmlElement("SourceDocumentsInfo")]
    public List<SourceDocumentsInfo> SourceDocumentsInfo { get; set; }

    [XmlElement("CustomMessage")]
    public string CustomMessage { get; set; }
}
