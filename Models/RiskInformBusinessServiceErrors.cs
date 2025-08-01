using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RiskInformBusinessServiceErrors")]
public class RiskInformBusinessServiceErrors
{
    [XmlElement("ServiceError")]
    public List<RiskInformBusinessServiceError> ServiceError { get; set; }
}
