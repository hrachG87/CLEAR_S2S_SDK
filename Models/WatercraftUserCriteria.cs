using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("WatercraftUserCriteria")]
public class WatercraftUserCriteria
{
    [XmlElement("WatercraftCriteria")]
    public WatercraftCriteria WatercraftCriteria { get; set; }

}
}