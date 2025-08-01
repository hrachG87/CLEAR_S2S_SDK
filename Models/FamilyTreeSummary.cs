using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("FamilyTreeSummary")]
public class FamilyTreeSummary
{
    [XmlElement("Headquarters")]
    public string Headquarters { get; set; }

    [XmlElement("TotalFamilyMembers")]
    public string TotalFamilyMembers { get; set; }

    [XmlElement("SubsidiaryNumber")]
    public string SubsidiaryNumber { get; set; }

    [XmlElement("Branches")]
    public string Branches { get; set; }

}
}