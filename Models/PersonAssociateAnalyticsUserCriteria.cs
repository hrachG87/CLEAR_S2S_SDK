using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonAssociateAnalyticsUserCriteria")]
public class PersonAssociateAnalyticsUserCriteria
{
    [XmlElement("PersonAssociateAnalyticsCriteria")]
    public PersonAssociateAnalyticsCriteria PersonAssociateAnalyticsCriteria { get; set; }

}
}