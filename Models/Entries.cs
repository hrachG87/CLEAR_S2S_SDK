using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("Entries")]
public class Entries
{
    [XmlElement("Amount")]
    public string Amount { get; set; }

    [XmlElement("Description")]
    public string Description { get; set; }

}
}