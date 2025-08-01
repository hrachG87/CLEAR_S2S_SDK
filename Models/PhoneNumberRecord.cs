using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PhoneNumberRecord")]
public class PhoneNumberRecord
{
    [XmlElement("PhoneDetails")]
    public List<PersonReportAddressInfo> PhoneDetails { get; set; }

}
}