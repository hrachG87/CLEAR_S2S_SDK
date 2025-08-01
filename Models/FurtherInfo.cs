using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("FurtherInfo")]
public class FurtherInfo
{
    [XmlElement("AccountNumber")]
    public string AccountNumber { get; set; }

    [XmlElement("AgentName")]
    public string AgentName { get; set; }

    [XmlElement("BondInfo")]
    public List<BondInfo> BondInfo { get; set; }

    [XmlElement("BusAddressRestriction")]
    public string BusAddressRestriction { get; set; }

    [XmlElement("DiscountBondInfo")]
    public DiscountBondInfo DiscountBondInfo { get; set; }

    [XmlElement("DistrictBranch")]
    public string DistrictBranch { get; set; }

    [XmlElement("Exemption")]
    public string Exemption { get; set; }

    [XmlElement("IpsoFactoSuspDate")]
    public string IpsoFactoSuspDate { get; set; }

    [XmlElement("LateRenewalDate")]
    public string LateRenewalDate { get; set; }

    [XmlElement("LateRenewedPrior")]
    public string LateRenewedPrior { get; set; }

    [XmlElement("MailingAddress")]
    public CommonDataAddress MailingAddress { get; set; }

    [XmlElement("MedClassExpireDate")]
    public string MedClassExpireDate { get; set; }

    [XmlElement("MedClassIssueDate")]
    public string MedClassIssueDate { get; set; }

    [XmlElement("MedicalClass")]
    public string MedicalClass { get; set; }

    [XmlElement("OutletInfo")]
    public OutletInfo OutletInfo { get; set; }

    [XmlElement("OwnershipRight")]
    public string OwnershipRight { get; set; }

    [XmlElement("PharmacistInCharge")]
    public string PharmacistInCharge { get; set; }

    [XmlElement("PharmacistLicenseNum")]
    public string PharmacistLicenseNum { get; set; }

    [XmlElement("ReceiptNumber")]
    public string ReceiptNumber { get; set; }

    [XmlElement("SubAccountNumber")]
    public string SubAccountNumber { get; set; }

    [XmlElement("TaxpayerNumber")]
    public string TaxpayerNumber { get; set; }

    [XmlElement("TypeOfCompany")]
    public string TypeOfCompany { get; set; }

    [XmlElement("TypeOfTaxableActivity")]
    public string TypeOfTaxableActivity { get; set; }

    [XmlElement("WorkersCompCancelDate")]
    public string WorkersCompCancelDate { get; set; }

    [XmlElement("WorkersCompCarrier")]
    public string WorkersCompCarrier { get; set; }

    [XmlElement("WorkersCompEffDate")]
    public string WorkersCompEffDate { get; set; }

    [XmlElement("WorkersCompPolicyNum")]
    public string WorkersCompPolicyNum { get; set; }

    [XmlElement("WorkersCompStatus")]
    public string WorkersCompStatus { get; set; }

    [XmlElement("CaseDocketID")]
    public List<string> CaseDocketID { get; set; }

    [XmlElement("Insurance")]
    public Insurance Insurance { get; set; }

    [XmlElement("BusinessDescription")]
    public string BusinessDescription { get; set; }

    [XmlElement("StartDate")]
    public string StartDate { get; set; }

}
}