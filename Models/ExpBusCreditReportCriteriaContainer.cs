using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ExpBusCreditReportCriteriaContainer")]
public class ExpBusCreditReportCriteriaContainer
{
    [XmlElement("ReportCriteria")]
    public ExpBusCreditReportCriteria ReportCriteria { get; set; }

}
}