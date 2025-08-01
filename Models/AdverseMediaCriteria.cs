using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AdverseMediaCriteria")]
public class AdverseMediaCriteria
{
    [XmlElement("AdverseMediaSearchCriteria")]
    public AdverseMediaSearchCriteria AdverseMediaSearchCriteria { get; set; }

}
}