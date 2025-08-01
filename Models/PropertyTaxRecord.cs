using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PropertyTaxRecord")]
public class PropertyTaxRecord
{
    [XmlElement("AdditionalOwnerName")]
    public string AdditionalOwnerName { get; set; }

    [XmlElement("BuildingInfo")]
    public BuildingInfo BuildingInfo { get; set; }

    [XmlElement("CurrentDeedInfo")]
    public SalesTransactionInfo CurrentDeedInfo { get; set; }

    [XmlElement("LegalDescription")]
    public List<LegalDescription> LegalDescription { get; set; }

    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("OwnershipInfo")]
    public OwnershipInfo OwnershipInfo { get; set; }

    [XmlElement("PriorSaleInfo")]
    public SalesTransactionInfo PriorSaleInfo { get; set; }

    [XmlElement("PropertyAddress")]
    public CommonDataAddress PropertyAddress { get; set; }

    [XmlElement("PropertyInfo")]
    public PropertyInfo PropertyInfo { get; set; }

    [XmlElement("TaxAssessmentHistory")]
    public List<TaxAssessmentHistory> TaxAssessmentHistory { get; set; }

    [XmlElement("TaxAssessorInfo")]
    public TaxAssessorInfo TaxAssessorInfo { get; set; }

    [XmlElement("TaxPropertyInfo")]
    public TaxPropertyInfo TaxPropertyInfo { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

}
}