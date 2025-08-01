using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("EidvOfacListingDetails")]
public class EidvOfacListingDetails
{
    [XmlElement("PersonName")]
    public string PersonName { get; set; }

    [XmlElement("LastKnownAddress")]
    public LastKnownAddress LastKnownAddress { get; set; }

    [XmlElement("SanctionProgram")]
    public string SanctionProgram { get; set; }

    [XmlElement("DocumentIdentifierInfo")]
    public EidvPersonSearchDocumentIdentifierInfo DocumentIdentifierInfo { get; set; }
}
