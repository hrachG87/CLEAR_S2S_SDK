using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CommercialFinanceRelationshipSection")]
public class CommercialFinanceRelationshipSection
{
    [XmlElement("CommercialFinanceRelationshipRecord")]
    public List<CommercialFinanceRelationshipRecord> CommercialFinanceRelationshipRecord { get; set; }
}
