using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CourtDominantValuesContainer")]
public class CourtDominantValuesContainer
{
    [XmlElement("CourtDominantValues")]
    public CourtDominantValues CourtDominantValues { get; set; }

}
}