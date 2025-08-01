using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("EidvBusinessOfacListingDetails")]
public class EidvBusinessOfacListingDetails
{
    [XmlElement("Name")]
    public string Name { get; set; }

    [XmlElement("address")]
    public EidvBusinessSearchAddress address { get; set; }

    [XmlElement("SanctionProgram")]
    public string SanctionProgram { get; set; }

    [XmlElement("DocumentIdentifierInfo")]
    public List<EidvBusinessSearchDocumentIdentifierInfo> DocumentIdentifierInfo { get; set; }

}