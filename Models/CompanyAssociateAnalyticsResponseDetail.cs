using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CompanyAssociateAnalyticsResponseDetail")]
public class CompanyAssociateAnalyticsResponseDetail
{
    [XmlElement("AssociatesWithEntityId")]
    public List<FlagSearchChartDetailsWithEntityId> AssociatesWithEntityId { get; set; }

}