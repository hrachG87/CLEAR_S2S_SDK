using System;
using System.Collections.Generic;
using System.Xml.Serialization;

[XmlRoot("MailingInfo")]
public class MailingInfo
{
    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("PhoneInfo")]
    public PhoneInfo PhoneInfo { get; set; }
}
