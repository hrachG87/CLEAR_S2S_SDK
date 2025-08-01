using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RealPropertyDominantValues")]
public class RealPropertyDominantValues
{
    [XmlElement("SitusAddress")]
    public CommonDataAddress SitusAddress { get; set; }

    [XmlElement("PropertyOwner")]
    public string PropertyOwner { get; set; }

    [XmlElement("MailingAddress")]
    public CommonDataAddress MailingAddress { get; set; }

}
}