using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AdverseMediaReportCriteriaContainer")]
public class AdverseMediaReportCriteriaContainer
{
    [XmlElement("ReportCriteria")]
    public AdverseMediaReportCriteria ReportCriteria { get; set; }

}
}