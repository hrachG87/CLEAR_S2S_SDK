using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RIPersonReportSections")]
public class RIPersonReportSections
{
    [XmlElement("section")]
    public List<RIPersonReportSection> section { get; set; }

}
}