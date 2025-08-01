using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AuditorInfo")]
public class AuditorInfo
{
    [XmlElement("ParentAuditor")]
    public string ParentAuditor { get; set; }

}
}