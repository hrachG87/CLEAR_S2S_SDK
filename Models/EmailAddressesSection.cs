using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("EmailAddressesSection")]
public class EmailAddressesSection
{
    [XmlElement("EmailAddressesRecord")]
    public List<WebAndSocialMediaEmailInfo> EmailAddressesRecord { get; set; }

}
}