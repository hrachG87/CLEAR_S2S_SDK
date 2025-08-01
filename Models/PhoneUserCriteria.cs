using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PhoneUserCriteria")]
public class PhoneUserCriteria
{
    [XmlElement("PhoneCriteria")]
    public PhoneCriteria PhoneCriteria { get; set; }

}
}