using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("UncategorizedCriminalRecords")]
public class UncategorizedCriminalRecords
{
    [XmlElement("UncategorizedCriminalRecordsFlag")]
    public RiskFlagInfo UncategorizedCriminalRecordsFlag { get; set; }

}
}