using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BOH.Data.CustomerVerification.CLEARSdk.Models
{
[XmlRoot("associated_email_addresses")]
public class associated_email_addresses
{
    [XmlElement("Status")]
    public string Status { get; set; }

    [XmlElement("Emails")]
    public List<string> Emails { get; set; }

}
}