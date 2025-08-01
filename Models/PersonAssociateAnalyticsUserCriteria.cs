using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("PersonAssociateAnalyticsUserCriteria")]
public class PersonAssociateAnalyticsUserCriteria
{
    [XmlElement("PersonAssociateAnalyticsCriteria")]
    public PersonAssociateAnalyticsCriteria PersonAssociateAnalyticsCriteria { get; set; }
}
