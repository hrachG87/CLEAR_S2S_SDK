using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("WorldbaseRecord")]
public class WorldbaseRecord
{
    [XmlElement("BusinessInfo")]
    public BusinessDataBusinessInfo BusinessInfo { get; set; }

    [XmlElement("ManagementTeam")]
    public ExecutiveInfo ManagementTeam { get; set; }

    [XmlElement("BusinessContacts")]
    public BusinessContacts BusinessContacts { get; set; }

    [XmlElement("BusinessDetails")]
    public BusinessDetails BusinessDetails { get; set; }

    [XmlElement("FinancialInformation")]
    public FinancialInformation FinancialInformation { get; set; }

    [XmlElement("SalesInformation")]
    public SalesInformation SalesInformation { get; set; }

    [XmlElement("CompanyRelationshipsAndOtherInformation")]
    public CompanyRelationshipsAndOtherInformation CompanyRelationshipsAndOtherInformation { get; set; }

    [XmlElement("LastUpdateToRecord")]
    public string LastUpdateToRecord { get; set; }

    [XmlElement("CopyrightMessage")]
    public string CopyrightMessage { get; set; }

    [XmlElement("Source")]
    public string Source { get; set; }

    [XmlElement("SourceDocumentGuid")]
    public string SourceDocumentGuid { get; set; }

}