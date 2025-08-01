using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("BusinessDataBusinessInfo")]
public class BusinessDataBusinessInfo
{
    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("PrimaryAddress")]
    public CommonDataAddress PrimaryAddress { get; set; }

    [XmlElement("MailingAddress")]
    public CommonDataAddress MailingAddress { get; set; }

    [XmlElement("CorpBusinessStatus")]
    public string CorpBusinessStatus { get; set; }

    [XmlElement("FilingType")]
    public string FilingType { get; set; }

    [XmlElement("FilingDate")]
    public string FilingDate { get; set; }

    [XmlElement("FilingNumber")]
    public string FilingNumber { get; set; }

    [XmlElement("FilingState")]
    public string FilingState { get; set; }

    [XmlElement("StateOfIncorporation")]
    public string StateOfIncorporation { get; set; }

    [XmlElement("OrigFilingDate")]
    public string OrigFilingDate { get; set; }

    [XmlElement("OrigFilingNumber")]
    public string OrigFilingNumber { get; set; }

    [XmlElement("TaxId")]
    public string TaxId { get; set; }

    [XmlElement("FederalEmpID")]
    public List<string> FederalEmpID { get; set; }

    [XmlElement("PrimarySIC")]
    public List<SICInfo> PrimarySIC { get; set; }

    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("PhoneInfo")]
    public PhoneInfo PhoneInfo { get; set; }

    [XmlElement("FilingOfficeAddress")]
    public FilingOfficeAddress FilingOfficeAddress { get; set; }

    [XmlElement("BusinessLocationType")]
    public string BusinessLocationType { get; set; }

    [XmlElement("BusinessEmail")]
    public string BusinessEmail { get; set; }

    [XmlElement("URL")]
    public string URL { get; set; }

    [XmlElement("BusinessNameShort")]
    public string BusinessNameShort { get; set; }

    [XmlElement("BusinessNumber")]
    public string BusinessNumber { get; set; }

    [XmlElement("BusinessDescription")]
    public string BusinessDescription { get; set; }

    [XmlElement("SummaryBusinessDescription")]
    public string SummaryBusinessDescription { get; set; }

    [XmlElement("NumberOfEmployees")]
    public string NumberOfEmployees { get; set; }

    [XmlElement("OperatingStatus")]
    public string OperatingStatus { get; set; }

    [XmlElement("YearStarted")]
    public string YearStarted { get; set; }

    [XmlElement("NationalID")]
    public string NationalID { get; set; }

    [XmlElement("SecondaryBusinessName")]
    public string SecondaryBusinessName { get; set; }

    [XmlElement("SICCode")]
    public string SICCode { get; set; }

    [XmlElement("SICDesc")]
    public string SICDesc { get; set; }

    [XmlElement("SICExt")]
    public string SICExt { get; set; }

    [XmlElement("DUNSNumber")]
    public string DUNSNumber { get; set; }

}
}