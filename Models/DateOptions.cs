using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("DateOptions")]
public class DateOptions
{
    [XmlElement("Unrestricted")]
    public bool Unrestricted { get; set; }

    [XmlElement("Last30Days")]
    public bool Last30Days { get; set; }

    [XmlElement("Last3Years")]
    public bool Last3Years { get; set; }

    [XmlElement("Last10Years")]
    public bool Last10Years { get; set; }

    [XmlElement("StartDate")]
    public string StartDate { get; set; }

    [XmlElement("EndDate")]
    public string EndDate { get; set; }

}
}