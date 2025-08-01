using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PrescriptionFraud")]
public class PrescriptionFraud
{
    [XmlElement("PrescriptionFraudFlag")]
    public RiskFlagInfo PrescriptionFraudFlag { get; set; }

}
}