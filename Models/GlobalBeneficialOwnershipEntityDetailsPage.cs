using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("GlobalBeneficialOwnershipEntityDetailsPage")]
public class GlobalBeneficialOwnershipEntityDetailsPage
{
    [XmlElement("Status")]
    public Status Status { get; set; }

    [XmlElement("GroupId")]
    public string GroupId { get; set; }

    [XmlElement("EntityDetails")]
    public GlobalBeneficialOwnershipEntityDetail EntityDetails { get; set; }

}