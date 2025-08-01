using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CompanyAssociateAnalyticsCriteria")]
public class CompanyAssociateAnalyticsCriteria
{
    [XmlElement("EntityId")]
    public string EntityId { get; set; }

    [XmlElement("GroupId")]
    public string GroupId { get; set; }

    [XmlElement("CompanyRiskFlags")]
    public CompanyAssociateRiskFlags CompanyRiskFlags { get; set; }

}