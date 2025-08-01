using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("PersonRiskFlagsSearchOptions")]
public class PersonRiskFlagsSearchOptions
{
    [XmlElement("AssociateAddressLimitOption")]
    public string AssociateAddressLimitOption { get; set; }

    [XmlElement("AssociateTimeFrameLimitOption")]
    public string AssociateTimeFrameLimitOption { get; set; }

    [XmlElement("AssociateMinimumStrengthOfAssociation")]
    public int AssociateMinimumStrengthOfAssociation { get; set; }

    [XmlElement("AssociateSharedAddresses")]
    public bool AssociateSharedAddresses { get; set; }

    [XmlElement("AssociateSharedPhoneNumbers")]
    public bool AssociateSharedPhoneNumbers { get; set; }

    [XmlElement("AssociateBusinessRelationships")]
    public bool AssociateBusinessRelationships { get; set; }

    [XmlElement("AssociatePossibleSpouse")]
    public bool AssociatePossibleSpouse { get; set; }

    [XmlElement("AssociateSharedVehicles")]
    public bool AssociateSharedVehicles { get; set; }

    [XmlElement("AssociatePartyToSameVehicleTransactions")]
    public bool AssociatePartyToSameVehicleTransactions { get; set; }

    [XmlElement("AssociatePartyToSameRealPropertyTransactions")]
    public bool AssociatePartyToSameRealPropertyTransactions { get; set; }

    [XmlElement("AssociatePossibleWorldCheckRelatedIndividual")]
    public bool AssociatePossibleWorldCheckRelatedIndividual { get; set; }

}