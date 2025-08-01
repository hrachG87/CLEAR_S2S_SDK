using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PhoneDominantValuesContainer")]
public class PhoneDominantValuesContainer
{
    [XmlElement("phoneDominantValues")]
    public PhoneDominantValues phoneDominantValues { get; set; }

}
}