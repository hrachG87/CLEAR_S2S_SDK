using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonReportCandidateCriteriaContainer")]
public class PersonReportCandidateCriteriaContainer
{
    [XmlElement("ReportCandidateCriteria")]
    public PersonReportCandidateCriteria ReportCandidateCriteria { get; set; }

}
}