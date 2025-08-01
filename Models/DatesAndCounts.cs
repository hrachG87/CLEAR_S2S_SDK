using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("DatesAndCounts")]
public class DatesAndCounts
{
    [XmlElement("DateAndCount")]
    public List<DateAndCount> DateAndCount { get; set; }

}
}