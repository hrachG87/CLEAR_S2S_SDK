using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("BusinessAKA")]
public class BusinessAKA
{
    [XmlElement("BusinessAKAName")]
    public string BusinessAKAName { get; set; }

    [XmlElement("TypeOfAKA")]
    public string TypeOfAKA { get; set; }

}
}