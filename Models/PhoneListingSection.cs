using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PhoneListingSection")]
public class PhoneListingSection
{
    [XmlElement("PhoneListingRecord")]
    public List<PhoneListingRecord> PhoneListingRecord { get; set; }

}
}