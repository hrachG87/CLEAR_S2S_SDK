using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformBusinessServiceErrors")]
public class RiskInformBusinessServiceErrors
{
    [XmlElement("ServiceError")]
    public List<RiskInformBusinessServiceError> ServiceError { get; set; }

}
}