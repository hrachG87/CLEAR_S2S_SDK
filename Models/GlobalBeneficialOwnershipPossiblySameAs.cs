using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("GlobalBeneficialOwnershipPossiblySameAs")]
public class GlobalBeneficialOwnershipPossiblySameAs
{
    [XmlElement("PersonName")]
    public string PersonName { get; set; }

    [XmlElement("PersonNameOriginalLanguage")]
    public string PersonNameOriginalLanguage { get; set; }

    [XmlElement("BusinessName")]
    public string BusinessName { get; set; }

    [XmlElement("BusinessNameOriginalLanguage")]
    public string BusinessNameOriginalLanguage { get; set; }

    [XmlElement("FEIN")]
    public string FEIN { get; set; }

    [XmlElement("Identifier")]
    public List<GlobalBeneficialOwnershipIdentifier> Identifier { get; set; }

    [XmlElement("DUNSNumber")]
    public string DUNSNumber { get; set; }

}