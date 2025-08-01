using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("IndustryCodes")]
public class IndustryCodes
{
    [XmlElement("SICCode")]
    public List<string> SICCode { get; set; }

    [XmlElement("NAICSCode")]
    public List<string> NAICSCode { get; set; }

}
}