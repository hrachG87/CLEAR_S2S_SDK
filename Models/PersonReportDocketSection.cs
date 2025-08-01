using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonReportDocketSection")]
public class PersonReportDocketSection
{
    [XmlElement("CircuitCourtDocketRecord")]
    public List<CircuitCourtDocketRecord> CircuitCourtDocketRecord { get; set; }

    [XmlElement("DistrictCourtDocketRecord")]
    public List<DistrictCourtDocketRecord> DistrictCourtDocketRecord { get; set; }

    [XmlElement("StateDocketRecord")]
    public List<StateDocketRecord> StateDocketRecord { get; set; }

}
}