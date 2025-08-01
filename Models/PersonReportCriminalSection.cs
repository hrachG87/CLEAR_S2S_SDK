using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonReportCriminalSection")]
public class PersonReportCriminalSection
{
    [XmlElement("CriminalRecord")]
    public List<CriminalRecord> CriminalRecord { get; set; }

    [XmlElement("CriminalExpansionRecord")]
    public List<CriminalExpansionRecord> CriminalExpansionRecord { get; set; }

}
}