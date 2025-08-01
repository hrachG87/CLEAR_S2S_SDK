using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("WorldCheckDocumentDominantValuesContainer")]
public class WorldCheckDocumentDominantValuesContainer
{
    [XmlElement("WorldCheckDocumentDominantValues")]
    public WorldCheckDocumentDominantValues WorldCheckDocumentDominantValues { get; set; }

}
}