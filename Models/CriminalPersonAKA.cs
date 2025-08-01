using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalPersonAKA")]
public class CriminalPersonAKA
{
    [XmlElement("AKADateOfBirth")]
    public string AKADateOfBirth { get; set; }

    [XmlElement("AKAPersonName")]
    public PersonName AKAPersonName { get; set; }

    [XmlElement("AKANickName")]
    public List<string> AKANickName { get; set; }

}
}