using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonDominantValues")]
public class PersonDominantValues
{
    [XmlElement("Name")]
    public PersonName Name { get; set; }

    [XmlElement("SSN")]
    public string SSN { get; set; }

    [XmlElement("AgeInfo")]
    public PersonProfile AgeInfo { get; set; }

    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

}
}