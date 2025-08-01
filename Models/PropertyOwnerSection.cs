using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PropertyOwnerSection")]
public class PropertyOwnerSection
{
    [XmlElement("PropertyOwnerRecord")]
    public List<PropertyOwnerRecord> PropertyOwnerRecord { get; set; }

}
}