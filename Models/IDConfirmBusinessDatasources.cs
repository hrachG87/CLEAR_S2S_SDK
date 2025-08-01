using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("IDConfirmBusinessDatasources")]
public class IDConfirmBusinessDatasources
{
    [XmlElement("PhoneAttributes")]
    public string PhoneAttributes { get; set; }

}
}