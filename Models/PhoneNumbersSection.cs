using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("PhoneNumbersSection")]
public class PhoneNumbersSection
{
    [XmlElement("PhoneNumbersRecord")]
    public List<WebAndSocialMediaPhoneInfo> PhoneNumbersRecord { get; set; }

}
}