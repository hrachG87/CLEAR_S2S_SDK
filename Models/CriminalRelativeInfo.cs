using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CriminalRelativeInfo")]
public class CriminalRelativeInfo
{
    [XmlElement("CriminalRelativeInfo")]
    public CommonDataAddress CriminalRelativeInfo { get; set; }

    [XmlElement("PersonName")]
    public PersonName PersonName { get; set; }

    [XmlElement("Phone")]
    public PhoneInfo Phone { get; set; }

    [XmlElement("TypeOfRelative")]
    public string TypeOfRelative { get; set; }

}
}