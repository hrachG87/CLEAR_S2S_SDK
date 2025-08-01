using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("FalseBombReport")]
public class FalseBombReport
{
    [XmlElement("FalseBombReportFlag")]
    public RiskFlagInfo FalseBombReportFlag { get; set; }

}
}