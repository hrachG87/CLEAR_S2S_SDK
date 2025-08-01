using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("BusinessFinderSection")]
public class BusinessFinderSection
{
    [XmlElement("BusinessPhoneRecord")]
    public List<BusinessPhoneRecord> BusinessPhoneRecord { get; set; }

    [XmlElement("CanadianBusinessPhoneRecord")]
    public List<BusinessPhoneRecord> CanadianBusinessPhoneRecord { get; set; }

}
}