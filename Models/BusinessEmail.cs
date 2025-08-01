using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("BusinessEmail")]
public class BusinessEmail
{
    [XmlElement("EmailAddress")]
    public string EmailAddress { get; set; }

    [XmlElement("EmailUserName")]
    public string EmailUserName { get; set; }

    [XmlElement("EmailDomain")]
    public string EmailDomain { get; set; }

}
}