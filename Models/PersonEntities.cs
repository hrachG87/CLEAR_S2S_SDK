using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonEntities")]
public class PersonEntities
{
    [XmlElement("PersonEntity")]
    public List<EIDVPersonEntity> PersonEntity { get; set; }

}
}