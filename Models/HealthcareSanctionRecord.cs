using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("HealthcareSanctionRecord")]
public class HealthcareSanctionRecord
{
    [XmlElement("PersonInfo")]
    public List<CriminalPersonInfo> PersonInfo { get; set; }

    [XmlElement("BusinessInfo")]
    public List<CriminalDataBusinessInfo> BusinessInfo { get; set; }

    [XmlElement("EntityType")]
    public string EntityType { get; set; }

    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("Phone")]
    public PhoneInfo Phone { get; set; }

    [XmlElement("LastReportedDate")]
    public string LastReportedDate { get; set; }

    [XmlElement("AdditionalInfo")]
    public string AdditionalInfo { get; set; }

    [XmlElement("ProviderInfo")]
    public List<ProviderInfo> ProviderInfo { get; set; }

    [XmlElement("PublicationInfo")]
    public CriminalPublicationInfo PublicationInfo { get; set; }

    [XmlElement("SanctionInfo")]
    public SanctionInfo SanctionInfo { get; set; }

    [XmlElement("ActionInfo")]
    public ActionInfo ActionInfo { get; set; }

    [XmlElement("Charge")]
    public string Charge { get; set; }

    [XmlElement("Finding")]
    public string Finding { get; set; }

    [XmlElement("Note")]
    public CriminalNoteInfo Note { get; set; }

    [XmlElement("AdditionalNote")]
    public CriminalNoteInfo AdditionalNote { get; set; }

    [XmlElement("OtherAdditionalNote")]
    public CriminalNoteInfo OtherAdditionalNote { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }
}
