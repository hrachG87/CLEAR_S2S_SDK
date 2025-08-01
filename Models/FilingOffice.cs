using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("FilingOffice")]
public class FilingOffice
{
    [XmlElement("FilingOfficeName")]
    public List<string> FilingOfficeName { get; set; }

    [XmlElement("Address")]
    public List<CommonDataAddress> Address { get; set; }

}
}