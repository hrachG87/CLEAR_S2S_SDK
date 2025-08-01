using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonOverviewSection")]
public class PersonOverviewSection
{
    [XmlElement("PersonOverviewRecord")]
    public PersonOverviewInfo PersonOverviewRecord { get; set; }

}
}