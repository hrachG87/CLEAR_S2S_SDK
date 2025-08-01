using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("WatercraftDominantValuesContainer")]
public class WatercraftDominantValuesContainer
{
    [XmlElement("watercraftDominantValues")]
    public WatercraftDominantValues watercraftDominantValues { get; set; }

}
}