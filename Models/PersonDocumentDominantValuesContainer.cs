using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonDocumentDominantValuesContainer")]
public class PersonDocumentDominantValuesContainer
{
    [XmlElement("PersonDocumentDominantValues")]
    public PersonDocumentDominantValues PersonDocumentDominantValues { get; set; }

}
}