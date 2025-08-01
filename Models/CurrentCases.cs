using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CurrentCases")]
public class CurrentCases
{
    [XmlElement("CaseEndDate")]
    public string CaseEndDate { get; set; }

    [XmlElement("CaseStartDate")]
    public string CaseStartDate { get; set; }

    [XmlElement("LeadDocketNumber")]
    public string LeadDocketNumber { get; set; }

    [XmlElement("MemberDocketNumber")]
    public string MemberDocketNumber { get; set; }

    [XmlElement("RelationshipDescription")]
    public string RelationshipDescription { get; set; }

}