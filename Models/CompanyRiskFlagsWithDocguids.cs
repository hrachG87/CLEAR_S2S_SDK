using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CompanyRiskFlagsWithDocguids")]
public class CompanyRiskFlagsWithDocguids
{
    [XmlElement("WorldCheck")]
    public CompanyRiskFlagInfo WorldCheck { get; set; }

    [XmlElement("OFAC")]
    public CompanyRiskFlagInfo OFAC { get; set; }

    [XmlElement("GlobalSanctions")]
    public CompanyRiskFlagInfo GlobalSanctions { get; set; }

    [XmlElement("BusinessUsedAsResidentialAddress")]
    public CompanyRiskFlagInfo BusinessUsedAsResidentialAddress { get; set; }

    [XmlElement("PrisonAddress")]
    public CompanyRiskFlagInfo PrisonAddress { get; set; }

    [XmlElement("Bankruptcy")]
    public CompanyRiskFlagInfo Bankruptcy { get; set; }

    [XmlElement("ListingLinkedToBusinessPhone")]
    public CompanyRiskFlagInfo ListingLinkedToBusinessPhone { get; set; }

    [XmlElement("ListingLinkedToBusinessAddress")]
    public CompanyRiskFlagInfo ListingLinkedToBusinessAddress { get; set; }

    [XmlElement("ListingLinkedToSameFEIN")]
    public CompanyRiskFlagInfo ListingLinkedToSameFEIN { get; set; }

    [XmlElement("KeyNatureOfSuit")]
    public CompanyRiskFlagInfo KeyNatureOfSuit { get; set; }

    [XmlElement("PendingClassAction")]
    public CompanyRiskFlagInfo PendingClassAction { get; set; }

    [XmlElement("GoingConcern")]
    public CompanyRiskFlagInfo GoingConcern { get; set; }

    [XmlElement("HealthcareSanction")]
    public CompanyRiskFlagInfo HealthcareSanction { get; set; }

    [XmlElement("MarijuanaRelatedBusiness")]
    public CompanyRiskFlagInfo MarijuanaRelatedBusiness { get; set; }

    [XmlElement("MSBListing")]
    public CompanyRiskFlagInfo MSBListing { get; set; }

    [XmlElement("POBoxAddress")]
    public CompanyRiskFlagInfo POBoxAddress { get; set; }
}
