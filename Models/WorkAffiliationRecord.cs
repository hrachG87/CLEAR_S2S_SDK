using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("WorkAffiliationRecord")]
public class WorkAffiliationRecord
{
    [XmlElement("BusinessAffiliationInfo")]
    public BusinessAffiliationInfo BusinessAffiliationInfo { get; set; }

    [XmlElement("BusinessAssociateInfo")]
    public List<BusinessAssociateInfo> BusinessAssociateInfo { get; set; }

    [XmlElement("BusinessEmailAddress")]
    public string BusinessEmailAddress { get; set; }

    [XmlElement("EmploymentStatus")]
    public string EmploymentStatus { get; set; }

    [XmlElement("HistoricBusinessAffiliationInfo")]
    public HistoricBusinessAffiliationInfo HistoricBusinessAffiliationInfo { get; set; }

    [XmlElement("BusinessID")]
    public string BusinessID { get; set; }

    [XmlElement("ManagementResponsibilities")]
    public List<string> ManagementResponsibilities { get; set; }

    [XmlElement("OfficerInfo")]
    public List<BusinessAssociateInfo> OfficerInfo { get; set; }

    [XmlElement("BusinessContact")]
    public List<BusinessAssociateInfo> BusinessContact { get; set; }

    [XmlElement("OtherBusinessRole")]
    public string OtherBusinessRole { get; set; }

    [XmlElement("ProfessionalTradeName")]
    public string ProfessionalTradeName { get; set; }

    [XmlElement("PersonalDetails")]
    public PersonInfo PersonalDetails { get; set; }

    [XmlElement("ProfLicenseInfo")]
    public ProfLicenseInfo ProfLicenseInfo { get; set; }

    [XmlElement("RegisteredAgentInfo")]
    public List<BusinessAssociateInfo> RegisteredAgentInfo { get; set; }

    [XmlElement("ReportedDate")]
    public string ReportedDate { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("TradeName")]
    public string TradeName { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

    [XmlElement("IPAddress")]
    public string IPAddress { get; set; }

}
}