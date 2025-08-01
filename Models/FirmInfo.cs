using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("FirmInfo")]
public class FirmInfo
{
    [XmlElement("Address")]
    public List<CommonDataAddress> Address { get; set; }

    [XmlElement("FirmName")]
    public string FirmName { get; set; }

    [XmlElement("Phone")]
    public PhoneInfo Phone { get; set; }

    [XmlElement("Status")]
    public CourtStatus Status { get; set; }

}