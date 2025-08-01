using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("EmailAddressesSection")]
public class EmailAddressesSection
{
    [XmlElement("EmailAddressesRecord")]
    public List<WebAndSocialMediaEmailInfo> EmailAddressesRecord { get; set; }
}
