using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("IDConfirmPersonDatasources")]
public class IDConfirmPersonDatasources
{
    [XmlElement("PhoneAttributes")]
    public string PhoneAttributes { get; set; }

    [XmlElement("EmailAttributes")]
    public string EmailAttributes { get; set; }

}
}