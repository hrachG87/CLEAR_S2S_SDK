using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PersonPreForeclosureSection")]
public class PersonPreForeclosureSection
{
    [XmlElement("ForeclosureRecord")]
    public List<ForeclosureRecord> ForeclosureRecord { get; set; }

}
}