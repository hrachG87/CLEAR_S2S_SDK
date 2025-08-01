using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PeopleDataContactInfo")]
public class PeopleDataContactInfo
{
    [XmlElement("ContactAddress")]
    public CommonDataAddress ContactAddress { get; set; }

    [XmlElement("ContactName")]
    public PersonName ContactName { get; set; }

    [XmlElement("ContactEmail")]
    public string ContactEmail { get; set; }

}
}