using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("ForeclosureRecord")]
public class ForeclosureRecord
{
    [XmlElement("BuildingInfo")]
    public BuildingInfo BuildingInfo { get; set; }

    [XmlElement("DefaultInfo")]
    public DefaultInfo DefaultInfo { get; set; }

    [XmlElement("JudgmentInfo")]
    public PropertyDataJudgmentInfo JudgmentInfo { get; set; }

    [XmlElement("LegalDescription")]
    public LegalDescription LegalDescription { get; set; }

    [XmlElement("LisPendensInfo")]
    public LisPendensInfo LisPendensInfo { get; set; }

    [XmlElement("MailingAddress")]
    public CommonDataAddress MailingAddress { get; set; }

    [XmlElement("OriginalLoanInfo")]
    public OriginalLoanInfo OriginalLoanInfo { get; set; }

    [XmlElement("OwnershipInfo")]
    public OwnershipInfo OwnershipInfo { get; set; }

    [XmlElement("PropertyAddress")]
    public CommonDataAddress PropertyAddress { get; set; }

    [XmlElement("PropertyInfo")]
    public PropertyInfo PropertyInfo { get; set; }

    [XmlElement("RecordingInfo")]
    public RecordingInfo RecordingInfo { get; set; }

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