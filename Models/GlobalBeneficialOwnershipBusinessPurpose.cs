using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("GlobalBeneficialOwnershipBusinessPurpose")]
public class GlobalBeneficialOwnershipBusinessPurpose
{
    [XmlElement("BusinessPurpose")]
    public string BusinessPurpose { get; set; }

    [XmlElement("BusinessPurposeOriginalLanguage")]
    public string BusinessPurposeOriginalLanguage { get; set; }

}