using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RIPersonReportCustomDetailsV3")]
public class RIPersonReportCustomDetailsV3
{
    [XmlElement("customRecord")]
    public CriminalRecordInfoV3 customRecord { get; set; }

}
}