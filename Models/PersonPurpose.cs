using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonPurpose")]
public class PersonPurpose
{
    [XmlElement("type")]
    public string type { get; set; }

    [XmlElement("code")]
    public string code { get; set; }

    [XmlElement("description")]
    public string description { get; set; }

}
}