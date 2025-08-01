using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("IndutryPurchasingTerms")]
public class IndutryPurchasingTerms
{
    [XmlElement("IndustryPurchasingTerm")]
    public List<string> IndustryPurchasingTerm { get; set; }
}
