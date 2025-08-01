using System;
using System.Collections.Generic;
using System.Xml.Serialization;


[XmlRoot("CriminalDataAddressInfo")]
public class CriminalDataAddressInfo
{
    [XmlElement("Address")]
    public CommonDataAddress Address { get; set; }

    [XmlElement("ReportedDate")]
    public string ReportedDate { get; set; }

    [XmlElement("Phone")]
    public PhoneInfo Phone { get; set; }

}