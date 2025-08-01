using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("IndutryPurchasingTerms")]
public class IndutryPurchasingTerms
{
    [XmlElement("IndustryPurchasingTerm")]
    public List<string> IndustryPurchasingTerm { get; set; }

}
}