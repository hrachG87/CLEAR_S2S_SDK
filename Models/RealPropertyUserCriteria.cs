using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("RealPropertyUserCriteria")]
public class RealPropertyUserCriteria
{
    [XmlElement("RealPropertyCriteria")]
    public RealPropertyCriteria RealPropertyCriteria { get; set; }

}
}