using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RealTimeIncarcerationRecords")]
public class RealTimeIncarcerationRecords
{
    [XmlElement("RealTimeIncarcerationRecord")]
    public List<RealTimeIncarcerationRecord> RealTimeIncarcerationRecord { get; set; }

}
}