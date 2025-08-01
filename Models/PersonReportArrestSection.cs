using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonReportArrestSection")]
public class PersonReportArrestSection
{
    [XmlElement("ArrestRecord")]
    public List<ArrestRecord> ArrestRecord { get; set; }

}
}