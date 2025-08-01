using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("KnownEmailAddresses")]
public class KnownEmailAddresses
{
    [XmlElement("KnownEmailAddress")]
    public List<KnownEmailAddress> KnownEmailAddress { get; set; }

}
}