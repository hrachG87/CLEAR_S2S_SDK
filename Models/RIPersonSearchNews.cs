using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RIPersonSearchNews")]
public class RIPersonSearchNews
{
    [XmlElement("NewsResult")]
    public List<RIPersonSearchNewsResult> NewsResult { get; set; }

}
}