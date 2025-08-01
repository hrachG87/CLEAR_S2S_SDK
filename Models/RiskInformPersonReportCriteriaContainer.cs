using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RiskInformPersonReportCriteriaContainer")]
public class RiskInformPersonReportCriteriaContainer
{
    [XmlElement("reportCriteria")]
    public RiskInformPersonReportCriteria reportCriteria { get; set; }

}
}