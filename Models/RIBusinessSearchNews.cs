using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RIBusinessSearchNews")]
public class RIBusinessSearchNews
{
    [XmlElement("NewsResult")]
    public List<RIBusinessSearchNewsResult> NewsResult { get; set; }

}
}