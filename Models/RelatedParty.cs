using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("RelatedParty")]
public class RelatedParty
{
    [XmlElement("PartyName")]
    public string PartyName { get; set; }

    [XmlElement("PartyType")]
    public string PartyType { get; set; }

    [XmlElement("PartyRole")]
    public string PartyRole { get; set; }

    [XmlElement("PartyTitle")]
    public string PartyTitle { get; set; }

    [XmlElement("RelatedDocumentInfo")]
    public RelatedDocumentInfo RelatedDocumentInfo { get; set; }

}