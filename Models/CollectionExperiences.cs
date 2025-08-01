using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CollectionExperiences")]
public class CollectionExperiences
{
    [XmlElement("CollectionExperience")]
    public List<CollectionExperience> CollectionExperience { get; set; }

}
}