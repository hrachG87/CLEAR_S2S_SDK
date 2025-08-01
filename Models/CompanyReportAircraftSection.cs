using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyReportAircraftSection")]
public class CompanyReportAircraftSection
{
    [XmlElement("AircraftRecord")]
    public List<AircraftRecord> AircraftRecord { get; set; }

}
}