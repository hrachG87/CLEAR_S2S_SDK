using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriteriaList")]
public class CriteriaList
{
    [XmlElement("Criteria")]
    public List<RequestValue> Criteria { get; set; }

}
}