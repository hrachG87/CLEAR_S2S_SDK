using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("GlobalBeneficialOwnershipSearchResultsGroup")]
public class GlobalBeneficialOwnershipSearchResultsGroup
{
    [XmlElement("GroupId")]
    public string GroupId { get; set; }

    [XmlElement("RecordCount")]
    public int RecordCount { get; set; }

    [XmlElement("RecordDetails")]
    public GlobalBeneficialOwnershipResponseDetailContainer RecordDetails { get; set; }

}