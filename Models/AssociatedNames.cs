using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AssociatedNames")]
public class AssociatedNames
{
    [XmlElement("Status")]
    public string Status { get; set; }

    [XmlElement("Names")]
    public List<string> Names { get; set; }

}
}