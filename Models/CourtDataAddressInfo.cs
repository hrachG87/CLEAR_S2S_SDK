using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CourtDataAddressInfo")]
public class CourtDataAddressInfo
{
    [XmlElement("Address")]
    public List<CommonDataAddress> Address { get; set; }

    [XmlElement("Phone")]
    public PhoneInfo Phone { get; set; }

}