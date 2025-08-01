using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("EidvServiceErrors")]
public class EidvServiceErrors
{
    [XmlElement("ServiceError")]
    public List<EidvServiceError> ServiceError { get; set; }

}
}