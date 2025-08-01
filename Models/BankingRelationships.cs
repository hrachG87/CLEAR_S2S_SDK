using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("BankingRelationships")]
public class BankingRelationships
{
    [XmlElement("BankingRelationship")]
    public List<BankingRelationship> BankingRelationship { get; set; }

}
}