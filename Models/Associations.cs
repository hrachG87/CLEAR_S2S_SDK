using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("Associations")]
public class Associations
{
    [XmlElement("AssociatedWith")]
    public string AssociatedWith { get; set; }

    [XmlElement("TotalAdditionalPeople")]
    public string TotalAdditionalPeople { get; set; }

}
}