using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformCustomDetails")]
public class RiskInformCustomDetails
{
    [XmlElement("CustomRecord")]
    public BusinessRiskRecord CustomRecord { get; set; }

}
}