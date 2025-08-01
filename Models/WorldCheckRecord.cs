using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("WorldCheckRecord")]
public class WorldCheckRecord
{
    [XmlElement("NameInfo")]
    public CriminalNameInfo NameInfo { get; set; }

    [XmlElement("ProfileCreated")]
    public string ProfileCreated { get; set; }

    [XmlElement("ProfileUpdated")]
    public string ProfileUpdated { get; set; }

    [XmlElement("Position")]
    public string Position { get; set; }

    [XmlElement("PassportNumber")]
    public List<string> PassportNumber { get; set; }

    [XmlElement("PassportCountry")]
    public List<string> PassportCountry { get; set; }

    [XmlElement("Category")]
    public string Category { get; set; }

    [XmlElement("SubCategory")]
    public string SubCategory { get; set; }

    [XmlElement("Countries")]
    public List<string> Countries { get; set; }

    [XmlElement("FurtherInformation")]
    public string FurtherInformation { get; set; }

    [XmlElement("CompaniesLinkedTo")]
    public List<string> CompaniesLinkedTo { get; set; }

    [XmlElement("ReportedToBeLinkedTo")]
    public List<string> ReportedToBeLinkedTo { get; set; }

    [XmlElement("OfficialLists")]
    public List<string> OfficialLists { get; set; }

    [XmlElement("ExternalSources")]
    public List<string> ExternalSources { get; set; }

    [XmlElement("Disclaimer")]
    public string Disclaimer { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("WorldCheckUniqueId")]
    public string WorldCheckUniqueId { get; set; }

    [XmlElement("ProfileType")]
    public string ProfileType { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

}
}