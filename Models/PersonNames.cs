using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonNames")]
public class PersonNames
{
    [XmlElement("PersonName")]
    public List<PersonName> PersonName { get; set; }

}
}