using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CorporateRecord")]
public class CorporateRecord
{
    [XmlElement("AssociatedEntities")]
    public List<AssociatedEntities> AssociatedEntities { get; set; }

    [XmlElement("AuthCapital")]
    public string AuthCapital { get; set; }

    [XmlElement("BusinessInfo")]
    public BusinessDataBusinessInfo BusinessInfo { get; set; }

    [XmlElement("BusinessType")]
    public List<string> BusinessType { get; set; }

    [XmlElement("CareOf")]
    public string CareOf { get; set; }

    [XmlElement("Classification")]
    public string Classification { get; set; }

    [XmlElement("CorpAgentInfo")]
    public CorpAgentInfo CorpAgentInfo { get; set; }

    [XmlElement("CorpHistory")]
    public List<CorpHistory> CorpHistory { get; set; }

    [XmlElement("CorpLifetime")]
    public string CorpLifetime { get; set; }

    [XmlElement("CorpNameHistory")]
    public List<CorpNameHistory> CorpNameHistory { get; set; }

    [XmlElement("CorpNumber")]
    public string CorpNumber { get; set; }

    [XmlElement("CorpOfficerInfo")]
    public List<CorpOfficerInfo> CorpOfficerInfo { get; set; }

    [XmlElement("CorpContactInfo")]
    public List<CorpContactInfo> CorpContactInfo { get; set; }

    [XmlElement("CorpStatusDate")]
    public string CorpStatusDate { get; set; }

    [XmlElement("CorpStockInfo")]
    public List<CorpStockInfo> CorpStockInfo { get; set; }

    [XmlElement("CorpTaxHistory")]
    public CorpTaxHistory CorpTaxHistory { get; set; }

    [XmlElement("CorpType")]
    public string CorpType { get; set; }

    [XmlElement("DurationDate")]
    public List<string> DurationDate { get; set; }

    [XmlElement("EffectiveDate")]
    public string EffectiveDate { get; set; }

    [XmlElement("FilingDUNSNumber")]
    public string FilingDUNSNumber { get; set; }

    [XmlElement("IncorpDate")]
    public string IncorpDate { get; set; }

    [XmlElement("InvestedAmount")]
    public string InvestedAmount { get; set; }

    [XmlElement("Note")]
    public List<string> Note { get; set; }

    [XmlElement("OrigFilingCounty")]
    public string OrigFilingCounty { get; set; }

    [XmlElement("PaidOnCreditAmount")]
    public List<string> PaidOnCreditAmount { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

    [XmlElement("LLCBusType")]
    public string LLCBusType { get; set; }

    [XmlElement("FEINTaxIDIndicator")]
    public string FEINTaxIDIndicator { get; set; }

}
}