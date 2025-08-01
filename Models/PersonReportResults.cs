using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonReportResults")]
public class PersonReportResults
{
    [XmlElement("Status")]
    public ClearReportApiStatus Status { get; set; }

    [XmlElement("Uri")]
    public string Uri { get; set; }

    [XmlElement("NumberOfCandidates")]
    public int NumberOfCandidates { get; set; }

    [XmlElement("ReportCandidates")]
    public ReportCandidates ReportCandidates { get; set; }

}
}