using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("DiscloseConfidentialInfo")]
public class DiscloseConfidentialInfo
{
    [XmlElement("DiscloseConfidentialInfo")]
    public RiskFlagInfo DiscloseConfidentialInfo { get; set; }

}
}