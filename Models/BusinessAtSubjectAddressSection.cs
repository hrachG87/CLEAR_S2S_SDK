using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("BusinessAtSubjectAddressSection")]
public class BusinessAtSubjectAddressSection
{
    [XmlElement("BusinessAtSubjectAddressRecord")]
    public List<BusinessAtSubjectAddressRecord> BusinessAtSubjectAddressRecord { get; set; }

}
}