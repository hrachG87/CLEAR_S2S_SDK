using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("BusinessReportCandidateCriteriaContainer")]
public class BusinessReportCandidateCriteriaContainer
{
    [XmlElement("ReportCandidateCriteria")]
    public BusinessReportCandidateCriteria ReportCandidateCriteria { get; set; }

}
}