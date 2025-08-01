using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("CriminalExpansionRecord")]
public class CriminalExpansionRecord
{
    [XmlElement("DefendantInfo")]
    public DefendantInfo DefendantInfo { get; set; }

    [XmlElement("OffenderInfo")]
    public List<OffenderInfo> OffenderInfo { get; set; }

    [XmlElement("AdditionalInfo")]
    public CriminalDataAdditionalInfo AdditionalInfo { get; set; }

    [XmlElement("PublicationDate")]
    public string PublicationDate { get; set; }

    [XmlElement("SourceName")]
    public string SourceName { get; set; }

    [XmlElement("SourceCounty")]
    public string SourceCounty { get; set; }

    [XmlElement("SourceState")]
    public string SourceState { get; set; }

    [XmlElement("TypeOfCriminal")]
    public string TypeOfCriminal { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("PhotoImages")]
    public List<CriminalPhotoImages> PhotoImages { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }
}
