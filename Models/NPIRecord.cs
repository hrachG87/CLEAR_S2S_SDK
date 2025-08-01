using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("NPIRecord")]
public class NPIRecord
{
    [XmlElement("AuthorizedIndividual")]
    public LicensePersonInfo AuthorizedIndividual { get; set; }

    [XmlElement("BusinessAKA")]
    public BusinessAKA BusinessAKA { get; set; }

    [XmlElement("CoParentBusinessName")]
    public string CoParentBusinessName { get; set; }

    [XmlElement("EntityType")]
    public string EntityType { get; set; }

    [XmlElement("MailingAddress")]
    public MailingInfo MailingAddress { get; set; }

    [XmlElement("Name")]
    public LicensePersonInfo Name { get; set; }

    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("OtherProviderInfo")]
    public List<OtherProviderInfo> OtherProviderInfo { get; set; }

    [XmlElement("PersonAKA")]
    public LicensePersonAKA PersonAKA { get; set; }

    [XmlElement("PhysicalAddress")]
    public MailingInfo PhysicalAddress { get; set; }

    [XmlElement("ProviderTaxonomy")]
    public List<ProviderTaxonomy> ProviderTaxonomy { get; set; }

    [XmlElement("SoleProprietorIndicator")]
    public string SoleProprietorIndicator { get; set; }

    [XmlElement("SubpartBusinessIndicator")]
    public string SubpartBusinessIndicator { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

    [XmlElement("NPINumber")]
    public string NPINumber { get; set; }

    [XmlElement("NPIDeactivationCode")]
    public string NPIDeactivationCode { get; set; }

    [XmlElement("NPIDeactivationDate")]
    public string NPIDeactivationDate { get; set; }

    [XmlElement("NPIIssueDate")]
    public string NPIIssueDate { get; set; }

    [XmlElement("NPIReactivationDate")]
    public string NPIReactivationDate { get; set; }

    [XmlElement("NPIReplacement")]
    public string NPIReplacement { get; set; }

    [XmlElement("NPIUpdateDate")]
    public string NPIUpdateDate { get; set; }
}
