using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CompanyAssociateAnalyticsUserCriteria")]
public class CompanyAssociateAnalyticsUserCriteria
{
    [XmlElement("CompanyAssociateAnalyticsUserCriteria")]
    public CompanyAssociateAnalyticsCriteria CompanyAssociateAnalyticsUserCriteria { get; set; }

}