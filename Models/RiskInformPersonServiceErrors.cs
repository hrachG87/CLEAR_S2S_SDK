using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformPersonServiceErrors")]
public class RiskInformPersonServiceErrors
{
    [XmlElement("ServiceError")]
    public List<RiskInformPersonServiceError> ServiceError { get; set; }

}
}