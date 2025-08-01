using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CompanyAssociateRiskFlags")]
public class CompanyAssociateRiskFlags
{
    [XmlElement("WorldCheck")]
    public bool WorldCheck { get; set; }

    [XmlElement("OFAC")]
    public bool OFAC { get; set; }

    [XmlElement("GlobalSanctions")]
    public bool GlobalSanctions { get; set; }

    [XmlElement("BusinessUsedAsResidentialAddress")]
    public bool BusinessUsedAsResidentialAddress { get; set; }

    [XmlElement("PrisonAddress")]
    public bool PrisonAddress { get; set; }

    [XmlElement("Bankruptcy")]
    public bool Bankruptcy { get; set; }

    [XmlElement("ListingLinkedToBusinessPhone")]
    public bool ListingLinkedToBusinessPhone { get; set; }

    [XmlElement("ListingLinkedToBusinessAddress")]
    public bool ListingLinkedToBusinessAddress { get; set; }

    [XmlElement("ListingLinkedToSameFEIN")]
    public bool ListingLinkedToSameFEIN { get; set; }

    [XmlElement("KeyNatureOfSuit")]
    public bool KeyNatureOfSuit { get; set; }

    [XmlElement("PendingClassAction")]
    public bool PendingClassAction { get; set; }

    [XmlElement("GoingConcern")]
    public bool GoingConcern { get; set; }

    [XmlElement("HealthcareSanction")]
    public bool HealthcareSanction { get; set; }

    [XmlElement("Criminal")]
    public bool Criminal { get; set; }

    [XmlElement("Arrest")]
    public bool Arrest { get; set; }

    [XmlElement("MarijuanaRelatedBusiness")]
    public bool MarijuanaRelatedBusiness { get; set; }

    [XmlElement("MSBListing")]
    public bool MSBListing { get; set; }

    [XmlElement("POBoxAddress")]
    public bool POBoxAddress { get; set; }
}
