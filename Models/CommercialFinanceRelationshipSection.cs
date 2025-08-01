using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CommercialFinanceRelationshipSection")]
public class CommercialFinanceRelationshipSection
{
    [XmlElement("CommercialFinanceRelationshipRecord")]
    public List<CommercialFinanceRelationshipRecord> CommercialFinanceRelationshipRecord { get; set; }

}
}