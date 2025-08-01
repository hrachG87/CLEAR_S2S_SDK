using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CollectionExperiencesSection")]
public class CollectionExperiencesSection
{
    [XmlElement("CollectionExperiencesRecord")]
    public List<CollectionExperiencesRecord> CollectionExperiencesRecord { get; set; }

}
}