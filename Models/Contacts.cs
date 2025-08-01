using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("Contacts")]
public class Contacts
{
    [XmlElement("Contact")]
    public List<Contact> Contact { get; set; }

}
}