using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("EidvBusinessServiceErrors")]
public class EidvBusinessServiceErrors
{
    [XmlElement("ServiceError")]
    public List<EidvBusinessServiceError> ServiceError { get; set; }
}
