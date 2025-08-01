using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("DECorpReportCriteriaContainer")]
public class DECorpReportCriteriaContainer
{
    [XmlElement("ReportCriteria")]
    public DECorpReportCriteria ReportCriteria { get; set; }

}
}