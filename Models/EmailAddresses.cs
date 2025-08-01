using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("EmailAddresses")]
public class EmailAddresses
{
    [XmlElement("EmailAddress")]
    public List<string> EmailAddress { get; set; }

}
}