using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonReportCriteriaContainer")]
public class PersonReportCriteriaContainer
{
    [XmlElement("ReportCriteria")]
    public PersonReportCriteria ReportCriteria { get; set; }

}
}