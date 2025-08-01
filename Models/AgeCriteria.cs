using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AgeCriteria")]
public class AgeCriteria
{
    [XmlElement("PersonBirthDate")]
    public string PersonBirthDate { get; set; }

    [XmlElement("PersonAgeTo")]
    public string PersonAgeTo { get; set; }

    [XmlElement("PersonAgeFrom")]
    public string PersonAgeFrom { get; set; }

}
}