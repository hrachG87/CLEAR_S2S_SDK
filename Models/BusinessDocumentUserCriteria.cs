using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("BusinessDocumentUserCriteria")]
public class BusinessDocumentUserCriteria
{
    [XmlElement("BusinessDocumentCriteria")]
    public BusinessDocumentCriteria BusinessDocumentCriteria { get; set; }
}
