using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("SanctionInfo")]
public class SanctionInfo
{
    [XmlElement("Issuer")]
    public string Issuer { get; set; }

    [XmlElement("IssuerCountry")]
    public string IssuerCountry { get; set; }

    [XmlElement("IssuerCategory")]
    public string IssuerCategory { get; set; }

    [XmlElement("SanctionType")]
    public string SanctionType { get; set; }

    [XmlElement("SanctionDescription")]
    public string SanctionDescription { get; set; }

    [XmlElement("SanctionBeginDate")]
    public string SanctionBeginDate { get; set; }

    [XmlElement("SanctionEndDate")]
    public string SanctionEndDate { get; set; }

    [XmlElement("SanctionPublicationDate")]
    public string SanctionPublicationDate { get; set; }

    [XmlElement("SanctionFullText")]
    public string SanctionFullText { get; set; }

    [XmlElement("Title")]
    public string Title { get; set; }

    [XmlElement("Occupation")]
    public string Occupation { get; set; }

    [XmlElement("DocumentTitle")]
    public string DocumentTitle { get; set; }

    [XmlElement("CaseNumber")]
    public string CaseNumber { get; set; }

    [XmlElement("DocketNumber")]
    public string DocketNumber { get; set; }

    [XmlElement("ExternalDocReference")]
    public string ExternalDocReference { get; set; }

    [XmlElement("RelatedEntityDescription")]
    public string RelatedEntityDescription { get; set; }

    [XmlElement("SubjectPositionHeld")]
    public string SubjectPositionHeld { get; set; }
}
