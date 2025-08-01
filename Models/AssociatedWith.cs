using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AssociatedWith")]
public class AssociatedWith
{
    [XmlElement("FullName")]
    public List<string> FullName { get; set; }

}
}