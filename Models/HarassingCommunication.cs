using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("HarassingCommunication")]
public class HarassingCommunication
{
    [XmlElement("HarassingCommunicationFlag")]
    public RiskFlagInfo HarassingCommunicationFlag { get; set; }

}
}