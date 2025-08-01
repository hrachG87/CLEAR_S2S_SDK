using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RealPropertyDominantValuesContainer")]
public class RealPropertyDominantValuesContainer
{
    [XmlElement("RealPropertyDominantValues")]
    public RealPropertyDominantValues RealPropertyDominantValues { get; set; }

}
}