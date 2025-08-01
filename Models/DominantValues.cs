using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("DominantValues")]
public class DominantValues
{
    [XmlElement("BusinessDocumentDominantValues")]
    public BusinessDocumentDominantValues BusinessDocumentDominantValues { get; set; }

}
}