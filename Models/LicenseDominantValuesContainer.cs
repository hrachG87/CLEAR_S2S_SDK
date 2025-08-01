using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("LicenseDominantValuesContainer")]
public class LicenseDominantValuesContainer
{
    [XmlElement("licenseDominantValues")]
    public LicenseDominantValues licenseDominantValues { get; set; }

}
}