using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("LastAddress")]
public class LastAddress
{
    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("DeathResidence")]
    public string DeathResidence { get; set; }

}
}