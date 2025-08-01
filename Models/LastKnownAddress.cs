using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("LastKnownAddress")]
public class LastKnownAddress
{
    [XmlElement("LastKnownStreet")]
    public string LastKnownStreet { get; set; }

    [XmlElement("LastKnownCity")]
    public string LastKnownCity { get; set; }

    [XmlElement("LastKnownState")]
    public string LastKnownState { get; set; }

    [XmlElement("LastKnownZip")]
    public string LastKnownZip { get; set; }

}
}