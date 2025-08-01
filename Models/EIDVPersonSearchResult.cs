using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("EIDVPersonSearchResult")]
public class EIDVPersonSearchResult
{
    [XmlElement("NormalizedCriteria")]
    public EidvNormalizedCriteria NormalizedCriteria { get; set; }

    [XmlElement("ServiceErrors")]
    public EidvServiceErrors ServiceErrors { get; set; }

    [XmlElement("personEntities")]
    public PersonEntities personEntities { get; set; }

    [XmlElement("phoneAttributes")]
    public IDConfirmPhoneAttributes phoneAttributes { get; set; }

    [XmlElement("emailAttributes")]
    public IDConfirmEmailAttributes emailAttributes { get; set; }

    [XmlElement("EIDVPersonSearchRequest")]
    public EIDVPersonSearchRequest EIDVPersonSearchRequest { get; set; }

}