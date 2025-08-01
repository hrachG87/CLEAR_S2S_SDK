using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PublicRecordsTampering")]
public class PublicRecordsTampering
{
    [XmlElement("TamperWithPublicRecords")]
    public RiskFlagInfo TamperWithPublicRecords { get; set; }

}
}