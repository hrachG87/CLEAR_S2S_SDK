using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("EidvServiceErrors")]
public class EidvServiceErrors
{
    [XmlElement("ServiceError")]
    public List<EidvServiceError> ServiceError { get; set; }

}