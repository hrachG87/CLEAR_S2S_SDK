using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("CanadianPhoneSection")]
public class CanadianPhoneSection
{
    [XmlElement("canadianPhoneRecord")]
    public List<CanadianPhoneRecord> canadianPhoneRecord { get; set; }

}
}