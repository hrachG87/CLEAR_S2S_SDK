using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("BusinessDocumentResponseDetails")]
public class BusinessDocumentResponseDetails
{
    [XmlElement("BusinessDocumentResponseDetail")]
    public BusinessDocumentResponseDetail BusinessDocumentResponseDetail { get; set; }

}