using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("LegalFilings")]
public class LegalFilings
{
    [XmlElement("LegalFiling")]
    public List<LegalFiling> LegalFiling { get; set; }

}
}