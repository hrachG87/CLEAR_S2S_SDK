using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("NewsCriteria")]
public class NewsCriteria
{
    [XmlElement("NewsSearchCriteria")]
    public NewsSearchCriteria NewsSearchCriteria { get; set; }

}
}