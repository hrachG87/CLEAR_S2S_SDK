using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonDominantValuesContainer")]
public class PersonDominantValuesContainer
{
    [XmlElement("PersonDominantValues")]
    public PersonDominantValues PersonDominantValues { get; set; }

}
}