using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("BusinessRegistrationInfo")]
public class BusinessRegistrationInfo
{
    [XmlElement("RegistrationClass")]
    public string RegistrationClass { get; set; }

    [XmlElement("RegistrationState")]
    public string RegistrationState { get; set; }

    [XmlElement("RegistrationNumber")]
    public string RegistrationNumber { get; set; }

}
}