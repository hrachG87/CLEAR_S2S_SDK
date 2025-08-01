using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CompanyDetailsStructure")]
public class CompanyDetailsStructure
{
    [XmlElement("LegalUltimateParentCompany")]
    public BusinessRiskFlagInfo LegalUltimateParentCompany { get; set; }

    [XmlElement("LegalImmediateParentCompany")]
    public BusinessRiskFlagInfo LegalImmediateParentCompany { get; set; }

    [XmlElement("PubliclyTradedCompany")]
    public BusinessRiskFlagInfo PubliclyTradedCompany { get; set; }

    [XmlElement("NonProfitCompany")]
    public BusinessRiskFlagInfo NonProfitCompany { get; set; }

    [XmlElement("ReligiousOrganization")]
    public BusinessRiskFlagInfo ReligiousOrganization { get; set; }

    [XmlElement("OtherBusinessesLinkedToBusinessAddress")]
    public BusinessRiskFlagInfo OtherBusinessesLinkedToBusinessAddress { get; set; }

    [XmlElement("OtherBusinessesLinkedToFEIN")]
    public BusinessRiskFlagInfo OtherBusinessesLinkedToFEIN { get; set; }

    [XmlElement("RegisteredAgent")]
    public BusinessRiskFlagInfo RegisteredAgent { get; set; }

    [XmlElement("IndustryClassificationCodes")]
    public BusinessRiskFlagInfo IndustryClassificationCodes { get; set; }

    [XmlElement("WebsiteAddress")]
    public BusinessRiskFlagInfo WebsiteAddress { get; set; }

    [XmlElement("DoingBusinessAs")]
    public BusinessRiskFlagInfo DoingBusinessAs { get; set; }

    [XmlElement("ActiveTickerSymbol")]
    public BusinessRiskFlagInfo ActiveTickerSymbol { get; set; }

    [XmlElement("CorporateFilings")]
    public BusinessRiskFlagInfo CorporateFilings { get; set; }

    [XmlElement("NoCorporateFilings")]
    public BusinessRiskFlagInfo NoCorporateFilings { get; set; }

    [XmlElement("ForeignCorporateFiling")]
    public BusinessRiskFlagInfo ForeignCorporateFiling { get; set; }

    [XmlElement("BusinessListedAsOwnerOfficerOrDirector")]
    public BusinessRiskFlagInfo BusinessListedAsOwnerOfficerOrDirector { get; set; }

}
}