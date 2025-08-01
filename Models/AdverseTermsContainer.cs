using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AdverseTermsContainer")]
public class AdverseTermsContainer
{
    [XmlElement("AdverseTerms")]
    public List<string> AdverseTerms { get; set; }

}
}