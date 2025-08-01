using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("DMVRecords")]
public class DMVRecords
{
    [XmlElement("DMVRecordsFlag")]
    public BusinessRiskFlagInfo DMVRecordsFlag { get; set; }

}
}