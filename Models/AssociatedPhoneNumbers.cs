using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("AssociatedPhoneNumbers")]
public class AssociatedPhoneNumbers
{
    [XmlElement("Status")]
    public string Status { get; set; }

    [XmlElement("PhoneNumbers")]
    public List<string> PhoneNumbers { get; set; }

}
}