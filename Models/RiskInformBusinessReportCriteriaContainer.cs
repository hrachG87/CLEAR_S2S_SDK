using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformBusinessReportCriteriaContainer")]
public class RiskInformBusinessReportCriteriaContainer
{
    [XmlElement("ReportCriteria")]
    public RiskInformBusinessReportCriteria ReportCriteria { get; set; }

}
}