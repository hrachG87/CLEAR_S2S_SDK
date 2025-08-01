using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RegisteredOwnerInfo")]
public class RegisteredOwnerInfo
{
    [XmlElement("RegisteredOwner")]
    public PersonName RegisteredOwner { get; set; }

    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("PersonProfile")]
    public PersonProfile PersonProfile { get; set; }

    [XmlElement("HomeOwnershipStatus")]
    public string HomeOwnershipStatus { get; set; }

    [XmlElement("PhoneInfo")]
    public PhoneInfo PhoneInfo { get; set; }

}
}