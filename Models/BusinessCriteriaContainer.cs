using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("BusinessCriteriaContainer")]
public class BusinessCriteriaContainer
{
    [XmlElement("ReportCriteria")]
    public BusinessReportCriteria ReportCriteria { get; set; }

}
}