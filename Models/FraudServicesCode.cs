using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("FraudServicesCode")]
public class FraudServicesCode
{
    [XmlElement("Code")]
    public string Code { get; set; }

    [XmlElement("Indicator")]
    public string Indicator { get; set; }

}
}