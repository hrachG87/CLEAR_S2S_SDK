using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CommercialFinanceRelationshipRecord")]
public class CommercialFinanceRelationshipRecord
{
    [XmlElement("BankingRelationships")]
    public BankingRelationships BankingRelationships { get; set; }

    [XmlElement("LeasingInformation")]
    public LeasingInformation LeasingInformation { get; set; }

    [XmlElement("InsuranceBondRelationships")]
    public InsuranceBondRelationships InsuranceBondRelationships { get; set; }

}
}