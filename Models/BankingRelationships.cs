using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("BankingRelationships")]
public class BankingRelationships
{
    [XmlElement("BankingRelationship")]
    public List<BankingRelationship> BankingRelationship { get; set; }
}
