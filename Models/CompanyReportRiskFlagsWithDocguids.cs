using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CompanyReportRiskFlagsWithDocguids")]
public class CompanyReportRiskFlagsWithDocguids
{
    [XmlElement("WorldCheck")]
    public CompanyReportRiskFlagInfo WorldCheck { get; set; }

    [XmlElement("OFAC")]
    public CompanyReportRiskFlagInfo OFAC { get; set; }

    [XmlElement("GlobalSanctions")]
    public CompanyReportRiskFlagInfo GlobalSanctions { get; set; }

    [XmlElement("BusinessUsedAsResidentialAddress")]
    public CompanyReportRiskFlagInfo BusinessUsedAsResidentialAddress { get; set; }

    [XmlElement("PrisonAddress")]
    public CompanyReportRiskFlagInfo PrisonAddress { get; set; }

    [XmlElement("Bankruptcy")]
    public CompanyReportRiskFlagInfo Bankruptcy { get; set; }

    [XmlElement("ListingLinkedToBusinessPhone")]
    public CompanyReportRiskFlagInfo ListingLinkedToBusinessPhone { get; set; }

    [XmlElement("ListingLinkedToBusinessAddress")]
    public CompanyReportRiskFlagInfo ListingLinkedToBusinessAddress { get; set; }

    [XmlElement("ListingLinkedToSameFEIN")]
    public CompanyReportRiskFlagInfo ListingLinkedToSameFEIN { get; set; }

    [XmlElement("KeyNatureOfSuit")]
    public CompanyReportRiskFlagInfo KeyNatureOfSuit { get; set; }

    [XmlElement("PendingClassAction")]
    public CompanyReportRiskFlagInfo PendingClassAction { get; set; }

    [XmlElement("GoingConcern")]
    public CompanyReportRiskFlagInfo GoingConcern { get; set; }

    [XmlElement("HealthcareSanction")]
    public CompanyReportRiskFlagInfo HealthcareSanction { get; set; }

    [XmlElement("Criminal")]
    public CompanyReportRiskFlagInfo Criminal { get; set; }

    [XmlElement("Arrest")]
    public CompanyReportRiskFlagInfo Arrest { get; set; }

    [XmlElement("MarijuanaRelatedBusiness")]
    public CompanyReportRiskFlagInfo MarijuanaRelatedBusiness { get; set; }

    [XmlElement("MSBListing")]
    public CompanyReportRiskFlagInfo MSBListing { get; set; }

    [XmlElement("POBoxAddress")]
    public CompanyReportRiskFlagInfo POBoxAddress { get; set; }
}
