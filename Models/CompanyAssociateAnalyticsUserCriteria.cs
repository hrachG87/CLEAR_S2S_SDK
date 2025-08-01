using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyAssociateAnalyticsUserCriteria")]
public class CompanyAssociateAnalyticsUserCriteria
{
    [XmlElement("CompanyAssociateAnalyticsUserCriteria")]
    public CompanyAssociateAnalyticsCriteria CompanyAssociateAnalyticsUserCriteria { get; set; }

}
}