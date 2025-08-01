using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("InsuranceBondRelationships")]
public class InsuranceBondRelationships
{
    [XmlElement("InsuranceBondRelationship")]
    public List<InsuranceBondRelationship> InsuranceBondRelationship { get; set; }

}