using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("BusinessSamePhoneSection")]
public class BusinessSamePhoneSection
{
    [XmlElement("BusinessSamePhoneRecord")]
    public List<BusinessSamePhoneRecord> BusinessSamePhoneRecord { get; set; }

}
}