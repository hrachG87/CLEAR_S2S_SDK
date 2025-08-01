using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("RiskInformPersonReportOptions")]
public class RiskInformPersonReportOptions
{
    [XmlElement("RelativesSectionDegreeOption")]
    public string RelativesSectionDegreeOption { get; set; }

    [XmlElement("RelativesSectionDisplayOption")]
    public string RelativesSectionDisplayOption { get; set; }

    [XmlElement("RelativesSectionIncludeAkasOption")]
    public bool RelativesSectionIncludeAkasOption { get; set; }

    [XmlElement("AssociatesSectionAddressOption")]
    public string AssociatesSectionAddressOption { get; set; }

    [XmlElement("AssociatesSectionTimeframeOption")]
    public string AssociatesSectionTimeframeOption { get; set; }

    [XmlElement("AssociateSectionDisplayOption")]
    public string AssociateSectionDisplayOption { get; set; }

    [XmlElement("NeighborsTypeOption")]
    public string NeighborsTypeOption { get; set; }

    [XmlElement("NeighborsTimeframeOption")]
    public string NeighborsTimeframeOption { get; set; }

    [XmlElement("AddressSectionAddressOption")]
    public string AddressSectionAddressOption { get; set; }

    [XmlElement("RelativesMinimumStrengthOfAssociation")]
    public int RelativesMinimumStrengthOfAssociation { get; set; }

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
