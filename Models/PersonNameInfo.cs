using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonNameInfo")]
public class PersonNameInfo
{
    [XmlElement("Name")]
    public PersonName Name { get; set; }

}
}